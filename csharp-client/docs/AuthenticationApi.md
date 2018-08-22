# mantle.lib.Api.AuthenticationApi

All URIs are relative to *http://dev.api.mantle.services*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthenticationForgotpasswordConfirmationPost**](AuthenticationApi.md#authenticationforgotpasswordconfirmationpost) | **POST** /authentication/forgotpassword/confirmation | Confirm your password reset using the code that has been sent to the email address that was specified in the invitation. This step is required before you can use your new password.
[**AuthenticationForgotpasswordPost**](AuthenticationApi.md#authenticationforgotpasswordpost) | **POST** /authentication/forgotpassword | Send an email to the user&#39;s email address with the reset password instructions.
[**AuthenticationLoginPost**](AuthenticationApi.md#authenticationloginpost) | **POST** /authentication/login | Login a user with a username and password. The returned access token can be used to perform requests on the platform
[**AuthenticationLogoutPost**](AuthenticationApi.md#authenticationlogoutpost) | **POST** /authentication/logout | Logout a user. You must be logged in to perform this action. This will also delete the current access-token and a new one will be generated on the next login.
[**AuthenticationSignupConfirmationPost**](AuthenticationApi.md#authenticationsignupconfirmationpost) | **POST** /authentication/signup/confirmation | Confirm your account using the code that has been sent to the email address that was specified in the invitation. This step is required before you first log in.
[**AuthenticationSignupPost**](AuthenticationApi.md#authenticationsignuppost) | **POST** /authentication/signup | Sign up a user with an invitation. You shouldn&#39;t be authentified for this request as it&#39;s meant to create an account


<a name="authenticationforgotpasswordconfirmationpost"></a>
# **AuthenticationForgotpasswordConfirmationPost**
> void AuthenticationForgotpasswordConfirmationPost (UserForgotPasswordConfirmationRequest request = null)

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
    public class AuthenticationForgotpasswordConfirmationPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var request = new UserForgotPasswordConfirmationRequest(); // UserForgotPasswordConfirmationRequest |  (optional) 

            try
            {
                // Confirm your password reset using the code that has been sent to the email address that was specified in the invitation. This step is required before you can use your new password.
                apiInstance.AuthenticationForgotpasswordConfirmationPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationForgotpasswordConfirmationPost: " + e.Message );
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
# **AuthenticationForgotpasswordPost**
> void AuthenticationForgotpasswordPost (UserForgotPasswordRequest request = null)

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
    public class AuthenticationForgotpasswordPostExample
    {
        public void main()
        {
            var apiInstance = new AuthenticationApi();
            var request = new UserForgotPasswordRequest(); // UserForgotPasswordRequest |  (optional) 

            try
            {
                // Send an email to the user's email address with the reset password instructions.
                apiInstance.AuthenticationForgotpasswordPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthenticationForgotpasswordPost: " + e.Message );
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

Login a user with a username and password. The returned access token can be used to perform requests on the platform

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
                // Login a user with a username and password. The returned access token can be used to perform requests on the platform
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

Logout a user. You must be logged in to perform this action. This will also delete the current access-token and a new one will be generated on the next login.

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
                // Logout a user. You must be logged in to perform this action. This will also delete the current access-token and a new one will be generated on the next login.
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

Confirm your account using the code that has been sent to the email address that was specified in the invitation. This step is required before you first log in.

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
                // Confirm your account using the code that has been sent to the email address that was specified in the invitation. This step is required before you first log in.
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

Sign up a user with an invitation. You shouldn't be authentified for this request as it's meant to create an account

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
                // Sign up a user with an invitation. You shouldn't be authentified for this request as it's meant to create an account
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

