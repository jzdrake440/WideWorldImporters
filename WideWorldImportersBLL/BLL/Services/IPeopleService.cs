using System;
using System.Collections.Generic;
using DataTables.Models;
using WideWorldImporters.DAL;
using WideWorldImporters.BLL.Models;

namespace WideWorldImporters.BLL.Services
{
    public interface IPeopleService
    {
        PersonBl AddPerson(PersonBl personBl);
        void DeletePerson(PersonBl personBl);
        List<PersonBl> GetPeople();
        List<PersonBl> GetPeople(Func<Person, bool> criteria);
        List<PersonBl> GetPeople(IEnumerable<int> ids);
        DataTableServerSideResponse<PersonBl> GetPeopleDataTableResponse(DataTableServerSideRequest request);
        PersonBl GetPerson(int id);
        PersonBl UpdatePerson(PersonBl personBl);
    }
}