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
    /// API methods related to HomeFile
    /// </summary>
    public interface IHomeFileClient
    {

        /// <summary>
        /// Uploads a file to a Home folder.
        ///
        /// When you upload a File, please allow a few moments. ProjectManager may reject File uploads based on security policies. Once a File has completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// </summary>
        /// <param name="filename">The full path of a file to upload to the API</param>
        Task<AstroResult<FileDto>> UploadaFiletoausersHomeArea(string filename);

        /// <summary>
        /// Uploads a file to a home folder.
        ///
        /// When you upload a File, please allow a few moments. ProjectManager may reject File uploads based on security policies. Once a File has completed the upload the process, you may retrieve it using the DownloadFile API.
        ///
        /// </summary>
        /// <param name="folderId">The reference to the sub folder to put the file into</param>
        /// <param name="filename">The full path of a file to upload to the API</param>
        Task<AstroResult<FileDto>> UploadaFiletotheusersHomeArea(Guid folderId, string filename);
    }
}
