# mantle.lib.Api.TrackerApi

All URIs are relative to *http://dev.api.mantle.services*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrackerAssetsByAssetIdDelete**](TrackerApi.md#trackerassetsbyassetiddelete) | **DELETE** /tracker/assets/{assetId} | [ASSETS] Delete an asset that has been previously created. It won&#39;t be issuable and transferable anymore, but all transactions made in the past with this asset will still be visible. Requires the Tracker Admin Role.
[**TrackerAssetsByAssetIdGet**](TrackerApi.md#trackerassetsbyassetidget) | **GET** /tracker/assets/{assetId} | [ASSETS] Get a specific asset&#39;s details. Requires the Track Admin Role.
[**TrackerAssetsByAssetIdPut**](TrackerApi.md#trackerassetsbyassetidput) | **PUT** /tracker/assets/{assetId} | [ASSETS] Edit an asset that has previously been created. Only the name can be changed. Requires the Tracker Admin Role.
[**TrackerAssetsGet**](TrackerApi.md#trackerassetsget) | **GET** /tracker/assets | [ASSETS] Get all of the assets that have been created in Tracker. Requires the Tracker Admin Role.
[**TrackerAssetsIssuePost**](TrackerApi.md#trackerassetsissuepost) | **POST** /tracker/assets/issue | [ASSETS] Issue a certain amount of asset to a recipient. Requires the Tracker Admin Role.
[**TrackerAssetsIssuedbatchesByAssetIdByBatchIdGet**](TrackerApi.md#trackerassetsissuedbatchesbyassetidbybatchidget) | **GET** /tracker/assets/issuedbatches/{assetId}/{batchId} | [ASSETS] Get all issued batches for an asset. Requires the Tracker Admin Role.
[**TrackerAssetsIssuedbatchesByAssetIdGet**](TrackerApi.md#trackerassetsissuedbatchesbyassetidget) | **GET** /tracker/assets/issuedbatches/{assetId} | [ASSETS] Get all issued batches for an asset. Requires the Tracker Admin Role.
[**TrackerAssetsPost**](TrackerApi.md#trackerassetspost) | **POST** /tracker/assets | [ASSETS] Creates an asset in Tracker. This asset will then be issuable and transferable between entities. Requires the Tracker Admin Role.
[**TrackerStatsGet**](TrackerApi.md#trackerstatsget) | **GET** /tracker/stats | [STATS] Get 3 statistics regarding the usage of Tracker in the last 24 hours. Requires the Tracker Admin Role.
[**TrackerTransactionsGet**](TrackerApi.md#trackertransactionsget) | **GET** /tracker/transactions | [TRANSACTIONS] Get all of the latest transactions that have been performed in Tracker. Requires the Tracker Admin Role.
[**TrackerTransactionsReversePost**](TrackerApi.md#trackertransactionsreversepost) | **POST** /tracker/transactions/reverse | [TRANSACTIONS] Revert a transaction. This operation will refund the amounts that have been sent from a user to another by creating a new transaction. Requires the Tracker Admin Role.
[**TrackerWalletBatchesTransferPost**](TrackerApi.md#trackerwalletbatchestransferpost) | **POST** /tracker/wallet/batches/transfer | [WALLET] Create a transfer between yourself and another user from one of your specific batches. Requires the Tracker Admin Role or Tracker User Role.
[**TrackerWalletDetailedbalancesGet**](TrackerApi.md#trackerwalletdetailedbalancesget) | **GET** /tracker/wallet/detailedbalances | [WALLET] Get all of the logged user&#39;s asset balances for a specific main coin. Requires the Tracker Admin Role or Tracker User Role.
[**TrackerWalletTransactionsByAssetIdGet**](TrackerApi.md#trackerwallettransactionsbyassetidget) | **GET** /tracker/wallet/transactions/{assetId} | [WALLET] Get all transactions for a specific asset. Requires the Tracker Admin Role or Tracker User Role.
[**TrackerWalletTransferPost**](TrackerApi.md#trackerwallettransferpost) | **POST** /tracker/wallet/transfer | [WALLET] Create a transfer between yourself and another user. Requires the Tracker Admin Role or Tracker User Role.


<a name="trackerassetsbyassetiddelete"></a>
# **TrackerAssetsByAssetIdDelete**
> void TrackerAssetsByAssetIdDelete (string assetId)

[ASSETS] Delete an asset that has been previously created. It won't be issuable and transferable anymore, but all transactions made in the past with this asset will still be visible. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsByAssetIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 

            try
            {
                // [ASSETS] Delete an asset that has been previously created. It won't be issuable and transferable anymore, but all transactions made in the past with this asset will still be visible. Requires the Tracker Admin Role.
                apiInstance.TrackerAssetsByAssetIdDelete(assetId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsByAssetIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerassetsbyassetidget"></a>
# **TrackerAssetsByAssetIdGet**
> TrackerAsset TrackerAssetsByAssetIdGet (string assetId)

[ASSETS] Get a specific asset's details. Requires the Track Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 

            try
            {
                // [ASSETS] Get a specific asset's details. Requires the Track Admin Role.
                TrackerAsset result = apiInstance.TrackerAssetsByAssetIdGet(assetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 

### Return type

[**TrackerAsset**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerassetsbyassetidput"></a>
# **TrackerAssetsByAssetIdPut**
> void TrackerAssetsByAssetIdPut (string assetId, TrackerAssetCreateRequest request = null)

[ASSETS] Edit an asset that has previously been created. Only the name can be changed. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsByAssetIdPutExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var request = new TrackerAssetCreateRequest(); // TrackerAssetCreateRequest |  (optional) 

            try
            {
                // [ASSETS] Edit an asset that has previously been created. Only the name can be changed. Requires the Tracker Admin Role.
                apiInstance.TrackerAssetsByAssetIdPut(assetId, request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsByAssetIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 
 **request** | [**TrackerAssetCreateRequest**](TrackerAssetCreateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerassetsget"></a>
# **TrackerAssetsGet**
> List<TrackerAsset> TrackerAssetsGet ()

[ASSETS] Get all of the assets that have been created in Tracker. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();

            try
            {
                // [ASSETS] Get all of the assets that have been created in Tracker. Requires the Tracker Admin Role.
                List&lt;TrackerAsset&gt; result = apiInstance.TrackerAssetsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TrackerAsset>**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerassetsissuepost"></a>
# **TrackerAssetsIssuePost**
> void TrackerAssetsIssuePost (TrackerAssetIssueRequest request = null)

[ASSETS] Issue a certain amount of asset to a recipient. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsIssuePostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var request = new TrackerAssetIssueRequest(); // TrackerAssetIssueRequest |  (optional) 

            try
            {
                // [ASSETS] Issue a certain amount of asset to a recipient. Requires the Tracker Admin Role.
                apiInstance.TrackerAssetsIssuePost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsIssuePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TrackerAssetIssueRequest**](TrackerAssetIssueRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerassetsissuedbatchesbyassetidbybatchidget"></a>
# **TrackerAssetsIssuedbatchesByAssetIdByBatchIdGet**
> IssuedBatchTransactionsResponse TrackerAssetsIssuedbatchesByAssetIdByBatchIdGet (string assetId, string batchId)

[ASSETS] Get all issued batches for an asset. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsIssuedbatchesByAssetIdByBatchIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 
            var batchId = batchId_example;  // string | 

            try
            {
                // [ASSETS] Get all issued batches for an asset. Requires the Tracker Admin Role.
                IssuedBatchTransactionsResponse result = apiInstance.TrackerAssetsIssuedbatchesByAssetIdByBatchIdGet(assetId, batchId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsIssuedbatchesByAssetIdByBatchIdGet: " + e.Message );
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

### Return type

[**IssuedBatchTransactionsResponse**](IssuedBatchTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerassetsissuedbatchesbyassetidget"></a>
# **TrackerAssetsIssuedbatchesByAssetIdGet**
> IssuedBatchesResponse TrackerAssetsIssuedbatchesByAssetIdGet (string assetId)

[ASSETS] Get all issued batches for an asset. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsIssuedbatchesByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 

            try
            {
                // [ASSETS] Get all issued batches for an asset. Requires the Tracker Admin Role.
                IssuedBatchesResponse result = apiInstance.TrackerAssetsIssuedbatchesByAssetIdGet(assetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsIssuedbatchesByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 

### Return type

[**IssuedBatchesResponse**](IssuedBatchesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerassetspost"></a>
# **TrackerAssetsPost**
> TrackerAsset TrackerAssetsPost (TrackerAssetCreateRequest request = null)

[ASSETS] Creates an asset in Tracker. This asset will then be issuable and transferable between entities. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerAssetsPostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var request = new TrackerAssetCreateRequest(); // TrackerAssetCreateRequest |  (optional) 

            try
            {
                // [ASSETS] Creates an asset in Tracker. This asset will then be issuable and transferable between entities. Requires the Tracker Admin Role.
                TrackerAsset result = apiInstance.TrackerAssetsPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerAssetsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TrackerAssetCreateRequest**](TrackerAssetCreateRequest.md)|  | [optional] 

### Return type

[**TrackerAsset**](TrackerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerstatsget"></a>
# **TrackerStatsGet**
> TrackerStatsResponse TrackerStatsGet ()

[STATS] Get 3 statistics regarding the usage of Tracker in the last 24 hours. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerStatsGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();

            try
            {
                // [STATS] Get 3 statistics regarding the usage of Tracker in the last 24 hours. Requires the Tracker Admin Role.
                TrackerStatsResponse result = apiInstance.TrackerStatsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerStatsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TrackerStatsResponse**](TrackerStatsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackertransactionsget"></a>
# **TrackerTransactionsGet**
> List<AssetTransaction> TrackerTransactionsGet (DateTime? beforeDateTime = null, int? limit = null, int? offset = null)

[TRANSACTIONS] Get all of the latest transactions that have been performed in Tracker. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerTransactionsGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var beforeDateTime = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 

            try
            {
                // [TRANSACTIONS] Get all of the latest transactions that have been performed in Tracker. Requires the Tracker Admin Role.
                List&lt;AssetTransaction&gt; result = apiInstance.TrackerTransactionsGet(beforeDateTime, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerTransactionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="trackertransactionsreversepost"></a>
# **TrackerTransactionsReversePost**
> void TrackerTransactionsReversePost (TrackerTransactionRevertRequest request = null)

[TRANSACTIONS] Revert a transaction. This operation will refund the amounts that have been sent from a user to another by creating a new transaction. Requires the Tracker Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerTransactionsReversePostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var request = new TrackerTransactionRevertRequest(); // TrackerTransactionRevertRequest |  (optional) 

            try
            {
                // [TRANSACTIONS] Revert a transaction. This operation will refund the amounts that have been sent from a user to another by creating a new transaction. Requires the Tracker Admin Role.
                apiInstance.TrackerTransactionsReversePost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerTransactionsReversePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TrackerTransactionRevertRequest**](TrackerTransactionRevertRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerwalletbatchestransferpost"></a>
# **TrackerWalletBatchesTransferPost**
> void TrackerWalletBatchesTransferPost (TrackerBatchTransferRequest request = null)

[WALLET] Create a transfer between yourself and another user from one of your specific batches. Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerWalletBatchesTransferPostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var request = new TrackerBatchTransferRequest(); // TrackerBatchTransferRequest |  (optional) 

            try
            {
                // [WALLET] Create a transfer between yourself and another user from one of your specific batches. Requires the Tracker Admin Role or Tracker User Role.
                apiInstance.TrackerWalletBatchesTransferPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerWalletBatchesTransferPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TrackerBatchTransferRequest**](TrackerBatchTransferRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerwalletdetailedbalancesget"></a>
# **TrackerWalletDetailedbalancesGet**
> List<DetailedAssetBalance> TrackerWalletDetailedbalancesGet ()

[WALLET] Get all of the logged user's asset balances for a specific main coin. Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerWalletDetailedbalancesGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();

            try
            {
                // [WALLET] Get all of the logged user's asset balances for a specific main coin. Requires the Tracker Admin Role or Tracker User Role.
                List&lt;DetailedAssetBalance&gt; result = apiInstance.TrackerWalletDetailedbalancesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerWalletDetailedbalancesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DetailedAssetBalance>**](DetailedAssetBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerwallettransactionsbyassetidget"></a>
# **TrackerWalletTransactionsByAssetIdGet**
> List<AssetTransaction> TrackerWalletTransactionsByAssetIdGet (string assetId)

[WALLET] Get all transactions for a specific asset. Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerWalletTransactionsByAssetIdGetExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var assetId = assetId_example;  // string | 

            try
            {
                // [WALLET] Get all transactions for a specific asset. Requires the Tracker Admin Role or Tracker User Role.
                List&lt;AssetTransaction&gt; result = apiInstance.TrackerWalletTransactionsByAssetIdGet(assetId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerWalletTransactionsByAssetIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assetId** | **string**|  | 

### Return type

[**List<AssetTransaction>**](AssetTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackerwallettransferpost"></a>
# **TrackerWalletTransferPost**
> void TrackerWalletTransferPost (TrackerTransferRequest request = null)

[WALLET] Create a transfer between yourself and another user. Requires the Tracker Admin Role or Tracker User Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class TrackerWalletTransferPostExample
    {
        public void main()
        {
            var apiInstance = new TrackerApi();
            var request = new TrackerTransferRequest(); // TrackerTransferRequest |  (optional) 

            try
            {
                // [WALLET] Create a transfer between yourself and another user. Requires the Tracker Admin Role or Tracker User Role.
                apiInstance.TrackerWalletTransferPost(request);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackerApi.TrackerWalletTransferPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TrackerTransferRequest**](TrackerTransferRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

