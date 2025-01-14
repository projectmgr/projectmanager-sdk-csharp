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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to TaskField
    /// </summary>
    public interface ITaskFieldClient
    {

        /// <summary>
        /// Retrieves all TaskFields defined for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve TaskFields</param>
        Task<AstroResult<TaskFieldDto[]>> RetrieveTaskFields(Guid projectId);

        /// <summary>
        /// Creates a new TaskField for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project within which to create this TaskField</param>
        /// <param name="body">Information about the TaskField to create</param>
        Task<AstroResult<ChangeSetStatusDto>> CreateTaskField(Guid projectId, CreateTaskFieldDto body);

        /// <summary>
        /// Retrieve a list of TaskFields that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside a Project.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<TaskFieldDto[]>> QueryTaskFields(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Deletes a TaskField for a specific Project within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that contains this TaskField</param>
        /// <param name="fieldId">The unique identifier of the TaskField to delete</param>
        Task<AstroResult<string>> DeleteTaskField(Guid projectId, Guid fieldId);

        /// <summary>
        /// Retrieves all TaskField values for a particular Task.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task for which we want TaskField values</param>
        Task<AstroResult<TaskFieldValueDto[]>> RetrieveAllTaskFieldValues(Guid taskId);

        /// <summary>
        /// Retrieve a list of TaskFieldValues that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<TaskFieldValueDto[]>> QueryTaskFieldValues(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Retrieves the current TaskField value for a particular Task and TaskField.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task of the value to retrieve</param>
        /// <param name="fieldId">The unique identifier of the TaskField of the value to retrieve</param>
        Task<AstroResult<TaskFieldValueDto>> RetrieveTaskFieldValue(Guid taskId, Guid fieldId);

        /// <summary>
        /// Replaces the current value of a TaskField for a specific Task within your Workspace.
        ///
        /// A TaskField is a custom field defined within your Workspace for a specific Project.  You can
        /// define TaskFields for any integration purpose that is important to your business.  Each
        /// TaskField has a data type as well as options in how it is handled.  TaskFields can be edited
        /// for each Task inside this Project.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task whose value you wish to update</param>
        /// <param name="fieldId">The unique identifier of the TaskField whose value you wish to update</param>
        /// <param name="body">The new value for this TaskField for this Task</param>
        Task<AstroResult<ChangeSetStatusDto>> UpdateTaskFieldValue(Guid taskId, Guid fieldId, UpdateTaskFieldValueDto body);
    }
}
