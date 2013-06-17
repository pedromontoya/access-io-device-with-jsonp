using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace Client.Server.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define server configuration
            var serverConfig = new HttpSelfHostConfiguration("http://127.0.0.1:99");
            serverConfig.Routes
                .MapHttpRoute(
                    "default",
                    "api/{controller}");

            //Remove default formatters since they're not really being used. 
            serverConfig.Formatters.Clear();

            //Create instance of self hosted server with previously defined configuration settings.
            var server = new HttpSelfHostServer(serverConfig);

            //Initiate server to listen for requests.
            server.OpenAsync().Wait();

            Console.ReadLine();

            //Shut down server. 
            server.CloseAsync();
        }
    }
}
