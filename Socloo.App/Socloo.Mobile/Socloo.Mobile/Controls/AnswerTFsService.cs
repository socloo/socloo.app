using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class AnswerTFsService
    {
        public string url { get; set; }
        public AnswerTFsService()
        {
            url = new Constants().WebApi + "AnswerTFs/";
        }
        public bool Post(AnswerTFViewModel answerTF)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(answerTF);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<AnswerTFModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<AnswerTFModel>> response = client.Execute<List<AnswerTFModel>>(request);
                List<AnswerTFModel> answerTFs = new List<AnswerTFModel>(response.Data);
                return answerTFs;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public AnswerTFModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<AnswerTFModel> response = client.Execute<AnswerTFModel>(request);
                AnswerTFModel answerTF = response.Data;
                return answerTF;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Put(string id, AnswerTFModel answerTF)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(answerTF);
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
