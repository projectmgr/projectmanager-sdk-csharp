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
    }
}
