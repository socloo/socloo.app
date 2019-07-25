using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class OccurrenceController
    {
        public string url { get; set; }
        public OccurrenceController()
        {
            url = new Constants().WebApi + "Occurrences/";
        }

        public bool Post(OccurrenceViewModel occurrence)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(occurrence);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public List<OccurrenceModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<OccurrenceModel>> response = client.Execute<List<OccurrenceModel>>(request);
                List<OccurrenceModel> occurrences = new List<OccurrenceModel>(response.Data);
                return occurrences;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public OccurrenceModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<OccurrenceModel> response = client.Execute<OccurrenceModel>(request);
                OccurrenceModel occurrence = response.Data;
                return occurrence;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool PutById(string id, OccurrenceModel occurrence)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(occurrence);
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
