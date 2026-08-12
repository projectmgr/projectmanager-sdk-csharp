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
    /// Baseline schedule and cost values captured for a Task when a project baseline is set.
    /// </summary>
    public class TaskBaselineDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this baseline record.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The baseline number for this Task.
        /// </summary>
        public int? Number { get; set; }

        /// <summary>
        /// The baselined duration (in minutes) for this Task.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// The baselined effort (in minutes) for this Task.
        /// </summary>
        public int? Effort { get; set; }

        /// <summary>
        /// The baselined start date for this Task.
        /// </summary>
        public DateTime? Start { get; set; }

        /// <summary>
        /// The baselined finish date for this Task.
        /// </summary>
        public DateTime? Finish { get; set; }

        /// <summary>
        /// The baselined cost for this Task.
        /// </summary>
        public decimal? Cost { get; set; }

        /// <summary>
        /// The duration format for this baseline value.
        /// </summary>
        public string DurationFormat { get; set; }

        /// <summary>
        /// The effort format for this baseline value.
        /// </summary>
        public string EffortFormat { get; set; }
    }
}
