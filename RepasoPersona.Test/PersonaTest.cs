using System;
using Xunit;
using RepasoPersona.core;


namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        Persona Elkakas {get; set;}
        public PersonaTest() => Elkakas = new Persona ("Elkakas", "Lopez", 0);

        [Fact]
        public void Constructor()
        {
            Assert.Equal("Elkakas", Elkakas.Nombre);
            Assert.Equal("Lopez", Elkakas.Apellido);
            Assert.Equal(0, Elkakas. Efectivo);
        }

        [Fact]
        public void AcreditarPositivo()
        {
            double esporado = 1000;
            Elkakas.acreditar(1000);
            Assert.Equal(esporado, Elkakas.Efectivo, 3);
        }
    }
}
