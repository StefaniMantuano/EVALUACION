using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmerEvaluacion
{
    public abstract class Profesor
    {

        //Propiedades 
        private string Nombres;
        private string Apellidos;
        private string Dirección;
        private int Numerocedula;

        
        public string getNombres()
        {
            return Nombres;
        }

        public void setNombres(string Nombres)
        {
            this.Nombres = Nombres;
        }


        public string getApellidos()
        {
            return Apellidos;
        }

        public void setApellidos(string Apellidos)
        {
            this.Apellidos = Apellidos;
        }

        public string getDirección()
        {
            return Dirección;
        }

        public void setDirección(string Dirección)
        {
            this.Dirección = Dirección;
        }

        public int getnumerocedula()
        {
            return Numerocedula;
        }

        public void setnumerocedula(int Numerocedula)
        {
            this.Numerocedula = Numerocedula;
        }


        //Definir método
        public void Mostrar()

        {
            Console.WriteLine("Nombre: {0}; Apellidos:  {1}; Dirección:  {2}; Numerocedula:  {3}", Nombres, Apellidos, Dirección, Numerocedula);
        }


        public abstract void Calculocobrar();
        
    }
}
