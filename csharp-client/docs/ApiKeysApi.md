# mantle.lib.Api.ApiKeysApi

All URIs are relative to *http://dev.api.mantle.services*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiKeysAllGet**](ApiKeysApi.md#apikeysallget) | **GET** /apikeys/all | Get all of the users that have a generated API key and their details. Requires the User Admin Role.
[**ApiKeysByUserIdDelete**](ApiKeysApi.md#apikeysbyuseriddelete) | **DELETE** /apikeys/{userId} | Delete the API key for a specific user. Requires the User Admin Role.
[**ApiKeysGet**](ApiKeysApi.md#apikeysget) | **GET** /apikeys | Get the API key for the currently authenticated user. Will return null if no API key has been generated for your account.
[**ApiKeysPost**](ApiKeysApi.md#apikeyspost) | **POST** /apikeys | Create an API key for a specific user. Requires the User Admin Role.


<a name="apikeysallget"></a>
# **ApiKeysAllGet**
> List<AnonymousApiKeyResponse> ApiKeysAllGet ()

Get all of the users that have a generated API key and their details. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ApiKeysAllGetExample
    {
        public void main()
        {
            var apiInstance = new ApiKeysApi();

            try
            {
                // Get all of the users that have a generated API key and their details. Requires the User Admin Role.
                List&lt;AnonymousApiKeyResponse&gt; result = apiInstance.ApiKeysAllGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApiKeysAllGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AnonymousApiKeyResponse>**](AnonymousApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apikeysbyuseriddelete"></a>
# **ApiKeysByUserIdDelete**
> void ApiKeysByUserIdDelete (string userId)

Delete the API key for a specific user. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ApiKeysByUserIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new ApiKeysApi();
            var userId = userId_example;  // string | 

            try
            {
                // Delete the API key for a specific user. Requires the User Admin Role.
                apiInstance.ApiKeysByUserIdDelete(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApiKeysByUserIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apikeysget"></a>
# **ApiKeysGet**
> string ApiKeysGet ()

Get the API key for the currently authenticated user. Will return null if no API key has been generated for your account.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ApiKeysGetExample
    {
        public void main()
        {
            var apiInstance = new ApiKeysApi();

            try
            {
                // Get the API key for the currently authenticated user. Will return null if no API key has been generated for your account.
                string result = apiInstance.ApiKeysGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApiKeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apikeyspost"></a>
# **ApiKeysPost**
> void ApiKeysPost (CreateApiKeyRequest request = null)

Create an API key for a specific user. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ApiKeysPostExample
    {
        public void main()
        {
            var apiInstance = new ApiKeysApi();
            var request = new CreateApiKeyRequest(); // CreateApiKeyRequest |  (optional) 

            try
            {
                // Create an API key for a specific user. Requires the User Admin Role.
                apiInstance.ApiKeysPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApiKeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateApiKeyRequest**](CreateApiKeyRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

