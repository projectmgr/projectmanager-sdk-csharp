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
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to TaskRecurrency
    /// </summary>
    public class TaskRecurrencyClient : ITaskRecurrencyClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskRecurrencyClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Create Weekly Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The weekly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateWeeklyRecurringTasks(Guid taskId, WeeklyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/weekly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Create Monthly Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The monthly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateMonthlyRecurringTasks(Guid taskId, MonthlyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/monthly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Create Daily Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The daily recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateDailyRecurringTasks(Guid taskId, DailyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/daily";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Create Yearly Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="body">The yearly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateYearlyRecurringTasks(Guid taskId, YearlyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/yearly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Delete Recurring Tasks
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Task</param>
        /// <param name="option">The options for the deletion</param>
        public async Task<AstroResult<ChangeSetStatusDto>> DeleteRecurringTasks(Guid taskId, string option)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/{option}";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Delete, url, null);
        }
    }
}
