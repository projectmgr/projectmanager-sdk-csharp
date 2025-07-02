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
    /// Represents a timesheet approval request
    /// </summary>
    public class TimeSheetApprovalDto : ApiModel
    {

        /// <summary>
        /// The id for the resource, if null it indicates the request is for the current logged-in user
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// The date of the week to which the timesheet applies
        /// </summary>
        public DateTime? Date { get; set; }
    }
}
