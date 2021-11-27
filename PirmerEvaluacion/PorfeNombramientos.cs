using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmerEvaluacion
{
    public class PorfeNombramientos:Profesor
    {
        private int Sueldofijo;

        public int getSueldofijo()
        {
            return Sueldofijo;
        }

        public void setSueldofijo(int Sueldofijo)
        {
            this.Sueldofijo = Sueldofijo;
        }


        public override void Calculocobrar()
        {
            if (Sueldofijo > 1000)
            {
                Console.WriteLine("El sueldo del profesor es mayor a 1000");
            }
            else
            {
                Console.WriteLine("El sueldo del profesor es menor a 1000");
            }
        }
    }
}

