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
        /// Creates new time entry for Resource on a given day.
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        /// <param name="body">The time entry you wish to create</param>
        Task<AstroResult<TimesheetResponseDto>> CreateTimeEntry(TimesheetCreateRequestDto body);

        /// <summary>
        /// Retrieve a list of time entries that match an [OData formatted query](https://www.odata.org/).
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        /// <param name="top">The number of records to return</param>
        /// <param name="skip">Skips the given number of records and then returns $top records</param>
        /// <param name="filter">Filter the expression according to oData queries</param>
        /// <param name="orderby">Order collection by this field.</param>
        /// <param name="expand">Include related data in the response</param>
        Task<AstroResult<TimesheetDto[]>> QueryTimeEntries(int? top = null, int? skip = null, string filter = null, string orderby = null, string expand = null);

        /// <summary>
        /// Delete time entry by its unique identifier.
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        /// <param name="timesheetId">The unique identifier of the time entry to delete</param>
        Task<AstroResult<string>> DeleteTimeEntry(Guid timesheetId);

        /// <summary>
        /// Updates a time entry by its unique identifier.
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        /// <param name="timesheetId">The unique identifier of the time entry to update</param>
        /// <param name="body">The new information that should replace the previous time entry</param>
        Task<AstroResult<TimesheetResponseDto>> UpdateTimeEntry(Guid timesheetId, TimesheetUpdateRequestDto body);

        /// <summary>
        /// Retrieves a list of Administrative Tasks that are defined for use within your Workspace.
        ///
        /// Administrative tasks are a list of regular, recurring non-Task actions that are typically associated with
        /// overhead, such as sick leave, travel, or attending meetings.
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        Task<AstroResult<TimesheetAdminTypeDto[]>> RetrieveAdministrativeTasks();

        /// <summary>
        /// Submit a Timesheet for approval for a specific Resource and week.
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        /// <param name="body">The Timesheet to be submitted for approval</param>
        Task<AstroResult<TimeSheetApprovalResponseDto>> SubmitTimeSheet(TimeSheetApprovalDto body);

        /// <summary>
        /// Approve an existing Timesheet approval request.
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        /// <param name="body">The Timesheet to approve</param>
        Task<AstroResult<TimeSheetApprovalResponseDto>> ApproveTimeSheet(TimeSheetApprovalDto body);

        /// <summary>
        /// Rejects a specific resource&#39;s Timesheet approval request for a specific week.
        ///
        /// A Timesheet is a collection of time entries for a particular Resource for a specific week.  Each time
        /// entry records the number of whole minutes spent by this Resource on an activity. An activity can be a Task
        /// in any project that Resource can access, or the activity can be an administrative task such as &quot;Sick
        /// Leave&quot; or &quot;Meetings&quot;.  When a time entry is linked to a Task, the number of minutes spent on the time entry
        /// are recorded as time spent on the Task.  Time entries linked to an administrative tasks are grouped for
        /// reporting but are not added to any Task within your Workspace.
        ///
        /// Time entries are recorded in whole minutes.  If you specify a time entry in fractional hours, either using
        /// the API or via the web application, the amount you specify will be converted to minutes and rounded to the
        /// nearest neighbor using the rounding algorithm Midpoint-Away-From-Zero.
        ///
        /// When a Timesheet is submitted for approval or approved, users are no longer permitted to create, update, or
        /// delete time entries for that week.  Users with Global Admin level access can override this restriction and
        /// continue to make changes to a Timesheet after approval.
        /// </summary>
        /// <param name="body">Information about the Timesheet approval request to be rejected</param>
        Task<AstroResult<TimeSheetApprovalResponseDto>> RejectTimeSheet(TimeSheetApprovalRejectDto body);
    }
}
