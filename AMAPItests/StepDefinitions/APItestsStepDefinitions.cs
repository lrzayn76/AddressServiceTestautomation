using System;
using TechTalk.SpecFlow;
using Flurl;
using Flurl.Http;

namespace AMAPItests.StepDefinitions
{
    [Binding]
    public sealed class APItestsStepDefinitions

    {
        AddressServiceAutocomplete asc = new();
        AddressServiceAddressAtributes asaa = new();

        [Given("Controller used to retrieve autocomplete suggestions")]
        public void ControllerUsedToRetrieveAutocompleteSuggestions()
        {
            //to do
            Console.WriteLine("Address service autocomplete test run");
        }

        [Then("Get addresses by country code status code")]
        public static void ThenGetAddressesByCountryCodeStatusCode()
        {
            //to do
            var scvar = AddressServiceAutocomplete.StatusCodeAutocompleteStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);
        }
        [Then("Get addresses by country code detail status code")]
        public void ThenGetAddressesByCountryCodeDetailStatusCode()
        {
            //to do
            var scvar = AddressServiceAutocomplete.StatusCodeAutocompleteDetailStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);
        }
        [Given("Controller used to retrieve all the Countries")]
        public void ControllerUsedToRetrieveAllTheCountries()
        {
            //to do
            Console.WriteLine("Address service attribute tests run");
        }

        [Then("Get address atributes by countries status code")]
        public void ThenGetAddressesAtributesByCountriesStatusCode()
        {
            //to do
            var scvar = AddressServiceAddressAtributes.ThenGetAddressAtributesByCountriesStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get address atributes by country code status code")]
        public void ThenGetAddressesAtributesByCountryCodeStatusCode()
        {
            //to do
            var scvar = AddressServiceAddressAtributes.ThenGetAddressAtributesByCountryCodesStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get address atributes by administrative areas status code")]
        public void ThenGetAddressesAtributesByAdministrativeAreasStatusCode()
        {
            //to do
            var scvar = AddressServiceAddressAtributes.ThenGetAddressAtributesByAdministrativeAreasStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get address atributes by subadministrative areas status code")]
        public void ThenGetAddressesAtributesBySubAdministrativeAreasStatusCode()
        {
            //to do
            var scvar = AddressServiceAddressAtributes.ThenGetAddressAtributesBySubAdministrativeAreasStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get address atributes by localities status code")]
        public void ThenGetAddressesAtributesByLocalitiesStatusCode()
        {
            //to do
            var scvar = AddressServiceAddressAtributes.ThenGetAddressAtributesByLocalitiesStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);
        }

        [Given("Controller used to retrieve addresses")]
        public void ControllerUsedToRetrieveAddresses()
        {
            //to do
            Console.WriteLine("Address service Adresses tests run");

        }

        [Then("Get addresses by validate single status code")]
        public void ThenGetAddressesByValidateSingleStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenGetAddressByValidateSingleStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get addresses by validate single free form status code")]
        public void ThenGetAddressesByValidateSingleFreeFormStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenGetAddressByValidateSingleFreeFormStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }
        [Then("Get addresses by validate multiple status code")]
        public void ThenGetAddressesByValidateMultipleStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenGetAddressByValidateMultipleStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get addresses by validate multiple free form status code")]
        public void ThenGetAddressesByValidateMultipleFreeFormStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenGetAddressByValidateMultipleFreeFormStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Post addresses status code")]
        public void ThenPostAddressesStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenPostAddressesStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }
        [Then("Put addresses status code")]
        public void ThenPutAddressesStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenPutAddressesStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }
        [Then("Post addresses multiple status code")]
        public void ThenPostAddressesMultipleStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenPostAddressesMultipleStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get addresses multiple status code")]
        public void ThenGetAddressesMultipleStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenGetAddressesMultipleStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Put addresses id status code")]
        public void ThenPutAddressesIdStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenPutAddressesIdStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }

        [Then("Get addresses id status code")]
        public void ThenGetAddressesIdStatusCode()
        {
            //to do
            var scvar = AddressServiceAddresses.ThenGetAddressesIdStatusCode();
            int sc = scvar.Result;

            Console.WriteLine("status code is: " + sc);

        }
    }
}