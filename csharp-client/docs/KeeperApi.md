# mantle.lib.Api.KeeperApi

All URIs are relative to *http://develop.api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**KeeperByProductIdFilesByFileIdDelete**](KeeperApi.md#keeperbyproductidfilesbyfileiddelete) | **DELETE** /keeper/{productId}/files/{fileId} | [] Delete a file
[**KeeperByProductIdFilesByFileIdGet**](KeeperApi.md#keeperbyproductidfilesbyfileidget) | **GET** /keeper/{productId}/files/{fileId} | [] Get a file&#39;s details.
[**KeeperByProductIdFilesDiffLatestPost**](KeeperApi.md#keeperbyproductidfilesdifflatestpost) | **POST** /keeper/{productId}/files/diff/latest | [] Compare a local file to the latest version
[**KeeperByProductIdFilesDiffPost**](KeeperApi.md#keeperbyproductidfilesdiffpost) | **POST** /keeper/{productId}/files/diff | [] Compare a local file to the original version
[**KeeperByProductIdFilesExistPost**](KeeperApi.md#keeperbyproductidfilesexistpost) | **POST** /keeper/{productId}/files/exist | [] Check if a file already exists
[**KeeperByProductIdFilesGet**](KeeperApi.md#keeperbyproductidfilesget) | **GET** /keeper/{productId}/files | [] Get all files
[**KeeperByProductIdFilesPost**](KeeperApi.md#keeperbyproductidfilespost) | **POST** /keeper/{productId}/files | [] Create a file
[**KeeperByProductIdFoldersByFolderIdDelete**](KeeperApi.md#keeperbyproductidfoldersbyfolderiddelete) | **DELETE** /keeper/{productId}/folders/{folderId} | [] Delete a folder
[**KeeperByProductIdFoldersByFolderIdGet**](KeeperApi.md#keeperbyproductidfoldersbyfolderidget) | **GET** /keeper/{productId}/folders/{folderId} | [] Get a specific folder&#39;s details
[**KeeperByProductIdFoldersGet**](KeeperApi.md#keeperbyproductidfoldersget) | **GET** /keeper/{productId}/folders | [] Get all folders
[**KeeperByProductIdFoldersPost**](KeeperApi.md#keeperbyproductidfolderspost) | **POST** /keeper/{productId}/folders | [] Create a folder
[**KeeperByProductIdVersionsByFileIdGet**](KeeperApi.md#keeperbyproductidversionsbyfileidget) | **GET** /keeper/{productId}/versions/{fileId} | [] Get all the versions&#39; details for a specific file
[**KeeperByProductIdVersionsDiffPost**](KeeperApi.md#keeperbyproductidversionsdiffpost) | **POST** /keeper/{productId}/versions/diff | [] Compare a local file to a specific version
[**KeeperByProductIdVersionsPost**](KeeperApi.md#keeperbyproductidversionspost) | **POST** /keeper/{productId}/versions | [] Create a version for an existing file


<a name="keeperbyproductidfilesbyfileiddelete"></a>
# **KeeperByProductIdFilesByFileIdDelete**
> void KeeperByProductIdFilesByFileIdDelete (string fileId, string productId)

[] Delete a file

Its fingerprint will stay in the blockchain, but we won't show it to you anymore.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFilesByFileIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Delete a file
                apiInstance.KeeperByProductIdFilesByFileIdDelete(fileId, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFilesByFileIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfilesbyfileidget"></a>
# **KeeperByProductIdFilesByFileIdGet**
> KeeperFile KeeperByProductIdFilesByFileIdGet (string fileId, string productId)

[] Get a file's details.

Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFilesByFileIdGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get a file's details.
                KeeperFile result = apiInstance.KeeperByProductIdFilesByFileIdGet(fileId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFilesByFileIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**KeeperFile**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfilesdifflatestpost"></a>
# **KeeperByProductIdFilesDiffLatestPost**
> BreadcrumbingCompareResponse KeeperByProductIdFilesDiffLatestPost (string fileId, System.IO.Stream file, string productId, bool? mustGenerateFileDiff = null, string request = null)

[] Compare a local file to the latest version

Compare a local file to the latest version of a file that's been stored in the blockchain. We will compare their  fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is  either Text, JSON or an image, then a file highlighting the differences will be generated.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFilesDiffLatestPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var mustGenerateFileDiff = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Compare a local file to the latest version
                BreadcrumbingCompareResponse result = apiInstance.KeeperByProductIdFilesDiffLatestPost(fileId, file, productId, mustGenerateFileDiff, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFilesDiffLatestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **mustGenerateFileDiff** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfilesdiffpost"></a>
# **KeeperByProductIdFilesDiffPost**
> BreadcrumbingCompareResponse KeeperByProductIdFilesDiffPost (string fileId, System.IO.Stream file, string productId, bool? mustGenerateFileDiff = null, string request = null)

[] Compare a local file to the original version

Compare a local file to the original version of a file that's been stored in the blockchain. We will compare their  fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is  either Text, JSON or an image, then a file highlighting the differences will be generated.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFilesDiffPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var mustGenerateFileDiff = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Compare a local file to the original version
                BreadcrumbingCompareResponse result = apiInstance.KeeperByProductIdFilesDiffPost(fileId, file, productId, mustGenerateFileDiff, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFilesDiffPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **mustGenerateFileDiff** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfilesexistpost"></a>
# **KeeperByProductIdFilesExistPost**
> bool? KeeperByProductIdFilesExistPost (System.IO.Stream file, string productId, string accuracy = null, string request = null)

[] Check if a file already exists

We will verify if we have the fingerprint of the file you sent.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFilesExistPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var accuracy = accuracy_example;  // string |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Check if a file already exists
                bool? result = apiInstance.KeeperByProductIdFilesExistPost(file, productId, accuracy, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFilesExistPost: " + e.Message );
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
 **accuracy** | **string**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfilesget"></a>
# **KeeperByProductIdFilesGet**
> List<KeeperFile> KeeperByProductIdFilesGet (string productId, string displayName = null, int? limit = null, int? offset = null, string request = null)

[] Get all files

Get all the files stored in Keeper.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFilesGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var displayName = displayName_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Get all files
                List&lt;KeeperFile&gt; result = apiInstance.KeeperByProductIdFilesGet(productId, displayName, limit, offset, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **displayName** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**List<KeeperFile>**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfilespost"></a>
# **KeeperByProductIdFilesPost**
> KeeperFile KeeperByProductIdFilesPost (System.IO.Stream file, string displayName, string productId, string accuracy = null, string request = null)

[] Create a file

This will create a cryptographic representation of the file and store its fingerprint in the blockchain.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFilesPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var displayName = displayName_example;  // string | 
            var productId = productId_example;  // string | 
            var accuracy = accuracy_example;  // string |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Create a file
                KeeperFile result = apiInstance.KeeperByProductIdFilesPost(file, displayName, productId, accuracy, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFilesPost: " + e.Message );
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
 **accuracy** | **string**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**KeeperFile**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfoldersbyfolderiddelete"></a>
# **KeeperByProductIdFoldersByFolderIdDelete**
> void KeeperByProductIdFoldersByFolderIdDelete (string productId, string folderId)

[] Delete a folder

This will also delete all the files it contains.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFoldersByFolderIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var folderId = folderId_example;  // string | 

            try
            {
                // [] Delete a folder
                apiInstance.KeeperByProductIdFoldersByFolderIdDelete(productId, folderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFoldersByFolderIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **folderId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfoldersbyfolderidget"></a>
# **KeeperByProductIdFoldersByFolderIdGet**
> KeeperFolder KeeperByProductIdFoldersByFolderIdGet (string productId, string folderId)

[] Get a specific folder's details

Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFoldersByFolderIdGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var folderId = folderId_example;  // string | 

            try
            {
                // [] Get a specific folder's details
                KeeperFolder result = apiInstance.KeeperByProductIdFoldersByFolderIdGet(productId, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFoldersByFolderIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **folderId** | **string**|  | 

### Return type

[**KeeperFolder**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfoldersget"></a>
# **KeeperByProductIdFoldersGet**
> List<KeeperFolder> KeeperByProductIdFoldersGet (string productId, string name = null)

[] Get all folders

Get all folders that have been created in Keeper.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFoldersGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var name = name_example;  // string |  (optional) 

            try
            {
                // [] Get all folders
                List&lt;KeeperFolder&gt; result = apiInstance.KeeperByProductIdFoldersGet(productId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **name** | **string**|  | [optional] 

### Return type

[**List<KeeperFolder>**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidfolderspost"></a>
# **KeeperByProductIdFoldersPost**
> KeeperFolder KeeperByProductIdFoldersPost (string productId, KeeperFolderCreateRequest request = null)

[] Create a folder

This is necessary to add files in Keeper.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdFoldersPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var request = new KeeperFolderCreateRequest(); // KeeperFolderCreateRequest |  (optional) 

            try
            {
                // [] Create a folder
                KeeperFolder result = apiInstance.KeeperByProductIdFoldersPost(productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **string**|  | 
 **request** | [**KeeperFolderCreateRequest**](KeeperFolderCreateRequest.md)|  | [optional] 

### Return type

[**KeeperFolder**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidversionsbyfileidget"></a>
# **KeeperByProductIdVersionsByFileIdGet**
> List<KeeperFileVersion> KeeperByProductIdVersionsByFileIdGet (string fileId, string productId)

[] Get all the versions' details for a specific file

Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdVersionsByFileIdGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 

            try
            {
                // [] Get all the versions' details for a specific file
                List&lt;KeeperFileVersion&gt; result = apiInstance.KeeperByProductIdVersionsByFileIdGet(fileId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdVersionsByFileIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **productId** | **string**|  | 

### Return type

[**List<KeeperFileVersion>**](KeeperFileVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidversionsdiffpost"></a>
# **KeeperByProductIdVersionsDiffPost**
> BreadcrumbingCompareResponse KeeperByProductIdVersionsDiffPost (string versionId, string fileId, System.IO.Stream file, string productId, bool? generateDiffFile = null, string request = null)

[] Compare a local file to a specific version

We will compare their  fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is  either Text, JSON or an image, then a file highlighting the differences will be generated.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdVersionsDiffPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var versionId = versionId_example;  // string | 
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var generateDiffFile = true;  // bool? |  (optional) 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Compare a local file to a specific version
                BreadcrumbingCompareResponse result = apiInstance.KeeperByProductIdVersionsDiffPost(versionId, fileId, file, productId, generateDiffFile, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdVersionsDiffPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **versionId** | **string**|  | 
 **fileId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **generateDiffFile** | **bool?**|  | [optional] 
 **request** | **string**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperbyproductidversionspost"></a>
# **KeeperByProductIdVersionsPost**
> KeeperFileVersion KeeperByProductIdVersionsPost (string fileId, System.IO.Stream file, string productId, string request = null)

[] Create a version for an existing file

This new version will also have its fingerprint stored in the blockchain.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperByProductIdVersionsPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var request = request_example;  // string |  (optional) 

            try
            {
                // [] Create a version for an existing file
                KeeperFileVersion result = apiInstance.KeeperByProductIdVersionsPost(fileId, file, productId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperByProductIdVersionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **request** | **string**|  | [optional] 

### Return type

[**KeeperFileVersion**](KeeperFileVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

