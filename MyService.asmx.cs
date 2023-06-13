using System.Collections.Generic;
using System.Web.Services;

namespace WebService_Building
{

    /// <summary>
    /// Implementation of the MyService web service by merit of studies
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyService : System.Web.Services.WebService
    {
        private List<string> GreetingsArray = new List<string> { "Olá, mundo!", "Hello World!", "Hallo Welt!", "Hei Verden!", "pozdrowienia" };

        //built-in database simulation

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<string> HelloWorldInSeveralLanguagens() 
        {
            var Greetings = GreetingsArray;

            return Greetings;
        }

        [WebMethod]
        public List<string> IncludeNewSaludation(string saludation)
        {
            GreetingsArray.Add(saludation);

            return GreetingsArray;
        }
    }
}
