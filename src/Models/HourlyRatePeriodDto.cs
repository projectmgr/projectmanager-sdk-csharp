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
    /// Represents a period of time for which a specific hourly rate is applicable.
    /// </summary>
    public class HourlyRatePeriodDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the hourly rate period.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The start date of the hourly rate period. If null this is the first period.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// The finish date of the hourly rate period. If null this is the last period.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string FinishDate { get; set; }

        /// <summary>
        /// Indicates whether the hourly rate period is the current period.
        /// </summary>
        public bool? IsCurrent { get; set; }

        /// <summary>
        /// The resourceId who created the hourly rate period.
        /// </summary>
        public Guid? CreateBy { get; set; }

        /// <summary>
        /// The date and time the hourly rate period was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The resourceId who last modified the hourly rate period.
        /// </summary>
        public Guid? ModifyBy { get; set; }

        /// <summary>
        /// The date and time the hourly rate period was last modified.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// A list of all the rates for the rate period
        /// </summary>
        public HourlyRateValueDto[] Values { get; set; }
    }
}
