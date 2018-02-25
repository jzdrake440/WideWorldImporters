using System.Linq;
using DataTables.Models;
using AutoMapper;

namespace DataTables.Services
{
    public interface IDataTableService
    {
        DataTableServerSideResponse<TMapTo> GetDataTableData<T, TMapTo>(DataTableServerSideRequest request, IQueryable<T> data);
    }
}