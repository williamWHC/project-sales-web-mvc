using System.Collections.Generic;

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
    }
}
