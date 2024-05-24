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
    }
}
