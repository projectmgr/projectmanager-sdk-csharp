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
    /// Due Date Filter Settings
    /// </summary>
    public class ExportDueDateFilterDto : ApiModel
    {

        /// <summary>
        /// Include items without a due date
        /// </summary>
        public bool? IncludeNoDueDate { get; set; }

        /// <summary>
        /// Include items with a due date in the past
        /// </summary>
        public bool? IncludeOverdue { get; set; }

        /// <summary>
        /// Include items with a due date of today
        /// </summary>
        public bool? IncludeToday { get; set; }

        /// <summary>
        /// Include items due within the current week
        /// </summary>
        public bool? IncludeThisWeek { get; set; }

        /// <summary>
        /// Include items due within the next week
        /// </summary>
        public bool? IncludeNextWeek { get; set; }

        /// <summary>
        /// Include items due later
        /// </summary>
        public bool? IncludeLater { get; set; }
    }
}
