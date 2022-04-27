using System;

namespace RepasoPersona.core
{
    public class Persona : EnteConSaldo
    {
        public string Nombre {get; private set;}
        public string Apellido {get; private set;}
        // public double Efectivo {get; private set;}
        
        public Persona () => Saldo = 0;

        public Persona (string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
        }
            
        }

        

        
    }

