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
    /// Settings for Yearly Recurring Tasks
    /// </summary>
    public class YearlyRecurringSettingsDto : ApiModel
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
        /// RepeatOnEveryNumberOfYears
        /// </summary>
        public int? RepeatOnEveryNumberOfYears { get; set; }

        /// <summary>
        /// RepeatOnMonth
        /// </summary>
        public int? RepeatOnMonth { get; set; }

        /// <summary>
        /// RepeatOnDay
        /// </summary>
        public int? RepeatOnDay { get; set; }
    }
}
