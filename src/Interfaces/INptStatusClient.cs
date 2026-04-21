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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to NptStatus
    /// </summary>
    public interface INptStatusClient
    {

        /// <summary>
        /// Get a list of task statuses that can be used by non-protect tasks.
        /// </summary>
        Task<AstroResult<NptStatusDto[]>> GetNptTaskStatuses();

        /// <summary>
        /// Creates a new status level for non-project tasks.
        /// </summary>
        /// <param name="body">Information about the new status level to create</param>
        Task<AstroResult<NptStatusDto>> CreateNptTaskStatus(NptStatusCreateDto body);

        /// <summary>
        /// Updates an existing status level for non-project tasks.
        /// </summary>
        /// <param name="nptStatusId">The unique identifier of the status to update</param>
        /// <param name="body">Information about the status level to update</param>
        Task<AstroResult<NptStatusDto>> UpdateNptTaskStatus(Guid nptStatusId, NptStatusUpdateDto body);

        /// <summary>
        /// Deletes an existing status level for non-project tasks.
        ///
        /// You will not be able to delete a status if there are tasks assigned to it
        /// or if it is the default status level.
        /// </summary>
        /// <param name="nptStatusId">The unique identifier of the status to delete</param>
        Task<AstroResult<string>> DeleteNptTaskStatus(Guid nptStatusId);
    }
}
