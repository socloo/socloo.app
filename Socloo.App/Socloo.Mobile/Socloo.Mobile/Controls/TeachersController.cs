using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class TeachersController
    {
        public string url { get; set; }
        public TeachersController()
        {
            url = new Constants().WebApi+"Teachers/";
        }

        public bool Post(TeacherViewModel teacher)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
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

        public List<TeacherModel> GetAllTeacher()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest("https://socloodev.azurewebsites.net/api/" + "teachers/", Method.GET);
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

        public TeacherModel GetTeacherById(string id)
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
                var request = new RestRequest("https://socloodev.azurewebsites.net/api/" + "teachers/" + id, Method.PUT);
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
