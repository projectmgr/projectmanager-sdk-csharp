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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to TaskMetadata
    /// </summary>
    public interface ITaskMetadataClient
    {

        /// <summary>
        /// Adds a metadata to a task
        /// </summary>
        /// <param name="taskId">Task ID</param>
        /// <param name="isSystem">If metadata is for system or customer, isSystem = true is only of ProjectManager</param>
        /// <param name="isOverride">If false we merge with the keys</param>
        /// <param name="body">The metadata</param>
        Task<AstroResult<string>> AddMetadata(Guid taskId, TaskMetadataUpdateDto body, bool? isSystem = null, bool? isOverride = null);

        /// <summary>
        /// Get tasks by project ID and foreign key ID
        /// </summary>
        /// <param name="foreignKey">Foreign Key ID</param>
        /// <param name="projectId">Project ID</param>
        /// <param name="isSystem">If metadata is for system or customer, isSystem = true is only of ProjectManager</param>
        Task<AstroResult<TaskMetadataSearchDto[]>> TaskMetadataSearch(Guid projectId, string foreignKey = null, bool? isSystem = null);
    }
}
