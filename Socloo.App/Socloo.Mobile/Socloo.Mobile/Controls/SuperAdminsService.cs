using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls {
    class SuperAdminsService {
        public string url { get; set; }
        public SuperAdminsService() {
            url = new Constants().WebApi + "SuperAdmins/";
        }

        public async Task<bool> Post(SuperAdminViewModel superAdmin) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(superAdmin);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            } catch (Exception e) {
                return false;
            }

        }

        public List<SuperAdminModel> GetAll() {
            try {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<SuperAdminModel>> response = client.Execute<List<SuperAdminModel>>(request);
                List<SuperAdminModel> superAdmins = new List<SuperAdminModel>(response.Data);
                return superAdmins;
            } catch (Exception e) {
                return null;
            }
        }

        public SuperAdminModel GetById(string id) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<SuperAdminModel> response = client.Execute<SuperAdminModel>(request);
                SuperAdminModel superAdmin = response.Data;
                return superAdmin;
            } catch (Exception e) {
                return null;
            }
        }

        public bool Put(string id, SuperAdminModel superAdmin) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(superAdmin);
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
