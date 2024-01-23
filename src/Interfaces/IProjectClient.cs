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
    /// API methods related to Project
    /// </summary>
    public interface IProjectClient
    {

        /// <summary>
        /// Retrieve a list of Projects that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks represent individual items of work that team members must complete.  The sum total of Tasks within a Project represents the work to be completed for that Project.
        ///
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<ProjectDto[]>> QueryProjects(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Create a new project based on the details provided.
        ///
        /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks represent individual items of work that team members must complete.  The sum total of Tasks within a Project represents the work to be completed for that Project.
        ///
        /// </summary>
        /// <param name="body">Information about the Project you wish to create</param>
        Task<AstroResult<ProjectDto>> CreateProject(ProjectCreateDto body);

        /// <summary>
        /// Retrieves a project based on its unique identifier.
        ///
        /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks represent individual items of work that team members must complete.  The sum total of Tasks within a Project represents the work to be completed for that Project.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        Task<AstroResult<ProjectDto>> RetrieveProject(string projectId);

        /// <summary>
        /// Update an existing Project and replace the values of fields specified.
        ///
        /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks represent individual items of work that team members must complete.  The sum total of Tasks within a Project represents the work to be completed for that Project.
        ///
        /// Multiple users can be working on data at the same time.  When you call an API to update an object, this call is converted into a Changeset that is then applied sequentially.  You can use RetrieveChangeset to see the status of an individual Changeset.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to update</param>
        /// <param name="body">All non-null fields in this object will replace previous data within the Project</param>
        Task<AstroResult<string>> UpdateProject(Guid projectId, ProjectUpdateDto body);
    }
}
