using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using TestingProject.DbServices;
using TestingProject.DTOs;

namespace TestingProject.Android
{
    [Activity(Label = "CarDetails", MainLauncher = true)]
    public class CarDetails : Activity
    {
        private CarDTO _car;
        private TextView _carId;
        private TextView _carName;
        private TextView _carPrice;

        private HttpClientHandler _httpClientHandler;
        private HttpClient _httpClient;
        private HttpResponseMessage _dataTask;

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CarDetailsView);

            // Create your application here
            _httpClientHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
            };

            _httpClient = new HttpClient(_httpClientHandler);
            var uri = new Uri(string.Format("https://10.0.2.2:5001/api/car/1"));

            
            //_httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicatioj/json"));
            _dataTask = await _httpClient.GetAsync(uri);
            if (_dataTask.IsSuccessStatusCode)
                _car = _dataTask.Content.ReadAsAsync<CarDTO>().Result;

            FindViews();
            BindData();
        }

        private void BindData()
        {
            _carId.Text = _car.Id.ToString();
            _carName.Text = _car.Name;
            _carPrice.Text = _car.Price.ToString();
        }

        private void FindViews()
        {
            _carId = FindViewById<TextView>(Resource.Id.tvId);
            _carName = FindViewById<TextView>(Resource.Id.tvName);
            _carPrice = FindViewById<TextView>(Resource.Id.tvPrice);
        }
    }
}