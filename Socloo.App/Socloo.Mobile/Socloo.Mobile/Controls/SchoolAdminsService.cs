﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls {
    class SchoolAdminsService {
        
        public string url { get; set; }
        public SchoolAdminsService() {
            url = new Constants().WebApi + "SchoolAdmins/";
        }

        public async Task<bool> Post(SchoolAdminViewModel schoolAdmin) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(schoolAdmin);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            } catch (Exception e) {
                return false;
            }

        }

        public List<SchoolAdminModel> GetAll() {
            try {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<SchoolAdminModel>> response = client.Execute<List<SchoolAdminModel>>(request);
                List<SchoolAdminModel> schoolAdmins = new List<SchoolAdminModel>(response.Data);
                return schoolAdmins;
            } catch (Exception e) {
                return null;
            }
        }

        public SchoolAdminModel GetById(string id) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<SchoolAdminModel> response = client.Execute<SchoolAdminModel>(request);
                SchoolAdminModel schoolAdmin = response.Data;
                return schoolAdmin;
            } catch (Exception e) {
                return null;
            }
        }

        public bool Put(string id, SchoolAdminModel SchoolAdmin) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(SchoolAdmin);
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

