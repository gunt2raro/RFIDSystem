using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Warriror
{
    /// <summary>
    /// Interface Http Service
    /// </summary>
    public interface IHttpService
    {
        string CreateUrl(string model);
        string GetAuthenticationString();
        List<T> JSONHttpPettitionList<T>(HttpMethod method, string model, string req_data);
        T JSONHttpPettitionObject<T>(HttpMethod method, string model, string req_data);
        string Base64Encode(string plainText);
        string Base64Decode(string base64EncodedData);

    }// End of Http Service interface
}
