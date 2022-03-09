using System;

namespace RepasoPersona.core
{
    public class Persona
    {
        public string Nombre {get; private set;}
        public string Apellido {get; private set;}
        public double Efectivo {get; private set;}

        public Persona () => Efectivo = 0;

        public Persona (string Nombre, string Apellido, double Efecto)
        {
            Nombre = Nombre;
            Apellido = Apellido;
            Efectivo = Efectivo;
        }
        
        public class Persona
        {
            public void debitar(double monto){

                if(Efectivo <= 0)
                {
                    throw new Exception("El monto debe ser > a 0");
                } 
                if (Efectivo <= monto)
                throw new Exception ("Saldo insificiente");
                Efectivo -= monto;
            } 
            public void acreditar(double monto)
            {
                if (Efectivo <= 0)
                {
                    throw new Exception ("el monto debe ser mayor a 0");
                }
                Efectivo += monto;
            }
            
        }

        

        
    }
}
