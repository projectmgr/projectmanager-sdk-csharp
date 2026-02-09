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
    /// Represents the data required to create a new Risk within a Project.
    ///
    /// A Risk identifies a potential issue or uncertainty that may impact
    /// project outcomes. This DTO captures descriptive information,
    /// risk assessment metrics (such as impact and likelihood),
    /// and optional ownership via assignees.
    /// </summary>
    public class RiskCreateDto : ApiModel
    {

        /// <summary>
        /// The common name of this Risk.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the work to be performed in this Risk.
        /// </summary>
        public string Description { get; set; }

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
        /// A list of unique identifiers of Assignees to be assigned to this Risk
        /// </summary>
        public Guid[] Assignees { get; set; }
    }
}
