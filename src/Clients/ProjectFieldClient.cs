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
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to ProjectField
    /// </summary>
    public class ProjectFieldClient : IProjectFieldClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectFieldClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ProjectFields defined within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        public async Task<AstroResult<ProjectFieldDto[]>> RetrieveProjectFields()
        {
            var url = $"/api/data/projects/fields";
            return await _client.Request<ProjectFieldDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a new ProjectField within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="body">Information about the ProjectField to create</param>
        public async Task<AstroResult<ProjectFieldDto>> CreateProjectField(ProjectFieldCreateDto body)
        {
            var url = $"/api/data/projects/fields";
            return await _client.RequestWithBody<ProjectFieldDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Deletes an existing ProjectField within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="fieldId">The unique identifier or short ID of this ProjectField</param>
        public async Task<AstroResult<string>> DeleteProjectField(string fieldId)
        {
            var url = $"/api/data/projects/fields/{fieldId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Replaces the current value of a ProjectField for a specific Project within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that contains this ProjectField</param>
        /// <param name="fieldId">The unique identifier or short ID of this ProjectField</param>
        /// <param name="body">The new information for this ProjectField</param>
        public async Task<AstroResult<string>> UpdateProjectFieldValue(Guid projectId, string fieldId, UpdateProjectFieldValueDto body)
        {
            var url = $"/api/data/projects/{projectId}/fields/{fieldId}";
            return await _client.RequestWithBody<string>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Retrieves the current ProjectField value for a particular Project and ProjectField.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project of the value to retrieve</param>
        /// <param name="fieldId">The unique identifier or short ID of the ProjectField of the value to retrieve</param>
        public async Task<AstroResult<ProjectFieldValueDto>> RetrieveProjectFieldValue(Guid projectId, string fieldId)
        {
            var url = $"/api/data/projects/{projectId}/fields/{fieldId}";
            return await _client.Request<ProjectFieldValueDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Retrieves all ProjectField values for a particular Project.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields
        /// for any integration purpose that is important to your business.  Each ProjectField has a data
        /// type as well as options in how it is handled.  ProjectFields can be edited for each Project
        /// within your Workspace.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for which we want ProjectField values</param>
        public async Task<AstroResult<ProjectFieldValueDto[]>> RetrieveAllProjectFieldValues(Guid projectId)
        {
            var url = $"/api/data/projects/{projectId}/fields";
            return await _client.Request<ProjectFieldValueDto[]>(HttpMethod.Get, url, null);
        }
    }
}
