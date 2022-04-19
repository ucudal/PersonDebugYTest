using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void NombreInvalidoPeroCedulaValida()
        {
            Person p = new Person("", "5.118.426-3");

            Assert.AreEqual(null, p.Name);
            Assert.AreEqual("5.118.426-3", p.ID);
        }
        
        [Test]
        public void CedulaInvalidaPeroNombreValido()
        {
            Person p = new Person("Jorge", "347");
            
            Assert.AreEqual("Jorge", p.Name);
            Assert.AreEqual(null, p.ID);
        }
        
        [Test]
        public void TodoInvalido()
        {
            Person p = new Person("", "347");
            
            Assert.AreEqual(null, p.Name);
            Assert.AreEqual(null, p.ID);
        }

        [Test]
        public void TodoValido()
        {
            Person p = new Person("Jorge", "5.118.426-3");
            
            Assert.AreEqual("Jorge", p.Name);
            Assert.AreEqual("5.118.426-3", p.ID);
        }
    }
}