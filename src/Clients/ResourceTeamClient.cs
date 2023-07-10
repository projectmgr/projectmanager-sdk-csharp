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
        /// Retrieves all ResourceTeams defined within your Workspace.
        ///
        /// A ResourceTeam is a grouping of Resources that allows you to keep track of assignments in a manner consistent with your business needs.  You can assign Resources to be members of zero, one, or many ResourceTeams.
        ///
        /// </summary>
        public async Task<AstroResult<BusinessTeamDto[]>> RetrieveResourceTeams()
        {
            var url = $"/project-api/public/resources/teams";
            return await _client.Request<BusinessTeamDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
