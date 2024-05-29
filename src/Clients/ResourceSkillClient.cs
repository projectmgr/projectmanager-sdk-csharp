/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
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
        /// A ResourceSkill is a capability possessed by a Resource that can be used to distinguish
        /// different classes of Resources suitable for use by a Task.  You can specify that a Task
        /// requires a Resource with a particular set of ResourceSkills and then allocate Resources
        /// based on whether or not they have the suitable ResourceSkills.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<ResourceSkillDto[]>> RetrieveResourceSkills(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/resources/skills";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<ResourceSkillDto[]>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Create a Resource Skill.
        /// </summary>
        /// <param name="body">The name of the skill to create.</param>
        public async Task<AstroResult<ResourceSkillDto>> CreateResourceSkill(CreateResourceSkillDto body)
        {
            var url = $"/api/data/resources/skills";
            return await _client.Request<ResourceSkillDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Update a Resource Skill.
        /// </summary>
        /// <param name="skillId">The id of the skill to update.</param>
        /// <param name="body">The data of the skill to update.</param>
        public async Task<AstroResult<ResourceSkillDto>> UpdateResourceSkill(Guid skillId, UpdateResourceSkillDto body)
        {
            var url = $"/api/data/resources/skills/{skillId}";
            return await _client.Request<ResourceSkillDto>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// The endpoint is used to delete a resource skill. Users assigned to this skill will no longer be assigned thereafter.
        /// </summary>
        /// <param name="resourceSkillId">The Id of the skill to be removed.</param>
        public async Task<AstroResult<string>> DeleteResourceSkill(Guid resourceSkillId)
        {
            var url = $"/api/data/resources/skills/{resourceSkillId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }
    }
}
