using System;
namespace RepasoPersona.core
{
    public abstract class EnteConSaldo
    {
        public virtual double Saldo { get; set; }
        public void debitar(double monto){

                if(Saldo <= 0)
                {
                    throw new Exception("El monto debe ser > a 0");
                } 
                if (Saldo <= monto)
                throw new Exception ("Saldo insificiente");
                Saldo -= monto;
            } 
            public void acreditar(double monto)
            {
                if (Saldo <= 0)
                {
                    throw new Exception ("el monto debe ser mayor a 0");
                }
                Saldo += monto;
            }
    }
}