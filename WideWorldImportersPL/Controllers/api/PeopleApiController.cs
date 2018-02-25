using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WideWorldImporters.BLL.Models;
using WideWorldImporters.BLL.Services;
using WideWorldImporters.Model.Dto;
using Microsoft.AspNetCore.Http.Extensions;

namespace WideWorldImporters.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/people")]
    public class PeopleApiController : Controller
    {
        private readonly IPeopleService _people;
        private readonly IMapper _mapper;

        public PeopleApiController(IPeopleService people, IMapper mapper)
        {
            _people = people;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(_mapper.Map<List<PersonDto>>(_people.GetPeople()));
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(int id)
        {
            var personBl = _people.GetPerson(id);

            if (personBl == null)
                return NotFound();

            return Ok(_mapper.Map<PersonDto>(personBl));
        }

        [HttpPost]
        public IActionResult AddPerson(PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var personBl = _mapper.Map<PersonBl>(personDto);
            personBl = _people.AddPerson(personBl);

            return Created(new Uri(Request.GetDisplayUrl() + personBl.PersonId),
                _mapper.Map<PersonDto>(personBl));
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePerson(int id, PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var personBl = _people.GetPerson(id);

            if (personBl == null)
                return NotFound();

            _mapper.Map(personDto, personBl);

            personBl = _people.UpdatePerson(personBl);

            return Ok(_mapper.Map<PersonDto>(personBl));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            var personBl = _people.GetPerson(id);

            if (personBl == null)
                return BadRequest();

            _people.DeletePerson(personBl);

            return Ok();
        }
    }
}