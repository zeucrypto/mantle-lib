# mantle.lib.Api.TrackerApi

All URIs are relative to *http://develop.api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrackerByProductIdAssetsBatchesIssuedByAssetIdByBatchIdGet**](TrackerApi.md#trackerbyproductidassetsbatchesissuedbyassetidbybatchidget) | **GET** /tracker/{productId}/assets/batches/issued/{assetId}/{batchId} | [] Get all issued batches for an asset
[**TrackerByProductIdAssetsBatchesIssuedByAssetIdGet**](TrackerApi.md#trackerbyproductidassetsbatchesissuedbyassetidget) | **GET** /tracker/{productId}/assets/batches/issued/{assetId} | [] Get all issued batches for an asset
[**TrackerByProductIdAssetsBatchesIssuedMultiByAssetIdGet**](TrackerApi.md#trackerbyproductidassetsbatchesissuedmultibyassetidget) | **GET** /tracker/{productId}/assets/batches/issued/multi/{assetId} | [] Get all issued batches for a multi asset
[**TrackerByProductIdAssetsByAssetIdDelete**](TrackerApi.md#trackerbyproductidassetsbyassetiddelete) | **DELETE** /tracker/{productId}/assets/{assetId} | [] Delete an asset
[**TrackerByProductIdAssetsByAssetIdGet**](TrackerApi.md#trackerbyproductidassetsbyassetidget) | **GET** /tracker/{productId}/assets/{assetId} | [] Get a specific asset&#39;s details
[**TrackerByProductIdAssetsByAssetIdPut**](TrackerApi.md#trackerbyproductidassetsbyassetidput) | **PUT** /tracker/{productId}/assets/{assetId} | [] Edit an asset
[**TrackerByProductIdAssetsGet**](TrackerApi.md#trackerbyproductidassetsget) | **GET** /tracker/{productId}/assets | [] Get all assets
[**TrackerByProductIdAssetsIssuePost**](TrackerApi.md#trackerbyproductidassetsissuepost) | **POST** /tracker/{productId}/assets/issue | [] Issue a certain amount of asset to a recipient
[**TrackerByProductIdAssetsPost**](TrackerApi.md#trackerbyproductidassetspost) | **POST** /tracker/{productId}/assets | [] Create an asset
[**TrackerByProductIdMultiAssetsByAssetIdGet**](TrackerApi.md#trackerbyproductidmultiassetsbyassetidget) | **GET** /tracker/{productId}/multiassets/{assetId} | [] Get a specific multi asset&#39;s details
[**TrackerByProductIdMultiAssetsGet**](TrackerApi.md#trackerbyproductidmultiassetsget) | **GET** /tracker/{productId}/multiassets | [] Get all multi assets
[**TrackerByProductIdMultiAssetsPost**](TrackerApi.md#trackerbyproductidmultiassetspost) | **POST** /tracker/{productId}/multiassets | [] Creates a multi asset
[**TrackerByProductIdStatsGet**](TrackerApi.md#trackerbyproductidstatsget) | **GET** /tracker/{productId}/stats | [] Get 3 statistics regarding the usage of Tracker in the last 24 hours
[**TrackerByProductIdTransactionsGet**](TrackerApi.md#trackerbyproductidtransactionsget) | **GET** /tracker/{productId}/transactions | [] Get all transactions
[**TrackerByProductIdTransactionsReversePost**](TrackerApi.md#trackerbyproductidtransactionsreversepost) | **POST** /tracker/{productId}/transactions/reverse | [] Revert a transaction
[**TrackerByProductIdWalletBalancesDetailedGet**](TrackerApi.md#trackerbyproductidwalletbalancesdetailedget) | **GET** /tracker/{productId}/wallet/balances/detailed | [] Get all authenticated user&#39;s asset balances
[**TrackerByProductIdWalletBatchesTransferPost**](TrackerApi.md#trackerbyproductidwalletbatchestransferpost) | **POST** /tracker/{productId}/wallet/batches/transfer | [] Create a transfer between yourself and another user from one of your specific batches
[**TrackerByProductIdWalletTransactionsByAssetIdGet**](TrackerApi.md#trackerbyproductidwallettransactionsbyassetidget) | **GET** /tracker/{productId}/wallet/transactions/{assetId} | [] Get all transactions for a specific asset
[**TrackerByProductIdWalletTransferPost**](TrackerApi.md#trackerbyproductidwallettransferpost) | **POST** /tracker/{productId}/wallet/transfer | [] Create a transfer between yourself and another user


<a name="trackerbyproductidassetsbatchesissuedbyassetidbybatchidget"></a>
# **TrackerByProductIdAssetsBatchesIssuedByAssetIdByBatchIdGet**
> IssuedBatchTransactionsResponse TrackerByProductIdAssetsBatchesIssuedByAssetIdByBatchIdGet (string assetId, string batchId, string productId)

[] Get all issued batches for an asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsBatchesIssuedByAssetIdByBatchIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var batchId = batchId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get all issued batches for an asset
                IssuedBatchTransactionsResponse result = apiInstance.TrackerByProductIdAssetsBatchesIssuedByAssetIdByBatchIdGet(assetId, batchId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsBatchesIssuedByAssetIdByBatchIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **batchId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**IssuedBatchTransactionsResponse**](IssuedBatchTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetsbatchesissuedbyassetidget"></a>
# **TrackerByProductIdAssetsBatchesIssuedByAssetIdGet**
> IssuedBatchesResponse TrackerByProductIdAssetsBatchesIssuedByAssetIdGet (string assetId, string productId)

[] Get all issued batches for an asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsBatchesIssuedByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get all issued batches for an asset
                IssuedBatchesResponse result = apiInstance.TrackerByProductIdAssetsBatchesIssuedByAssetIdGet(assetId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsBatchesIssuedByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**IssuedBatchesResponse**](IssuedBatchesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetsbatchesissuedmultibyassetidget"></a>
# **TrackerByProductIdAssetsBatchesIssuedMultiByAssetIdGet**
> IssuedBatchesResponse TrackerByProductIdAssetsBatchesIssuedMultiByAssetIdGet (string assetId, string productId)

[] Get all issued batches for a multi asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsBatchesIssuedMultiByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get all issued batches for a multi asset
                IssuedBatchesResponse result = apiInstance.TrackerByProductIdAssetsBatchesIssuedMultiByAssetIdGet(assetId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsBatchesIssuedMultiByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**IssuedBatchesResponse**](IssuedBatchesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetsbyassetiddelete"></a>
# **TrackerByProductIdAssetsByAssetIdDelete**
> void TrackerByProductIdAssetsByAssetIdDelete (string assetId, string productId)

[] Delete an asset

It won't be issuable and transferable anymore, but all transactions made in the past with this asset will still be visible.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsByAssetIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Delete an asset
                apiInstance.TrackerByProductIdAssetsByAssetIdDelete(assetId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsByAssetIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetsbyassetidget"></a>
# **TrackerByProductIdAssetsByAssetIdGet**
> TrackerAsset TrackerByProductIdAssetsByAssetIdGet (string assetId, string productId)

[] Get a specific asset's details

Requires the Track Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get a specific asset's details
                TrackerAsset result = apiInstance.TrackerByProductIdAssetsByAssetIdGet(assetId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**TrackerAsset**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetsbyassetidput"></a>
# **TrackerByProductIdAssetsByAssetIdPut**
> void TrackerByProductIdAssetsByAssetIdPut (string assetId, string productId, TrackerAssetCreateRequest request = null)

[] Edit an asset

Only the name can be changed.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsByAssetIdPutExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var request = new TrackerAssetCreateRequest(); // TrackerAssetCreateRequest |  (optional) 

            try
            {
                // [] Edit an asset
                apiInstance.TrackerByProductIdAssetsByAssetIdPut(assetId, productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsByAssetIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **productId** | **string**|  | 
 **request** | [**TrackerAssetCreateRequest**](TrackerAssetCreateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetsget"></a>
# **TrackerByProductIdAssetsGet**
> List<TrackerAsset> TrackerByProductIdAssetsGet (string productId, DateTime? beforeDateTime = null, int? limit = null, int? offset = null, string request = null)

[] Get all assets

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var beforeDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Get all assets
                List&lt;TrackerAsset&gt; result = apiInstance.TrackerByProductIdAssetsGet(productId, beforeDateTime, limit, offset, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **beforeDateTime** | **DateTime?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**List<TrackerAsset>**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetsissuepost"></a>
# **TrackerByProductIdAssetsIssuePost**
> void TrackerByProductIdAssetsIssuePost (string productId, TrackerAssetIssueRequest request = null)

[] Issue a certain amount of asset to a recipient

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsIssuePostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var request = new TrackerAssetIssueRequest(); // TrackerAssetIssueRequest |  (optional) 

            try
            {
                // [] Issue a certain amount of asset to a recipient
                apiInstance.TrackerByProductIdAssetsIssuePost(productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsIssuePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **request** | [**TrackerAssetIssueRequest**](TrackerAssetIssueRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidassetspost"></a>
# **TrackerByProductIdAssetsPost**
> TrackerAsset TrackerByProductIdAssetsPost (string productId, TrackerAssetCreateRequest request = null)

[] Create an asset

This asset will then be issuable and transferable between entities.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdAssetsPostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var request = new TrackerAssetCreateRequest(); // TrackerAssetCreateRequest |  (optional) 

            try
            {
                // [] Create an asset
                TrackerAsset result = apiInstance.TrackerByProductIdAssetsPost(productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdAssetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **request** | [**TrackerAssetCreateRequest**](TrackerAssetCreateRequest.md)|  | [optional] 

### Return type

[**TrackerAsset**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidmultiassetsbyassetidget"></a>
# **TrackerByProductIdMultiAssetsByAssetIdGet**
> TrackerMultiAsset TrackerByProductIdMultiAssetsByAssetIdGet (string assetId, string productId)

[] Get a specific multi asset's details

Requires the Track Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdMultiAssetsByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get a specific multi asset's details
                TrackerMultiAsset result = apiInstance.TrackerByProductIdMultiAssetsByAssetIdGet(assetId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdMultiAssetsByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**TrackerMultiAsset**](TrackerMultiAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidmultiassetsget"></a>
# **TrackerByProductIdMultiAssetsGet**
> List<TrackerMultiAsset> TrackerByProductIdMultiAssetsGet (string productId, DateTime? beforeDateTime = null, int? limit = null, int? offset = null, string assetIds = null, string request = null)

[] Get all multi assets

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdMultiAssetsGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var beforeDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var assetIds = assetIds_example;  // string |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Get all multi assets
                List&lt;TrackerMultiAsset&gt; result = apiInstance.TrackerByProductIdMultiAssetsGet(productId, beforeDateTime, limit, offset, assetIds, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdMultiAssetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **beforeDateTime** | **DateTime?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **assetIds** | **string**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**List<TrackerMultiAsset>**](TrackerMultiAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidmultiassetspost"></a>
# **TrackerByProductIdMultiAssetsPost**
> TrackerMultiAsset TrackerByProductIdMultiAssetsPost (string productId, TrackerMultiAssetCreateRequest request = null)

[] Creates a multi asset

This asset will then be issuable and transferable between entities.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdMultiAssetsPostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var request = new TrackerMultiAssetCreateRequest(); // TrackerMultiAssetCreateRequest |  (optional) 

            try
            {
                // [] Creates a multi asset
                TrackerMultiAsset result = apiInstance.TrackerByProductIdMultiAssetsPost(productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdMultiAssetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **request** | [**TrackerMultiAssetCreateRequest**](TrackerMultiAssetCreateRequest.md)|  | [optional] 

### Return type

[**TrackerMultiAsset**](TrackerMultiAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidstatsget"></a>
# **TrackerByProductIdStatsGet**
> TrackerStatsResponse TrackerByProductIdStatsGet (string productId)

[] Get 3 statistics regarding the usage of Tracker in the last 24 hours

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdStatsGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 

            try
            {
                // [] Get 3 statistics regarding the usage of Tracker in the last 24 hours
                TrackerStatsResponse result = apiInstance.TrackerByProductIdStatsGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdStatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 

### Return type

[**TrackerStatsResponse**](TrackerStatsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidtransactionsget"></a>
# **TrackerByProductIdTransactionsGet**
> List<AssetTransaction> TrackerByProductIdTransactionsGet (string productId, DateTime? beforeDateTime = null, int? limit = null, int? offset = null, string request = null)

[] Get all transactions

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdTransactionsGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var beforeDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Get all transactions
                List&lt;AssetTransaction&gt; result = apiInstance.TrackerByProductIdTransactionsGet(productId, beforeDateTime, limit, offset, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdTransactionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **beforeDateTime** | **DateTime?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidtransactionsreversepost"></a>
# **TrackerByProductIdTransactionsReversePost**
> void TrackerByProductIdTransactionsReversePost (string productId, TrackerTransactionRevertRequest request = null)

[] Revert a transaction

This operation will refund the amounts that have been sent from a user to another by creating a new transaction.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdTransactionsReversePostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var request = new TrackerTransactionRevertRequest(); // TrackerTransactionRevertRequest |  (optional) 

            try
            {
                // [] Revert a transaction
                apiInstance.TrackerByProductIdTransactionsReversePost(productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdTransactionsReversePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **request** | [**TrackerTransactionRevertRequest**](TrackerTransactionRevertRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidwalletbalancesdetailedget"></a>
# **TrackerByProductIdWalletBalancesDetailedGet**
> List<DetailedAssetBalance> TrackerByProductIdWalletBalancesDetailedGet (string productId)

[] Get all authenticated user's asset balances

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdWalletBalancesDetailedGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 

            try
            {
                // [] Get all authenticated user's asset balances
                List&lt;DetailedAssetBalance&gt; result = apiInstance.TrackerByProductIdWalletBalancesDetailedGet(productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdWalletBalancesDetailedGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 

### Return type

[**List<DetailedAssetBalance>**](DetailedAssetBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidwalletbatchestransferpost"></a>
# **TrackerByProductIdWalletBatchesTransferPost**
> void TrackerByProductIdWalletBatchesTransferPost (string productId, TrackerBatchTransferRequest request = null)

[] Create a transfer between yourself and another user from one of your specific batches

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdWalletBatchesTransferPostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var request = new TrackerBatchTransferRequest(); // TrackerBatchTransferRequest |  (optional) 

            try
            {
                // [] Create a transfer between yourself and another user from one of your specific batches
                apiInstance.TrackerByProductIdWalletBatchesTransferPost(productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdWalletBatchesTransferPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **request** | [**TrackerBatchTransferRequest**](TrackerBatchTransferRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidwallettransactionsbyassetidget"></a>
# **TrackerByProductIdWalletTransactionsByAssetIdGet**
> List<AssetTransaction> TrackerByProductIdWalletTransactionsByAssetIdGet (string assetId, string productId)

[] Get all transactions for a specific asset

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdWalletTransactionsByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get all transactions for a specific asset
                List&lt;AssetTransaction&gt; result = apiInstance.TrackerByProductIdWalletTransactionsByAssetIdGet(assetId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdWalletTransactionsByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerbyproductidwallettransferpost"></a>
# **TrackerByProductIdWalletTransferPost**
> void TrackerByProductIdWalletTransferPost (string productId, TrackerTransferRequest request = null)

[] Create a transfer between yourself and another user

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerByProductIdWalletTransferPostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var request = new TrackerTransferRequest(); // TrackerTransferRequest |  (optional) 

            try
            {
                // [] Create a transfer between yourself and another user
                apiInstance.TrackerByProductIdWalletTransferPost(productId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerByProductIdWalletTransferPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **request** | [**TrackerTransferRequest**](TrackerTransferRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

