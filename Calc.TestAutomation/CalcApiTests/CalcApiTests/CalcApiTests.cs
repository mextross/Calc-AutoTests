
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.IO;

namespace CalcApiTests
{
    public class CalcAPITests
    {
        public string calcEndpoint;
        public RestClient client;
        public string authKey;
        public string Operator;

        public CalcAPITests(string Op) {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            calcEndpoint = configuration.GetSection("calcAPIEndpoint").Value;
            authKey = configuration.GetSection("x-functions-key").Value;
            client = new RestClient(calcEndpoint);
            Operator = Op;
        }

        public decimal Calculate(decimal leftNumber, decimal rightNumber)
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-functions-key", authKey);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { LeftNumber = leftNumber, RightNumber = rightNumber, Operator = this.Operator});
            IRestResponse response = client.Execute(request);
            var jObj = JObject.Parse(response.Content);
            string answer = jObj.GetValue("value").ToString();
            Console.WriteLine("Answer = " + answer);
            Assert.AreEqual("OK", response.StatusCode.ToString());
            decimal actualAnswer = Convert.ToDecimal(answer);
            return actualAnswer;
        }
    }
}


