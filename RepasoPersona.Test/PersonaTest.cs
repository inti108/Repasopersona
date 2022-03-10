using System;
using Xunit;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona Elkakas {get; set;}
        
        [fact]
        public void Constructor()
        {
            Elkakas = new Persona("Elkakas","Lopez",0);
            assert.Equal("Elkakas", Elkakas.Nombre);
            assert.Equal("Lopez", Elkakas.Apellido);
            assert.Equal(0; Elkakas. Efectivo);
        }
    }
}
