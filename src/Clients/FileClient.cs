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

        public async Task<AstroResult<string>> DownloadsafilewiththespecifieddocumentID.(Guid documentId)
        {
            var url = $"/api/data/files/{documentId}/download";
            return await _client.Request<string>(HttpMethod.Get, url, null, null, null);
        }

        public async Task<AstroResult<string>> Uploadsafilewiththespecifiedrequestdto.(string filename)
        {
            var url = $"/api/data/files/upload";
            return await _client.Request<string>(HttpMethod.Post, url, null, null, filename);
        }

        public async Task<AstroResult<string>> Updatesafilewiththespecifiedrequestdto.(Guid fileId, UpdateRequestDto body)
        {
            var url = $"/api/data/files/{fileId}";
            return await _client.Request<string>(HttpMethod.Put, url, null, body, null);
        }
    }
}
