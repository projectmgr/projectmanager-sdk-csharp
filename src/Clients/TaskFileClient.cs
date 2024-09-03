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
    /// API methods related to TaskFile
    /// </summary>
    public class TaskFileClient : ITaskFileClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskFileClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Uploads a file to a task.
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
        public async Task<AstroResult<FileDto>> UploadTaskFile(Guid taskId, string fileName, byte[] fileBytes)
        {
            var url = $"/api/data/tasks/{taskId}/files";
            return await _client.RequestWithFile<FileDto>(HttpMethod.Post, url, null, fileBytes, fileName);
        }
    }
}
