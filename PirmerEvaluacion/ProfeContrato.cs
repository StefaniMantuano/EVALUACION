using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmerEvaluacion
{
    public class ProfeContrato: Profesor
    {
        private int Sueldobasico;
        private int horasextras;
        private int sueldot;

        
        public int getSueldobasico()
        {
            return Sueldobasico;
        }

        public void setSueldobasico(int Sueldobasico)
        {
            this.Sueldobasico = Sueldobasico;
        }

        public int gethorasextras()
        {
            return horasextras;
        }

        public void sethorasextras(int horasextras)
        {
            this.horasextras = horasextras;
        }


        public override void Calculocobrar()
        {
            sueldot = Sueldobasico + horasextras;

            Console.WriteLine("El sueldo del profesor por contrato es:   "+sueldot);
        }

    }
}
