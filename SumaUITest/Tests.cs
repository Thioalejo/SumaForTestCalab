using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SumaUITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void SumaDeDosnumerosEnteros()
        {
            //arrange
            app.EnterText("EntryA", "5");
            app.EnterText("EntryA", "5");

            //act

            //para presionar el boton

            app.Tap("btnCalcularA");


            //Assert
            //para guardar dato tomado 
            var appResult = app.Query("EntryR").First(resul => resul.Text == "10");
            Assert.IsTrue(appResult != null, "El resultado del label no es correcto");


        }
    }
}

