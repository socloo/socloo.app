﻿using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Socloo.Mobile.Models;
using Socloo.Mobile.Utils;
using Socloo.Mobile.ViewModels;

namespace Socloo.Mobile.Controls {
    class StudentsController {
        public string url { get; set; }
        public StudentsController() {
            url = new Constants().WebApi + "Students/";
        }

        public bool Post(StudentViewModel Student) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(Student);
                client.Execute(request);
                return true;
            } catch (Exception e) {
                return false;
            }

        }

        public List<StudentModel> GetAll() {
            try {

                var client = new RestClient();
                var request = new RestRequest("https://socloodev.azurewebsites.net/api/" + "Students/", Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<StudentModel>> response = client.Execute<List<StudentModel>>(request);
                List<StudentModel> students = new List<StudentModel>(response.Data);
                return students;
            } catch (Exception e) {
                return null;
            }
        }

        public StudentModel GetById(string id) {
            try {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<StudentModel> response = client.Execute<StudentModel>(request);
                StudentModel Student = response.Data;
                return Student;
            } catch (Exception e) {
                return null;
            }
        }

        public bool Put(string id, StudentModel student) {
            try {
                var client = new RestClient();
                var request = new RestRequest("https://socloodev.azurewebsites.net/api/" + "Students/" + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(student);
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
