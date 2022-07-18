using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAPItests.StepDefinitions
{
    class AddressServiceAddresses
    {
        public static async Task<int> ThenGetAddressByValidateSingleStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses", "validateSingle")
                //.SetQueryParam("SubAdministrativeAreas", "840")
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

        public static async Task<int> ThenGetAddressByValidateSingleFreeFormStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses")
                .SetQueryParam("validateSingle", "123 Main Street, NY, 12345")
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

        public static async Task<int> ThenGetAddressByValidateMultipleStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses", "validateMultiple")
                //.SetQueryParam("SubAdministrativeAreas", "840")
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

        public static async Task<int> ThenGetAddressByValidateMultipleFreeFormStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses")
                .SetQueryParam("validateMultiple", "123 Main Street, NY, 12345")
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
        public static async Task<int> ThenPostAddressesStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses")
                //.SetQueryParam("validateMultiple", "123 Main Street, NY, 12345")
                //.SetQueryParam("api-key", testdata.apiKey)
                .PostAsync();
                //.ReceiveJson<Data>();
                return 200;
            }
            catch (FlurlHttpException ex)
            {
                return (int)ex.StatusCode;
            }
        }
        public static async Task<int> ThenPutAddressesStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses")
                //.SetQueryParam("validateMultiple", "123 Main Street, NY, 12345")
                //.SetQueryParam("api-key", testdata.apiKey)
                .PutAsync();
                //.ReceiveJson<Data>();
                return 200;
            }
            catch (FlurlHttpException ex)
            {
                return (int)ex.StatusCode;
            }
        }
        public static async Task<int> ThenPostAddressesMultipleStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses", "multiple")
                //.SetQueryParam("validateMultiple", "123 Main Street, NY, 12345")
                //.SetQueryParam("api-key", testdata.apiKey)
                .PostAsync();
                //.ReceiveJson<Data>();
                return 200;
            }
            catch (FlurlHttpException ex)
            {
                return (int)ex.StatusCode;
            }
        }
        public static async Task<int> ThenGetAddressesMultipleStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses", "multiple")
                //.SetQueryParam("validateMultiple", "123 Main Street, NY, 12345")
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
        public static async Task<int> ThenPutAddressesIdStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses")
                .SetQueryParam("id", "123 Main Street, NY, 12345")
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
        public static async Task<int> ThenGetAddressesIdStatusCode()
        {
            try
            {
                var flurlJson = await "https://dev-api.ac1.conservice.com"
                .AppendPathSegments("common", "address", "secured", "api", "v1", "Addresses")
                .SetQueryParam("id", "123 Main Street, NY, 12345")
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
