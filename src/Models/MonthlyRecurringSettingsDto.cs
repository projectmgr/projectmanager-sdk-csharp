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
    /// Settings for Monthly Recurring Tasks
    /// </summary>
    public class MonthlyRecurringSettingsDto : ApiModel
    {

        /// <summary>
        /// RecurringEndDate
        /// </summary>
        public DateTime? RecurringEndDate { get; set; }

        /// <summary>
        /// EndAfterNumberOfOccurences
        /// </summary>
        public int? EndAfterNumberOfOccurences { get; set; }

        /// <summary>
        /// RepeatOnEveryNumberOfMonths
        /// </summary>
        public int? RepeatOnEveryNumberOfMonths { get; set; }

        /// <summary>
        /// RepeatOnMonthDay
        /// </summary>
        public int? RepeatOnMonthDay { get; set; }

        /// <summary>
        /// RepeatOnMonthWeek
        /// </summary>
        public int? RepeatOnMonthWeek { get; set; }

        /// <summary>
        /// RepeatOnWeekDay
        /// </summary>
        public int? RepeatOnWeekDay { get; set; }
    }
}
