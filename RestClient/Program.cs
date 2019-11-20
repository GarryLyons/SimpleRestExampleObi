using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Waiting to start request");
            Console.ReadKey();
            var client = new RestSharp.RestClient("https://localhost:44362");

            var request = new RestRequest("/api/Sccm", Method.POST, DataFormat.Json);
            request.AddJsonBody("{\"Data\": { \"Id\": 2,\"Name\": \"asdad\"}}");
            var response =client.Execute(request);

            Console.WriteLine(response);
        }
    }
}
