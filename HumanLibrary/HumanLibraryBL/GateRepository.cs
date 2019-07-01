using HumanLibraryBL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace HumanTracking_BL
{
    public class DeserializedOdataGateList
    {
        public List<Gate> value;
    }
    public class GateRepository
    {
        private const string URL = "http://127.0.0.1:8080/Gate";
        public List<Gate> Retrieve()
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
