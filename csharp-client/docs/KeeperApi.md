# mantle.lib.Mantle.lib.KeeperApi

All URIs are relative to *http://api.mantleblockchain.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompareVersion**](KeeperApi.md#compareversion) | **POST** /keeper/{productId}/files/{fileId}/versions/compare/{versionId} | [VERSIONS] Compare a local file to a version
[**CompareWithLatestFileVersion**](KeeperApi.md#comparewithlatestfileversion) | **POST** /keeper/{productId}/files/{fileId}/compare/latest | [FILES] Compare a local file to the latest version
[**CompareWithOriginalFile**](KeeperApi.md#comparewithoriginalfile) | **POST** /keeper/{productId}/files/{fileId}/compare/original | [FILES] Compare a local file to the original version
[**CreateFile**](KeeperApi.md#createfile) | **POST** /keeper/{productId}/files | [FILES] Create a file
[**CreateFolder**](KeeperApi.md#createfolder) | **POST** /keeper/{productId}/folders | [FOLDERS] Create a folder
[**CreateVersion**](KeeperApi.md#createversion) | **POST** /keeper/{productId}/files/{fileId}/versions | [VERSIONS] Create a version for an existing file
[**DeleteFileById**](KeeperApi.md#deletefilebyid) | **DELETE** /keeper/{productId}/files/{fileId} | [FILES] Delete a file
[**DeleteFolder**](KeeperApi.md#deletefolder) | **DELETE** /keeper/{productId}/folders/{folderId} | [FOLDERS] Delete a folder
[**DoesFileExist**](KeeperApi.md#doesfileexist) | **POST** /keeper/{productId}/files/exist | [FILES] Check if a file already exists
[**GetAllFiles**](KeeperApi.md#getallfiles) | **GET** /keeper/{productId}/files | [FILES] Get all files
[**GetAllFolders**](KeeperApi.md#getallfolders) | **GET** /keeper/{productId}/folders | [FOLDERS] Get all folders
[**GetAllVersions**](KeeperApi.md#getallversions) | **GET** /keeper/{productId}/files/{fileId}/versions | [VERSIONS] Get all the versions&#39; details for a file
[**GetFileById**](KeeperApi.md#getfilebyid) | **GET** /keeper/{productId}/files/{fileId} | [FILES] Get a file&#39;s details.
[**GetFolderById**](KeeperApi.md#getfolderbyid) | **GET** /keeper/{productId}/folders/{folderId} | [FOLDERS] Get folder details


<a name="compareversion"></a>
# **CompareVersion**
> BreadcrumbingCompareResponse CompareVersion (string fileId, string versionId, System.IO.Stream file, string productId, string xApiKey, bool? mustGenerateCompareResult = null)

[VERSIONS] Compare a local file to a version

It will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is  either Text, JSON or an image, then a file highlighting the differences will be generated.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CompareVersionExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var versionId = versionId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var mustGenerateCompareResult = true;  // bool? |  (optional) 

            try
            {
                // [VERSIONS] Compare a local file to a version
                BreadcrumbingCompareResponse result = apiInstance.CompareVersion(fileId, versionId, file, productId, xApiKey, mustGenerateCompareResult);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.CompareVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 
 **versionId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **mustGenerateCompareResult** | **bool?**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comparewithlatestfileversion"></a>
# **CompareWithLatestFileVersion**
> BreadcrumbingCompareResponse CompareWithLatestFileVersion (string fileId, System.IO.Stream file, string productId, string xApiKey, bool? mustGenerateCompareResult = null)

[FILES] Compare a local file to the latest version

Compare a local file to the latest version of a file that's been stored in the blockchain. It will compare their  fingerprint against each other to find the differences.  The MustGenerateCompareResult property is false by default, and if it is set to true and the file's type is  either Text, JSON or an image, then a file highlighting the differences will be generated.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CompareWithLatestFileVersionExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var mustGenerateCompareResult = true;  // bool? |  (optional) 

            try
            {
                // [FILES] Compare a local file to the latest version
                BreadcrumbingCompareResponse result = apiInstance.CompareWithLatestFileVersion(fileId, file, productId, xApiKey, mustGenerateCompareResult);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.CompareWithLatestFileVersion: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **mustGenerateCompareResult** | **bool?**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comparewithoriginalfile"></a>
# **CompareWithOriginalFile**
> BreadcrumbingCompareResponse CompareWithOriginalFile (string fileId, System.IO.Stream file, string productId, string xApiKey, bool? mustGenerateCompareResult = null)

[FILES] Compare a local file to the original version

Compare a local file to the original version of a file that's been stored in the blockchain. It will compare their  fingerprint against each other to find the differences.  The MustGenerateCompareResult property is false by default, and if it is set to true and the file's type is  either Text, JSON or an image, then a file highlighting the differences will be generated.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CompareWithOriginalFileExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var mustGenerateCompareResult = true;  // bool? |  (optional) 

            try
            {
                // [FILES] Compare a local file to the original version
                BreadcrumbingCompareResponse result = apiInstance.CompareWithOriginalFile(fileId, file, productId, xApiKey, mustGenerateCompareResult);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.CompareWithOriginalFile: " + e.Message );
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
 **xApiKey** | **string**|  | 
 **mustGenerateCompareResult** | **bool?**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfile"></a>
# **CreateFile**
> KeeperFile CreateFile (string accuracy, System.IO.Stream file, string displayName, string productId, string xApiKey, string folderId = null)

[FILES] Create a file

This will create a cryptographic representation of the file and store its fingerprint in the blockchain.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateFileExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var accuracy = accuracy_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var displayName = displayName_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                // [FILES] Create a file
                KeeperFile result = apiInstance.CreateFile(accuracy, file, displayName, productId, xApiKey, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.CreateFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accuracy** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **displayName** | **string**|  | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **folderId** | **string**|  | [optional] 

### Return type

[**KeeperFile**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfolder"></a>
# **CreateFolder**
> KeeperFolder CreateFolder (string productId, string xApiKey, KeeperFolderCreateRequest request = null)

[FOLDERS] Create a folder

A folder is necessary to add files in Keeper.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateFolderExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var request = new KeeperFolderCreateRequest(); // KeeperFolderCreateRequest |  (optional) 

            try
            {
                // [FOLDERS] Create a folder
                KeeperFolder result = apiInstance.CreateFolder(productId, xApiKey, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.CreateFolder: " + e.Message );
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
 **request** | [**KeeperFolderCreateRequest**](KeeperFolderCreateRequest.md)|  | [optional] 

### Return type

[**KeeperFolder**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createversion"></a>
# **CreateVersion**
> KeeperFileVersion CreateVersion (string fileId, System.IO.Stream file, string productId, string xApiKey)

[VERSIONS] Create a version for an existing file

This new version will also have its fingerprint stored in the blockchain.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class CreateVersionExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [VERSIONS] Create a version for an existing file
                KeeperFileVersion result = apiInstance.CreateVersion(fileId, file, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.CreateVersion: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**KeeperFileVersion**](KeeperFileVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefilebyid"></a>
# **DeleteFileById**
> void DeleteFileById (string fileId, string productId, string xApiKey)

[FILES] Delete a file

Its fingerprint will stay in the blockchain, but it will not be accessible and visible.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteFileByIdExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [FILES] Delete a file
                apiInstance.DeleteFileById(fileId, productId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.DeleteFileById: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (string productId, string folderId, string xApiKey)

[FOLDERS] Delete a folder

This will also delete all the files it contains.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var folderId = folderId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [FOLDERS] Delete a folder
                apiInstance.DeleteFolder(productId, folderId, xApiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.DeleteFolder: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="doesfileexist"></a>
# **DoesFileExist**
> bool? DoesFileExist (string accuracy, System.IO.Stream file, string productId, string xApiKey, string folderId = null)

[FILES] Check if a file already exists

Verify if the file's fingerprint exist.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class DoesFileExistExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var accuracy = accuracy_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                // [FILES] Check if a file already exists
                bool? result = apiInstance.DoesFileExist(accuracy, file, productId, xApiKey, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.DoesFileExist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accuracy** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **productId** | **string**|  | 
 **xApiKey** | **string**|  | 
 **folderId** | **string**|  | [optional] 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallfiles"></a>
# **GetAllFiles**
> List<KeeperFile> GetAllFiles (string productId, string xApiKey, string displayName = null, int? limit = null, int? offset = null, string folderId = null)

[FILES] Get all files

Get all the files stored in Keeper.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllFilesExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var displayName = displayName_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var offset = 56;  // int? |  (optional) 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                // [FILES] Get all files
                List&lt;KeeperFile&gt; result = apiInstance.GetAllFiles(productId, xApiKey, displayName, limit, offset, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.GetAllFiles: " + e.Message );
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
 **displayName** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **offset** | **int?**|  | [optional] 
 **folderId** | **string**|  | [optional] 

### Return type

[**List<KeeperFile>**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallfolders"></a>
# **GetAllFolders**
> List<KeeperFolder> GetAllFolders (string productId, string xApiKey, string name = null)

[FOLDERS] Get all folders

Get all folders that have been created in Keeper.                Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllFoldersExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 
            var name = name_example;  // string |  (optional) 

            try
            {
                // [FOLDERS] Get all folders
                List&lt;KeeperFolder&gt; result = apiInstance.GetAllFolders(productId, xApiKey, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.GetAllFolders: " + e.Message );
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
 **name** | **string**|  | [optional] 

### Return type

[**List<KeeperFolder>**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallversions"></a>
# **GetAllVersions**
> List<KeeperFileVersion> GetAllVersions (string fileId, string productId, string xApiKey)

[VERSIONS] Get all the versions' details for a file

Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetAllVersionsExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [VERSIONS] Get all the versions' details for a file
                List&lt;KeeperFileVersion&gt; result = apiInstance.GetAllVersions(fileId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.GetAllVersions: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**List<KeeperFileVersion>**](KeeperFileVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfilebyid"></a>
# **GetFileById**
> KeeperFile GetFileById (string fileId, string productId, string xApiKey)

[FILES] Get a file's details.

Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetFileByIdExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var productId = productId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [FILES] Get a file's details.
                KeeperFile result = apiInstance.GetFileById(fileId, productId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.GetFileById: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**KeeperFile**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfolderbyid"></a>
# **GetFolderById**
> KeeperFolder GetFolderById (string productId, string folderId, string xApiKey)

[FOLDERS] Get folder details

Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Mantle.lib;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class GetFolderByIdExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var productId = productId_example;  // string | 
            var folderId = folderId_example;  // string | 
            var xApiKey = xApiKey_example;  // string | 

            try
            {
                // [FOLDERS] Get folder details
                KeeperFolder result = apiInstance.GetFolderById(productId, folderId, xApiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.GetFolderById: " + e.Message );
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
 **xApiKey** | **string**|  | 

### Return type

[**KeeperFolder**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

