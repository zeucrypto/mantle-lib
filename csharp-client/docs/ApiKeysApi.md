# mantle.lib.Mantle.lib.ApiKeysApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateApiKey**](ApiKeysApi.md#createapikey) | **POST** /apikeys | Create an API key for a specific user
[**DeleteApiKey**](ApiKeysApi.md#deleteapikey) | **DELETE** /apikeys/{userId} | Delete the API key for a specific user
[**GetAllApiKeys**](ApiKeysApi.md#getallapikeys) | **GET** /apikeys | Get all generated api keys


<a name="createapikey"></a>
# **CreateApiKey**
> void CreateApiKey (string xApiKey, CreateApiKeyRequest request = null)

Create an API key for a specific user

Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateApiKeyExample
    {
        public void main()
        {
            var apiInstance = new ApiKeysApi();
            var xApiKey = xApiKey_example;  // string | 
            var request = new CreateApiKeyRequest(); // CreateApiKeyRequest |  (optional) 

            try
            {
                // Create an API key for a specific user
                apiInstance.CreateApiKey(xApiKey, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.CreateApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiKey** | **string**|  | 
 **request** | [**CreateApiKeyRequest**](CreateApiKeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapikey"></a>
# **DeleteApiKey**
> void DeleteApiKey (string userId, string xApiKey)

Delete the API key for a specific user

Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteApiKeyExample
    {
        public void main()
        {
            var apiInstance = new ApiKeysApi();
            var userId = userId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Delete the API key for a specific user
                apiInstance.DeleteApiKey(userId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.DeleteApiKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallapikeys"></a>
# **GetAllApiKeys**
> List<AnonymousApiKeyResponse> GetAllApiKeys (string xApiKey)

Get all generated api keys

Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllApiKeysExample
    {
        public void main()
        {
            var apiInstance = new ApiKeysApi();
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get all generated api keys
                List&lt;AnonymousApiKeyResponse&gt; result = apiInstance.GetAllApiKeys(xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.GetAllApiKeys: " + e.Message );
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

[**List<AnonymousApiKeyResponse>**](AnonymousApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

