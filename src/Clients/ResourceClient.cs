/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to Resource
    /// </summary>
    public class ResourceClient : IResourceClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Create a new Resource within your Workspace.
        ///
        /// A Resource represents a person, material, or tool that is used within your Projects. When you attach a Resources to more than one Task, the software will schedule the usage of your Resource so that it is not allocated to more than one Task at the same time. The users in your Workspace are also considered Resources.  To invite a new User to your Workspace, create a new Resource for that user.
        ///
        /// </summary>
        /// <param name="body">The details for the new Resource to create</param>
        public async Task<AstroResult<ResourceDto>> CreateResource(ResourceCreateDto body)
        {
            var url = $"/project-api/public/resources";
            return await _client.Request<ResourceDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Retrieve a list of Resources that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Resource represents a person, material, or tool that is used within your Projects. When you attach a Resources to more than one Task, the software will schedule the usage of your Resource so that it is not allocated to more than one Task at the same time. The users in your Workspace are also considered Resources.  To invite a new User to your Workspace, create a new Resource for that user.
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="select">Specify which properties should be returned</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<ResourceDto[]>> QueryResources(int? top = null, int? skip = null, string filter = null, string select = null, string orderby = null, string expand = null)
        {
            var url = $"/project-api/public/resources";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (select != null) { options["$select"] = select; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<ResourceDto[]>(HttpMethod.Get, url, options, null, null);
        }
    }
}
