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
    /// A single recurrence instance created by a recurring Task, NPT, or Meeting action
    /// </summary>
    public class RecurrenceDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the created recurrence instance
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The occurrence start (UTC). For Meetings this carries the meeting time.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The occurrence finish (UTC)
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}
