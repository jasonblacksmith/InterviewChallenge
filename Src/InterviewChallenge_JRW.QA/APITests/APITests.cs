using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Extensions;
using RestSharp.Authenticators;
using RestSharp.Serializers;
using RestSharp;
using NUnit.Framework;
using System.Diagnostics;

namespace InterviewChallenge_JRW.QA.APITests
{
    internal class APITests
    {

        [TestCase]
        public async Task Get_Information_Challenge() 
        {
            var client = new RestClient("https://si-interview-api.azurewebsites.net/api/Information/Challenge");
            RestRequest request = new("", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Assert.That(response.StatusDescription, Is.EqualTo("OK"));
        }

        [TestCase]
        public async Task Get_Forecast()
        {
            var client = new RestClient("https://si-interview-api.azurewebsites.net/api/WeatherForecast");
            RestRequest request = new("/WeatherForecast", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Assert.That(response.StatusDescription, Is.EqualTo("OK"));
        }

        [TestCase]
        public async Task Post_Forecast()
        {
            var client = new RestClient("https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast");
            RestRequest request = new("", Method.Post);
            var param = new {
                id = 0,
                date = "2022-03-14T04:50:49.046Z",
                temperatureC = 10,
                summary = "string",
                location = "string"
            };
            request.AddJsonBody(param);
            RestResponse response = await client.ExecuteAsync(request);
            Assert.That(response.StatusDescription, Is.EqualTo("OK"));
        }

        [TestCase]
        public async Task Put_Forecast()
        {
            var client = new RestClient("https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast");
            RestRequest request = new("", Method.Put);
            var param = new
            {
                id = 0,
                date = "2022-03-14T04:50:49.046Z",
                temperatureC = 10,
                summary = "string",
                location = "string"
            };
            request.AddJsonBody(param);
            RestResponse response = await client.ExecuteAsync(request);
            Assert.That(response.StatusDescription, Is.EqualTo("OK"));
        }

        [TestCase]
        public async Task Get_Forecast_ByLocation()
        {
            var client = new RestClient("https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast");
            RestRequest request = new("/Brazil", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Assert.That(response.StatusDescription, Is.EqualTo("OK"));
        }

        [TestCase]
        public async Task Delete_Forecast_ByLocation()
        {
            var forecastId = 637825710798870019;
            var client = new RestClient("https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast");
            RestRequest request = new($"/{forecastId}", Method.Delete);
            RestResponse response = await client.ExecuteAsync(request);
            Assert.That(response.StatusDescription, Is.EqualTo("OK"));
        }
    }
}
