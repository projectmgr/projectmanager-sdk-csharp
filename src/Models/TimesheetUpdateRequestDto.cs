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
    /// Payload to update time entry
    /// </summary>
    public class TimesheetUpdateRequestDto : ApiModel
    {

        /// <summary>
        /// Reported hours. If minutes is specified this property is ignored
        /// </summary>
        public decimal? Hours { get; set; }

        /// <summary>
        /// Specify the time in minutes. This overrides the Hours property.
        /// </summary>
        public int? Minutes { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Document Ids
        /// </summary>
        public Guid[] DocumentIds { get; set; }
    }
}
