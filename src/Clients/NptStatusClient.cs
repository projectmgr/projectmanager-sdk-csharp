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
    /// API methods related to NptStatus
    /// </summary>
    public class NptStatusClient : INptStatusClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public NptStatusClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Get a list of task statuses that can be used by non-protect tasks.
        /// </summary>
        public async Task<AstroResult<NptStatusDto[]>> GetNptTaskStatuses()
        {
            var url = $"/api/data/non-project-tasks/statuses";
            return await _client.Request<NptStatusDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a new status level for non-project tasks.
        /// </summary>
        /// <param name="body">Information about the new status level to create</param>
        public async Task<AstroResult<NptStatusDto>> CreateNptTaskStatus(NptStatusCreateDto body)
        {
            var url = $"/api/data/non-project-tasks/statuses";
            return await _client.RequestWithBody<NptStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates an existing status level for non-project tasks.
        /// </summary>
        /// <param name="nptStatusId">The unique identifier of the status to update</param>
        /// <param name="body">Information about the status level to update</param>
        public async Task<AstroResult<NptStatusDto>> UpdateNptTaskStatus(Guid nptStatusId, NptStatusUpdateDto body)
        {
            var url = $"/api/data/non-project-tasks/statuses/{nptStatusId}";
            return await _client.RequestWithBody<NptStatusDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Deletes an existing status level for non-project tasks.
        ///
        /// You will not be able to delete a status if there are tasks assigned to it
        /// or if it is the default status level.
        /// </summary>
        /// <param name="nptStatusId">The unique identifier of the status to delete</param>
        public async Task<AstroResult<string>> DeleteNptTaskStatus(Guid nptStatusId)
        {
            var url = $"/api/data/non-project-tasks/statuses/{nptStatusId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
