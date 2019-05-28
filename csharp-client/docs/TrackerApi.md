# mantle.lib.Mantle.lib.TrackerApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAsset**](TrackerApi.md#createasset) | **POST** /tracker/{productId}/assets | [ASSETS] Create an asset
[**CreateAssetBatchTransfer**](TrackerApi.md#createassetbatchtransfer) | **POST** /tracker/{productId}/assets/{assetId}/batches/transfer | [ASSETS] Create a transfer for one or many batches for an asset
[**CreateAssetTransfer**](TrackerApi.md#createassettransfer) | **POST** /tracker/{productId}/assets/{assetId}/transfer | [ASSETS] Create a transfer for an asset
[**CreateAssetTransferBulk**](TrackerApi.md#createassettransferbulk) | **POST** /tracker/{productId}/assets/transfer/bulk | [ASSETS] Create transfers in bulk
[**CreateEntity**](TrackerApi.md#createentity) | **POST** /tracker/{productId}/entities | [ENTITIES] Create an entity
[**CreateMultiAsset**](TrackerApi.md#createmultiasset) | **POST** /tracker/{productId}/multiassets | [MULTIASSETS] Creates a multi asset
[**CreateMultiAssetBatchTransfer**](TrackerApi.md#createmultiassetbatchtransfer) | **POST** /tracker/{productId}/multiassets/{assetId}/batches/transfer | [MULTIASSETS] Create a transfer for one or many batches for a multi asset
[**CreateMultiAssetTransfer**](TrackerApi.md#createmultiassettransfer) | **POST** /tracker/{productId}/multiassets/{assetId}/transfer | [MULTIASSETS] Create a transfer for a multi asset
[**DeleteAsset**](TrackerApi.md#deleteasset) | **DELETE** /tracker/{productId}/assets/{assetId} | [ASSETS] Delete an asset
[**DeleteEntity**](TrackerApi.md#deleteentity) | **DELETE** /tracker/{productId}/entities/{id} | [ENTITIES] Delete an entity
[**DeleteMultiAsset**](TrackerApi.md#deletemultiasset) | **DELETE** /tracker/{productId}/multiassets/{assetId} | [MULTIASSETS] Delete a multi asset
[**EditAsset**](TrackerApi.md#editasset) | **PUT** /tracker/{productId}/assets/{assetId} | [ASSETS] Edit an asset
[**EditEntity**](TrackerApi.md#editentity) | **PUT** /tracker/{productId}/entities/{id} | [ENTITIES] Edit an entity
[**EditMultiAsset**](TrackerApi.md#editmultiasset) | **PUT** /tracker/{productId}/multiassets/{assetId} | [MULTIASSETS] Edit a multi asset
[**GetAllAssets**](TrackerApi.md#getallassets) | **GET** /tracker/{productId}/assets | [ASSETS] Get all assets
[**GetAllMultiAssets**](TrackerApi.md#getallmultiassets) | **GET** /tracker/{productId}/multiassets | [MULTIASSETS] Get all multi assets
[**GetAllTransactions**](TrackerApi.md#getalltransactions) | **GET** /tracker/{productId}/transactions | [TRANSACTIONS] Get all transactions
[**GetAssetById**](TrackerApi.md#getassetbyid) | **GET** /tracker/{productId}/assets/{assetId} | [ASSETS] Get a specific asset&#39;s details
[**GetAssetDetailedBalance**](TrackerApi.md#getassetdetailedbalance) | **GET** /tracker/{productId}/balances/{assetId} | [BALANCES] Get all authenticated user&#39;s asset balance batches
[**GetAssetIssuedBatchTransactions**](TrackerApi.md#getassetissuedbatchtransactions) | **GET** /tracker/{productId}/assets/{assetId}/batches/{batchId}/transactions | [ASSETS] Get all transactions of a specific batch for an asset
[**GetAssetIssuedBatches**](TrackerApi.md#getassetissuedbatches) | **GET** /tracker/{productId}/assets/{assetId}/batches | [ASSETS] Get all issued batches for an asset
[**GetBalances**](TrackerApi.md#getbalances) | **GET** /tracker/{productId}/balances | [BALANCES] Get all authenticated user&#39;s assets balances
[**GetMultiAssetById**](TrackerApi.md#getmultiassetbyid) | **GET** /tracker/{productId}/multiassets/{assetId} | [MULTIASSETS] Get a specific multi asset&#39;s details
[**GetMultiAssetIssuedBatchTransactions**](TrackerApi.md#getmultiassetissuedbatchtransactions) | **GET** /tracker/{productId}/multiassets/{assetId}/batches/{batchId}/transactions | [MULTIASSETS] Get all transactions of a specific batch for a multi asset
[**GetMultiAssetIssuedBatches**](TrackerApi.md#getmultiassetissuedbatches) | **GET** /tracker/{productId}/multiassets/{assetId}/batches | [MULTIASSETS] Get all issued batches for a multi asset
[**GetOwnedIdentities**](TrackerApi.md#getownedidentities) | **GET** /tracker/{productId}/entities | [ENTITIES] Get all entities of a user
[**GetTransactionsByAssetId**](TrackerApi.md#gettransactionsbyassetid) | **GET** /tracker/{productId}/assets/{assetId}/transactions | [ASSETS] Get all transactions for an asset
[**GetTransactionsByMultiAssetId**](TrackerApi.md#gettransactionsbymultiassetid) | **GET** /tracker/{productId}/multiassets/{assetId}/transactions | [MULTIASSETS] Get all transactions for a multi asset
[**IssueAsset**](TrackerApi.md#issueasset) | **POST** /tracker/{productId}/assets/{assetId}/issue | [ASSETS] Issue an amount of an asset
[**IssueAssetBulk**](TrackerApi.md#issueassetbulk) | **POST** /tracker/{productId}/assets/issue/bulk | [ASSETS] Issue in bulk
[**IssueMultiAsset**](TrackerApi.md#issuemultiasset) | **POST** /tracker/{productId}/multiassets/{assetId}/issue | [MULTIASSETS] Issue an amount of a multi asset
[**IssueMultiAssetBulk**](TrackerApi.md#issuemultiassetbulk) | **POST** /tracker/{productId}/multiassets/issue/bulk | [MULTIASSETS] Issue multi asset in bulk
[**Reverse**](TrackerApi.md#reverse) | **POST** /tracker/{productId}/transactions/{transactionId}/reverse | [TRANSACTIONS] Revert a transaction


<a name="createasset"></a>
# **CreateAsset**
> TrackerAsset CreateAsset (string productId, string xApiKey, TrackerAssetCreateRequest request = null)

[ASSETS] Create an asset

This asset will then be issuable and transferable between entities.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerAssetCreateRequest(); // TrackerAssetCreateRequest |  (optional) 

            try
            {
                // [ASSETS] Create an asset
                TrackerAsset result = apiInstance.CreateAsset(productId, xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateAsset: " + e.Message );
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
 **request** | [**TrackerAssetCreateRequest**](TrackerAssetCreateRequest.md)|  | [optional] 

### Return type

[**TrackerAsset**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createassetbatchtransfer"></a>
# **CreateAssetBatchTransfer**
> void CreateAssetBatchTransfer (string assetId, string productId, string xApiKey, TrackerBatchTransferRequest request = null, string ownedId = null)

[ASSETS] Create a transfer for one or many batches for an asset

The authenticated must have the specific batches                Requires the Tracker Admin Role or Tracker User Role.  If you want to transfer to an entity, you should put the id of it.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateAssetBatchTransferExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerBatchTransferRequest(); // TrackerBatchTransferRequest |  (optional) 
            var ownedId = ownedId_example;  // string |  (optional) 

            try
            {
                // [ASSETS] Create a transfer for one or many batches for an asset
                apiInstance.CreateAssetBatchTransfer(assetId, productId, xApiKey, request, ownedId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateAssetBatchTransfer: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerBatchTransferRequest**](TrackerBatchTransferRequest.md)|  | [optional] 
 **ownedId** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createassettransfer"></a>
# **CreateAssetTransfer**
> List<AssetTransaction> CreateAssetTransfer (string assetId, string productId, string xApiKey, TrackerTransferRequest request = null, string ownedId = null)

[ASSETS] Create a transfer for an asset

Requires the Tracker Admin Role or Tracker User Role.  If you want to transfer to an entity, you should put the id of it.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateAssetTransferExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerTransferRequest(); // TrackerTransferRequest |  (optional) 
            var ownedId = ownedId_example;  // string |  (optional) 

            try
            {
                // [ASSETS] Create a transfer for an asset
                List&lt;AssetTransaction&gt; result = apiInstance.CreateAssetTransfer(assetId, productId, xApiKey, request, ownedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateAssetTransfer: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerTransferRequest**](TrackerTransferRequest.md)|  | [optional] 
 **ownedId** | **string**|  | [optional] 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createassettransferbulk"></a>
# **CreateAssetTransferBulk**
> List<TrackerBatchTransferBulkResponse> CreateAssetTransferBulk (string productId, string xApiKey, List<TrackerBatchTransferBulkRequest> requests = null, string ownedId = null)

[ASSETS] Create transfers in bulk

Requires the Tracker Admin Role or Tracker User Role.  If you want to transfer to an entity, you should put the id of it.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateAssetTransferBulkExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var requests = new List<TrackerBatchTransferBulkRequest>(); // List<TrackerBatchTransferBulkRequest> |  (optional) 
            var ownedId = ownedId_example;  // string |  (optional) 

            try
            {
                // [ASSETS] Create transfers in bulk
                List&lt;TrackerBatchTransferBulkResponse&gt; result = apiInstance.CreateAssetTransferBulk(productId, xApiKey, requests, ownedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateAssetTransferBulk: " + e.Message );
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
 **requests** | [**List&lt;TrackerBatchTransferBulkRequest&gt;**](TrackerBatchTransferBulkRequest.md)|  | [optional] 
 **ownedId** | **string**|  | [optional] 

### Return type

[**List<TrackerBatchTransferBulkResponse>**](TrackerBatchTransferBulkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createentity"></a>
# **CreateEntity**
> NonUser CreateEntity (string productId, string xApiKey, CreateEnttityRequest request = null)

[ENTITIES] Create an entity

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateEntityExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new CreateEnttityRequest(); // CreateEnttityRequest |  (optional) 

            try
            {
                // [ENTITIES] Create an entity
                NonUser result = apiInstance.CreateEntity(productId, xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateEntity: " + e.Message );
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
 **request** | [**CreateEnttityRequest**](CreateEnttityRequest.md)|  | [optional] 

### Return type

[**NonUser**](NonUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmultiasset"></a>
# **CreateMultiAsset**
> TrackerMultiAsset CreateMultiAsset (string productId, string xApiKey, TrackerMultiAssetCreateRequest request = null)

[MULTIASSETS] Creates a multi asset

This asset will then be issuable and transferable between entities.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateMultiAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerMultiAssetCreateRequest(); // TrackerMultiAssetCreateRequest |  (optional) 

            try
            {
                // [MULTIASSETS] Creates a multi asset
                TrackerMultiAsset result = apiInstance.CreateMultiAsset(productId, xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateMultiAsset: " + e.Message );
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
 **request** | [**TrackerMultiAssetCreateRequest**](TrackerMultiAssetCreateRequest.md)|  | [optional] 

### Return type

[**TrackerMultiAsset**](TrackerMultiAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmultiassetbatchtransfer"></a>
# **CreateMultiAssetBatchTransfer**
> void CreateMultiAssetBatchTransfer (string assetId, string productId, string xApiKey, TrackerBatchTransferRequest request = null, string ownedId = null)

[MULTIASSETS] Create a transfer for one or many batches for a multi asset

The authenticated must have the specific batches                Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateMultiAssetBatchTransferExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerBatchTransferRequest(); // TrackerBatchTransferRequest |  (optional) 
            var ownedId = ownedId_example;  // string |  (optional) 

            try
            {
                // [MULTIASSETS] Create a transfer for one or many batches for a multi asset
                apiInstance.CreateMultiAssetBatchTransfer(assetId, productId, xApiKey, request, ownedId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateMultiAssetBatchTransfer: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerBatchTransferRequest**](TrackerBatchTransferRequest.md)|  | [optional] 
 **ownedId** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmultiassettransfer"></a>
# **CreateMultiAssetTransfer**
> List<AssetTransaction> CreateMultiAssetTransfer (string assetId, string productId, string xApiKey, TrackerTransferRequest request = null, string ownedId = null)

[MULTIASSETS] Create a transfer for a multi asset

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateMultiAssetTransferExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerTransferRequest(); // TrackerTransferRequest |  (optional) 
            var ownedId = ownedId_example;  // string |  (optional) 

            try
            {
                // [MULTIASSETS] Create a transfer for a multi asset
                List&lt;AssetTransaction&gt; result = apiInstance.CreateMultiAssetTransfer(assetId, productId, xApiKey, request, ownedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.CreateMultiAssetTransfer: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerTransferRequest**](TrackerTransferRequest.md)|  | [optional] 
 **ownedId** | **string**|  | [optional] 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteasset"></a>
# **DeleteAsset**
> void DeleteAsset (string assetId, string productId, string xApiKey)

[ASSETS] Delete an asset

It won't be issuable and transferable anymore, but all transactions made in the past with this asset will still be visible.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [ASSETS] Delete an asset
                apiInstance.DeleteAsset(assetId, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.DeleteAsset: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteentity"></a>
# **DeleteEntity**
> void DeleteEntity (string id, string productId, string xApiKey)

[ENTITIES] Delete an entity

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteEntityExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var id = id_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [ENTITIES] Delete an entity
                apiInstance.DeleteEntity(id, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.DeleteEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
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

<a name="deletemultiasset"></a>
# **DeleteMultiAsset**
> void DeleteMultiAsset (string assetId, string productId, string xApiKey)

[MULTIASSETS] Delete a multi asset

It won't be issuable and transferable anymore, but all transactions made in the past with this multi asset will still be visible.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteMultiAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [MULTIASSETS] Delete a multi asset
                apiInstance.DeleteMultiAsset(assetId, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.DeleteMultiAsset: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editasset"></a>
# **EditAsset**
> void EditAsset (string assetId, string productId, string xApiKey, TrackerAssetCreateRequest request = null)

[ASSETS] Edit an asset

Only the name can be changed.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class EditAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerAssetCreateRequest(); // TrackerAssetCreateRequest |  (optional) 

            try
            {
                // [ASSETS] Edit an asset
                apiInstance.EditAsset(assetId, productId, xApiKey, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.EditAsset: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerAssetCreateRequest**](TrackerAssetCreateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editentity"></a>
# **EditEntity**
> void EditEntity (string id, string productId, string xApiKey, UpdateEntityRequest request = null)

[ENTITIES] Edit an entity

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class EditEntityExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var id = id_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new UpdateEntityRequest(); // UpdateEntityRequest |  (optional) 

            try
            {
                // [ENTITIES] Edit an entity
                apiInstance.EditEntity(id, productId, xApiKey, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.EditEntity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **request** | [**UpdateEntityRequest**](UpdateEntityRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editmultiasset"></a>
# **EditMultiAsset**
> void EditMultiAsset (string assetId, string productId, string xApiKey, TrackerAssetCreateRequest request = null)

[MULTIASSETS] Edit a multi asset

Only the name can be changed.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class EditMultiAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerAssetCreateRequest(); // TrackerAssetCreateRequest |  (optional) 

            try
            {
                // [MULTIASSETS] Edit a multi asset
                apiInstance.EditMultiAsset(assetId, productId, xApiKey, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.EditMultiAsset: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerAssetCreateRequest**](TrackerAssetCreateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallassets"></a>
# **GetAllAssets**
> List<TrackerAsset> GetAllAssets (string productId, string xApiKey, int? limit = null, int? offset = null, string assetDisplayNames = null)

[ASSETS] Get all assets

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllAssetsExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var assetDisplayNames = assetDisplayNames_example;  // string | Filter assets using their display names.  Example: Asset1,Asset2,Asset3 (optional) 

            try
            {
                // [ASSETS] Get all assets
                List&lt;TrackerAsset&gt; result = apiInstance.GetAllAssets(productId, xApiKey, limit, offset, assetDisplayNames);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetAllAssets: " + e.Message );
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
 **assetDisplayNames** | **string**| Filter assets using their display names.  Example: Asset1,Asset2,Asset3 | [optional] 

### Return type

[**List<TrackerAsset>**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallmultiassets"></a>
# **GetAllMultiAssets**
> List<TrackerMultiAsset> GetAllMultiAssets (string productId, string xApiKey, DateTime? beforeDateTime = null, int? limit = null, int? offset = null, string assetIds = null)

[MULTIASSETS] Get all multi assets

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllMultiAssetsExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var beforeDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var assetIds = assetIds_example;  // string |  (optional) 

            try
            {
                // [MULTIASSETS] Get all multi assets
                List&lt;TrackerMultiAsset&gt; result = apiInstance.GetAllMultiAssets(productId, xApiKey, beforeDateTime, limit, offset, assetIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetAllMultiAssets: " + e.Message );
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
 **beforeDateTime** | **DateTime?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **assetIds** | **string**|  | [optional] 

### Return type

[**List<TrackerMultiAsset>**](TrackerMultiAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalltransactions"></a>
# **GetAllTransactions**
> List<AssetTransaction> GetAllTransactions (string productId, string xApiKey, DateTime? beforeDateTime = null, int? limit = null, int? offset = null)

[TRANSACTIONS] Get all transactions

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllTransactionsExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var beforeDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [TRANSACTIONS] Get all transactions
                List&lt;AssetTransaction&gt; result = apiInstance.GetAllTransactions(productId, xApiKey, beforeDateTime, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetAllTransactions: " + e.Message );
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
 **beforeDateTime** | **DateTime?**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetbyid"></a>
# **GetAssetById**
> TrackerAsset GetAssetById (string assetId, string productId, string xApiKey)

[ASSETS] Get a specific asset's details

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAssetByIdExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [ASSETS] Get a specific asset's details
                TrackerAsset result = apiInstance.GetAssetById(assetId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetAssetById: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**TrackerAsset**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetdetailedbalance"></a>
# **GetAssetDetailedBalance**
> List<Batch> GetAssetDetailedBalance (string assetId, string productId, string xApiKey, string ownedId = null)

[BALANCES] Get all authenticated user's asset balance batches

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAssetDetailedBalanceExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var ownedId = ownedId_example;  // string |  (optional) 

            try
            {
                // [BALANCES] Get all authenticated user's asset balance batches
                List&lt;Batch&gt; result = apiInstance.GetAssetDetailedBalance(assetId, productId, xApiKey, ownedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetAssetDetailedBalance: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **ownedId** | **string**|  | [optional] 

### Return type

[**List<Batch>**](Batch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetissuedbatchtransactions"></a>
# **GetAssetIssuedBatchTransactions**
> IssuedBatchTransactionsResponse GetAssetIssuedBatchTransactions (string assetId, string batchId, string productId, string xApiKey)

[ASSETS] Get all transactions of a specific batch for an asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAssetIssuedBatchTransactionsExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var batchId = batchId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [ASSETS] Get all transactions of a specific batch for an asset
                IssuedBatchTransactionsResponse result = apiInstance.GetAssetIssuedBatchTransactions(assetId, batchId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetAssetIssuedBatchTransactions: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**IssuedBatchTransactionsResponse**](IssuedBatchTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetissuedbatches"></a>
# **GetAssetIssuedBatches**
> IssuedBatchesResponse GetAssetIssuedBatches (string assetId, string productId, string xApiKey)

[ASSETS] Get all issued batches for an asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAssetIssuedBatchesExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [ASSETS] Get all issued batches for an asset
                IssuedBatchesResponse result = apiInstance.GetAssetIssuedBatches(assetId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetAssetIssuedBatches: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**IssuedBatchesResponse**](IssuedBatchesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbalances"></a>
# **GetBalances**
> List<AssetBalance> GetBalances (string productId, string xApiKey, string ownedId = null)

[BALANCES] Get all authenticated user's assets balances

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetBalancesExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var ownedId = ownedId_example;  // string |  (optional) 

            try
            {
                // [BALANCES] Get all authenticated user's assets balances
                List&lt;AssetBalance&gt; result = apiInstance.GetBalances(productId, xApiKey, ownedId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetBalances: " + e.Message );
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
 **ownedId** | **string**|  | [optional] 

### Return type

[**List<AssetBalance>**](AssetBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmultiassetbyid"></a>
# **GetMultiAssetById**
> TrackerMultiAsset GetMultiAssetById (string assetId, string productId, string xApiKey)

[MULTIASSETS] Get a specific multi asset's details

Requires the Track Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetMultiAssetByIdExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [MULTIASSETS] Get a specific multi asset's details
                TrackerMultiAsset result = apiInstance.GetMultiAssetById(assetId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetMultiAssetById: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**TrackerMultiAsset**](TrackerMultiAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmultiassetissuedbatchtransactions"></a>
# **GetMultiAssetIssuedBatchTransactions**
> IssuedBatchTransactionsResponse GetMultiAssetIssuedBatchTransactions (string assetId, string batchId, string productId, string xApiKey)

[MULTIASSETS] Get all transactions of a specific batch for a multi asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetMultiAssetIssuedBatchTransactionsExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var batchId = batchId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [MULTIASSETS] Get all transactions of a specific batch for a multi asset
                IssuedBatchTransactionsResponse result = apiInstance.GetMultiAssetIssuedBatchTransactions(assetId, batchId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetMultiAssetIssuedBatchTransactions: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**IssuedBatchTransactionsResponse**](IssuedBatchTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmultiassetissuedbatches"></a>
# **GetMultiAssetIssuedBatches**
> IssuedBatchesResponse GetMultiAssetIssuedBatches (string assetId, string productId, string xApiKey)

[MULTIASSETS] Get all issued batches for a multi asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetMultiAssetIssuedBatchesExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [MULTIASSETS] Get all issued batches for a multi asset
                IssuedBatchesResponse result = apiInstance.GetMultiAssetIssuedBatches(assetId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetMultiAssetIssuedBatches: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**IssuedBatchesResponse**](IssuedBatchesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getownedidentities"></a>
# **GetOwnedIdentities**
> List<NonUserResponse> GetOwnedIdentities (string productId, string xApiKey)

[ENTITIES] Get all entities of a user

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetOwnedIdentitiesExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [ENTITIES] Get all entities of a user
                List&lt;NonUserResponse&gt; result = apiInstance.GetOwnedIdentities(productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetOwnedIdentities: " + e.Message );
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

[**List<NonUserResponse>**](NonUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsbyassetid"></a>
# **GetTransactionsByAssetId**
> List<AssetTransaction> GetTransactionsByAssetId (string assetId, string productId, string xApiKey)

[ASSETS] Get all transactions for an asset

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetTransactionsByAssetIdExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [ASSETS] Get all transactions for an asset
                List&lt;AssetTransaction&gt; result = apiInstance.GetTransactionsByAssetId(assetId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetTransactionsByAssetId: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionsbymultiassetid"></a>
# **GetTransactionsByMultiAssetId**
> List<AssetTransaction> GetTransactionsByMultiAssetId (string assetId, string productId, string xApiKey)

[MULTIASSETS] Get all transactions for a multi asset

Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetTransactionsByMultiAssetIdExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [MULTIASSETS] Get all transactions for a multi asset
                List&lt;AssetTransaction&gt; result = apiInstance.GetTransactionsByMultiAssetId(assetId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.GetTransactionsByMultiAssetId: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueasset"></a>
# **IssueAsset**
> void IssueAsset (string assetId, string productId, string xApiKey, TrackerAssetIssueRequest request = null)

[ASSETS] Issue an amount of an asset

Requires the Tracker Admin Role. If you want to transfer to an entity, you should put the id of it.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class IssueAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerAssetIssueRequest(); // TrackerAssetIssueRequest |  (optional) 

            try
            {
                // [ASSETS] Issue an amount of an asset
                apiInstance.IssueAsset(assetId, productId, xApiKey, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.IssueAsset: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerAssetIssueRequest**](TrackerAssetIssueRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issueassetbulk"></a>
# **IssueAssetBulk**
> List<TrackerAssetIssueResponse> IssueAssetBulk (string productId, string xApiKey, List<TrackerAssetIssueBulkRequest> requests = null)

[ASSETS] Issue in bulk

Requires the Tracker Admin Role.  If you want to transfer to an entity, you should put the id of it.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class IssueAssetBulkExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var requests = new List<TrackerAssetIssueBulkRequest>(); // List<TrackerAssetIssueBulkRequest> |  (optional) 

            try
            {
                // [ASSETS] Issue in bulk
                List&lt;TrackerAssetIssueResponse&gt; result = apiInstance.IssueAssetBulk(productId, xApiKey, requests);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.IssueAssetBulk: " + e.Message );
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
 **requests** | [**List&lt;TrackerAssetIssueBulkRequest&gt;**](TrackerAssetIssueBulkRequest.md)|  | [optional] 

### Return type

[**List<TrackerAssetIssueResponse>**](TrackerAssetIssueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuemultiasset"></a>
# **IssueMultiAsset**
> void IssueMultiAsset (string assetId, string productId, string xApiKey, TrackerAssetIssueRequest request = null)

[MULTIASSETS] Issue an amount of a multi asset

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class IssueMultiAssetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new TrackerAssetIssueRequest(); // TrackerAssetIssueRequest |  (optional) 

            try
            {
                // [MULTIASSETS] Issue an amount of a multi asset
                apiInstance.IssueMultiAsset(assetId, productId, xApiKey, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.IssueMultiAsset: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **request** | [**TrackerAssetIssueRequest**](TrackerAssetIssueRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="issuemultiassetbulk"></a>
# **IssueMultiAssetBulk**
> List<TrackerAssetIssueResponse> IssueMultiAssetBulk (string productId, string xApiKey, List<TrackerAssetIssueBulkRequest> requests = null)

[MULTIASSETS] Issue multi asset in bulk

Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class IssueMultiAssetBulkExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var requests = new List<TrackerAssetIssueBulkRequest>(); // List<TrackerAssetIssueBulkRequest> |  (optional) 

            try
            {
                // [MULTIASSETS] Issue multi asset in bulk
                List&lt;TrackerAssetIssueResponse&gt; result = apiInstance.IssueMultiAssetBulk(productId, xApiKey, requests);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.IssueMultiAssetBulk: " + e.Message );
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
 **requests** | [**List&lt;TrackerAssetIssueBulkRequest&gt;**](TrackerAssetIssueBulkRequest.md)|  | [optional] 

### Return type

[**List<TrackerAssetIssueResponse>**](TrackerAssetIssueResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reverse"></a>
# **Reverse**
> void Reverse (string transactionId, string productId, string xApiKey)

[TRANSACTIONS] Revert a transaction

This operation will refund the amounts that have been sent from a user to another by creating a new transaction.                Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class ReverseExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var transactionId = transactionId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [TRANSACTIONS] Revert a transaction
                apiInstance.Reverse(transactionId, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.Reverse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionId** | **string**|  | 
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

