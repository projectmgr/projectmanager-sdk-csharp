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
    /// API methods related to ResourceSkill
    /// </summary>
    public class ResourceSkillClient : IResourceSkillClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ResourceSkillClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ResourceSkills defined within your Workspace.
        ///
        /// A ResourceSkill is a capability possessed by a Resource that can be used to distinguish different classes of Resources suitable for use by a Task.  You can specify that a Task requires a Resource with a particular set of ResourceSkills and then allocate Resources based on whether or not they have the suitable ResourceSkills.
        ///
        /// </summary>
        public async Task<AstroResult<BusinessSkillDto[]>> RetrieveResourceSkills()
        {
            var url = $"/api/data/resources/skills";
            return await _client.Request<BusinessSkillDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
