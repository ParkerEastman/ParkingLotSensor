using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net;
using System.Text;

namespace ClassProject.Models
{

        public class Distance
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class Duration
        {
            public string text { get; set; }
            public int value { get; set; }
        }

        public class Element
        {
            public Distance distance { get; set; }
            public Duration duration { get; set; }
            public string status { get; set; }
        }

        public class Row
        {
            public List<Element> elements { get; set; }
        }

        public class RootObject
        {
            public List<string> destination_addresses { get; set; }
            public List<string> origin_addresses { get; set; }
            public List<Row> rows { get; set; }
            public string status { get; set; }
        }
       

        

        public class ApiReturn
        {
            public RootObject loadApi(string apiRequest)
            {
                WebClient client = new WebClient();
                var serialize = new DataContractJsonSerializer(typeof(RootObject));
                var jsonResponse = client.DownloadString(apiRequest);
                byte[] JRBytes = Encoding.ASCII.GetBytes(jsonResponse);
                var JRStream = new MemoryStream(JRBytes);
                return serialize.ReadObject(JRStream) as RootObject;
            }
        }

        public class MCUReturn
        {
            public int ID { get; set; }
            public int Change { get; set; }
            //public DateTime Update { get; set; }
            
        }

}

