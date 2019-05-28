# mantle.lib.Mantle.lib.InvitationsApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateInvitation**](InvitationsApi.md#createinvitation) | **POST** /invitations | Create an invitation
[**DeleteInvitation**](InvitationsApi.md#deleteinvitation) | **DELETE** /invitations/{invitationId} | Delete a specific invitation
[**GetAllInvitations**](InvitationsApi.md#getallinvitations) | **GET** /invitations | Get all invitations
[**GetInvitationById**](InvitationsApi.md#getinvitationbyid) | **GET** /invitations/{invitationId} | Get an invitation&#39;s details


<a name="createinvitation"></a>
# **CreateInvitation**
> Invitation CreateInvitation (string xApiKey, InvitationCreateRequest request = null)

Create an invitation

Invite a user to join the platform. The entered email will be used to confirm the user's  entity. An invitation email will also be sent.                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateInvitationExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var xApiKey = xApiKey_example;  // string | 
            var request = new InvitationCreateRequest(); // InvitationCreateRequest |  (optional) 

            try
            {
                // Create an invitation
                Invitation result = apiInstance.CreateInvitation(xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.CreateInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiKey** | **string**|  | 
 **request** | [**InvitationCreateRequest**](InvitationCreateRequest.md)|  | [optional] 

### Return type

[**Invitation**](Invitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinvitation"></a>
# **DeleteInvitation**
> void DeleteInvitation (string invitationId, string xApiKey)

Delete a specific invitation

The invited user won't be able to join the platform anymore. An invitation can be created with the same email again.                Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteInvitationExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var invitationId = invitationId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Delete a specific invitation
                apiInstance.DeleteInvitation(invitationId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.DeleteInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallinvitations"></a>
# **GetAllInvitations**
> List<Invitation> GetAllInvitations (string xApiKey)

Get all invitations

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
    public class GetAllInvitationsExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get all invitations
                List&lt;Invitation&gt; result = apiInstance.GetAllInvitations(xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.GetAllInvitations: " + e.Message );
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

[**List<Invitation>**](Invitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitationbyid"></a>
# **GetInvitationById**
> InvitationSignUpResponse GetInvitationById (string invitationId, string xApiKey)

Get an invitation's details

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetInvitationByIdExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var invitationId = invitationId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get an invitation's details
                InvitationSignUpResponse result = apiInstance.GetInvitationById(invitationId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.GetInvitationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

[**InvitationSignUpResponse**](InvitationSignUpResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

