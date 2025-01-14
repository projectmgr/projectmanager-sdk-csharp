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
    /// API methods related to NptFiles
    /// </summary>
    public interface INptFilesClient
    {

        /// <summary>
        /// Uploads a file to a non-project task.
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
        /// <param name="taskId">The reference to the task</param>
        /// <param name="fileName">The full path of a file to upload to the API</param>
        Task<AstroResult<FileDto>> UploadFileToNonProjectTasks(Guid taskId, string fileName, byte[] fileBytes);
    }
}
