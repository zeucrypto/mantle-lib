# mantle.lib.Api.UsersApi

All URIs are relative to *http://dev.api.mantle.services*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersByUserIdGet**](UsersApi.md#usersbyuseridget) | **GET** /users/{userId} | Get a specific user&#39;s details and roles. Requires the User Admin Role.
[**UsersByUserIdPut**](UsersApi.md#usersbyuseridput) | **PUT** /users/{userId} | Edit a user&#39;s details. If their roles are changed, it will also delete their access token and they will need to login again next time. Requires the User Admin Role.
[**UsersDisableByUserIdPut**](UsersApi.md#usersdisablebyuseridput) | **PUT** /users/disable/{userId} | Disable a specific user. This will prevent this user from accessing the platform and will delete their API key if they had one. Requires the User Admin Role.
[**UsersEnableByUserIdPut**](UsersApi.md#usersenablebyuseridput) | **PUT** /users/enable/{userId} | Enable a specific user that has been disabled previously. This will let this user access the platform again. If the user needs an API key, it will need to be regenerated. Requires the User Admin Role.
[**UsersGet**](UsersApi.md#usersget) | **GET** /users | Get all of the users for the authenticated user&#39;s client. Requires the User Admin Role.
[**UsersSelfRolesGet**](UsersApi.md#usersselfrolesget) | **GET** /users/self/roles | Get all of the available assignable roles. Requires the User Admin Role.


<a name="usersbyuseridget"></a>
# **UsersByUserIdGet**
> ProductUser UsersByUserIdGet (string userId)

Get a specific user's details and roles. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UsersByUserIdGetExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 

            try
            {
                // Get a specific user's details and roles. Requires the User Admin Role.
                ProductUser result = apiInstance.UsersByUserIdGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersByUserIdGet: " + e.Message );
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

[**ProductUser**](ProductUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersbyuseridput"></a>
# **UsersByUserIdPut**
> void UsersByUserIdPut (string userId, EditUserRequest request = null)

Edit a user's details. If their roles are changed, it will also delete their access token and they will need to login again next time. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UsersByUserIdPutExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 
            var request = new EditUserRequest(); // EditUserRequest |  (optional) 

            try
            {
                // Edit a user's details. If their roles are changed, it will also delete their access token and they will need to login again next time. Requires the User Admin Role.
                apiInstance.UsersByUserIdPut(userId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersByUserIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **request** | [**EditUserRequest**](EditUserRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersdisablebyuseridput"></a>
# **UsersDisableByUserIdPut**
> void UsersDisableByUserIdPut (string userId)

Disable a specific user. This will prevent this user from accessing the platform and will delete their API key if they had one. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UsersDisableByUserIdPutExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 

            try
            {
                // Disable a specific user. This will prevent this user from accessing the platform and will delete their API key if they had one. Requires the User Admin Role.
                apiInstance.UsersDisableByUserIdPut(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDisableByUserIdPut: " + e.Message );
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

<a name="usersenablebyuseridput"></a>
# **UsersEnableByUserIdPut**
> void UsersEnableByUserIdPut (string userId)

Enable a specific user that has been disabled previously. This will let this user access the platform again. If the user needs an API key, it will need to be regenerated. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UsersEnableByUserIdPutExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 

            try
            {
                // Enable a specific user that has been disabled previously. This will let this user access the platform again. If the user needs an API key, it will need to be regenerated. Requires the User Admin Role.
                apiInstance.UsersEnableByUserIdPut(userId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersEnableByUserIdPut: " + e.Message );
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

<a name="usersget"></a>
# **UsersGet**
> List<ProductUser> UsersGet (bool? isEnabled = null)

Get all of the users for the authenticated user's client. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UsersGetExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var isEnabled = true;  // bool? |  (optional) 

            try
            {
                // Get all of the users for the authenticated user's client. Requires the User Admin Role.
                List&lt;ProductUser&gt; result = apiInstance.UsersGet(isEnabled);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **isEnabled** | **bool?**|  | [optional] 

### Return type

[**List<ProductUser>**](ProductUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersselfrolesget"></a>
# **UsersSelfRolesGet**
> List<string> UsersSelfRolesGet ()

Get all of the available assignable roles. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UsersSelfRolesGetExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                // Get all of the available assignable roles. Requires the User Admin Role.
                List&lt;string&gt; result = apiInstance.UsersSelfRolesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersSelfRolesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

