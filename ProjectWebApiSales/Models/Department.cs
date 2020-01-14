using System.Collections.Generic;
using System;
using System.Linq;

namespace ProjectWebApiSales.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Associação com o class saller + instanciado a coleção com uma lista de vendedores
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //Method
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
