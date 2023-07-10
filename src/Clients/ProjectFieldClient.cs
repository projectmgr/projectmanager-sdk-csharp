/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
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
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields for any integration purpose that is important to your business.  Each ProjectField has a data type as well as options in how it is handled.  ProjectFields can be edited for each Project within your Workspace.
        ///
        /// </summary>
        public async Task<AstroResult<GetProjectFieldsResponseDto[]>> RetrieveProjectFields()
        {
            var url = $"/project-api/public/projects/fields";
            return await _client.Request<GetProjectFieldsResponseDto[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Creates a new ProjectField within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields for any integration purpose that is important to your business.  Each ProjectField has a data type as well as options in how it is handled.  ProjectFields can be edited for each Project within your Workspace.
        ///
        /// </summary>
        /// <param name="body">Information about the ProjectField to create</param>
        public async Task<AstroResult<CreateProjectFieldResponseDto>> CreateProjectField(CreateProjectFieldDto body)
        {
            var url = $"/project-api/public/projects/fields";
            return await _client.Request<CreateProjectFieldResponseDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Deletes an existing ProjectField within your Workspace.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields for any integration purpose that is important to your business.  Each ProjectField has a data type as well as options in how it is handled.  ProjectFields can be edited for each Project within your Workspace.
        ///
        /// </summary>
        /// <param name="body">The identity of the ProjectField to delete</param>
        public async Task<AstroResult<string>> DeleteProjectField(DeleteProjectFieldDto body)
        {
            var url = $"/project-api/public/projects/fields";
            return await _client.Request<string>(HttpMethod.Delete, url, null, body, null);
        }

        /// <summary>
        /// Updates an existing ProjectField with new information.
        ///
        /// A ProjectField is a custom field defined within your Workspace.  You can define ProjectFields for any integration purpose that is important to your business.  Each ProjectField has a data type as well as options in how it is handled.  ProjectFields can be edited for each Project within your Workspace.
        ///
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project that contains this ProjectField</param>
        /// <param name="fieldId">The unique identifier of this ProjectField</param>
        /// <param name="body">The new information for this ProjectField</param>
        public async Task<AstroResult<string>> UpdateProjectField(Guid projectId, Guid fieldId, UpdateProjectFieldValueDto body)
        {
            var url = $"/project-api/public/projects/{projectId}/fields/{fieldId}";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }
    }
}
