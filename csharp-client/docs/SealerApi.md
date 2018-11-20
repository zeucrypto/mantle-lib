# mantle.lib.Api.SealerApi

All URIs are relative to *http://develop.api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SealerByProductIdContractsByContractIdDelete**](SealerApi.md#sealerbyproductidcontractsbycontractiddelete) | **DELETE** /sealer/{productId}/contracts/{contractId} | [] Delete a contract
[**SealerByProductIdContractsCompareContractPost**](SealerApi.md#sealerbyproductidcontractscomparecontractpost) | **POST** /sealer/{productId}/contracts/compare/contract | [] Compare a local contract file
[**SealerByProductIdContractsCompareSignaturePost**](SealerApi.md#sealerbyproductidcontractscomparesignaturepost) | **POST** /sealer/{productId}/contracts/compare/signature | [] Compare a local signature file to all the signatures of the contract to see if one matches
[**SealerByProductIdContractsGet**](SealerApi.md#sealerbyproductidcontractsget) | **GET** /sealer/{productId}/contracts | [] Get all the contracts grouped by signer
[**SealerByProductIdContractsPost**](SealerApi.md#sealerbyproductidcontractspost) | **POST** /sealer/{productId}/contracts | [] Create a contract for specified emails
[**SealerByProductIdContractsSelfGet**](SealerApi.md#sealerbyproductidcontractsselfget) | **GET** /sealer/{productId}/contracts/self | [] Get all of the authenticated user’s contracts
[**SealerByProductIdContractsSignByContractIdPost**](SealerApi.md#sealerbyproductidcontractssignbycontractidpost) | **POST** /sealer/{productId}/contracts/sign/{contractId} | [] Sign a contract
[**SealerByProductIdContractsSignPost**](SealerApi.md#sealerbyproductidcontractssignpost) | **POST** /sealer/{productId}/contracts/sign | [] Sign a contract
[**SealerByProductIdSignaturesBySignatureIdDelete**](SealerApi.md#sealerbyproductidsignaturesbysignatureiddelete) | **DELETE** /sealer/{productId}/signatures/{signatureId} | [] Delete a signature
[**SealerByProductIdSignaturesComparePost**](SealerApi.md#sealerbyproductidsignaturescomparepost) | **POST** /sealer/{productId}/signatures/compare | [] Compare a local signature file to a signature
[**SealerByProductIdSignaturesGet**](SealerApi.md#sealerbyproductidsignaturesget) | **GET** /sealer/{productId}/signatures | [] Get all of the authenticated user’s signatures
[**SealerByProductIdSignaturesPost**](SealerApi.md#sealerbyproductidsignaturespost) | **POST** /sealer/{productId}/signatures | [] Create a signature for the authenticated user
[**SealerByProductIdTemplatesByTemplateIdContractsGet**](SealerApi.md#sealerbyproductidtemplatesbytemplateidcontractsget) | **GET** /sealer/{productId}/templates/{templateId}/contracts | [] Get contracts attached to a template
[**SealerByProductIdTemplatesByTemplateIdDelete**](SealerApi.md#sealerbyproductidtemplatesbytemplateiddelete) | **DELETE** /sealer/{productId}/templates/{templateId} | [] Delete a template
[**SealerByProductIdTemplatesByTemplateIdGet**](SealerApi.md#sealerbyproductidtemplatesbytemplateidget) | **GET** /sealer/{productId}/templates/{templateId} | [] Get a specific template
[**SealerByProductIdTemplatesComparePost**](SealerApi.md#sealerbyproductidtemplatescomparepost) | **POST** /sealer/{productId}/templates/compare | [] Compare a local template file to the template
[**SealerByProductIdTemplatesGet**](SealerApi.md#sealerbyproductidtemplatesget) | **GET** /sealer/{productId}/templates | [] Get all templates
[**SealerByProductIdTemplatesPost**](SealerApi.md#sealerbyproductidtemplatespost) | **POST** /sealer/{productId}/templates | [] Create a template


<a name="sealerbyproductidcontractsbycontractiddelete"></a>
# **SealerByProductIdContractsByContractIdDelete**
> void SealerByProductIdContractsByContractIdDelete (string contractId, string productId)

[] Delete a contract

Cannot if the contract was signed by at least one person.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsByContractIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var contractId = contractId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Delete a contract
                apiInstance.SealerByProductIdContractsByContractIdDelete(contractId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsByContractIdDelete: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidcontractscomparecontractpost"></a>
# **SealerByProductIdContractsCompareContractPost**
> SealerBreadcrumbingCompareResponse SealerByProductIdContractsCompareContractPost (System.IO.Stream file, string contractId, string productId, bool? mustGenerateFileDiff = null, string request = null)

[] Compare a local contract file

 Compare a local contract file to the unsigned contract document.                Requires the Sealer Admin Role for all contracts, but a Sealer User can compare their signed contract.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsCompareContractPostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var contractId = contractId_example;  // string | 
            var productId = productId_example;  // string | 
            var mustGenerateFileDiff = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Compare a local contract file
                SealerBreadcrumbingCompareResponse result = apiInstance.SealerByProductIdContractsCompareContractPost(file, contractId, productId, mustGenerateFileDiff, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsCompareContractPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **contractId** | **string**|  | 
 **productId** | **string**|  | 
 **mustGenerateFileDiff** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**SealerBreadcrumbingCompareResponse**](SealerBreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidcontractscomparesignaturepost"></a>
# **SealerByProductIdContractsCompareSignaturePost**
> ContractSignatureDiffResponse SealerByProductIdContractsCompareSignaturePost (System.IO.Stream file, string contractId, string productId, bool? mustGenerateFileDiff = null, string request = null)

[] Compare a local signature file to all the signatures of the contract to see if one matches

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsCompareSignaturePostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var contractId = contractId_example;  // string | 
            var productId = productId_example;  // string | 
            var mustGenerateFileDiff = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Compare a local signature file to all the signatures of the contract to see if one matches
                ContractSignatureDiffResponse result = apiInstance.SealerByProductIdContractsCompareSignaturePost(file, contractId, productId, mustGenerateFileDiff, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsCompareSignaturePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **contractId** | **string**|  | 
 **productId** | **string**|  | 
 **mustGenerateFileDiff** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**ContractSignatureDiffResponse**](ContractSignatureDiffResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidcontractsget"></a>
# **SealerByProductIdContractsGet**
> List<Contract> SealerByProductIdContractsGet (string productId, int? limit = null, int? offset = null)

[] Get all the contracts grouped by signer

A status defines if the contract is signed, partially signed, currently being signed or unsigned

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsGetExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [] Get all the contracts grouped by signer
                List&lt;Contract&gt; result = apiInstance.SealerByProductIdContractsGet(productId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
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

<a name="sealerbyproductidcontractspost"></a>
# **SealerByProductIdContractsPost**
> Contract SealerByProductIdContractsPost (System.IO.Stream file, string displayName, List<string> signerEmails, string signatures, string productId, string templateId = null, string request = null)

[] Create a contract for specified emails

The contract can also be signed at the same time if signature files are provided at the same time.  If provided, the signature files must match the SignerEmails provided in the same order.  If signatures are not provided, an email will be sent to the users to ask for their signatures when the contract is ready.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsPostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var displayName = displayName_example;  // string | 
            var signerEmails = new List<string>(); // List<string> | 
            var signatures = signatures_example;  // string | The files to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var templateId = templateId_example;  // string |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Create a contract for specified emails
                Contract result = apiInstance.SealerByProductIdContractsPost(file, displayName, signerEmails, signatures, productId, templateId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsPost: " + e.Message );
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
 **signatures** | **string**| The files to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **templateId** | **string**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidcontractsselfget"></a>
# **SealerByProductIdContractsSelfGet**
> List<Contract> SealerByProductIdContractsSelfGet (string productId, int? limit = null, int? offset = null)

[] Get all of the authenticated user’s contracts

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsSelfGetExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [] Get all of the authenticated user’s contracts
                List&lt;Contract&gt; result = apiInstance.SealerByProductIdContractsSelfGet(productId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsSelfGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
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

<a name="sealerbyproductidcontractssignbycontractidpost"></a>
# **SealerByProductIdContractsSignByContractIdPost**
> void SealerByProductIdContractsSignByContractIdPost (string contractId, System.IO.Stream signature, System.IO.Stream contract, string productId, bool? reuseLastSignature = null, string request = null)

[] Sign a contract

Requires to be authenticated to the platform.  The original contract and signature must be provided and a Signature Request Id is used to link the email and the contract Id

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsSignByContractIdPostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var contractId = contractId_example;  // string | 
            var signature = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var contract = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var reuseLastSignature = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Sign a contract
                apiInstance.SealerByProductIdContractsSignByContractIdPost(contractId, signature, contract, productId, reuseLastSignature, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsSignByContractIdPost: " + e.Message );
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
 **productId** | **string**|  | 
 **reuseLastSignature** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidcontractssignpost"></a>
# **SealerByProductIdContractsSignPost**
> void SealerByProductIdContractsSignPost (System.IO.Stream signature, System.IO.Stream contract, string productId, string request = null)

[] Sign a contract

Requires no role, as someone outside of the Mantle software could sign this contract.  The original contract and signature must be provided and a Signature Request Id is used to link the email and the contract Id.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdContractsSignPostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var signature = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var contract = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Sign a contract
                apiInstance.SealerByProductIdContractsSignPost(signature, contract, productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdContractsSignPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signature** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **contract** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **request** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidsignaturesbysignatureiddelete"></a>
# **SealerByProductIdSignaturesBySignatureIdDelete**
> void SealerByProductIdSignaturesBySignatureIdDelete (string signatureId, string productId)

[] Delete a signature

Cannot if used in one or more contracts.                Requires the Sealer User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdSignaturesBySignatureIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var signatureId = signatureId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Delete a signature
                apiInstance.SealerByProductIdSignaturesBySignatureIdDelete(signatureId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdSignaturesBySignatureIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **signatureId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidsignaturescomparepost"></a>
# **SealerByProductIdSignaturesComparePost**
> SealerBreadcrumbingCompareResponse SealerByProductIdSignaturesComparePost (string signatureId, System.IO.Stream file, string productId, bool? mustGenerateFileDiff = null, string request = null)

[] Compare a local signature file to a signature

Requires the Sealer User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdSignaturesComparePostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var signatureId = signatureId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var mustGenerateFileDiff = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Compare a local signature file to a signature
                SealerBreadcrumbingCompareResponse result = apiInstance.SealerByProductIdSignaturesComparePost(signatureId, file, productId, mustGenerateFileDiff, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdSignaturesComparePost: " + e.Message );
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
 **mustGenerateFileDiff** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**SealerBreadcrumbingCompareResponse**](SealerBreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidsignaturesget"></a>
# **SealerByProductIdSignaturesGet**
> List<Contract> SealerByProductIdSignaturesGet (string productId, int? limit = null, int? offset = null)

[] Get all of the authenticated user’s signatures

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdSignaturesGetExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [] Get all of the authenticated user’s signatures
                List&lt;Contract&gt; result = apiInstance.SealerByProductIdSignaturesGet(productId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdSignaturesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
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

<a name="sealerbyproductidsignaturespost"></a>
# **SealerByProductIdSignaturesPost**
> Signature SealerByProductIdSignaturesPost (System.IO.Stream file, string productId, string request = null)

[] Create a signature for the authenticated user

Requires the Sealer User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdSignaturesPostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Create a signature for the authenticated user
                Signature result = apiInstance.SealerByProductIdSignaturesPost(file, productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdSignaturesPost: " + e.Message );
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
 **request** | **string**|  | [optional] 

### Return type

[**Signature**](Signature.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidtemplatesbytemplateidcontractsget"></a>
# **SealerByProductIdTemplatesByTemplateIdContractsGet**
> List<Contract> SealerByProductIdTemplatesByTemplateIdContractsGet (string templateId, string productId, int? limit = null, int? offset = null)

[] Get contracts attached to a template

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdTemplatesByTemplateIdContractsGetExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var productId = productId_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [] Get contracts attached to a template
                List&lt;Contract&gt; result = apiInstance.SealerByProductIdTemplatesByTemplateIdContractsGet(templateId, productId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdTemplatesByTemplateIdContractsGet: " + e.Message );
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

<a name="sealerbyproductidtemplatesbytemplateiddelete"></a>
# **SealerByProductIdTemplatesByTemplateIdDelete**
> void SealerByProductIdTemplatesByTemplateIdDelete (string templateId, string productId)

[] Delete a template

Cannot if it has linked contracts.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdTemplatesByTemplateIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Delete a template
                apiInstance.SealerByProductIdTemplatesByTemplateIdDelete(templateId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdTemplatesByTemplateIdDelete: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidtemplatesbytemplateidget"></a>
# **SealerByProductIdTemplatesByTemplateIdGet**
> Template SealerByProductIdTemplatesByTemplateIdGet (string templateId, string productId)

[] Get a specific template

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdTemplatesByTemplateIdGetExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get a specific template
                Template result = apiInstance.SealerByProductIdTemplatesByTemplateIdGet(templateId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdTemplatesByTemplateIdGet: " + e.Message );
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

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidtemplatescomparepost"></a>
# **SealerByProductIdTemplatesComparePost**
> SealerBreadcrumbingCompareResponse SealerByProductIdTemplatesComparePost (string templateId, System.IO.Stream file, string productId, bool? mustGenerateFileDiff = null, string request = null)

[] Compare a local template file to the template

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdTemplatesComparePostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var templateId = templateId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var mustGenerateFileDiff = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Compare a local template file to the template
                SealerBreadcrumbingCompareResponse result = apiInstance.SealerByProductIdTemplatesComparePost(templateId, file, productId, mustGenerateFileDiff, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdTemplatesComparePost: " + e.Message );
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
 **mustGenerateFileDiff** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**SealerBreadcrumbingCompareResponse**](SealerBreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealerbyproductidtemplatesget"></a>
# **SealerByProductIdTemplatesGet**
> List<Template> SealerByProductIdTemplatesGet (string productId, int? limit = null, int? offset = null)

[] Get all templates

Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdTemplatesGetExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var productId = productId_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [] Get all templates
                List&lt;Template&gt; result = apiInstance.SealerByProductIdTemplatesGet(productId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdTemplatesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
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

<a name="sealerbyproductidtemplatespost"></a>
# **SealerByProductIdTemplatesPost**
> Template SealerByProductIdTemplatesPost (System.IO.Stream file, string displayName, string productId, string request = null)

[] Create a template

Used to regroup contracts.                Requires the Sealer Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class SealerByProductIdTemplatesPostExample
    {
        public void main()
        {
            var apiInstance = new SealerApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var displayName = displayName_example;  // string | 
            var productId = productId_example;  // string | 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Create a template
                Template result = apiInstance.SealerByProductIdTemplatesPost(file, displayName, productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SealerApi.SealerByProductIdTemplatesPost: " + e.Message );
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
 **request** | **string**|  | [optional] 

### Return type

[**Template**](Template.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

