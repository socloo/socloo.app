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
    class MessagesService
    {
        public string url { get; set; } 
        public MessagesService()
        {
            url = new Constants().WebApi + "Messages/";
        }

        public async Task<bool> Post(MessageViewModel message)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(message);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public List<MessageModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<MessageModel>> response = client.Execute<List<MessageModel>>(request);
                List<MessageModel> messages = new List<MessageModel>(response.Data);
                return messages;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public MessageModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<MessageModel> response = client.Execute<MessageModel>(request);
                MessageModel message = response.Data;
                return message;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Put(string id, MessageModel message)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(message);
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
