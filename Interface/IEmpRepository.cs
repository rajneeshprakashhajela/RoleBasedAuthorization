using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.RoleAuthorization.Interface
{
    public interface IEmpRepository<T> where T : class
    {
        IEnumerable<T> GetAllEmp();
        T GetEmpById(int id);
        void AddEmp(T entity);
        void DeleteEmp(int id);
        void UpdateEmp(T entity);
    }

}
