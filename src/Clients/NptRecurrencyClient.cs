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
    /// API methods related to NptRecurrency
    /// </summary>
    public class NptRecurrencyClient : INptRecurrencyClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public NptRecurrencyClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Create Weekly Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The weekly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateWeeklyRecurringNpts(Guid taskId, WeeklyRecurringSettingsDto body)
        {
            var url = $"/api/data/npt/{taskId}/recurring/weekly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Create Monthly Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The monthly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateMonthlyRecurringNpts(Guid taskId, MonthlyRecurringSettingsDto body)
        {
            var url = $"/api/data/npt/{taskId}/recurring/monthly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Create Daily Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The daily recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateDailyRecurringNpts(Guid taskId, DailyRecurringSettingsDto body)
        {
            var url = $"/api/data/npt/{taskId}/recurring/daily";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Create Yearly Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="body">The yearly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateYearlyRecurringNpts(Guid taskId, YearlyRecurringSettingsDto body)
        {
            var url = $"/api/data/npt/{taskId}/recurring/yearly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Delete Recurring Npts
        /// </summary>
        /// <param name="taskId">The unique identifier or short ID of the Npt Tasks</param>
        /// <param name="option">The options for the deletion</param>
        public async Task<AstroResult<DeletedTasksDto>> DeleteRecurringNpts(Guid taskId, string option)
        {
            var url = $"/api/data/npt/{taskId}/recurring/{option}";
            return await _client.Request<DeletedTasksDto>(HttpMethod.Delete, url, null);
        }
    }
}
