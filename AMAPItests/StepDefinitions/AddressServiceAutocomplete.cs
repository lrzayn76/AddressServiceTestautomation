using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAPItests.StepDefinitions
{
    public class AddressServiceAutocomplete
    {
        public static async Task<int> StatusCodeAutocompleteStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Autocomplete")
                .SetQueryParam("US")
                //.SetQueryParam("api-key", testdata.apiKey)
                .GetAsync();
                //.ReceiveJson<Data>();
                return 200;
            }
            catch (FlurlHttpException ex)
            {
                return (int)ex.StatusCode;
            }
        }

        public static async Task<int> StatusCodeAutocompleteDetailStatusCode()
        {
            try
            {
                //https://qa-api.ac1.conservice.com/common/address/secured/api/v1/Autocomplete/
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Autocomplete")
                .SetQueryParam("US")
                .AppendPathSegments("Detail")
                //.SetQueryParam("api-key", testdata.apiKey)
                .GetAsync();
                //.ReceiveJson<Data>();
                return 200;
            }
            catch (FlurlHttpException ex)
            {
                return (int)ex.StatusCode;
            }
        }
    }


}
