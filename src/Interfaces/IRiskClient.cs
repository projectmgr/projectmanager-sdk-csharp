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
        /// Initiates a new Export action for Risks.
        ///
        /// Returns the identifier of this Risk Export.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project for which to export Risks</param>
        /// <param name="body">The settings to use for this export action</param>
        Task<AstroResult<ExportDto>> CreateRiskExport(Guid projectId, RiskExportSettingsDto body);
    }
}
