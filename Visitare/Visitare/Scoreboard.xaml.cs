using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Visitare
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scoreboard : ContentPage
    {
        Services.Services _service = new Services.Services();
        public Scoreboard()
        {
            InitializeComponent();

            GetAll();
        }




        private async void GetAll()
        {
           

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", " RHI069lPFC1wjDCXPzv5ywHtoJIhDsL6DH55ovfKzMKtGC3Z24bhJqh31AiN-38-9GedqSh78NVKklexIr2yPHHTSYaP2yffr8O4ZmLp-ZCRgH6IwLmYhgwWSSLr540oYPclhJhCyvhAkoEbqEiHf7EUmsqLCkBIxfchQrg9EpTlXoot7x0XfR5msaReothGCQrTKEpLA6YS12EKVXxdJMvgY0NwlN2G8EdCUPFh1pJVCIrx0R12uAl1KYG-o3RAvUVdKbph6TnSpaZ2UNhYJ7N0Lr0DLv-GydBwlLbTrygpPoF6GUHMex9UkHWTB4mHMELXwfB0YTx2Z9t87xOJPiKFpxplefuh2Z1CWRWucP8nG7J0JcL2O77RQ_Sd8sr-NNgWqBPKZXoRTiO8_-cZG4tmdyNQSqbtjakTdq9MGAmDjxxMLsWx6y_6tS4byRPQU67wkAorlQWszXXrTwTqQo01Ureofp__0y3ED7MwUjplrgCzCl_vQj0adcELjyUT");

            var response = await client.GetStringAsync("http://dearjean.ddns.net:44301/api/Rewards/GetAll");

            var tablicaW = JsonConvert.DeserializeObject<List<RewardsGetALL>>(response);

            scoreBoard.ItemsSource = tablicaW;


        } 
    }
}