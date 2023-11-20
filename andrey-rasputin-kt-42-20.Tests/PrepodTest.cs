using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using andrey_rasputin_kt_42_20.Models;

namespace andrey_rasputin_kt_42_20.Tests
{
    public class PrepodTest
    {
        [Fact]
        public void IsValidMail_True()
        {
            var MailTest = new Prepod
            {
                Mail = "test@mail.ru"
            };

            var result = MailTest.IsValidMail();

            Assert.False(result);

        }
    }
}
