Feature: AddressService

@AddressServiceAPIAutocompete
Scenario: 01_Autocomplete
	Given Controller used to retrieve autocomplete suggestions
	Then Get addresses by country code status code
	Then Get addresses by country code detail status code

@AddressServiceAPIAddressAtributes
Scenario: 02_AddressAtributes
	Given Controller used to retrieve all the Countries
	Then Get address atributes by countries status code
	Then Get address atributes by country code status code
	Then Get address atributes by administrative areas status code
	Then Get address atributes by subadministrative areas status code
	Then Get address atributes by localities status code

@AddressServiceAPIAddresses
Scenario: 03_Addresses
	Given Controller used to retrieve addresses
	Then Get addresses by validate single status code
	Then Get addresses by validate single free form status code
	Then Get addresses by validate multiple status code
	Then Get addresses by validate multiple free form status code
	Then Post addresses status code
	Then Put addresses status code
	Then Post addresses multiple status code
	Then Get addresses multiple status code
	Then Put addresses id status code
	Then Get addresses id status code