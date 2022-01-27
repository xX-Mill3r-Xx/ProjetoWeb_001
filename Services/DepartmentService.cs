using ProjetoWebMVC.Data;
using ProjetoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoWebMVC.Services
{
    public class DepartmentService 
    {
        private readonly ProjetoWebMVCContext _context;

        public DepartmentService(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}