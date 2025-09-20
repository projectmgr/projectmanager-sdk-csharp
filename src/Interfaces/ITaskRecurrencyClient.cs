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



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to TaskRecurrency
    /// </summary>
    public interface ITaskRecurrencyClient
    {

        /// <summary>
        /// Create Weekly Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The weekly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateWeeklyRecurringTasks(Guid taskId, WeeklyRecurringSettingsDto body);

        /// <summary>
        /// Create Monthly Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The monthly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateMonthlyRecurringTasks(Guid taskId, MonthlyRecurringSettingsDto body);

        /// <summary>
        /// Create Daily Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The daily recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateDailyRecurringTasks(Guid taskId, DailyRecurringSettingsDto body);

        /// <summary>
        /// Create Yearly Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The yearly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateYearlyRecurringTasks(Guid taskId, YearlyRecurringSettingsDto body);

        /// <summary>
        /// Delete Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="option">The options for the deletion</param>
        Task<AstroResult<ChangeSetStatusDto>> DeleteRecurringTasks(Guid taskId, string option);
    }
}
