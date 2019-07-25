using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;
namespace Socloo.Mobile.Controls
{
    class PortfolioController
    {
        public string url { get; set; }
        public PortfolioController()
        {
            url = new Constants().WebApi + "Portfolios/";
        }

        public bool Post(PortfolioViewModel portfolio)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(portfolio);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public List<PortfolioModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<PortfolioModel>> response = client.Execute<List<PortfolioModel>>(request);
                List<PortfolioModel> portfolios = new List<PortfolioModel>(response.Data);
                return portfolios;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public PortfolioModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<PortfolioModel> response = client.Execute<PortfolioModel>(request);
                PortfolioModel portfolio = response.Data;
                return portfolio;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool PutById(string id, PortfolioModel portfolio)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(portfolio);
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
