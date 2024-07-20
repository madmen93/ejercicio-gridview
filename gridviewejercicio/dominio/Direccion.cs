using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Direccion
    {
        public int Id { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public int codigoPostal { get; set; }
        public string distrito { get; set; }
    }
    public class DireccionNegocio
    {
        public List<Direccion> listar()
        {
            List<Direccion> lista = new List<Direccion>();
            lista.Add(new Direccion());
            lista.Add(new Direccion());
            lista.Add(new Direccion());

            lista[0].Id = 1;
            lista[0].calle = "Jr Rousseau";
            lista[0].numero = 220;
            lista[0].codigoPostal = 15037;
            lista[0].distrito = "San Borja";
            
            lista[1].Id = 2;
            lista[1].calle = "Av México";
            lista[1].numero = 1150;
            lista[1].codigoPostal = 15000;
            lista[1].distrito = "La Victoria";
            
            lista[2].Id = 3;
            lista[2].calle = "Jr Luna Pizarro";
            lista[2].numero = 235;
            lista[2].codigoPostal = 15018;
            lista[2].distrito = "La Victoria";
            
            return lista;
        }
    }
}
