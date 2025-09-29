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
    /// API methods related to NptRecurrency
    /// </summary>
    public interface INptRecurrencyClient
    {

        /// <summary>
        /// Create Weekly Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The weekly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateWeeklyRecurringNpts(Guid taskId, WeeklyRecurringSettingsDto body);

        /// <summary>
        /// Create Monthly Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The monthly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateMonthlyRecurringNpts(Guid taskId, MonthlyRecurringSettingsDto body);

        /// <summary>
        /// Create Daily Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The daily recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateDailyRecurringNpts(Guid taskId, DailyRecurringSettingsDto body);

        /// <summary>
        /// Create Yearly Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The yearly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateYearlyRecurringNpts(Guid taskId, YearlyRecurringSettingsDto body);

        /// <summary>
        /// Delete Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="option">The options for the deletion</param>
        Task<AstroResult<DeletedTasksDto>> DeleteRecurringNpts(Guid taskId, string option);
    }
}
