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
    /// API methods related to TaskLink
    /// </summary>
    public interface ITaskLinkClient
    {

        /// <summary>
        /// Creates a new link (dependency) from this Task to another Task in the same Project.
        ///
        /// A Task Link connects a predecessor Task to a successor Task, indicating a scheduling
        /// dependency between them. The link type controls how the two Tasks&#39; dates relate to
        /// each other, and lag adds (or, if negative, removes) time between them.
        ///
        /// Valid LinkType values (case-insensitive): finishToStart, startToStart, finishToFinish, startToFinish.
        /// Omitting LinkType defaults to finishToStart.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task for this link</param>
        /// <param name="body">The Task to link to, along with the link type and lag</param>
        Task<AstroResult<ChangeSetStatusDto>> CreateTaskLink(Guid taskId, TaskLinkCreateDto body);

        /// <summary>
        /// Updates the link type and/or lag of an existing link between this Task and another Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task for this link</param>
        /// <param name="successorTaskId">The unique identifier of the successor Task for this link</param>
        /// <param name="body">The new link type and lag for this link</param>
        Task<AstroResult<ChangeSetStatusDto>> UpdateTaskLink(Guid taskId, Guid successorTaskId, TaskLinkUpdateDto body);

        /// <summary>
        /// Removes an existing link between this Task and another Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task for this link</param>
        /// <param name="successorTaskId">The unique identifier of the successor Task for this link</param>
        Task<AstroResult<ChangeSetStatusDto>> DeleteTaskLink(Guid taskId, Guid successorTaskId);

        /// <summary>
        /// Retrieve the existing links from this Task to other Tasks.
        /// </summary>
        /// <param name="taskId">The unique identifier of the predecessor Task</param>
        Task<AstroResult<TaskLinkDto[]>> RetrieveTaskLinks(Guid taskId);
    }
}
