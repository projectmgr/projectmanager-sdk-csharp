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
    /// API methods related to TaskMetadata
    /// </summary>
    public class TaskMetadataClient : ITaskMetadataClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskMetadataClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Adds a metadata to a task
        /// </summary>
        /// <param name="taskId">Task ID</param>
        /// <param name="isSystem">If metadata is for system or customer, isSystem = true is only of ProjectManager</param>
        /// <param name="isOverride">If false we merge with the keys</param>
        /// <param name="body">The metadata</param>
        public async Task<AstroResult<string>> AddMetadata(Guid taskId, TaskMetadataUpdateDto body, bool? isSystem = null, bool? isOverride = null)
        {
            var url = $"/api/data/tasks/{taskId}/metadata";
            var options = new Dictionary<string, object>();
            if (isSystem != null) { options["isSystem"] = isSystem; }
            if (isOverride != null) { options["isOverride"] = isOverride; }
            return await _client.RequestWithBody<string>(HttpMethod.Put, url, options, body);
        }

        /// <summary>
        /// Get tasks by project ID and foreign key ID
        /// </summary>
        /// <param name="foreignKey">Foreign Key ID</param>
        /// <param name="projectId">Project ID</param>
        /// <param name="isSystem">If metadata is for system or customer, isSystem = true is only of ProjectManager</param>
        public async Task<AstroResult<TaskMetadataSearchDto[]>> TaskMetadataSearch(Guid projectId, string foreignKey = null, bool? isSystem = null)
        {
            var url = $"/api/data/projects/{projectId}/tasks/metadata";
            var options = new Dictionary<string, object>();
            if (foreignKey != null) { options["foreignKey"] = foreignKey; }
            if (isSystem != null) { options["isSystem"] = isSystem; }
            return await _client.Request<TaskMetadataSearchDto[]>(HttpMethod.Get, url, options);
        }
    }
}
