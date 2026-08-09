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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Request body for updating workspace-level scheduling defaults.
    /// Omit properties to leave existing values unchanged.
    /// </summary>
    public class WorkspaceSettingsUpdateDto : ApiModel
    {

        /// <summary>
        /// Default planned hours per day for new resources (0–24).
        /// </summary>
        public decimal? DefaultPlannedHours { get; set; }

        /// <summary>
        /// Default working hours per weekday for the workspace calendar.
        /// </summary>
        public WorkspaceWorkingDaysDto WorkingDays { get; set; }
    }
}
