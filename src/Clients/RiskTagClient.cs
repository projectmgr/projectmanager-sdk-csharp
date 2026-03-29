/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  ProjectManager.com, Inc.
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
    /// API methods related to RiskTag
    /// </summary>
    public class RiskTagClient : IRiskTagClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public RiskTagClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Replaces the existing tags on a Risk with a newly provided list.
        /// A tag is a connection between a Risk and a Tag. Each Risk can have zero, one or many tags.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        /// <param name="body">The replacement list of tags for this Risk</param>
        public async Task<AstroResult<TaskTagDto[]>> ReplaceRiskTags(Guid riskId, NameDto[] body)
        {
            var url = $"/api/data/risks/{riskId}/tags";
            return await _client.RequestWithBody<TaskTagDto[]>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Add one or more tags to a Risk.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        /// <param name="body">The tags to add</param>
        public async Task<AstroResult<TaskTagDto[]>> AddTagsToRisk(Guid riskId, NameDto[] body)
        {
            var url = $"/api/data/risks/{riskId}/tags";
            return await _client.RequestWithBody<TaskTagDto[]>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Removes one or more tags from a Risk.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        /// <param name="body">The tags to remove</param>
        public async Task<AstroResult<string>> RemoveTagsFromRisk(Guid riskId, NameDto[] body)
        {
            var url = $"/api/data/risks/{riskId}/tags";
            return await _client.RequestWithBody<string>(HttpMethod.Delete, url, null, body);
        }

        /// <summary>
        /// Returns the list of tags assigned to the specified Risk.
        /// </summary>
        /// <param name="riskId">The unique identifier of the Risk</param>
        public async Task<AstroResult<TaskTagDto[]>> RetrieveTagsForARisk(Guid riskId)
        {
            var url = $"/api/data/risks/{riskId}/tags";
            return await _client.Request<TaskTagDto[]>(HttpMethod.Get, url, null);
        }
    }
}
