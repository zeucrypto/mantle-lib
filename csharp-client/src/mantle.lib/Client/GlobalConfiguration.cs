/* 
 * Mantle API
 *
 * Most endpoints require authentication with an API key.  You must first authenticate with your account by logging in your account on app.mantle.services. Then, you will need to navigate to the \"My API Key\" page in the Administration section. You might need to have the user administrator of your organization generate you an API Key first.  You must then use this API Key in all your requests with the following header:  [ x-api-key: API_KEY ].
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace mantle.lib.Client
{
    /// <summary>
    /// <see cref="GlobalConfiguration"/> provides a compile-time extension point for globally configuring
    /// API Clients.
    /// </summary>
    /// <remarks>
    /// A customized implementation via partial class may reside in another file and may
    /// be excluded from automatic generation via a .swagger-codegen-ignore file.
    /// </remarks>
    public partial class GlobalConfiguration : Configuration
    {

    }
}