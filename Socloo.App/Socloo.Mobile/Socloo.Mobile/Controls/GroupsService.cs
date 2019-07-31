using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class GroupsService
    {
        public string url { get; set; }
        public GroupsService()
        {
            url = new Constants().WebApi + "Groups/";
        }

        public async Task<bool> Post(GroupViewModel group)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(group);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public List<GroupModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<GroupModel>> response = client.Execute<List<GroupModel>>(request);
                List<GroupModel> groups = new List<GroupModel>(response.Data);
                return groups;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public GroupModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<GroupModel> response = client.Execute<GroupModel>(request);
                GroupModel group = response.Data;
                return group;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool PutById(string id, GroupModel group)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(group);
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
