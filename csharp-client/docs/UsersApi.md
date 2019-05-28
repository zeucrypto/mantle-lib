# mantle.lib.Mantle.lib.UsersApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /users/{userId} | Delete a user
[**DisableUser**](UsersApi.md#disableuser) | **PUT** /users/{userId}/disable | Disable a user
[**EditUser**](UsersApi.md#edituser) | **PUT** /users/{userId} | Edit a user&#39;s details
[**EnableUser**](UsersApi.md#enableuser) | **PUT** /users/{userId}/enable | Enable a user
[**Get**](UsersApi.md#get) | **GET** /users/self | Get the authenticated user
[**GetAllUsers**](UsersApi.md#getallusers) | **GET** /users | Get all users
[**GetUserById**](UsersApi.md#getuserbyid) | **GET** /users/{userId} | Get a user


<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string userId, string xApiKey)

Delete a user

Delete a specific user. This will prevent this user from accessing the platform and will delete their API key if  they had one.                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Delete a user
                apiInstance.DeleteUser(userId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
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
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disableuser"></a>
# **DisableUser**
> void DisableUser (string userId, string xApiKey)

Disable a user

This will prevent this user from accessing the platform and will delete their API key if they had one.                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DisableUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Disable a user
                apiInstance.DisableUser(userId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DisableUser: " + e.Message );
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
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edituser"></a>
# **EditUser**
> void EditUser (string userId, string xApiKey, EditUserRequest request = null)

Edit a user's details

If their roles are changed, it will also delete their access token and they will need to login again next time.                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class EditUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new EditUserRequest(); // EditUserRequest |  (optional) 

            try
            {
                // Edit a user's details
                apiInstance.EditUser(userId, xApiKey, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.EditUser: " + e.Message );
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
 **request** | [**EditUserRequest**](EditUserRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enableuser"></a>
# **EnableUser**
> void EnableUser (string userId, string xApiKey)

Enable a user

This will let this user access the platform again. If the user needs an API key, it will need to be regenerated.                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class EnableUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Enable a user
                apiInstance.EnableUser(userId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.EnableUser: " + e.Message );
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
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> User Get (string xApiKey)

Get the authenticated user

Details on the authenticated user                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get the authenticated user
                User result = apiInstance.Get(xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Get: " + e.Message );
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

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallusers"></a>
# **GetAllUsers**
> List<User> GetAllUsers (string xApiKey, bool? isEnabled = null, int? limit = null, int? offset = null)

Get all users

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
    public class GetAllUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var xApiKey = xApiKey_example;  // string | 
            var isEnabled = true;  // bool? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // Get all users
                List&lt;User&gt; result = apiInstance.GetAllUsers(xApiKey, isEnabled, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetAllUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiKey** | **string**|  | 
 **isEnabled** | **bool?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbyid"></a>
# **GetUserById**
> User GetUserById (string userId, string xApiKey)

Get a user

Get a specific user's details.                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetUserByIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = userId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get a user
                User result = apiInstance.GetUserById(userId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserById: " + e.Message );
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

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

