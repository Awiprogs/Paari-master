using System;
using System.Configuration;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaariTest
{
    [TestClass]
    public class WebApiTest
    {
        private HttpClient _client;

        public WebApiTest()
        {
            string url = ConfigurationManager.AppSettings["WebApiUrl"];
            _client = new HttpClient {BaseAddress = new Uri(url)};

            ProductController apiController = new ProductController();
        }

        [TestMethod]
        public void WebApiConnectionTestTest()
        {
            //_client.
        }

        [TestMethod]
        public void GetAllTest()
        {
        }
    }
}
