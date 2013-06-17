using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Client.Server.Sample
{
    public class ServicesController : ApiController
    {
        /// <summary>
        /// Gets resulting data JSON wrapped in caback function invocation.
        /// </summary>
        /// <param name="callback">The name of the callback function to invoke.</param>
        /// <returns>JavaScript string containing return data as a parameter in a callback invocation.</returns>
        public HttpResponseMessage GET(string callback)
        {
            var jsonObjString = "{camber: -1.8, caster: 2.9, toe: .5}";
            var jsonPString = callback + "(" + jsonObjString + ")";

            var responseMsg = new HttpResponseMessage
            {
                Content = new StringContent(jsonPString, Encoding.UTF8, "application/x-javascript")
            };

            return responseMsg;
        }

        /// <summary>
        /// Default GET request endpoint. 
        /// </summary>
        /// <returns>A hard-coded JSON string.</returns>
        public HttpResponseMessage GET()
        {
            var jsonObjString = "{camber: -1.8, caster: 2.9, toe: .5}";

            var responseMsg = new HttpResponseMessage
            {
                Content = new StringContent(jsonObjString, Encoding.UTF8, "application/json")
            };

            return responseMsg;
        }
    }
}
