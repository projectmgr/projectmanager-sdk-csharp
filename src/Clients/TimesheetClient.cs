/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
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
        ///
        /// </summary>
        /// <param name="body">Payload</param>
        public async Task<AstroResult<TimesheetResponseDto>> Createtimeentry(TimesheetCreateRequestDto body)
        {
            var url = $"/api/data/timesheets";
            return await _client.Request<TimesheetResponseDto>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Delete time entry by id.
        ///
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        public async Task<AstroResult<string>> Deletetimeentry(Guid timesheetId)
        {
            var url = $"/api/data/timesheets/{timesheetId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Updates a time entry by its unique identifier.
        ///
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        /// <param name="body">payload</param>
        public async Task<AstroResult<TimesheetResponseDto>> Updatetimeentry(Guid timesheetId, TimesheetUpdateRequestDto body)
        {
            var url = $"/api/data/timesheets/{timesheetId}";
            return await _client.Request<TimesheetResponseDto>(HttpMethod.Put, url, null, body, null);
        }

        /// <summary>
        /// Returns active admin tasks that are used to report time not related to work on projects. I.e. annual/sick leave etc
        ///
        /// </summary>
        public async Task<AstroResult<TimesheetAdminTypeDto[]>> Returnsactiveadmintasksthatareusedtoreporttime()
        {
            var url = $"/api/data/timesheets/admintasks";
            return await _client.Request<TimesheetAdminTypeDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
