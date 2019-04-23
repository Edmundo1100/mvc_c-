using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Servicos
{
    public class VendedorServico
    {
        private readonly SalesWebMvcContext _context;

        public VendedorServico(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            obj.Departamento = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
