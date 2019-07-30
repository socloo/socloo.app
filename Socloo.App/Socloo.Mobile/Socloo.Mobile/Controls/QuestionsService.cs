using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls {
    class QuestionsService {
        public string url { get; set; }
        public QuestionsService() {
            url = new Constants().WebApi + "Questions/";
        }

        public bool Post(QuestionViewModel question) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(question);
                client.Execute(request);
                return true;
            } catch (Exception e) {
                return false;
            }

        }

        public List<QuestionModel> GetAll() {
            try {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<QuestionModel>> response = client.Execute<List<QuestionModel>>(request);
                List<QuestionModel> questions = new List<QuestionModel>(response.Data);
                return questions;
            } catch (Exception e) {
                return null;
            }
        }

        public QuestionModel GetById(string id) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<QuestionModel> response = client.Execute<QuestionModel>(request);
                QuestionModel question = response.Data;
                return question;
            } catch (Exception e) {
                return null;
            }
        }

        public bool Put(string id, QuestionModel question) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url+ id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(question);
                client.Execute(request);
                return true;
            } catch (Exception e) {
                return false;
            }
        }
        public bool Delete(string id) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.DELETE);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                client.Execute(request);
                return true;
            } catch (Exception e) {
                return false;
            }

        }
    }
}
