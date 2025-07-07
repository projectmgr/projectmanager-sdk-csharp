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
    /// Represents a potential threat or uncertainty that could impact a project, system, or process.
    /// Contains information such as its likelihood, impact, response, and resolution details.
    /// </summary>
    public class RiskDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this risk.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique identifier of the Project to which this Task belongs.
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The common name of this Task.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date when work on this risk is expected to complete.
        ///
        /// This value contains only the date in year-month-day format.  For display, this
        /// date will always be shown as this same year-month-day regardless of time zone.
        /// For reporting purposes, this date is calculated against the official time zone
        /// of the Workspace.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// The numerical percentage, from 0-100, representing the percentage completion
        /// for this risk.  Any numbers below zero or above 100 will be clamped to the
        /// minimum or maximum value.
        /// </summary>
        public int? PercentComplete { get; set; }

        /// <summary>
        /// Indicates the level of importance assigned to a risk, with 500 being standard priority; the higher the number, the higher the priority.
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// The potential effect of the risk.
        /// </summary>
        public int? Impact { get; set; }

        /// <summary>
        /// Probability or chance of the risk occurring.
        /// </summary>
        public int? Likelihood { get; set; }

        /// <summary>
        /// The planned or implemented response to address the identified risk.
        /// Avoid, Mitigate, Transfer, Accept
        /// </summary>
        public int? ResponseId { get; set; }

        /// <summary>
        /// The actions or strategy planned or taken to mitigate or eliminate the risk.
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// Any additional comments, observations, or details related to the risk.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// The timestamp in UTC when this risk was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The timestamp in UTC when this risk was most recently modified.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// The risk version.
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// A short ID that can be used to refer to this risk. This short ID is
        /// guaranteed to be unique within your Workspace.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// Risk has a taskTypeId of 31
        /// </summary>
        public int? TaskTypeId { get; set; }

        /// <summary>
        /// Users assigned to the risk.
        /// </summary>
        public AssignmentDto[] Assignments { get; set; }

        /// <summary>
        /// Tags applied to the risk.
        /// </summary>
        public TaskTagDto[] Tags { get; set; }

        /// <summary>
        /// The user which created the risk.
        /// </summary>
        public TaskOwnerDto Owner { get; set; }

        /// <summary>
        /// The number of files attached to the risk.
        /// </summary>
        public int? FilesCount { get; set; }

        /// <summary>
        /// The number of comments added to the risk.
        /// </summary>
        public int? CommentsCount { get; set; }

        /// <summary>
        /// The id of the Risk Type
        /// Risk = 1
        /// Assumption = 2
        /// Issue = 3
        /// Dependency = 4
        /// Change = 5
        /// </summary>
        public int? RiskTypeId { get; set; }
    }
}
