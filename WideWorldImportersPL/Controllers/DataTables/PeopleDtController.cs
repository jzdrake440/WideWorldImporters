using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataTables.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WideWorldImporters.BLL.Services;

namespace WideWorldImportersPL.Controllers.DataTables
{
    [Produces("application/json")]
    [Route("dt/people")]
    public class PeopleDtController : Controller
    {
        private IMapper _mapper;
        private IPeopleService _people;

        public PeopleDtController(IMapper mapper, IPeopleService people)
        {
            _mapper = mapper;
            _people = people;
        }

        [HttpPost]
        public IActionResult GetCustomerDataTable(DataTableServerSideRequest request)
        {
            return Ok(_people.GetPeopleDataTableResponse(request));
        }
    }
}