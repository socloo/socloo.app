using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class TeachersService
    {
        public string url { get; set; }
        public TeachersService()
        {
            url = new Constants().WebApi+"Teachers/";
        }

        public async Task<bool> Post(TeacherViewModel teacher)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(teacher);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            }
            catch (Exception e)
            {
                return false;
            }
           
        }

        public List<TeacherModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<TeacherModel>> response = client.Execute<List<TeacherModel>>(request);
                List<TeacherModel> teachers= new List<TeacherModel>(response.Data);
                return teachers;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public TeacherModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<TeacherModel> response = client.Execute<TeacherModel>(request);
                TeacherModel teacher = response.Data;
                return teacher;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool PutById(string id, TeacherModel teacher)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(teacher);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DeleteById(string id)
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
