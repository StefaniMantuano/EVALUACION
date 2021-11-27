using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmerEvaluacion
{
    public class ProfeHoras:Profesor
    {
        private int preciohora;
        private int cantidadhorastrabajadas;
        private int sueldo;
    
  
        public int getpreciohora()
        {
            return preciohora;
        }

        public void setpreciohora(int preciohora)
        {
            this.preciohora = preciohora;
        }

        public int getcantidadhorastrabajadas()
        {
            return cantidadhorastrabajadas;
        }

        public void setcantidadhorastrabajadas(int cantidadhorastrabajadas)
        {
            this.cantidadhorastrabajadas = cantidadhorastrabajadas;
        }

        public override void Calculocobrar()
    
    {
        sueldo = preciohora * cantidadhorastrabajadas;
        Console.WriteLine("El sueldo a pagar es:   "+sueldo);

    }

    }
}
