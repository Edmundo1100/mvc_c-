using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            this.Vendedores.Add(vendedor);
        }
        public double TotalVendas(DateTime dataInicialVenda, DateTime dataFinalVenda)
        {
            return this.Vendedores.Sum(v => v.TotalVendas(dataInicialVenda, dataFinalVenda));
        }
    }
}
