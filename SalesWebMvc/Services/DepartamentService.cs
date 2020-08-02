using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartamentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Departament obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
