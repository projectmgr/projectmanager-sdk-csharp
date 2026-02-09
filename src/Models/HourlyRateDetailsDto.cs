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
    /// Detailed information about a specific hourly rate, including task and resource counts.
    /// </summary>
    public class HourlyRateDetailsDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Hourly Rate.  This value is set by the system and cannot
        /// be set with a CreateHourlyRate or changed with an UpdateHourlyRate call.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Who created the Hourly rate
        /// </summary>
        public Guid? CreateBy { get; set; }

        /// <summary>
        /// The timestamp in UTC when the Hourly Rate was created.
        ///
        /// This field is automatically determined by the system when this Hourly Rate is created
        /// and cannot be changed by the user.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Who last modified the Hourly rate
        /// </summary>
        public Guid? ModifyBy { get; set; }

        /// <summary>
        /// The timestamp in UTC when the Hourly Rate was most recently modified.
        ///
        /// This field is automatically determined by the system when this Hourly Rate is modified
        /// and cannot be directly changed by the user.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// The type of the rate
        /// </summary>
        public string RateType { get; set; }

        /// <summary>
        /// The ProjectId the rate is for
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The Project the rate is for
        /// </summary>
        public TaskProjectDto Project { get; set; }

        /// <summary>
        /// The ResourceId the rate is for
        /// </summary>
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// The Resource the rate is for
        /// </summary>
        public PartialResourceDto Resource { get; set; }

        /// <summary>
        /// The SkillId the rate is for
        /// </summary>
        public Guid? SkillId { get; set; }

        /// <summary>
        /// The Skill the rate is for
        /// </summary>
        public ResourceSkillDto Skill { get; set; }

        /// <summary>
        /// A list of all rates for each rate period
        /// </summary>
        public HourlyRateValueDto[] Values { get; set; }

        /// <summary>
        /// If this is an archived rate
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Total number of tasks with at least 1 association to this rate
        /// </summary>
        public int? TaskCount { get; set; }

        /// <summary>
        /// Total number of resources using this rate
        /// </summary>
        public int? ResourceCount { get; set; }

        /// <summary>
        /// Total number of timesheets using this rate
        /// </summary>
        public int? HourlyRateTimesheetCount { get; set; }
    }
}
