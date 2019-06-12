using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace horsedev.Tests
{
    class APITests
    {
        

        [Test]
        public void PostRequestTests()
        {
            string location = "";
            //estalishing the client
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");

            // request
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            //add the body of request 
            request.AddParameter("application/json", "{\"name\":\"value\"}", ParameterType.RequestBody);

            //executing the rest request
            var response = client.Execute(request);

            var resHeader = response.Headers;
            foreach(var res in resHeader)
            {
                if (res.Name == "Location")
                    location = res.Value.ToString();

            }
            Console.WriteLine("location" + location);

            //assertion / validation / verification
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        [Test]
        public void GetRequestTests()
        {
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");
            var request = new RestRequest("/d46ff4be-8cef-11e9-8bcb-ef8e39077ebe", Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            //executing the request
            var response = client.Execute(request);

            //assertion
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void UpdateRequestsTests()
        {
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");
            var request = new RestRequest("/d46ff4be-8cef-11e9-8bcb-ef8e39077ebe", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", "{\"students\": [\"Minty\",\"Kavya\",\"Shashi\",\"Kris\",\"Divya\",\"Shashi\",\"Richa\",\"Sravan\",\"Priya\"]}", ParameterType.RequestBody);

            var response = client.Execute(request);

            //assertion
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void DeleteRequestTests()
        {
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");
            var request = new RestRequest("/d46ff4be-8cef-11e9-8bcb-ef8e39077ebe", Method.DELETE);
            var response = client.Execute(request);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
