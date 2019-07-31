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
    class CalendarsService
    {
        public string url { get; set; }
        public CalendarsService()
        {
            url = new Constants().WebApi + "Calendars/";
        }
        public async Task<bool> Post(CalendarViewModel calendar)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(calendar);
                var restResponse = await client.ExecuteTaskAsync(request, CancellationToken.None);
                return restResponse.IsSuccessful;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public List<CalendarModel> GetAll()
        {
            try
            {

                var client = new RestClient();
                var request = new RestRequest(url, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<List<CalendarModel>> response = client.Execute<List<CalendarModel>>(request);
                List<CalendarModel> calendars = new List<CalendarModel>(response.Data);
                return calendars;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public CalendarModel GetById(string id)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                IRestResponse<CalendarModel> response = client.Execute<CalendarModel>(request);
                CalendarModel calendar = response.Data;
                return calendar;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Put(string id, CalendarModel calendar)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(url + id, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(calendar);
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
