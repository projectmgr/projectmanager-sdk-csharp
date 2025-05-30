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
        /// ProjectManager allows you to store Files connected to other elements of your Workspace
        /// such as a Project, a Task, or Home.  Files are maintained separately based on the location
        /// where the file was stored.
        ///
        /// When you upload a File, please allow a few moments for the File to be processed and verified.
        /// ProjectManager may reject File uploads that contain problems such as malware. Once a File has
        /// completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// If successful, this API returns the file contents as an octet-stream (raw bytes).  If an error
        /// occurs, you will receive a JSON result with error information.
        /// </summary>
        /// <param name="documentId">The unique identifier of the document to download</param>
        /// <param name="type">If you specify a type of `html`, processes the file using text encoding, otherwise binary</param>
        public async Task<AstroResult<byte[]>> DownloadFile(Guid documentId, string type = null)
        {
            var url = $"/api/data/files/{documentId}/download";
            var options = new Dictionary<string, object>();
            if (type != null) { options["type"] = type; }
            return await _client.Request<byte[]>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Downloads a thumbnail image associated with a document that was previously uploaded to ProjectManager.com.
        ///
        /// ProjectManager allows you to store files linked to various elements within your Workspace,
        /// such as Projects, Tasks, or your Home. Files are organized based on their storage location.
        ///
        /// When uploading a file, please allow some time for the file to undergo processing and verification.
        /// ProjectManager may reject file uploads containing issues such as malware. Once a file has
        /// completed the upload process, you can retrieve its associated thumbnail using the DownloadThumbnail API.
        ///
        /// If successful, this API returns the file contents as an octet-stream (raw bytes).  If an error
        /// occurs, you will receive a JSON result with error information.
        /// </summary>
        /// <param name="documentId">The unique identifier of the document for which to download the thumbnail.</param>
        public async Task<AstroResult<byte[]>> DownloadAThumbnailImage(Guid documentId)
        {
            var url = $"/api/data/files/{documentId}/thumbnail";
            return await _client.Request<byte[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Updates information about a File uploaded to your Workspace.
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
        /// <param name="fileId">The unique identifier of the File to update</param>
        /// <param name="body">Information to change about the File and its location</param>
        public async Task<AstroResult<string>> UpdateFile(Guid fileId, UpdateRequestDto body)
        {
            var url = $"/api/data/files/{fileId}";
            return await _client.RequestWithBody<string>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// In case of soft delete moves file to trash folder. For hard delete completely deletes
        /// file&#39;s metadata from pm database as well as from amazon storage
        ///
        /// This API returns a JSON response indicating success or failure.
        /// </summary>
        /// <param name="fileId">The unique identifier of the File to delete</param>
        /// <param name="hard">Param indicates that file should be hard deleted</param>
        public async Task<AstroResult<string>> DeleteFile(Guid fileId, bool? hard = null)
        {
            var url = $"/api/data/files/{fileId}";
            var options = new Dictionary<string, object>();
            if (hard != null) { options["hard"] = hard; }
            return await _client.Request<string>(HttpMethod.Delete, url, options);
        }
    }
}
