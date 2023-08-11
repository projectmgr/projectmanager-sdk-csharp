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
    /// API methods related to File
    /// </summary>
    public class FileClient : IFileClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public FileClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Downloads the contents of a file that was previously uploaded to ProjectManager.com.
        ///
        /// ProjectManager allows you to store Files connected to other elements of your Workspace such as a Project or a Discussion.  When you upload a File, please allow a few moments for the File to be processed and verified.  ProjectManager may reject File uploads that contain problems such as malware. Once a File has completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// </summary>
        /// <param name="documentId">The unique identifier of the document to download</param>
        public async Task<AstroResult<string>> DownloadFile(Guid documentId)
        {
            var url = $"/api/data/files/{documentId}/download";
            return await _client.Request<string>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Uploads a File to the specified location.
        ///
        /// ProjectManager allows you to store Files connected to other elements of your Workspace such as a Project or a Discussion.  When you upload a File, please allow a few moments for the File to be processed and verified.  ProjectManager may reject File uploads that contain problems such as malware. Once a File has completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// </summary>
        /// <param name="filename">The full path of a file to upload to the API</param>
        public async Task<AstroResult<string>> UploadFile(string filename)
        {
            var url = $"/api/data/files/upload";
            return await _client.Request<string>(HttpMethod.Post, url, null, null, filename);
        }

        /// <summary>
        /// Updates information about a File uploaded to your Workspace.
        ///
        /// ProjectManager allows you to store Files connected to other elements of your Workspace such as a Project or a Discussion.  When you upload a File, please allow a few moments for the File to be processed and verified.  ProjectManager may reject File uploads that contain problems such as malware. Once a File has completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// </summary>
        /// <param name="fileId">The unique identifier of the File to update</param>
        /// <param name="body">Information to change about the File and its location</param>
        public async Task<AstroResult<string>> UpdateFile(Guid fileId, UpdateRequestDto body)
        {
            var url = $"/api/data/files/{fileId}";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }
    }
}
