using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("values")]
    public class ValuesController : Controller
    {

        [Route("getname")]
        [HttpGet]
        public IEnumerable<string> GetName()
        {
            return new string[] { "Damien", "Gallagher" };
        }

        [Route("gethell")]
        [HttpGet]
        public IEnumerable<string> GetHell(int multiplier)
        {

            List<string> array = new List<string>();

            for (int i = 0; i < multiplier; i++)
            {
                array.Add("hell world");
            }

            return array;
        }

        [Route("getweekday")]
        public string GetWeekDay()
        {
            var dateTime = DateTime.Now;
            var detractTime = dateTime.AddYears(-10);

            return String.Format($"Today is {dateTime.DayOfWeek} and 10 years ago it was {detractTime.DayOfWeek}.");
        }

        [Route("getfloskel")]
        public string GetFloskel()
        {

            string message = "You've got the case of the ";
            var weekDayInt = (int)DateTime.Now.DayOfWeek;

            switch (weekDayInt)
            {
                case 0:
                    message += "sundays";
                    break;
                case 1:
                    message += "mondays";
                    break;
                case 2:
                    message += "tuesdays";
                    break;
                case 3:
                    message += "wednesdays";
                    break;
                case 4:
                    message += "thurdays";
                    break;
                case 5:
                    message += "fridays";
                    break;
                case 6:
                    message += "saturdays";
                    break;
                default:
                    message = "Something went wrong";
                    break;
            }

            return message;
        }

    }
}
