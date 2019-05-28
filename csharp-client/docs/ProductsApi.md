# mantle.lib.Mantle.lib.ProductsApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllProducts**](ProductsApi.md#getallproducts) | **GET** /products | Get the products for the authenticated user
[**GetProductById**](ProductsApi.md#getproductbyid) | **GET** /products/{productId} | Get a product and its settings
[**UpdateKeeperProduct**](ProductsApi.md#updatekeeperproduct) | **PUT** /products/keeper/{productId} | Update a keeper instance&#39;s name
[**UpdateSealerProduct**](ProductsApi.md#updatesealerproduct) | **PUT** /products/sealer/{productId} | Update a sealer instance&#39;s name
[**UpdateTrackerProduct**](ProductsApi.md#updatetrackerproduct) | **PUT** /products/tracker/{productId} | Update a tracker instance&#39;s name


<a name="getallproducts"></a>
# **GetAllProducts**
> List<ProductMenuOption> GetAllProducts (string xApiKey)

Get the products for the authenticated user

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllProductsExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get the products for the authenticated user
                List&lt;ProductMenuOption&gt; result = apiInstance.GetAllProducts(xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetAllProducts: " + e.Message );
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

[**List<ProductMenuOption>**](ProductMenuOption.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductbyid"></a>
# **GetProductById**
> ProductSubscription GetProductById (string productId, string xApiKey)

Get a product and its settings

Requires the Admin role

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetProductByIdExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // Get a product and its settings
                ProductSubscription result = apiInstance.GetProductById(productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductById: " + e.Message );
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

### Return type

[**ProductSubscription**](ProductSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatekeeperproduct"></a>
# **UpdateKeeperProduct**
> KeeperProductSubscription UpdateKeeperProduct (string productId, string xApiKey, UpdateKeeperProductRequest request = null)

Update a keeper instance's name

Requires the Admin role

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UpdateKeeperProductExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new UpdateKeeperProductRequest(); // UpdateKeeperProductRequest |  (optional) 

            try
            {
                // Update a keeper instance's name
                KeeperProductSubscription result = apiInstance.UpdateKeeperProduct(productId, xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateKeeperProduct: " + e.Message );
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
 **request** | [**UpdateKeeperProductRequest**](UpdateKeeperProductRequest.md)|  | [optional] 

### Return type

[**KeeperProductSubscription**](KeeperProductSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesealerproduct"></a>
# **UpdateSealerProduct**
> SealerProductSubscription UpdateSealerProduct (string productId, string xApiKey, UpdateSealerProductRequest request = null)

Update a sealer instance's name

When the Mode is set to API: Signatures must be provided on Contract Creation, Allow non-email Signers, Users cannot sign Contracts by themselves.  When the Mode is set to GUI: Signatures cannot be provided on Contract Creation, Only allow signer emails, An email will be sent to ask for a signature after the contract is confirmed in blockchain, Users must sign the contracts either logged in or using the link in the email that was sent.                Requires the Admin role

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UpdateSealerProductExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new UpdateSealerProductRequest(); // UpdateSealerProductRequest |  (optional) 

            try
            {
                // Update a sealer instance's name
                SealerProductSubscription result = apiInstance.UpdateSealerProduct(productId, xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateSealerProduct: " + e.Message );
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
 **request** | [**UpdateSealerProductRequest**](UpdateSealerProductRequest.md)|  | [optional] 

### Return type

[**SealerProductSubscription**](SealerProductSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetrackerproduct"></a>
# **UpdateTrackerProduct**
> TrackerProductSubscription UpdateTrackerProduct (string productId, string xApiKey, UpdateTrackerProductRequest request = null)

Update a tracker instance's name

Requires the Admin role

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class UpdateTrackerProductExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new UpdateTrackerProductRequest(); // UpdateTrackerProductRequest |  (optional) 

            try
            {
                // Update a tracker instance's name
                TrackerProductSubscription result = apiInstance.UpdateTrackerProduct(productId, xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateTrackerProduct: " + e.Message );
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
 **request** | [**UpdateTrackerProductRequest**](UpdateTrackerProductRequest.md)|  | [optional] 

### Return type

[**TrackerProductSubscription**](TrackerProductSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

