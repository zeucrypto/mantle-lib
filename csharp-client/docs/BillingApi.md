# mantle.lib.Api.BillingApi

All URIs are relative to *http://develop.api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillsGet**](BillingApi.md#billsget) | **GET** /bills | Get all bills


<a name="billsget"></a>
# **BillsGet**
> List<Bill> BillsGet ()

Get all bills

Get all bills that have been generated for the client linked to the authenticated user. Requires the Billing Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class BillsGetExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();

            try
            {
                // Get all bills
                List&lt;Bill&gt; result = apiInstance.BillsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Bill>**](Bill.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

