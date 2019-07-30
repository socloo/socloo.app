using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class AnswerSAsService
    {
        public string url { get; set; }
        public AnswerSAsService()
        {
            url = new Constants().WebApi + "AnswerSAs/";
        }
        public bool Post(AnswerSAViewModel answerSA)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(answerSA);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<AnswerSAModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<AnswerSAModel>> response = client.Execute<List<AnswerSAModel>>(request);
                List<AnswerSAModel> answerSAs = new List<AnswerSAModel>(response.Data);
                return answerSAs;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public AnswerSAModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<AnswerSAModel> response = client.Execute<AnswerSAModel>(request);
                AnswerSAModel answerSA = response.Data;
                return answerSA;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Put(string id, AnswerSAModel answerSA)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(answerSA);
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
