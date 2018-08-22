# mantle.lib.Api.InvitationsApi

All URIs are relative to *http://dev.api.mantle.services*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvitationsByInvitationIdDelete**](InvitationsApi.md#invitationsbyinvitationiddelete) | **DELETE** /invitations/{invitationId} | Delete a specific invitation. The invited user won&#39;t be able to join the platform anymore. An invitation can be created with the same email again. Requires the User Admin Role.
[**InvitationsByInvitationIdGet**](InvitationsApi.md#invitationsbyinvitationidget) | **GET** /invitations/{invitationId} | Get an invitation&#39;s details
[**InvitationsGet**](InvitationsApi.md#invitationsget) | **GET** /invitations | Get all of the invitations that have been sent for the current client. Requires the User Admin Role.
[**InvitationsPost**](InvitationsApi.md#invitationspost) | **POST** /invitations | Create an invitation so that a user can join the platform. The entered email will be used to confirm the user&#39;s entity. An invitation email will also be sent. Requires the User Admin Role.


<a name="invitationsbyinvitationiddelete"></a>
# **InvitationsByInvitationIdDelete**
> void InvitationsByInvitationIdDelete (string invitationId)

Delete a specific invitation. The invited user won't be able to join the platform anymore. An invitation can be created with the same email again. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class InvitationsByInvitationIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var invitationId = invitationId_example;  // string | 

            try
            {
                // Delete a specific invitation. The invited user won't be able to join the platform anymore. An invitation can be created with the same email again. Requires the User Admin Role.
                apiInstance.InvitationsByInvitationIdDelete(invitationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.InvitationsByInvitationIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationsbyinvitationidget"></a>
# **InvitationsByInvitationIdGet**
> InvitationSignUpResponse InvitationsByInvitationIdGet (string invitationId)

Get an invitation's details

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class InvitationsByInvitationIdGetExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var invitationId = invitationId_example;  // string | 

            try
            {
                // Get an invitation's details
                InvitationSignUpResponse result = apiInstance.InvitationsByInvitationIdGet(invitationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.InvitationsByInvitationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **string**|  | 

### Return type

[**InvitationSignUpResponse**](InvitationSignUpResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationsget"></a>
# **InvitationsGet**
> List<Invitation> InvitationsGet ()

Get all of the invitations that have been sent for the current client. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class InvitationsGetExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();

            try
            {
                // Get all of the invitations that have been sent for the current client. Requires the User Admin Role.
                List&lt;Invitation&gt; result = apiInstance.InvitationsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.InvitationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Invitation>**](Invitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invitationspost"></a>
# **InvitationsPost**
> Invitation InvitationsPost (InvitationCreateRequest request = null)

Create an invitation so that a user can join the platform. The entered email will be used to confirm the user's entity. An invitation email will also be sent. Requires the User Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class InvitationsPostExample
    {
        public void main()
        {
            var apiInstance = new InvitationsApi();
            var request = new InvitationCreateRequest(); // InvitationCreateRequest |  (optional) 

            try
            {
                // Create an invitation so that a user can join the platform. The entered email will be used to confirm the user's entity. An invitation email will also be sent. Requires the User Admin Role.
                Invitation result = apiInstance.InvitationsPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationsApi.InvitationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**InvitationCreateRequest**](InvitationCreateRequest.md)|  | [optional] 

### Return type

[**Invitation**](Invitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

