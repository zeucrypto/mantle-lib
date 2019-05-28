# mantle.lib.Mantle.lib.BillingApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllBills**](BillingApi.md#getallbills) | **GET** /bills | Get all bills


<a name="getallbills"></a>
# **GetAllBills**
> List<Bill> GetAllBills (string xApiKey)

Get all bills

Get all bills that have been generated for the client linked to the authenticated user.                Requires the Billing Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllBillsExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get all bills
                List&lt;Bill&gt; result = apiInstance.GetAllBills(xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.GetAllBills: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiKey** | **string**|  | 

### Return type

[**List<Bill>**](Bill.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

