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
    /// API methods related to Risk
    /// </summary>
    public class RiskClient : IRiskClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public RiskClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Initiates a new Export action for Risks.
        ///
        /// Returns the identifier of this Risk Export.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for which to export Risks</param>
        /// <param name="body">The settings to use for this export action</param>
        public async Task<AstroResult<ExportDto>> CreateRiskExport(Guid projectId, RiskExportSettingsDto body)
        {
            var url = $"/api/data/projects/{projectId}/risks/export";
            return await _client.RequestWithBody<ExportDto>(HttpMethod.Post, url, null, body);
        }
    }
}
