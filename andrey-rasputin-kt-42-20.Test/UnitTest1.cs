using andrey_rasputin_kt_42_20.Models;
namespace andrey_rasputin_kt_42_20.Test
{
    public class UnitTest1
    {
        [Fact]
        public void IsValidMail_True()
        {
            var MailTest = new Prepod
            {
                Mail = "mm@mail.ru"
            };

            var result = MailTest.IsValidMail();

            Assert.False(result);

        }
    }
}