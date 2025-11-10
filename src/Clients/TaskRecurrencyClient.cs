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
        /// Changes an existing Task into a Recurring Task, so that it will recur regularly given the specified rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task</param>
        /// <param name="body">The weekly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateWeeklyRecurringTasks(Guid taskId, WeeklyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/weekly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Changes an existing Task into a Recurring Task, so that it will recur regularly given the specified rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task</param>
        /// <param name="body">The monthly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateMonthlyRecurringTasks(Guid taskId, MonthlyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/monthly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Changes an existing Task into a Recurring Task, so that it will recur regularly given the specified rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task</param>
        /// <param name="body">The daily recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateDailyRecurringTasks(Guid taskId, DailyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/daily";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Changes an existing Task into a Recurring Task, so that it will recur regularly given the specified rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task</param>
        /// <param name="body">The yearly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetailsChangeSetStatusDto>> CreateYearlyRecurringTasks(Guid taskId, YearlyRecurringSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/yearly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetailsChangeSetStatusDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Removes one or more instances of a Recurring Task based on the `option` you specify: `this` means to remove
        /// a single instance, `all` means to remove all instances, or `future` means to remove all future instances of
        /// the Recurring Task.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task</param>
        /// <param name="option">Specify `this`, `all`, or `future` to indicate which task recurrnces to delete.</param>
        public async Task<AstroResult<ChangeSetStatusDto>> DeleteRecurringTasks(Guid taskId, string option)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/{option}";
            return await _client.Request<ChangeSetStatusDto>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Reviews potential updates to a Recurring Task and report back on the list of changes that would occur if this
        /// Recurring Task was updated with these settings.
        ///
        /// When making changes to a Recurring Task, you may want to investigate the consequences of your changes first
        /// before finalizing the changes.  You can use the Validate Recurring Tasks API to examine these changes.  When
        /// you are happy with the changes, call Update Recurring Tasks to complete them.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task</param>
        /// <param name="body">The new settings</param>
        public async Task<AstroResult<RecurringTaskValidationResultDto>> ValidateRecurringTasks(Guid taskId, RecurringTaskSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/settings/validate";
            return await _client.RequestWithBody<RecurringTaskValidationResultDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates the settings for a Recurring Task and re-generates occurrences of the Recurring Task from the new rules.
        ///
        /// When making changes to a Recurring Task, you may want to investigate the consequences of your changes first
        /// before finalizing the changes.  You can use the Validate Recurring Tasks API to examine these changes.  When
        /// you are happy with the changes, call Update Recurring Tasks to complete them.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="taskId">The unique identifier of the Task</param>
        /// <param name="body">The new settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> UpdateRecurringTasks(Guid taskId, RecurringTaskSettingsDto body)
        {
            var url = $"/api/data/tasks/{taskId}/recurring/settings";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Put, url, null, body);
        }
    }
}
