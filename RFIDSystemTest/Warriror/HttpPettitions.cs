using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Warriror
{
    /// <summary>
    /// Http Pettitions
    /// </summary>
    public static class HttpPettitions
    {
        /// <summary>
        /// Create url
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static string CreateUrl( string action ) {
            StringBuilder sg = new StringBuilder();
            string url = "http://url:2342/api";
            sg.Append( url ).
                Append( "/" ).
                Append( action );
            return sg.ToString();
        }//End of Create Url function

        /// <summary>
        /// JSON HTTP Pettition generic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="method"></param>
        /// <param name="action"></param>
        /// <param name="req_data"></param>
        /// <returns></returns>
        public static T JSONHttpPettition<T, U>(  HttpMethod method, string action, U req_data ) {
            try
            {
                //Init request
                HttpWebRequest request = WebRequest.Create(HttpPettitions.CreateUrl(action)) as HttpWebRequest;
                //Get data serialized
                var data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(req_data));
                //Request configuration
                request.Method = method.ToString();
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                //Stream the data to the request
                using (var stream = request.GetRequestStream())
                {
                    stream.Write( data, 0, data.Length );
                }//End of stream use
                // Get response
                using ( HttpWebResponse response = request.GetResponse() as HttpWebResponse )
                {
                    //Verify if it is a right pettition
                    if ( response.StatusCode != HttpStatusCode.OK )
                    {
                        throw new Exception( String.Format( "Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription ) );
                    }
                    //Return of the serialized object
                    return JsonConvert.DeserializeObject< T >( new StreamReader(response.GetResponseStream() ).ReadToEnd() ) ;
                }//End of response use
            }
            catch (Exception e)
            {
                // Manage the exceptions
                Console.WriteLine(e.Message);
                return default(T);
            }
        }//End of HttpPettition function

    }//End of HttpPettitions
}
