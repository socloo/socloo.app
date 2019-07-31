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
    class PostsService
    {
        public string url { get; set; }
        public PostsService()
        {
            url = new Constants().WebApi + "Posts/";
        }

        public async Task<bool> Post(PostViewModel post)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(post);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public List<PostModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<PostModel>> response = client.Execute<List<PostModel>>(request);
                List<PostModel> posts = new List<PostModel>(response.Data);
                return posts;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public PostModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<PostModel> response = client.Execute<PostModel>(request);
                PostModel post = response.Data;
                return post;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool PutById(string id, PostModel post)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(post);
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
