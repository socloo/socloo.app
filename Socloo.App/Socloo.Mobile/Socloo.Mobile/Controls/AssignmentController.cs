using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class AssignmentController
    {
        public string url { get; set; }
        public AssignmentController()
        {
            url = new Constants().WebApi + "Assignments/";
        }
        public bool Post(AssignmentViewModel assignment)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(assignment);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<AssignmentModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<AssignmentModel>> response = client.Execute<List<AssignmentModel>>(request);
                List<AssignmentModel> assignments = new List<AssignmentModel>(response.Data);
                return assignments;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public AssignmentModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<AssignmentModel> response = client.Execute<AssignmentModel>(request);
                AssignmentModel assignment = response.Data;
                return assignment;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Put(string id, AssignmentModel assignment)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(assignment);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public bool Delete(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.DELETE);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}

