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
    /// API methods related to ProjectFolder
    /// </summary>
    public interface IProjectFolderClient
    {

        /// <summary>
        /// Retrieves all ProjectFolders defined within your Workspace.
        ///
        /// A ProjectFolder is a named storage location that can contain Projects.
        /// </summary>
        Task<AstroResult<ProjectFolderDto[]>> RetrieveProjectFolders();

        /// <summary>
        /// Create a project folder
        /// </summary>
        /// <param name="body">The data to create the folder</param>
        Task<AstroResult<ProjectFolderDto>> CreateProjectFolder(ProjectFolderCreateDto body);

        /// <summary>
        /// Update a project folder
        /// </summary>
        /// <param name="projectFolderId">The id of the folder</param>
        /// <param name="body">The data to update the folder</param>
        Task<AstroResult<ProjectFolderDto>> UpdateProjectFolder(Guid projectFolderId, ProjectFolderUpdateDto body);

        /// <summary>
        /// Delete a project folder
        /// </summary>
        /// <param name="projectFolderId">The id of the folder</param>
        Task<AstroResult<string>> DeleteProjectFolder(Guid projectFolderId);
    }
}
