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
    /// Whole hours per weekday for scheduling (matches workspace/resource calendar rows).
    /// Property order is Monday through Sunday for documentation and OpenAPI schema clarity.
    /// On read, all seven values are set. On create/update, omit a property (or send null) to leave that day
    /// unchanged; specified values merge over workspace defaults when building the resource calendar.
    /// </summary>
    public class ResourceWorkingDaysHours : ApiModel
    {

        /// <summary>
        /// Hours available on Monday.
        /// </summary>
        public decimal? Monday { get; set; }

        /// <summary>
        /// Hours available on Tuesday.
        /// </summary>
        public decimal? Tuesday { get; set; }

        /// <summary>
        /// Hours available on Wednesday.
        /// </summary>
        public decimal? Wednesday { get; set; }

        /// <summary>
        /// Hours available on Thursday.
        /// </summary>
        public decimal? Thursday { get; set; }

        /// <summary>
        /// Hours available on Friday.
        /// </summary>
        public decimal? Friday { get; set; }

        /// <summary>
        /// Hours available on Saturday.
        /// </summary>
        public decimal? Saturday { get; set; }

        /// <summary>
        /// Hours available on Sunday.
        /// </summary>
        public decimal? Sunday { get; set; }
    }
}
