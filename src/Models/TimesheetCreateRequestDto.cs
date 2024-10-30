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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Payload to create time entry
    /// </summary>
    public class TimesheetCreateRequestDto : ApiModel
    {

        /// <summary>
        /// Time entry date
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Reported hours. If minutes is specified this property is ignored
        /// </summary>
        public decimal? Hours { get; set; }

        /// <summary>
        /// Specify the time in minutes. This overrides the Hours property.
        /// </summary>
        public int? Minutes { get; set; }

        /// <summary>
        /// Task id that time reported to
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Admin task id that time reported to
        /// </summary>
        public Guid? AdminTypeId { get; set; }

        /// <summary>
        /// Resource id that time reported to
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        public string Notes { get; set; }
    }
}
