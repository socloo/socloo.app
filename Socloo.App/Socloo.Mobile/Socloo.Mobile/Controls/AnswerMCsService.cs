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
    class AnswerMCsService
    {
        public string url { get; set; }
        public AnswerMCsService()
        {
            url = new Constants().WebApi + "AnswerMCs/";
        }
        public async Task<bool> Post(AnswerMCViewModel answerMC)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(answerMC);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<AnswerMCModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<AnswerMCModel>> response = client.Execute<List<AnswerMCModel>>(request);
                List<AnswerMCModel> answerMCs = new List<AnswerMCModel>(response.Data);
                return answerMCs;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public AnswerMCModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<AnswerMCModel> response = client.Execute<AnswerMCModel>(request);
                AnswerMCModel answerMC = response.Data;
                return answerMC;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Put(string id, AnswerMCModel answerMC)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(answerMC);
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
