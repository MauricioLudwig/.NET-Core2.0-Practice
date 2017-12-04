using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        [Route("breakfast")]
        [HttpGet]
        public string Breakfast(string breakfast)
        {

            string message;

            if (String.IsNullOrEmpty(breakfast))
                return "You did not enter anything";

            switch (breakfast.ToLower())
            {
                case "egg":
                    message = "Å nej, du borde inte äta ägg till frukost!";
                    break;
                case "mango":
                    message = "Ja, mango är gott!";
                    break;
                default:
                    message = "Does not exist";
                    break;
            }

            return message;
        }

        [Route("square")]
        [HttpGet]
        public int Square(int number)
        {
            return number * number;
        }

        [Route("range")]
        [HttpGet]
        public string Range(int fromNumber, int toNumber)
        {
            string message = "";

            for (int i = fromNumber; i <= toNumber; i++)
            {
                message += i.ToString() + ", ";
            }

            return message; ;
        }

        [Route("backgroundcolor")]
        [HttpGet]
        public IActionResult BackgroundColor(string backgroundColor)
        {
            string html = $"<body style='background-color:{backgroundColor}'></body>";
            return Content(html, "text/html");
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
