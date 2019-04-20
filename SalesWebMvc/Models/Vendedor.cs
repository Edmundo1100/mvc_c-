using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateNascimento { get; set; }
        public int SalarioBase { get; set; }
        public Department Departamento { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime dateNascimento, int salarioBase, Department departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            DateNascimento = dateNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void AddVendas(Venda v)
        {
            Vendas.Add(v);
        }
        public void RemoveVendas(Venda v)
        {
            Vendas.Remove(v);
        }
        public double TotalVendas(DateTime dataInicial,DateTime dataFinal)
        {
            return Vendas.Where(v => v.Data >= dataInicial && v.Data <= dataFinal).Sum(v => v.Total);
        }
    }
}
