/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
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
    /// API methods related to ResourceTeam
    /// </summary>
    public class ResourceTeamClient : IResourceTeamClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceTeamClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ResourceTeams defined within your Workspace that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A ResourceTeam is a grouping of Resources that allows you to keep track of assignments
        /// in a manner consistent with your business needs.  You can assign Resources to be members
        /// of zero, one, or many ResourceTeams.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<ResourceTeamDto[]>> RetrieveResourceTeams(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/resources/teams";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<ResourceTeamDto[]>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Create a Resource Team.
        /// </summary>
        /// <param name="body">The name of the team to create.</param>
        public async Task<AstroResult<ResourceTeamDto>> CreateResourceTeam(CreateResourceTeamDto body)
        {
            var url = $"/api/data/resources/teams";
            return await _client.RequestWithBody<ResourceTeamDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// The endpoint is used to delete a resource team. Users assigned to this team will no longer be assigned thereafter.
        /// </summary>
        /// <param name="resourceTeamId">The Id of the team to be removed.</param>
        public async Task<AstroResult<string>> DeleteResourceTeam(Guid resourceTeamId)
        {
            var url = $"/api/data/resources/teams/{resourceTeamId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Update a Resource Team.
        /// </summary>
        /// <param name="teamresourceId">The id of the resource team</param>
        /// <param name="body">The name of the team to Update.</param>
        public async Task<AstroResult<ResourceTeamDto>> UpdateResourceTeam(Guid teamresourceId, UpdateResourceTeamDto body)
        {
            var url = $"/api/data/resources/teams/{teamresourceId}";
            return await _client.RequestWithBody<ResourceTeamDto>(HttpMethod.Put, url, null, body);
        }
    }
}
