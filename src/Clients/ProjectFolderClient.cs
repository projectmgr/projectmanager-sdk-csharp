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
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to ProjectFolder
    /// </summary>
    public class ProjectFolderClient : IProjectFolderClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectFolderClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ProjectFolders defined within your Workspace.
        ///
        /// A ProjectFolder is a named storage location that can contain Projects.
        /// </summary>
        public async Task<AstroResult<ProjectFolderDto[]>> RetrieveProjectFolders()
        {
            var url = $"/api/data/project-folders";
            return await _client.Request<ProjectFolderDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Create a project folder
        /// </summary>
        /// <param name="body">The data to create the folder</param>
        public async Task<AstroResult<ProjectFolderDto>> CreateProjectFolder(ProjectFolderCreateDto body)
        {
            var url = $"/api/data/project-folders";
            return await _client.RequestWithBody<ProjectFolderDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Update a project folder
        /// </summary>
        /// <param name="projectFolderId">The id of the folder</param>
        /// <param name="body">The data to update the folder</param>
        public async Task<AstroResult<ProjectFolderDto>> UpdateProjectFolder(Guid projectFolderId, ProjectFolderUpdateDto body)
        {
            var url = $"/api/data/project-folders/{projectFolderId}";
            return await _client.RequestWithBody<ProjectFolderDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Delete a project folder
        /// </summary>
        /// <param name="projectFolderId">The id of the folder</param>
        public async Task<AstroResult<string>> DeleteProjectFolder(Guid projectFolderId)
        {
            var url = $"/api/data/project-folders/{projectFolderId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
