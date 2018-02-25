using DataTables.Models;
using WideWorldImporters.DAL;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataTables.Services;
using WideWorldImporters.BLL.Models;

namespace WideWorldImporters.BLL.Services
{
    
    public class PeopleService : IPeopleService
    {
        private readonly WideWorldImportersContext _context;
        private readonly IMapper _mapper;
        private readonly IDataTableService _dataTableService;

        public PeopleService(WideWorldImportersContext context, IMapper mapper, IDataTableService dataTableService)
        {
            _context = context;
            _mapper = mapper;
            _dataTableService = dataTableService;
        }

        public PersonBl GetPerson(int id)
        {
            return GetPeople(p => p.PersonId == id).SingleOrDefault();
        }

        public List<PersonBl> GetPeople(IEnumerable<int> ids)
        {
            return GetPeople(p => ids.Contains(p.PersonId));
        }

        public List<PersonBl> GetPeople(Func<Person, bool> criteria)
        {
            return _mapper.Map<List<PersonBl>>(_context.People.Where(criteria).ToList());
        }

        public List<PersonBl> GetPeople()
        {
            return _mapper.Map<List<PersonBl>>(_context.People.ToList());
        }

        public DataTableServerSideResponse<PersonBl> GetPeopleDataTableResponse(DataTableServerSideRequest request)
        {
            return _dataTableService.GetDataTableData<Person, PersonBl>(
                request,
                _context.People);
        }

        public PersonBl AddPerson(PersonBl personBl)
        {
            if (personBl == null)
                throw new ArgumentException("personBl cannot be null");

            if (personBl.PersonId != 0)
                throw new ArgumentException("personBl cannot define it's own id");

            var person = _mapper.Map<Person>(personBl);
            _context.People.Add(person);
            _context.SaveChanges();

            return _mapper.Map<PersonBl>(person);
        }

        public PersonBl UpdatePerson(PersonBl personBl)
        {
            if (personBl == null)
                throw new ArgumentException("personBl cannot be null");

            var person = _context.People.SingleOrDefault(p => p.PersonId == personBl.PersonId);

            if (person == null)
                throw new ArgumentException(String.Format("person {0} does not exist", personBl.PersonId));

            _mapper.Map(personBl, person);
            _context.SaveChanges();

            return _mapper.Map<PersonBl>(person);
        }

        public void DeletePerson(PersonBl personBl)
        {
            if (personBl == null)
                throw new ArgumentException("personBl cannot be null");

            var person = _context.People.SingleOrDefault(p => p.PersonId == personBl.PersonId);

            if (person == null)
                throw new ArgumentException(String.Format("person {0} does not exist", personBl.PersonId));

            _context.People.Remove(person);
            _context.SaveChanges();
        }
    }
}
