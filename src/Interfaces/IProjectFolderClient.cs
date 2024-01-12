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
    /// API methods related to ProjectFolder
    /// </summary>
    public interface IProjectFolderClient
    {

        /// <summary>
        /// Retrieves all ProjectFolders defined within your Workspace.
        ///
        /// A ProjectFolder is a named storage location that can contain Projects.
        ///
        /// </summary>
        Task<AstroResult<ProjectFolderDto[]>> RetrieveProjectFolders();
    }
}
