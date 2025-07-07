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
    /// Holds the list of pending timesheet approvals
    /// </summary>
    public class TimeSheetApprovalResponseDto : ApiModel
    {

        /// <summary>
        /// Date and time (in UTC) that this timesheet entry was last modified.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// A list of pending timesheet approvals
        /// </summary>
        public PendingTimeSheetApprovalDto[] PendingApprovals { get; set; }
    }
}
