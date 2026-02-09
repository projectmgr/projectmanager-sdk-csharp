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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to Risk
    /// </summary>
    public interface IRiskClient
    {

        /// <summary>
        /// Retrieve a Risk by its unique identifier or by its short ID.
        /// A Risk has both a unique identifier (GUID) and a short ID
        /// that is unique within a Workspace.
        /// </summary>
        /// <param name="riskId">The id of the risk</param>
        Task<AstroResult<RiskDetailsDto>> GetRisk(string riskId);

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
        Task<AstroResult<RiskDto>> UpdateRisk(Guid riskId, RiskUpdateDto body);

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
        Task<AstroResult<string>> RemoveRisk(Guid riskId);

        /// <summary>
        /// Retrieves all Risks associated with the specified Project.
        ///
        /// This endpoint returns a flat list of Risk summaries (not details)
        /// and does not use OData. Results are scoped to the Project and
        /// respect feature flags such as Hourly Rates.
        /// </summary>
        /// <param name="projectId">The id of the project</param>
        Task<AstroResult<RiskDetailsDto[]>> GetRisksForProject(Guid projectId);

        /// <summary>
        /// Creates a new Risk within the specified Project.
        ///
        /// The Risk will inherit Project context such as access permissions
        /// and workspace ownership. Validation is applied to ensure the
        /// Project exists and the caller has permission to create Risks.
        /// </summary>
        /// <param name="projectId">The id of the project</param>
        /// <param name="body">The data used to create the Risk</param>
        Task<AstroResult<RiskDto>> CreateRisk(Guid projectId, RiskCreateDto body);

        /// <summary>
        /// Initiates a new Export action for Risks.
        ///
        /// Returns the identifier of this Risk Export.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for which to export Risks</param>
        /// <param name="body">The settings to use for this export action</param>
        Task<AstroResult<ExportDto>> CreateRiskExport(Guid projectId, RiskExportSettingsDto body);

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
        Task<AstroResult<RiskDto[]>> QueryRisks(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);
    }
}
