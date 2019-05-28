# mantle.lib.Mantle.lib.SealerApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompareContract**](SealerApi.md#comparecontract) | **POST** /sealer/{productId}/contracts/{contractId}/compare/contract | [CONTRACTS] Compare a local contract file
[**CompareContractSignature**](SealerApi.md#comparecontractsignature) | **POST** /sealer/{productId}/contracts/{contractId}/compare/signature | [CONTRACTS] Compare a local signature
[**CompareSignature**](SealerApi.md#comparesignature) | **POST** /sealer/{productId}/signatures/compare/{signatureId} | [SIGNATURES] Compare a local signature file to a signature
[**CompareTemplate**](SealerApi.md#comparetemplate) | **POST** /sealer/{productId}/templates/compare/{templateId} | [TEMPLATES] Compare a local template file to the template
[**CreateContract**](SealerApi.md#createcontract) | **POST** /sealer/{productId}/contracts | [CONTRACTS] Create a contract for specified emails
[**CreateSignature**](SealerApi.md#createsignature) | **POST** /sealer/{productId}/signatures | [SIGNATURES] Create a signature for the authenticated user
[**CreateTemplate**](SealerApi.md#createtemplate) | **POST** /sealer/{productId}/templates | [TEMPLATES] Create a template
[**DeleteContract**](SealerApi.md#deletecontract) | **DELETE** /sealer/{productId}/contracts/{contractId} | [CONTRACTS] Delete a contract
[**DeleteTemplate**](SealerApi.md#deletetemplate) | **DELETE** /sealer/{productId}/templates/{templateId} | [TEMPLATES] Delete a template
[**GetAllContracts**](SealerApi.md#getallcontracts) | **GET** /sealer/{productId}/contracts | [CONTRACTS] Get all the contracts grouped by signer
[**GetAllSignatures**](SealerApi.md#getallsignatures) | **GET** /sealer/{productId}/signatures | [SIGNATURES] Get all signatures of the authenticated user’s
[**GetAllTemplates**](SealerApi.md#getalltemplates) | **GET** /sealer/{productId}/templates | [TEMPLATES] Get all templates
[**GetAuthenticatedUserContracts**](SealerApi.md#getauthenticatedusercontracts) | **GET** /sealer/{productId}/contracts/self | [CONTRACTS] Get all of the authenticated user’s contracts
[**GetContractsByTemplateId**](SealerApi.md#getcontractsbytemplateid) | **GET** /sealer/{productId}/templates/{templateId}/contracts | [TEMPLATES] Get contracts attached to a template
[**GetTemplateById**](SealerApi.md#gettemplatebyid) | **GET** /sealer/{productId}/templates/{templateId} | [TEMPLATES] Get a template
[**SignContractWhenAuthenticated**](SealerApi.md#signcontractwhenauthenticated) | **POST** /sealer/{productId}/contracts/{contractId}/sign | [CONTRACTS] Sign a contract


<a name="comparecontract"></a>
# **CompareContract**
> SealerBreadcrumbingCompareResponse CompareContract (string contractId, System.IO.Stream file, string productId, string xApiKey, bool? mustGenerateCompareResult = null)

[CONTRACTS] Compare a local contract file

Compare a local contract file to the unsigned contract document.                Requires the Sealer Admin Role for all contracts, but a Sealer User can compare their signed contract.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CompareContractExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var contractId = contractId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var mustGenerateCompareResult = true;  // bool? |  (optional) 

            try
            {
                // [CONTRACTS] Compare a local contract file
                SealerBreadcrumbingCompareResponse result = apiInstance.CompareContract(contractId, file, productId, xApiKey, mustGenerateCompareResult);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.CompareContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **mustGenerateCompareResult** | **bool?**|  | [optional] 

### Return type

[**SealerBreadcrumbingCompareResponse**](SealerBreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comparecontractsignature"></a>
# **CompareContractSignature**
> ContractSignatureDiffResponse CompareContractSignature (string contractId, System.IO.Stream file, string productId, string xApiKey, bool? mustGenerateCompareResult = null)

[CONTRACTS] Compare a local signature

Compare a local signature file to all the signatures of the contract to see if one matches                Requires the Sealer Admin Role or the Sealer User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CompareContractSignatureExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var contractId = contractId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var mustGenerateCompareResult = true;  // bool? |  (optional) 

            try
            {
                // [CONTRACTS] Compare a local signature
                ContractSignatureDiffResponse result = apiInstance.CompareContractSignature(contractId, file, productId, xApiKey, mustGenerateCompareResult);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.CompareContractSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **mustGenerateCompareResult** | **bool?**|  | [optional] 

### Return type

[**ContractSignatureDiffResponse**](ContractSignatureDiffResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comparesignature"></a>
# **CompareSignature**
> SealerBreadcrumbingCompareResponse CompareSignature (string signatureId, System.IO.Stream file, string productId, string xApiKey, bool? mustGenerateCompareResult = null)

[SIGNATURES] Compare a local signature file to a signature

Requires the Sealer Admin Role or the Sealer User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CompareSignatureExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var signatureId = signatureId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var mustGenerateCompareResult = true;  // bool? |  (optional) 

            try
            {
                // [SIGNATURES] Compare a local signature file to a signature
                SealerBreadcrumbingCompareResponse result = apiInstance.CompareSignature(signatureId, file, productId, xApiKey, mustGenerateCompareResult);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.CompareSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signatureId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **mustGenerateCompareResult** | **bool?**|  | [optional] 

### Return type

[**SealerBreadcrumbingCompareResponse**](SealerBreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comparetemplate"></a>
# **CompareTemplate**
> SealerBreadcrumbingCompareResponse CompareTemplate (string templateId, System.IO.Stream file, string productId, string xApiKey, bool? mustGenerateCompareResult = null)

[TEMPLATES] Compare a local template file to the template

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CompareTemplateExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var mustGenerateCompareResult = true;  // bool? |  (optional) 

            try
            {
                // [TEMPLATES] Compare a local template file to the template
                SealerBreadcrumbingCompareResponse result = apiInstance.CompareTemplate(templateId, file, productId, xApiKey, mustGenerateCompareResult);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.CompareTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **mustGenerateCompareResult** | **bool?**|  | [optional] 

### Return type

[**SealerBreadcrumbingCompareResponse**](SealerBreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcontract"></a>
# **CreateContract**
> Contract CreateContract (System.IO.Stream file, string displayName, List<string> signerEmails, List<string> signatures, string productId, string xApiKey, string signatureRequestMessage = null, string templateId = null)

[CONTRACTS] Create a contract for specified emails

The contract can also be signed at the same time if signature files are provided at the same time.  If provided, the signature files must match the SignerEmails provided in the same order.  If signatures are not provided, an email will be sent to the users to ask for their signatures when the contract is ready.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateContractExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var displayName = displayName_example;  // string | 
            var signerEmails = new List<string>(); // List<string> | 
            var signatures = new List<string>(); // List<string> | The files to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var signatureRequestMessage = signatureRequestMessage_example;  // string |  (optional) 
            var templateId = templateId_example;  // string |  (optional) 

            try
            {
                // [CONTRACTS] Create a contract for specified emails
                Contract result = apiInstance.CreateContract(file, displayName, signerEmails, signatures, productId, xApiKey, signatureRequestMessage, templateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.CreateContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **displayName** | **string**|  | 
 **signerEmails** | [**List&lt;string&gt;**](string.md)|  | 
 **signatures** | [**List&lt;string&gt;**](string.md)| The files to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **signatureRequestMessage** | **string**|  | [optional] 
 **templateId** | **string**|  | [optional] 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsignature"></a>
# **CreateSignature**
> Signature CreateSignature (System.IO.Stream file, string productId, string xApiKey)

[SIGNATURES] Create a signature for the authenticated user

Requires the Sealer Admin Role or the Sealer User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateSignatureExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [SIGNATURES] Create a signature for the authenticated user
                Signature result = apiInstance.CreateSignature(file, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.CreateSignature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

[**Signature**](Signature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtemplate"></a>
# **CreateTemplate**
> Template CreateTemplate (System.IO.Stream file, string displayName, string productId, string xApiKey)

[TEMPLATES] Create a template

Used to regroup contracts.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateTemplateExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var displayName = displayName_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [TEMPLATES] Create a template
                Template result = apiInstance.CreateTemplate(file, displayName, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.CreateTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **displayName** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontract"></a>
# **DeleteContract**
> void DeleteContract (string contractId, string productId, string xApiKey)

[CONTRACTS] Delete a contract

Cannot be deleted if the contract was signed by at least one person.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteContractExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var contractId = contractId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [CONTRACTS] Delete a contract
                apiInstance.DeleteContract(contractId, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.DeleteContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplate"></a>
# **DeleteTemplate**
> void DeleteTemplate (string templateId, string productId, string xApiKey)

[TEMPLATES] Delete a template

Cannot be deleted if it has linked contracts.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteTemplateExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [TEMPLATES] Delete a template
                apiInstance.DeleteTemplate(templateId, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.DeleteTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcontracts"></a>
# **GetAllContracts**
> List<Contract> GetAllContracts (string productId, string xApiKey, int? limit = null, int? offset = null)

[CONTRACTS] Get all the contracts grouped by signer

A status defines if the contract is signed, partially signed, currently being signed or unsigned                Require the Sealer Admin Role

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllContractsExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [CONTRACTS] Get all the contracts grouped by signer
                List&lt;Contract&gt; result = apiInstance.GetAllContracts(productId, xApiKey, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.GetAllContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallsignatures"></a>
# **GetAllSignatures**
> List<Contract> GetAllSignatures (string productId, string xApiKey, int? limit = null, int? offset = null)

[SIGNATURES] Get all signatures of the authenticated user’s

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllSignaturesExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [SIGNATURES] Get all signatures of the authenticated user’s
                List&lt;Contract&gt; result = apiInstance.GetAllSignatures(productId, xApiKey, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.GetAllSignatures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltemplates"></a>
# **GetAllTemplates**
> List<Template> GetAllTemplates (string productId, string xApiKey, int? limit = null, int? offset = null)

[TEMPLATES] Get all templates

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllTemplatesExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [TEMPLATES] Get all templates
                List&lt;Template&gt; result = apiInstance.GetAllTemplates(productId, xApiKey, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.GetAllTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**List<Template>**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getauthenticatedusercontracts"></a>
# **GetAuthenticatedUserContracts**
> List<Contract> GetAuthenticatedUserContracts (string productId, string xApiKey, int? limit = null, int? offset = null)

[CONTRACTS] Get all of the authenticated user’s contracts

Require the Sealer Admin Role or Sealer User Role

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAuthenticatedUserContractsExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [CONTRACTS] Get all of the authenticated user’s contracts
                List&lt;Contract&gt; result = apiInstance.GetAuthenticatedUserContracts(productId, xApiKey, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.GetAuthenticatedUserContracts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontractsbytemplateid"></a>
# **GetContractsByTemplateId**
> List<Contract> GetContractsByTemplateId (string templateId, string productId, string xApiKey, int? limit = null, int? offset = null)

[TEMPLATES] Get contracts attached to a template

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetContractsByTemplateIdExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [TEMPLATES] Get contracts attached to a template
                List&lt;Contract&gt; result = apiInstance.GetContractsByTemplateId(templateId, productId, xApiKey, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.GetContractsByTemplateId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**List<Contract>**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettemplatebyid"></a>
# **GetTemplateById**
> Template GetTemplateById (string templateId, string productId, string xApiKey)

[TEMPLATES] Get a template

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetTemplateByIdExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [TEMPLATES] Get a template
                Template result = apiInstance.GetTemplateById(templateId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.GetTemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateId** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signcontractwhenauthenticated"></a>
# **SignContractWhenAuthenticated**
> void SignContractWhenAuthenticated (string contractId, System.IO.Stream signature, System.IO.Stream contract, bool? reuseLastSignature, string productId, string xApiKey)

[CONTRACTS] Sign a contract

Requires to be authenticated to the platform.  The original contract and signature must be provided and a Signature Request Id is used to link the email and the contract Id

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SignContractWhenAuthenticatedExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var contractId = contractId_example;  // string | 
            var signature = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var contract = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var reuseLastSignature = true;  // bool? | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [CONTRACTS] Sign a contract
                apiInstance.SignContractWhenAuthenticated(contractId, signature, contract, reuseLastSignature, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SignContractWhenAuthenticated: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **string**|  | 
 **signature** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **contract** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **reuseLastSignature** | **bool?**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

