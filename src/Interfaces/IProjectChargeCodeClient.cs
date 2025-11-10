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
    /// API methods related to ProjectChargeCode
    /// </summary>
    public interface IProjectChargeCodeClient
    {

        /// <summary>
        /// Retrieve all defined ChargeCodes that can be used when creating Projects.
        ///
        /// A ChargeCode is a code used to identify costs within your Projects.  Each ChargeCode has
        /// a name and a unique identifier.  ChargeCodes are defined per Workspace and are shared
        /// among Projects.
        /// </summary>
        Task<AstroResult<ProjectChargeCodeDto[]>> RetrieveChargeCodes();

        /// <summary>
        /// Create a project charge code
        /// </summary>
        /// <param name="body">The data to create the charge code</param>
        Task<AstroResult<ProjectChargeCodeDto>> CreateProjectChargeCode(ProjectChargeCodeCreateDto body);

        /// <summary>
        /// Update a project charge code
        /// </summary>
        /// <param name="chargeCodeId">The id of the charge code</param>
        /// <param name="body">The data to update the charge code</param>
        Task<AstroResult<ProjectChargeCodeDto>> UpdateProjectChargeCode(Guid chargeCodeId, ProjectChargeCodeUpdateDto body);

        /// <summary>
        /// Delete a project charge code
        /// </summary>
        /// <param name="chargeCodeId">The id of the charge code</param>
        Task<AstroResult<string>> DeleteProjectChargeCode(Guid chargeCodeId);
    }
}
