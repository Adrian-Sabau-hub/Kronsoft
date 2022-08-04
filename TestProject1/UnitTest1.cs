using System.Globalization;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
        [Test]
        public void Test1()
        {
            var alimente = new Alimente("paine", "moara", DateTime.ParseExact("04.08.2022", "dd.MM.yyyy", null), 10);
            Assert.Pass();
        }
        */
        /*
        [Test]
        public void WelnessTest()
        {
            // Arrange
            var infoApa = new InfoApa();

            // Act
            var result1.IsConsoleInputValid("0");

            // Asert
            Assert.IsFalse(result1);
        }
        */
        [Test]
        public void FirstTest()
        {
            // Arrange
            //var reverseLetters = new ReverseLetters();

            ////Act
            //reverseLetters.EnterLeter('b', 'a', 't');

            //// Asert
            //Assert.That(reverseLetters.Result, Is.EqualTo("t a b"));
        }

        [Test]
        public void SecondTest()
        {
            // Arrange
            //var string1 = new String("12345");

            ////Act
            //int nr = StringLength.CalculateLength(string1);

            //// Asert
            //Assert.That(nr, Is.EqualTo(5));

        }

        [Test]
        public void ThirdTest()
        {
            // Arrange
            var string1 = new String("Kronsoft, Iquest");

            //Act
            var index = string1.IndexOf(",");
            string rezultat = string1.Substring(index);
            rezultat = rezultat.Trim();

            // Asert
            Assert.That(rezultat, Is.EqualTo("Iquest"));

        }

        [Test]
        public void CultureTest()
        {
            // Arrange
            var date = new DateTime(2022, 08, 03);

            //Act
            Console.WriteLine(date.ToString("d", new CultureInfo("fr-FR")));

            // Asert

        }
    }
}