using System;

namespace PirmerEvaluacion
{
    
    class Program
    {
        static void Main(String[] args)
        {

            //Profesor Contrato
            ProfeContrato contrato = new ProfeContrato();
            contrato.setNombres("Stefania");
            contrato.setApellidos("Mantuano");
            contrato.setDirección("Manta");
            contrato.setnumerocedula(1319884858);
            contrato.setSueldobasico(400);
            contrato.sethorasextras(15);


            //Profesor Horas
            ProfeHoras profesor1= new ProfeHoras();
            profesor1.setNombres("Juaana");
            profesor1.setApellidos("Cedeño");
            profesor1.setDirección("Manta");
            profesor1.setnumerocedula(1354896455);
            profesor1.setpreciohora(5);
            profesor1.setcantidadhorastrabajadas(215);


            //Profesor Nombramiento
            PorfeNombramientos profesor2 = new PorfeNombramientos();
            profesor2.setNombres("Pedro");
            profesor2.setApellidos("Anchundia");
            profesor2.setDirección("Manta");
            profesor2.setnumerocedula(138532645);
            profesor2.setSueldofijo(850);

            List<Profesor> ListaProfesor = new List<Profesor>();
            ListaProfesor.Add(contrato);
            ListaProfesor.Add(profesor1);
            ListaProfesor.Add(profesor2);

            foreach (Profesor profesor in ListaProfesor)
            {
                profesor.Mostrar();
                profesor.Calculocobrar();
                Console.WriteLine();
            }












        }
    }
}




