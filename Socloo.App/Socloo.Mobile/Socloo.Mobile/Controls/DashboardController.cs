using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls
{
    class DashboardController
    {
        public string url { get; set; }
        public DashboardController()
        {
            url = new Constants().WebApi + "Dashboards/";
        }
        public bool Post(DashboardViewModel dashboard)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(dashboard);
                client.Execute(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<DashboardModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<DashboardModel>> response = client.Execute<List<DashboardModel>>(request);
                List<DashboardModel> dashboards = new List<DashboardModel>(response.Data);
                return dashboards;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public DashboardModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<DashboardModel> response = client.Execute<DashboardModel>(request);
                DashboardModel dashboard = response.Data;
                return dashboard;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Put(string id, DashboardModel dashboard)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(dashboard);
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
