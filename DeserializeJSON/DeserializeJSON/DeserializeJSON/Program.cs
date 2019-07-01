using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

using Newtonsoft.Json;

namespace DeserializeJSON
{
    public class Gate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class DeserializedOdataGateList
    {
        public List<Gate> value;
    }

    class Program
    {
        private const string URL = "http://localhost:54895/Gate";
        static void Main(string[] args)
        {
            var gates = Retrieve();

            foreach (var gate in gates)
            {
                Console.WriteLine("{0}, {1}, {2}", gate.Id, gate.Code, gate.Description);
            }

            Console.ReadLine();
        }

        private static List<Gate> Retrieve()
        {
            List<Gate> result = new List<Gate>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(URL).Result;               
                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsStringAsync().Result;
                    DeserializedOdataGateList deserializedOdataGateList = JsonConvert.DeserializeObject<DeserializedOdataGateList>(dataObjects);
                    result = deserializedOdataGateList.value.ToList();
                }                
            }
            return result;
        }
    }
}
