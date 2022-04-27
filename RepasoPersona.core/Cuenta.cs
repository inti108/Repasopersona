namespace RepasoPersona.core
{
    public class Cuenta : EnteConSaldo
    {
        public int CBU { get; set; }

        public Persona cliente { get; set; }

        public Cuenta() => Saldo = 0;
    }
}