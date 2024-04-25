using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public class Vertebrado : Animal
    {
        public int id { get; set; }

        public int vertebradoId { get; set; }

        public string vertebradoName { get; set; }



        public override string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
