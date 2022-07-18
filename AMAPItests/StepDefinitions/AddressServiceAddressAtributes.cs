using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAPItests.StepDefinitions
{
    class AddressServiceAddressAtributes
    {
        public static async Task<int> ThenGetAddressAtributesByCountriesStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Autocomplete", "AddressAttributes", "Countries")
                //.SetQueryParam("US")
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

        public static async Task<int> ThenGetAddressAtributesByCountryCodesStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Autocomplete", "AddressAttributes", "CountryCodes")
                //.SetQueryParam("US")
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
        public static async Task<int> ThenGetAddressAtributesByAdministrativeAreasStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Autocomplete", "AddressAttributes")
                .SetQueryParam("AdministrativeAreas", "840")
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

        public static async Task<int> ThenGetAddressAtributesBySubAdministrativeAreasStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Autocomplete", "AddressAttributes")
                .SetQueryParam("SubAdministrativeAreas", "840")
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

        public static async Task<int> ThenGetAddressAtributesByLocalitiesStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Autocomplete", "AddressAttributes")
                .SetQueryParam("SubAdministrativeAreas", "840")
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
