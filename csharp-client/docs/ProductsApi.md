# mantle.lib.Api.ProductsApi

All URIs are relative to *http://develop.api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductsByClientIdActivateByProductIdPost**](ProductsApi.md#productsbyclientidactivatebyproductidpost) | **POST** /products/{clientId}/activate/{productId} | Activate a product in Mantle that was previously deactivated
[**ProductsByClientIdDeactivateByProductIdPost**](ProductsApi.md#productsbyclientiddeactivatebyproductidpost) | **POST** /products/{clientId}/deactivate/{productId} | Deactivate a product in Mantle. This will result in a
[**ProductsByClientIdGet**](ProductsApi.md#productsbyclientidget) | **GET** /products/{clientId} | Get all available products for the logged in user&#39;s client including the ones that are disabled
[**ProductsByClientIdPost**](ProductsApi.md#productsbyclientidpost) | **POST** /products/{clientId} | Create a new product in Mantle
[**ProductsByClientIdPut**](ProductsApi.md#productsbyclientidput) | **PUT** /products/{clientId} | Update a product in Mantle
[**ProductsMenuGet**](ProductsApi.md#productsmenuget) | **GET** /products/menu | Get the product menu for the authenticated user


<a name="productsbyclientidactivatebyproductidpost"></a>
# **ProductsByClientIdActivateByProductIdPost**
> void ProductsByClientIdActivateByProductIdPost (string clientId, string productId)

Activate a product in Mantle that was previously deactivated

Requires the Admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ProductsByClientIdActivateByProductIdPostExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var clientId = clientId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // Activate a product in Mantle that was previously deactivated
                apiInstance.ProductsByClientIdActivateByProductIdPost(clientId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsByClientIdActivateByProductIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsbyclientiddeactivatebyproductidpost"></a>
# **ProductsByClientIdDeactivateByProductIdPost**
> void ProductsByClientIdDeactivateByProductIdPost (string clientId, string productId)

Deactivate a product in Mantle. This will result in a

Requires the Admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ProductsByClientIdDeactivateByProductIdPostExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var clientId = clientId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // Deactivate a product in Mantle. This will result in a
                apiInstance.ProductsByClientIdDeactivateByProductIdPost(clientId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsByClientIdDeactivateByProductIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsbyclientidget"></a>
# **ProductsByClientIdGet**
> List<ProductSubscription> ProductsByClientIdGet (string clientId)

Get all available products for the logged in user's client including the ones that are disabled

Requires the Admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ProductsByClientIdGetExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var clientId = clientId_example;  // string | 

            try
            {
                // Get all available products for the logged in user's client including the ones that are disabled
                List&lt;ProductSubscription&gt; result = apiInstance.ProductsByClientIdGet(clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsByClientIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 

### Return type

[**List<ProductSubscription>**](ProductSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsbyclientidpost"></a>
# **ProductsByClientIdPost**
> ProductSubscription ProductsByClientIdPost (string clientId, CreateProductRequest request = null)

Create a new product in Mantle

Requires the Admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ProductsByClientIdPostExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var clientId = clientId_example;  // string | 
            var request = new CreateProductRequest(); // CreateProductRequest |  (optional) 

            try
            {
                // Create a new product in Mantle
                ProductSubscription result = apiInstance.ProductsByClientIdPost(clientId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsByClientIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **request** | [**CreateProductRequest**](CreateProductRequest.md)|  | [optional] 

### Return type

[**ProductSubscription**](ProductSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsbyclientidput"></a>
# **ProductsByClientIdPut**
> ProductSubscription ProductsByClientIdPut (string clientId, UpdateProductRequest request = null)

Update a product in Mantle

Requires the Admin role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ProductsByClientIdPutExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();
            var clientId = clientId_example;  // string | 
            var request = new UpdateProductRequest(); // UpdateProductRequest |  (optional) 

            try
            {
                // Update a product in Mantle
                ProductSubscription result = apiInstance.ProductsByClientIdPut(clientId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsByClientIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **request** | [**UpdateProductRequest**](UpdateProductRequest.md)|  | [optional] 

### Return type

[**ProductSubscription**](ProductSubscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="productsmenuget"></a>
# **ProductsMenuGet**
> List<ProductMenuOption> ProductsMenuGet ()

Get the product menu for the authenticated user

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ProductsMenuGetExample
    {
        public void main()
        {
            var apiInstance = new ProductsApi();

            try
            {
                // Get the product menu for the authenticated user
                List&lt;ProductMenuOption&gt; result = apiInstance.ProductsMenuGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.ProductsMenuGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ProductMenuOption>**](ProductMenuOption.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

