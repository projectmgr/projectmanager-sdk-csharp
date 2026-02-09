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
    /// A Risk represents an item of potential impact or uncertainty.
    /// Risks share many characteristics with tasks but are tracked independently
    /// of project execution work.
    /// </summary>
    public class RiskUpdateDto : ApiModel
    {

        /// <summary>
        /// The common name of this Risk.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date when this risk is expected to be resolved.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// Percentage completion (0–100).
        /// </summary>
        public int? PercentComplete { get; set; }

        /// <summary>
        /// Priority of the risk.
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// The potential effect of the risk.
        /// </summary>
        public int? Impact { get; set; }

        /// <summary>
        /// Probability of the risk occurring.
        /// </summary>
        public int? Likelihood { get; set; }

        /// <summary>
        /// Planned or implemented response.
        /// Avoid it, Mitigate, Transfer, Accept
        /// </summary>
        public int? ResponseId { get; set; }

        /// <summary>
        /// Actions taken or planned to address the risk.
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// Additional comments or observations.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Users assigned to the risk.
        /// Replaces existing assignments when provided.
        /// </summary>
        public Guid[] Assignees { get; set; }

        /// <summary>
        /// Tags applied to the risk.
        /// Replaces existing tags when provided.
        /// </summary>
        public Guid[] TagIds { get; set; }

        /// <summary>
        /// The type of risk.
        /// Risk = 1
        /// Assumption = 2
        /// Issue = 3
        /// Dependency = 4
        /// Change = 5
        /// </summary>
        public int? RiskTypeId { get; set; }
    }
}
