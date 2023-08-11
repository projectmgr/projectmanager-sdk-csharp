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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to Timesheet
    /// </summary>
    public interface ITimesheetClient
    {

        /// <summary>
        /// Creates new time entry for given resource on given day.
        ///
        /// </summary>
        /// <param name="body">Payload</param>
        Task<AstroResult<TimesheetResponseDto>> Createtimeentry(TimesheetCreateRequestDto body);

        /// <summary>
        /// Delete time entry by id.
        ///
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        Task<AstroResult<string>> Deletetimeentry(Guid timesheetId);

        /// <summary>
        /// Updates a time entry by its unique identifier.
        ///
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        /// <param name="body">payload</param>
        Task<AstroResult<TimesheetResponseDto>> Updatetimeentry(Guid timesheetId, TimesheetUpdateRequestDto body);

        /// <summary>
        /// Returns active admin tasks that are used to report time not related to work on projects. I.e. annual/sick leave etc
        ///
        /// </summary>
        Task<AstroResult<TimesheetAdminTypeDto[]>> Returnsactiveadmintasksthatareusedtoreporttime();
    }
}
