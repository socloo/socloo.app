using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls {
    class TestsService {
        public string url { get; set; }
        public TestsService() {
            url = new Constants().WebApi + "Tests/";
        }

        public bool Post(TestViewModel test) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(test);
                client.Execute(request);
                return true;
            } catch (Exception e) {
                return false;
            }

        }

        public List<TestModel> GetAll() {
            try {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<TestModel>> response = client.Execute<List<TestModel>>(request);
                List<TestModel> tests = new List<TestModel>(response.Data);
                return tests;
            } catch (Exception e) {
                return null;
            }
        }

        public TestModel GetById(string id) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<TestModel> response = client.Execute<TestModel>(request);
                TestModel test = response.Data;
                return test;
            } catch (Exception e) {
                return null;
            }
        }

        public bool Put(string id, TestModel test) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(test);
                client.Execute(request);
                return true;
            } catch (Exception e) {
                return false;
            }
        }
        public bool Delete(string id) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.DELETE);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                client.Execute(request);
                return true;
            } catch (Exception e) {
                return false;
            }

        }
    }
}
