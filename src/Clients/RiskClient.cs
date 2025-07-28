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

        /// <summary>
        /// Retrieve a list of risks that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Risk represents a tracked item of concern for a project.  Risks may be categorized as Changes, Risks,
        /// Assumptions, Issues, or Dependencies.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<RiskDto[]>> QueryRisks(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/risks";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<RiskDto[]>(HttpMethod.Get, url, options);
        }
    }
}
