using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public abstract  class Animal
    {
        public abstract string Nombre { get; set; }    
        public string Tamanio {  get; set; }    
        public string Color { get; set;}
        public string Familia { get; set;}

        public abstract void Imprimir();
    }
}
