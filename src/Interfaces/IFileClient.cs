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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to File
    /// </summary>
    public interface IFileClient
    {

        /// <summary>
        /// Downloads the contents of a file that was previously uploaded to ProjectManager.com.
        ///
        /// ProjectManager allows you to store Files connected to other elements of your Workspace such as a Project, a Task, or Home.  Files are maintained separately based on the location where the file was stored.
        ///
        /// When you upload a File, please allow a few moments for the File to be processed and verified. ProjectManager may reject File uploads that contain problems such as malware. Once a File has completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// </summary>
        /// <param name="documentId">The unique identifier of the document to download</param>
        /// <param name="type">If you specify a type of `html`, processes the file using text encoding, otherwise binary</param>
        Task<AstroResult<string>> DownloadFile(Guid documentId, string type = null);

        /// <summary>
        /// Downloads a thumbnail image associated with a document that was previously uploaded to ProjectManager.com.
        ///
        /// ProjectManager allows you to store files linked to various elements within your Workspace,
        /// such as Projects, Tasks, or your Home. Files are organized based on their storage location.
        ///
        /// When uploading a file, please allow some time for the file to undergo processing and verification.
        /// ProjectManager may reject file uploads containing issues such as malware. Once a file has
        /// completed the upload process, you can retrieve its associated thumbnail using the DownloadThumbnail API.
        /// </summary>
        /// <param name="documentId">The unique identifier of the document for which to download the thumbnail.</param>
        Task<AstroResult<byte[]>> DownloadaThumbnailImage(Guid documentId);

        /// <summary>
        /// Updates information about a File uploaded to your Workspace.
        ///
        /// ProjectManager allows you to store Files connected to other elements of your Workspace such as a Project, a Task, or Home.  Files are maintained separately based on the location where the file was stored.
        ///
        /// When you upload a File, please allow a few moments for the File to be processed and verified. ProjectManager may reject File uploads that contain problems such as malware. Once a File has completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// </summary>
        /// <param name="fileId">The unique identifier of the File to update</param>
        /// <param name="body">Information to change about the File and its location</param>
        Task<AstroResult<string>> UpdateFile(Guid fileId, UpdateRequestDto body);
    }
}
