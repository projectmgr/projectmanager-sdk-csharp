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
    /// API methods related to Project
    /// </summary>
    public class ProjectClient : IProjectClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectClient(ProjectManagerClient client)
        {
            _client = client;
        }

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
        public async Task<AstroResult<ProjectDto[]>> QueryProjects(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/projects";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<ProjectDto[]>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Create a new project based on the details provided.
        ///
        /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks represent individual items of work that team members must complete.  The sum total of Tasks within a Project represents the work to be completed for that Project.
        ///
        /// </summary>
        /// <param name="body">Information about the Project you wish to create</param>
        public async Task<AstroResult<ProjectDto>> CreateProject(ProjectCreateDto body)
        {
            var url = $"/api/data/projects";
            return await _client.Request<ProjectDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Retrieves a project based on its unique identifier.
        ///
        /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks represent individual items of work that team members must complete.  The sum total of Tasks within a Project represents the work to be completed for that Project.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to retrieve.</param>
        public async Task<AstroResult<ProjectDto>> RetrieveProject(string projectId)
        {
            var url = $"/api/data/projects/{projectId}";
            return await _client.Request<ProjectDto>(HttpMethod.Get, url, null, null, null);
        }

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
        public async Task<AstroResult<string>> UpdateProject(Guid projectId, ProjectUpdateDto body)
        {
            var url = $"/api/data/projects/{projectId}";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Delete a project based on the details provided.
        ///
        /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks represent individual items of work that team members must complete.  The sum total of Tasks within a Project represents the work to be completed for that Project.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to delete</param>
        /// <param name="hardDelete">Hard delete project true or false</param>
        public async Task<AstroResult<string>> DeleteProject(Guid projectId, bool? hardDelete = null)
        {
            var url = $"/api/data/projects/{projectId}";
            var options = new Dictionary<string, object>();
            if (hardDelete != null) { options["hardDelete"] = hardDelete; }
            return await _client.Request<string>(HttpMethod.Delete, url, options, null, null);
        }
    }
}
