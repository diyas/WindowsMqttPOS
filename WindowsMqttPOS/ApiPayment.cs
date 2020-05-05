﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WindowsMqttPOS
{
    class ApiPayment
    {
        public static async Task<PaymentResponse> CreatePayment(PaymentRequest req)
        {
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:8081/api/v1/payment/publish");
            var json = new JavaScriptSerializer().Serialize(req);
            PaymentResponse payment = null;
            request.Headers.Accept.Clear();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            //client.BaseAddress = new Uri("http://localhost:8081");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = await client.PostAsJsonAsync("/api/v1/payment/publish", req);
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
           {
              payment = await response.Content.ReadAsAsync<PaymentResponse>();
           }
           return payment;
        }

        public class PaymentRequest
        {
            public string posId { get; set; }
            public string trNo { get; set; }
            public string trMethod { get; set; }
            public long trAmount { get; set; }
        }

        public class PaymentResponse
        {
            public int code { get; set; }
            public string status { get; set; }
            public string message { get; set; }
            public object data { get; set; }
        }
    }
}