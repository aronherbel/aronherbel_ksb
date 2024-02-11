using Wasserfass_Uebung;

namespace Wasserfass_Test
{
    [TestClass]
    public class Wasserfass_Test

    {
        [TestMethod]
        public void Befuellen()
        {
           //Arrange
           
            Wasserfass wasserfass = new Wasserfass(200, 0, 180);
            int menge = 10;
            Wasserfass wasserfass1 = new Wasserfass(200, 0, 180);
            int menge1 = -10;
           // Act
            wasserfass.Befuellen(menge);
            wasserfass1.Befuellen(menge1);
            // Assert
            Assert.AreEqual(menge, wasserfass.Fuellstand);
            Assert.AreEqual(wasserfass1.Fuellstand, wasserfass1.Kapiziteat);
        }

        [TestMethod]

        public void Entnehmen()
        {
            //Arrange
            Wasserfass wasserfass = new Wasserfass(200, 0, 180);
            int befuehlMenge = 100;
            int entnehmMenge = 10;
            //Act
            wasserfass.Befuellen(befuehlMenge);
            wasserfass.Entnehmen(entnehmMenge);
            //Assert
            Assert.AreEqual((befuehlMenge - entnehmMenge), wasserfass.Fuellstand);
        }

        [TestMethod]

        public void Entleeren()
        {
            //Arrange
            Wasserfass wasserfass = new Wasserfass(200, 0, 180);
            int befuehlMenge = 100;

            // Act
            wasserfass.Befuellen(befuehlMenge);
            wasserfass.Entleeren();

            // Assert
            Assert.AreEqual(wasserfass.Fuellstand, 0);


        }
    }
}