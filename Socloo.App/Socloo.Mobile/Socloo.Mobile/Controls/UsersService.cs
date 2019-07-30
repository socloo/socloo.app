using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class UsersService
    {
        public string url { get; set; }
        public UsersService()
        {
            url = new Constants().WebApi + "users/";
        }

        public List<UserModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<UserModel>> response = client.Execute<List<UserModel>>(request);
                List<UserModel> users = new List<UserModel>(response.Data);
                return users;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public UserModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<UserModel> response = client.Execute<UserModel>(request);
                UserModel user = response.Data;
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
