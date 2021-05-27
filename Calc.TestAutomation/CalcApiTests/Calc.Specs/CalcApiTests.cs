
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

        public CalcAPITests()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            calcEndpoint = configuration.GetSection("calcAPIEndpoint").Value;
            authKey = configuration.GetSection("x-functions-key").Value;
            client = new RestClient(calcEndpoint);

        }

        /*Triggers the api request and retrieves the response*/
        public decimal Calculate(decimal leftNumber, decimal rightNumber, string op)
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-functions-key", authKey);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { LeftNumber = leftNumber, RightNumber = rightNumber, Operator = op });
            IRestResponse response = client.Execute(request);
            Console.WriteLine("statuscode:" + response.StatusCode);
            Console.WriteLine("response: " + response.Content);
            var jObj = JObject.Parse(response.Content);
            string answer = jObj.GetValue("value").ToString();
            Console.WriteLine("Answer = " + answer);
            Assert.AreEqual("OK", response.StatusCode.ToString());
            decimal actualAnswer = Convert.ToDecimal(answer);
            return actualAnswer;
        }

        [Test]
        public void AuthorizationByFalseKey()
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-functions-key", ";ajg;ajga;jg");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { LeftNumber = "1", RightNumber = "2", Operator = "+" });
            IRestResponse response = client.Execute(request);
            Assert.AreEqual("Unauthorized", response.StatusCode.ToString());
        }

        [Test]
        public void AuthorizationNullAuthKey()
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-functions-key", null);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { LeftNumber = "1", RightNumber = "2", Operator = "+" });
            IRestResponse response = client.Execute(request);
            Assert.AreEqual("Unauthorized", response.StatusCode.ToString());
        }

        [Test]
        public void AuthorizationNoAuthKeyHeader()
        {
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { LeftNumber = "1", RightNumber = "2", Operator = "+" });
            IRestResponse response = client.Execute(request);
            Assert.AreEqual("Unauthorized", response.StatusCode.ToString());
        }

        [Test]
        public void AssertContentType()
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-functions-key", authKey);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { LeftNumber = "1", RightNumber = "2", Operator = "+" });
            IRestResponse response = client.Execute(request);
            Assert.AreEqual("application/json; charset=utf-8", response.ContentType.ToString());
        }

        [Test]
        public void EmptyOperator404Error()
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("x-functions-key", authKey);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { LeftNumber = "1", RightNumber = "2", Operator = "" });
            IRestResponse response = client.Execute(request);
            Assert.AreEqual("NotFound", response.StatusCode.ToString());
        }
    }
}


