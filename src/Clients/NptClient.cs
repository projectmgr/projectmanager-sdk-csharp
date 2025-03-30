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
    /// API methods related to Npt
    /// </summary>
    public class NptClient : INptClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public NptClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Gets a Npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        public async Task<AstroResult<NptDto>> GetNpt(Guid nptId)
        {
            var url = $"/api/data/non-project-tasks/{nptId}";
            return await _client.Request<NptDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Update a Npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        /// <param name="body">the fields to update</param>
        public async Task<AstroResult<NptDto>> UpdateNpt(Guid nptId, NptUpdateDto body)
        {
            var url = $"/api/data/non-project-tasks/{nptId}";
            return await _client.RequestWithBody<NptDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Remove Npt
        /// </summary>
        /// <param name="nptId">the id of the npt to remove</param>
        public async Task<AstroResult<string>> RemoveNpt(Guid nptId)
        {
            var url = $"/api/data/non-project-tasks/{nptId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Creates a new Npt
        /// </summary>
        /// <param name="body">The data used to create the Npt</param>
        public async Task<AstroResult<NptDto>> CreateNpt(NptCreateDto body)
        {
            var url = $"/api/data/non-project-tasks";
            return await _client.RequestWithBody<NptDto>(HttpMethod.Post, url, null, body);
        }
    }
}
