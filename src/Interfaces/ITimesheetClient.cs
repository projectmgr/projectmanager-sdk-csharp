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
    /// API methods related to Timesheet
    /// </summary>
    public interface ITimesheetClient
    {

        /// <summary>
        /// Creates new time entry for given resource on given day.
        /// </summary>
        /// <param name="body">Payload</param>
        Task<AstroResult<TimesheetResponseDto>> CreateTimeEntry(TimesheetCreateRequestDto body);

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
        Task<AstroResult<TimesheetDto[]>> QueryTimeSheets(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Delete time entry by id.
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        Task<AstroResult<string>> DeleteTimeEntry(Guid timesheetId);

        /// <summary>
        /// Updates a time entry by its unique identifier.
        /// </summary>
        /// <param name="timesheetId">time entry id</param>
        /// <param name="body">payload</param>
        Task<AstroResult<TimesheetResponseDto>> UpdateTimeEntry(Guid timesheetId, TimesheetUpdateRequestDto body);

        /// <summary>
        /// Returns active admin tasks that are used to report time not related to work on projects. I.e. annual/sick leave etc
        /// </summary>
        Task<AstroResult<TimesheetAdminTypeDto[]>> ReturnsActiveAdminTasksThatAreUsedToReportTime();

        /// <summary>
        /// Submit a timesheet for approval for a specific resource.
        /// </summary>
        /// <param name="body">The timesheet to be submitted for approval</param>
        Task<AstroResult<TimeSheetApprovalResponseDto>> SubmitResourceTimeSheetForApproval(TimeSheetApprovalDto body);

        /// <summary>
        /// Approve a timesheet approval request
        /// </summary>
        /// <param name="body">The timesheet to approve</param>
        Task<AstroResult<TimeSheetApprovalResponseDto>> ApproveResourceTimeSheetApprovalRequest(TimeSheetApprovalDto body);

        /// <summary>
        /// Rejects a specific resource&#39;s timesheet approval request for a specific week.
        /// </summary>
        /// <param name="body">The data for rejecting the approval request</param>
        Task<AstroResult<TimeSheetApprovalResponseDto>> RejectResourceTimeSheetApprovalRequest(TimeSheetApprovalRejectDto body);
    }
}
