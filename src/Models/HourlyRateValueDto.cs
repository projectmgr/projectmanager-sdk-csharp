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
    /// Represents the value of an hourly rate for a specific period, including audit information and references to the rate definition and period.
    /// </summary>
    public class HourlyRateValueDto : ApiModel
    {

        /// <summary>
        /// Gets or sets the unique identifier for this hourly rate value entry.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user or resource who created this hourly rate value.
        /// </summary>
        public Guid? CreateBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this hourly rate value was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user or resource who last modified this hourly rate value.
        /// </summary>
        public Guid? ModifyBy { get; set; }

        /// <summary>
        /// Gets or sets the date and time when this hourly rate value was last modified.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the hourly rate definition to which this value belongs.
        /// </summary>
        public Guid? HourlyRateDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the hourly rate period to which this value applies.
        /// </summary>
        public Guid? HourlyRatePeriodId { get; set; }

        /// <summary>
        /// Gets or sets the start date of the hourly rate period for which this value applies.
        /// This value is sourced from the associated HourlyRatePeriod.
        /// </summary>
        public DateTime? PeriodStartDate { get; set; }

        /// <summary>
        /// Gets or sets the finish date of the hourly rate period for which this value applies.
        /// This value is sourced from the associated HourlyRatePeriod.
        /// </summary>
        public DateTime? PeriodFinishDate { get; set; }

        /// <summary>
        /// Gets or sets the value of the hourly rate for the specified period.
        /// </summary>
        public decimal? Value { get; set; }
    }
}
