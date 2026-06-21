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
    /// Working hours per weekday (0 = non-working day).
    /// On update, omit a property (or send null) to leave that day unchanged.
    /// </summary>
    public class WorkspaceWorkingDaysDto : ApiModel
    {

        /// <summary>
        /// Working hours on Monday.
        /// </summary>
        public decimal? Monday { get; set; }

        /// <summary>
        /// Working hours on Tuesday.
        /// </summary>
        public decimal? Tuesday { get; set; }

        /// <summary>
        /// Working hours on Wednesday.
        /// </summary>
        public decimal? Wednesday { get; set; }

        /// <summary>
        /// Working hours on Thursday.
        /// </summary>
        public decimal? Thursday { get; set; }

        /// <summary>
        /// Working hours on Friday.
        /// </summary>
        public decimal? Friday { get; set; }

        /// <summary>
        /// Working hours on Saturday.
        /// </summary>
        public decimal? Saturday { get; set; }

        /// <summary>
        /// Working hours on Sunday.
        /// </summary>
        public decimal? Sunday { get; set; }
    }
}
