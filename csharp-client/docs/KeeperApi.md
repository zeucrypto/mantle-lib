# mantle.lib.Api.KeeperApi

All URIs are relative to *http://dev.api.mantle.services*

Method | HTTP request | Description
------------- | ------------- | -------------
[**KeeperFilesByFileIdDelete**](KeeperApi.md#keeperfilesbyfileiddelete) | **DELETE** /keeper/files/{fileId} | [FILES] Delete a file from Keeper. Its fingerprint will stay in the blockchain, but we won&#39;t show it to you anymore. Requires the Keeper Admin Role.
[**KeeperFilesByFileIdGet**](KeeperApi.md#keeperfilesbyfileidget) | **GET** /keeper/files/{fileId} | [FILES] Get a file&#39;s details. Requires the Keeper Admin Role.
[**KeeperFilesDiffPost**](KeeperApi.md#keeperfilesdiffpost) | **POST** /keeper/files/diff | [FILES] Compare a local file to the original version of a file that&#39;s been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare&#39;s type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.
[**KeeperFilesDiffWithLatestPost**](KeeperApi.md#keeperfilesdiffwithlatestpost) | **POST** /keeper/files/diffwithlatest | [FILES] Compare a local file to the latest version of a file that&#39;s been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare&#39;s type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.
[**KeeperFilesExistPost**](KeeperApi.md#keeperfilesexistpost) | **POST** /keeper/files/exist | [FILES] Check if a file already exists in Keeper. We will verify if we have the fingerprint of the file you sent. Requires the Keeper Admin Role.
[**KeeperFilesGet**](KeeperApi.md#keeperfilesget) | **GET** /keeper/files | [FILES] Get all the files stored in Keeper. Requires the Keeper Admin Role.
[**KeeperFilesPost**](KeeperApi.md#keeperfilespost) | **POST** /keeper/files | [FILES] Add a file to Keeper. This will create a cryptographic representation of the file and store its fingerprint in the blockchain. Requires the Keeper Admin Role.
[**KeeperFoldersByFolderIdDelete**](KeeperApi.md#keeperfoldersbyfolderiddelete) | **DELETE** /keeper/folders/{folderId} | [FOLDERS] Delete a folder in Keeper. This will also delete all the files it contains. Requires the Keeper Admin Role.
[**KeeperFoldersByFolderIdGet**](KeeperApi.md#keeperfoldersbyfolderidget) | **GET** /keeper/folders/{folderId} | [FOLDERS] Get a specific folder&#39;s details. Requires the Keeper Admin Role.
[**KeeperFoldersGet**](KeeperApi.md#keeperfoldersget) | **GET** /keeper/folders | [FOLDERS] Get all folders that have been created in Keeper. Requires the Keeper Admin Role.
[**KeeperFoldersPost**](KeeperApi.md#keeperfolderspost) | **POST** /keeper/folders | [FOLDERS] Create a folder in Keeper. This is necessary to add files in Keeper. Requires the Keeper Admin Role.
[**KeeperVersionsByFileIdGet**](KeeperApi.md#keeperversionsbyfileidget) | **GET** /keeper/versions/{fileId} | [VERSIONS] Get all the versions&#39; details for a specific file. Requires the Keeper Admin Role.
[**KeeperVersionsDiffPost**](KeeperApi.md#keeperversionsdiffpost) | **POST** /keeper/versions/diff | [VERSIONS] Compare a local file to a specific version of a file that&#39;s been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare&#39;s type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.
[**KeeperVersionsPost**](KeeperApi.md#keeperversionspost) | **POST** /keeper/versions | [VERSIONS] Create a version for an existing file. This new version will also have its fingerprint stored in the blockchain. Requires the Keeper Admin Role.


<a name="keeperfilesbyfileiddelete"></a>
# **KeeperFilesByFileIdDelete**
> void KeeperFilesByFileIdDelete (string fileId)

[FILES] Delete a file from Keeper. Its fingerprint will stay in the blockchain, but we won't show it to you anymore. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFilesByFileIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 

            try
            {
                // [FILES] Delete a file from Keeper. Its fingerprint will stay in the blockchain, but we won't show it to you anymore. Requires the Keeper Admin Role.
                apiInstance.KeeperFilesByFileIdDelete(fileId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFilesByFileIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfilesbyfileidget"></a>
# **KeeperFilesByFileIdGet**
> KeeperFile KeeperFilesByFileIdGet (string fileId)

[FILES] Get a file's details. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFilesByFileIdGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 

            try
            {
                // [FILES] Get a file's details. Requires the Keeper Admin Role.
                KeeperFile result = apiInstance.KeeperFilesByFileIdGet(fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFilesByFileIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 

### Return type

[**KeeperFile**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfilesdiffpost"></a>
# **KeeperFilesDiffPost**
> BreadcrumbingCompareResponse KeeperFilesDiffPost (string fileId, System.IO.Stream file, bool? generateDiffFile = null)

[FILES] Compare a local file to the original version of a file that's been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFilesDiffPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var generateDiffFile = true;  // bool? |  (optional) 

            try
            {
                // [FILES] Compare a local file to the original version of a file that's been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.
                BreadcrumbingCompareResponse result = apiInstance.KeeperFilesDiffPost(fileId, file, generateDiffFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFilesDiffPost: " + e.Message );
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
 **generateDiffFile** | **bool?**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfilesdiffwithlatestpost"></a>
# **KeeperFilesDiffWithLatestPost**
> BreadcrumbingCompareResponse KeeperFilesDiffWithLatestPost (string fileId, System.IO.Stream file, bool? generateDiffFile = null)

[FILES] Compare a local file to the latest version of a file that's been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFilesDiffWithLatestPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var generateDiffFile = true;  // bool? |  (optional) 

            try
            {
                // [FILES] Compare a local file to the latest version of a file that's been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.
                BreadcrumbingCompareResponse result = apiInstance.KeeperFilesDiffWithLatestPost(fileId, file, generateDiffFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFilesDiffWithLatestPost: " + e.Message );
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
 **generateDiffFile** | **bool?**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfilesexistpost"></a>
# **KeeperFilesExistPost**
> bool? KeeperFilesExistPost (string folderId, System.IO.Stream file, string accuracy = null)

[FILES] Check if a file already exists in Keeper. We will verify if we have the fingerprint of the file you sent. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFilesExistPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var folderId = folderId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var accuracy = accuracy_example;  // string |  (optional) 

            try
            {
                // [FILES] Check if a file already exists in Keeper. We will verify if we have the fingerprint of the file you sent. Requires the Keeper Admin Role.
                bool? result = apiInstance.KeeperFilesExistPost(folderId, file, accuracy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFilesExistPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **accuracy** | **string**|  | [optional] 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfilesget"></a>
# **KeeperFilesGet**
> List<KeeperFile> KeeperFilesGet (string displayName = null, string folderId = null)

[FILES] Get all the files stored in Keeper. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFilesGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var displayName = displayName_example;  // string |  (optional) 
            var folderId = folderId_example;  // string |  (optional) 

            try
            {
                // [FILES] Get all the files stored in Keeper. Requires the Keeper Admin Role.
                List&lt;KeeperFile&gt; result = apiInstance.KeeperFilesGet(displayName, folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFilesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **displayName** | **string**|  | [optional] 
 **folderId** | **string**|  | [optional] 

### Return type

[**List<KeeperFile>**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfilespost"></a>
# **KeeperFilesPost**
> KeeperFile KeeperFilesPost (string folderId, System.IO.Stream file, string displayName, string accuracy = null)

[FILES] Add a file to Keeper. This will create a cryptographic representation of the file and store its fingerprint in the blockchain. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFilesPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var folderId = folderId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var displayName = displayName_example;  // string | 
            var accuracy = accuracy_example;  // string |  (optional) 

            try
            {
                // [FILES] Add a file to Keeper. This will create a cryptographic representation of the file and store its fingerprint in the blockchain. Requires the Keeper Admin Role.
                KeeperFile result = apiInstance.KeeperFilesPost(folderId, file, displayName, accuracy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFilesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **displayName** | **string**|  | 
 **accuracy** | **string**|  | [optional] 

### Return type

[**KeeperFile**](KeeperFile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfoldersbyfolderiddelete"></a>
# **KeeperFoldersByFolderIdDelete**
> void KeeperFoldersByFolderIdDelete (string folderId)

[FOLDERS] Delete a folder in Keeper. This will also delete all the files it contains. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFoldersByFolderIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var folderId = folderId_example;  // string | 

            try
            {
                // [FOLDERS] Delete a folder in Keeper. This will also delete all the files it contains. Requires the Keeper Admin Role.
                apiInstance.KeeperFoldersByFolderIdDelete(folderId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFoldersByFolderIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfoldersbyfolderidget"></a>
# **KeeperFoldersByFolderIdGet**
> KeeperFolder KeeperFoldersByFolderIdGet (string folderId)

[FOLDERS] Get a specific folder's details. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFoldersByFolderIdGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var folderId = folderId_example;  // string | 

            try
            {
                // [FOLDERS] Get a specific folder's details. Requires the Keeper Admin Role.
                KeeperFolder result = apiInstance.KeeperFoldersByFolderIdGet(folderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFoldersByFolderIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **folderId** | **string**|  | 

### Return type

[**KeeperFolder**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfoldersget"></a>
# **KeeperFoldersGet**
> List<KeeperFolder> KeeperFoldersGet (string name = null)

[FOLDERS] Get all folders that have been created in Keeper. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFoldersGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var name = name_example;  // string |  (optional) 

            try
            {
                // [FOLDERS] Get all folders that have been created in Keeper. Requires the Keeper Admin Role.
                List&lt;KeeperFolder&gt; result = apiInstance.KeeperFoldersGet(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFoldersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | [optional] 

### Return type

[**List<KeeperFolder>**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperfolderspost"></a>
# **KeeperFoldersPost**
> KeeperFolder KeeperFoldersPost (KeeperFolderCreateRequest request = null)

[FOLDERS] Create a folder in Keeper. This is necessary to add files in Keeper. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperFoldersPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var request = new KeeperFolderCreateRequest(); // KeeperFolderCreateRequest |  (optional) 

            try
            {
                // [FOLDERS] Create a folder in Keeper. This is necessary to add files in Keeper. Requires the Keeper Admin Role.
                KeeperFolder result = apiInstance.KeeperFoldersPost(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperFoldersPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**KeeperFolderCreateRequest**](KeeperFolderCreateRequest.md)|  | [optional] 

### Return type

[**KeeperFolder**](KeeperFolder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperversionsbyfileidget"></a>
# **KeeperVersionsByFileIdGet**
> List<KeeperFileVersion> KeeperVersionsByFileIdGet (string fileId)

[VERSIONS] Get all the versions' details for a specific file. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperVersionsByFileIdGetExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 

            try
            {
                // [VERSIONS] Get all the versions' details for a specific file. Requires the Keeper Admin Role.
                List&lt;KeeperFileVersion&gt; result = apiInstance.KeeperVersionsByFileIdGet(fileId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperVersionsByFileIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileId** | **string**|  | 

### Return type

[**List<KeeperFileVersion>**](KeeperFileVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperversionsdiffpost"></a>
# **KeeperVersionsDiffPost**
> BreadcrumbingCompareResponse KeeperVersionsDiffPost (string versionId, System.IO.Stream file, bool? generateDiffFile = null)

[VERSIONS] Compare a local file to a specific version of a file that's been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperVersionsDiffPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var versionId = versionId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX
            var generateDiffFile = true;  // bool? |  (optional) 

            try
            {
                // [VERSIONS] Compare a local file to a specific version of a file that's been stored in the blockchain. We will compare their fingerprint against each other to find the differences.  The GenerateDiffFile property is false by default, and if it is set to true and the file to compare's type is either Text, JSON or an image, then a file highlighting the differences will be generated.  Requires the Keeper Admin Role.
                BreadcrumbingCompareResponse result = apiInstance.KeeperVersionsDiffPost(versionId, file, generateDiffFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperVersionsDiffPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **versionId** | **string**|  | 
 **file** | **System.IO.Stream**| The file to upload. How http file upload works: https://goo.gl/UYQ2nX | 
 **generateDiffFile** | **bool?**|  | [optional] 

### Return type

[**BreadcrumbingCompareResponse**](BreadcrumbingCompareResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="keeperversionspost"></a>
# **KeeperVersionsPost**
> KeeperFileVersion KeeperVersionsPost (string fileId, System.IO.Stream file)

[VERSIONS] Create a version for an existing file. This new version will also have its fingerprint stored in the blockchain. Requires the Keeper Admin Role.

### Example
```csharp
using System;
using System.Diagnostics;
using mantle.lib.Api;
using mantle.lib.Client;
using mantle.lib.Model;

namespace Example
{
    public class KeeperVersionsPostExample
    {
        public void main()
        {
            var apiInstance = new KeeperApi();
            var fileId = fileId_example;  // string | 
            var file = new System.IO.Stream(); // System.IO.Stream | The file to upload. How http file upload works: https://goo.gl/UYQ2nX

            try
            {
                // [VERSIONS] Create a version for an existing file. This new version will also have its fingerprint stored in the blockchain. Requires the Keeper Admin Role.
                KeeperFileVersion result = apiInstance.KeeperVersionsPost(fileId, file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KeeperApi.KeeperVersionsPost: " + e.Message );
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

### Return type

[**KeeperFileVersion**](KeeperFileVersion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

