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
        /// Retrieve a Risk by its unique identifier or by its short ID.
        /// A Risk has both a unique identifier (GUID) and a short ID
        /// that is unique within a Workspace.
        /// </summary>
        /// <param name="riskId">The id of the risk</param>
        public async Task<AstroResult<RiskDetailsDto>> GetRisk(string riskId)
        {
            var url = $"/api/data/risks/{riskId}";
            return await _client.Request<RiskDetailsDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Updates an existing Risk.
        ///
        /// Only the fields provided in the request body will be updated.
        /// Fields omitted from the request will remain unchanged.
        ///
        /// Authorization is enforced to ensure the caller has access
        /// to modify the specified Risk.
        /// </summary>
        /// <param name="riskId">The id of the risk</param>
        /// <param name="body">The fields to update</param>
        public async Task<AstroResult<RiskDto>> UpdateRisk(Guid riskId, RiskUpdateDto body)
        {
            var url = $"/api/data/risks/{riskId}";
            return await _client.RequestWithBody<RiskDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Permanently removes the specified Risk.
        ///
        /// This operation cannot be undone. Any related references
        /// (such as links, history, or notifications) will be handled
        /// according to system rules.
        ///
        /// Authorization is enforced to ensure the caller has permission
        /// to delete the Risk.
        /// </summary>
        /// <param name="riskId">The id of the risk to remove</param>
        public async Task<AstroResult<string>> RemoveRisk(Guid riskId)
        {
            var url = $"/api/data/risks/{riskId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Retrieves all Risks associated with the specified Project.
        ///
        /// This endpoint returns a flat list of Risk summaries (not details)
        /// and does not use OData. Results are scoped to the Project and
        /// respect feature flags such as Hourly Rates.
        /// </summary>
        /// <param name="projectId">The id of the project</param>
        public async Task<AstroResult<RiskDetailsDto[]>> GetRisksForProject(Guid projectId)
        {
            var url = $"/api/data/risks/projects/{projectId}";
            return await _client.Request<RiskDetailsDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a new Risk within the specified Project.
        ///
        /// The Risk will inherit Project context such as access permissions
        /// and workspace ownership. Validation is applied to ensure the
        /// Project exists and the caller has permission to create Risks.
        /// </summary>
        /// <param name="projectId">The id of the project</param>
        /// <param name="body">The data used to create the Risk</param>
        public async Task<AstroResult<RiskDto>> CreateRisk(Guid projectId, RiskCreateDto body)
        {
            var url = $"/api/data/risks/{projectId}";
            return await _client.RequestWithBody<RiskDto>(HttpMethod.Post, url, null, body);
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
