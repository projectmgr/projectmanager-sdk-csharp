/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
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
    /// API methods related to Timesheet
    /// </summary>
    public class TimesheetClient : ITimesheetClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TimesheetClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates new time entry for given resource on given day.
        /// </summary>
        /// <param name="body">Payload</param>
        public async Task<AstroResult<TimesheetResponseDto>> CreateTimeEntry(TimesheetCreateRequestDto body)
        {
            var url = $"/api/data/timesheets";
            return await _client.RequestWithBody<TimesheetResponseDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Retrieve a list of TimeSheets that match an [OData formatted query](https://www.odata.org/).
        ///
        /// Time Sheets is a list of times per task
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        public async Task<AstroResult<TimesheetDto[]>> QueryTimeSheets(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null)
        {
            var url = $"/api/data/timesheets";
            var options = new Dictionary<string, object>();
            if (top != null) { options["$top"] = top; }
            if (skip != null) { options["$skip"] = skip; }
            if (filter != null) { options["$filter"] = filter; }
            if (orderby != null) { options["$orderby"] = orderby; }
            if (expand != null) { options["$expand"] = expand; }
            return await _client.Request<TimesheetDto[]>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Delete time entry by id.
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        public async Task<AstroResult<string>> DeleteTimeEntry(Guid timesheetId)
        {
            var url = $"/api/data/timesheets/{timesheetId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Updates a time entry by its unique identifier.
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        /// <param name="body">payload</param>
        public async Task<AstroResult<TimesheetResponseDto>> UpdateTimeEntry(Guid timesheetId, TimesheetUpdateRequestDto body)
        {
            var url = $"/api/data/timesheets/{timesheetId}";
            return await _client.RequestWithBody<TimesheetResponseDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Returns active admin tasks that are used to report time not related to work on projects. I.e. annual/sick leave etc
        /// </summary>
        public async Task<AstroResult<TimesheetAdminTypeDto[]>> ReturnsActiveAdminTasksThatAreUsedToReportTime()
        {
            var url = $"/api/data/timesheets/admin-tasks";
            return await _client.Request<TimesheetAdminTypeDto[]>(HttpMethod.Get, url, null);
        }
    }
}
