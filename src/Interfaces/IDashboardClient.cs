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
    /// API methods related to Dashboard
    /// </summary>
    public interface IDashboardClient
    {

        /// <summary>
        /// Returns user dashboard settings
        /// </summary>
        /// <param name="type">The dashboard type that is not custom. For a list of values, see `DashboardTypeValues`.</param>
        Task<AstroResult<DashboardSettingDto>> RetrieveDashboardUserSettings(string type);

        /// <summary>
        /// Create or Update User Dashboard Settings
        /// </summary>
        /// <param name="body">User dashboard settings object</param>
        Task<AstroResult<DashboardSettingDto>> CreateOrUpdateUserDashboardSettings(DashboardSettingCreateDto body);
    }
}
