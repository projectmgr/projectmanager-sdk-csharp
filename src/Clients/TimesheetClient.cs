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
        public async Task<AstroResult<TimesheetCreatedResponseDto>> Createtimeentry(TimesheetCreateRequestDto body)
        {
            var url = $"/api/data/timesheets";
            return await _client.Request<TimesheetCreatedResponseDto>(HttpMethod.Post, url, null, body, null);
        }
    }
}
