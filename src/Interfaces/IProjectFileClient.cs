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
    /// API methods related to ProjectFile
    /// </summary>
    public interface IProjectFileClient
    {

        /// <summary>
        /// Uploads a file to the All Files folder on the Files page within the project that you specify.
        ///
        /// ProjectManager allows you to store Files connected to other elements of your Workspace
        /// such as a Project, a Task, or Home.  Files are maintained separately based on the location
        /// where the file was stored.
        ///
        /// When you upload a File, please allow a few moments for the File to be processed and verified.
        /// ProjectManager may reject File uploads that contain problems such as malware. Once a File has
        /// completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// This API returns a JSON response indicating success or failure.
        /// </summary>
        /// <param name="projectId">The reference to the project</param>
        /// <param name="fileName">The full path of a file to upload to the API</param>
        Task<AstroResult<FileDto>> UploadProjectFile(Guid projectId, string fileName, byte[] fileBytes);

        /// <summary>
        /// Uploads a file to a specific folder on the Files page within the project that you specify.
        ///
        /// ProjectManager allows you to store Files connected to other elements of your Workspace
        /// such as a Project, a Task, or Home.  Files are maintained separately based on the location
        /// where the file was stored.
        ///
        /// You can organize your files in the Home Files and Project Files pages by adding folders.
        ///
        /// When you upload a File, please allow a few moments for the File to be processed and verified.
        /// ProjectManager may reject File uploads that contain problems such as malware. Once a File has
        /// completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// This API returns a JSON response indicating success or failure.
        /// </summary>
        /// <param name="projectId">The reference to the project</param>
        /// <param name="folderId">The reference to the sub folder to put the file into</param>
        /// <param name="fileName">The full path of a file to upload to the API</param>
        Task<AstroResult<FileDto>> UploadProjectFileToFolder(Guid projectId, Guid folderId, string fileName, byte[] fileBytes);
    }
}
