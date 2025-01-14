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
    /// API methods related to Teams
    /// </summary>
    public class TeamsClient : ITeamsClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TeamsClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves zip file for teams integrations.
        ///
        /// The Teams API is intended for use by ProjectManager and its business development partners.  Please
        /// contact ProjectManager&#39;s sales team to request use of this API.
        /// </summary>
        public async Task<AstroResult<byte[]>> RetrieveZipFileForTeamsIntegrations()
        {
            var url = $"/api/data/integrations/teams/application";
            return await _client.Request<byte[]>(HttpMethod.Get, url, null);
        }
    }
}
