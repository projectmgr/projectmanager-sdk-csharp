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
    /// API methods related to Task
    /// </summary>
    public interface ITaskClient
    {

        /// <summary>
        /// Retrieve a list of Tasks that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A
        /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
        /// indicate whether they have a dependency or a connection.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<TaskDto[]>> QueryTasks(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Retrieve a Task by its unique identifier or by its short ID.  A Task has both a unique
        /// identifier, which is a GUID, and a short ID, which is a small text label that is unique
        /// only within your Workspace.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A
        /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
        /// indicate whether they have a dependency or a connection.
        ///
        /// This GET operation will also update the internal &quot;last viewed&quot; date for this Task for the
        /// current user.
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task to retrieve</param>
        Task<AstroResult<TaskDetailsDto>> RetrieveTask(string taskId);

        /// <summary>
        /// Update an existing Task and replace the values of fields specified.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A
        /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
        /// indicate whether they have a dependency or a connection.
        ///
        /// Multiple users can be working on data at the same time.  When you call an API to update an
        /// object, this call is converted into a Changeset that is then applied sequentially.  You can use
        /// RetrieveChangeset to see the status of an individual Changeset.
        ///
        /// Known Issues:  This API returns an error if your Update call includes too many changes in a
        /// single API call.  Please restrict usage to one change per API request.  This API will be
        /// deprecated and replaced with an improved API call in a future release.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task to update</param>
        /// <param name="body">All non-null fields in this object will replace existing data in the Task</param>
        Task<AstroResult<ChangeSetStatusDto>> UpdateTask(Guid taskId, TaskUpdateDto body);

        /// <summary>
        /// Delete an existing Task.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A
        /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
        /// indicate whether they have a dependency or a connection.
        ///
        /// Multiple users can be working on data at the same time.  When you call an API to update an
        /// object, this call is converted into a Changeset that is then applied sequentially.  You can use
        /// RetrieveChangeset to see the status of an individual Changeset.
        /// </summary>
        /// <param name="taskId">Unique identifier of the Task to delete</param>
        Task<AstroResult<ChangeSetStatusDto>> DeleteTask(Guid taskId);

        /// <summary>
        /// Fetch the first level child tasks from the task
        /// </summary>
        /// <param name="taskId">Parent task id</param>
        Task<AstroResult<TaskDto[]>> FetchTheFirstLevelChildTasksFromTheTask(Guid taskId);

        /// <summary>
        /// Create a new Task within a specified project.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A
        /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
        /// indicate whether they have a dependency or a connection.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that will contain this Task</param>
        /// <param name="body">The new Task to create</param>
        Task<AstroResult<ChangeSetStatusDto>> CreateTask(Guid projectId, TaskCreateDto body);

        /// <summary>
        /// Retrieves all TaskPriorities defined within your Workspace.
        ///
        /// A TaskPriority is a named priority level used by your business to determine how to decide
        /// which Tasks are the most important.  You can name your TaskPriority levels anything you like
        /// and you can reorganize the order of the TaskPriority levels at any time.
        ///
        /// Note that TaskPriority and ProjectPriority are different classes of priority levels.  Even
        /// if they may have similar names, they are different objects and must be tracked separately.
        /// </summary>
        Task<AstroResult<TaskPriorityDto[]>> RetrieveTaskPriorities();

        /// <summary>
        /// Create multiple new Tasks within a specified project with a single API call.
        ///
        /// A Task is an individual element of work that must be performed to complete a Project.  A
        /// Task can have one or more Resources assigned to it.  Tasks can be linked to other Tasks to
        /// indicate whether they have a dependency or a connection.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that will contain these Tasks</param>
        /// <param name="body">The list of new Tasks to create</param>
        Task<AstroResult<ChangeSetStatusDto[]>> CreateManyTasks(Guid projectId, TaskCreateDto[] body);

        /// <summary>
        /// Adds a task parent relationship
        /// </summary>
        /// <param name="taskId">The task that will become the child</param>
        /// <param name="parentTaskId">The parent task</param>
        Task<AstroResult<ChangeSetStatusDto>> AddParentTask(Guid taskId, Guid parentTaskId);

        /// <summary>
        /// Updates a task parent relationship
        /// </summary>
        /// <param name="taskId">The task that will become the child</param>
        /// <param name="parentTaskId">The parent task</param>
        Task<AstroResult<ChangeSetStatusDto>> UpdateParentTask(Guid taskId, Guid parentTaskId);

        /// <summary>
        /// Removes a task parent relationship completely
        /// </summary>
        /// <param name="taskId">The child task</param>
        Task<AstroResult<ChangeSetStatusDto>> RemoveParentTask(Guid taskId);
    }
}
