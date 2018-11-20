# mantle.lib.Api.AuthenticationApi

All URIs are relative to *http://develop.api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticationForgotPasswordConfirmationPost**](AuthenticationApi.md#authenticationforgotpasswordconfirmationpost) | **POST** /authentication/forgot/password/confirmation | Confirm your password reset
[**AuthenticationForgotPasswordPost**](AuthenticationApi.md#authenticationforgotpasswordpost) | **POST** /authentication/forgot/password | Send an email to the user&#39;s email address with the reset password instructions.
[**AuthenticationLoginPost**](AuthenticationApi.md#authenticationloginpost) | **POST** /authentication/login | Login a user with a username and password
[**AuthenticationLogoutPost**](AuthenticationApi.md#authenticationlogoutpost) | **POST** /authentication/logout | Logout a user
[**AuthenticationSignupConfirmationPost**](AuthenticationApi.md#authenticationsignupconfirmationpost) | **POST** /authentication/signup/confirmation | Confirm your account
[**AuthenticationSignupPost**](AuthenticationApi.md#authenticationsignuppost) | **POST** /authentication/signup | Sign up a user with an invitation


<a name="authenticationforgotpasswordconfirmationpost"></a>
# **AuthenticationForgotPasswordConfirmationPost**
> void AuthenticationForgotPasswordConfirmationPost (UserForgotPasswordConfirmationRequest request = null)

Confirm your password reset

Confirm your password reset using the code that has been sent to the email address that was specified in the invitation. This step is required before you can use your new password.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class AuthenticationForgotPasswordConfirmationPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var request = new UserForgotPasswordConfirmationRequest(); // UserForgotPasswordConfirmationRequest |  (optional) 

            try
            {
                // Confirm your password reset
                apiInstance.AuthenticationForgotPasswordConfirmationPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationForgotPasswordConfirmationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserForgotPasswordConfirmationRequest**](UserForgotPasswordConfirmationRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationforgotpasswordpost"></a>
# **AuthenticationForgotPasswordPost**
> void AuthenticationForgotPasswordPost (UserForgotPasswordRequest request = null)

Send an email to the user's email address with the reset password instructions.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class AuthenticationForgotPasswordPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var request = new UserForgotPasswordRequest(); // UserForgotPasswordRequest |  (optional) 

            try
            {
                // Send an email to the user's email address with the reset password instructions.
                apiInstance.AuthenticationForgotPasswordPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationForgotPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserForgotPasswordRequest**](UserForgotPasswordRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationloginpost"></a>
# **AuthenticationLoginPost**
> UserLoginResponse AuthenticationLoginPost (UserLoginRequest request = null)

Login a user with a username and password

The returned access token can be used to perform requests on the platform.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class AuthenticationLoginPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var request = new UserLoginRequest(); // UserLoginRequest |  (optional) 

            try
            {
                // Login a user with a username and password
                UserLoginResponse result = apiInstance.AuthenticationLoginPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationLoginPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserLoginRequest**](UserLoginRequest.md)|  | [optional] 

### Return type

[**UserLoginResponse**](UserLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationlogoutpost"></a>
# **AuthenticationLogoutPost**
> void AuthenticationLogoutPost ()

Logout a user

You must be logged in to perform this action. This will also delete the current access-token and a new one will be generated on the next login.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class AuthenticationLogoutPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();

            try
            {
                // Logout a user
                apiInstance.AuthenticationLogoutPost();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationLogoutPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationsignupconfirmationpost"></a>
# **AuthenticationSignupConfirmationPost**
> void AuthenticationSignupConfirmationPost (UserSignUpConfirmationRequest request = null)

Confirm your account

Confirm your account using the code that has been sent to the email address that was specified in the invitation.  This step is required before you first log in.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class AuthenticationSignupConfirmationPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var request = new UserSignUpConfirmationRequest(); // UserSignUpConfirmationRequest |  (optional) 

            try
            {
                // Confirm your account
                apiInstance.AuthenticationSignupConfirmationPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationSignupConfirmationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserSignUpConfirmationRequest**](UserSignUpConfirmationRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenticationsignuppost"></a>
# **AuthenticationSignupPost**
> void AuthenticationSignupPost (SignUpUserRequest request = null)

Sign up a user with an invitation

You shouldn't be authenticated for this request as it's meant to create an account.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class AuthenticationSignupPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var request = new SignUpUserRequest(); // SignUpUserRequest |  (optional) 

            try
            {
                // Sign up a user with an invitation
                apiInstance.AuthenticationSignupPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationSignupPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SignUpUserRequest**](SignUpUserRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

