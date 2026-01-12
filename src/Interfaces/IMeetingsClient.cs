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
    /// API methods related to Meetings
    /// </summary>
    public interface IMeetingsClient
    {

        /// <summary>
        /// Retrieve a Meeting by its unique identifier or by its short ID.
        /// A Meeting has both a unique identifier, which is a GUID, and a short ID, which is a small text label that is unique only within your Workspace.
        /// </summary>
        /// <param name="meetingId">the id of the meeting</param>
        Task<AstroResult<MeetingDetailsDto>> GetMeeting(string meetingId);

        /// <summary>
        /// Updates a Meeting by its unique identifier, which is a GUID.
        /// </summary>
        /// <param name="meetingId">the id of the meeting</param>
        /// <param name="body">the fields to update</param>
        Task<AstroResult<MeetingDto>> UpdateMeeting(Guid meetingId, MeetingUpdateDto body);

        /// <summary>
        /// Removes a Meeting by its unique identifier, which is a GUID.
        /// </summary>
        /// <param name="meetingId">the id of the meeting to remove</param>
        Task<AstroResult<string>> RemoveMeeting(Guid meetingId);

        /// <summary>
        /// Creates a new Meeting for the current user.
        /// If you specify an assignee for this Meeting, that user will be assigned to it.
        /// If you do not specify an assignee, the Meeting will be automatically assigned to you.
        /// </summary>
        /// <param name="body">The data used to create the Meeting</param>
        Task<AstroResult<MeetingDto>> CreateMeeting(MeetingCreateDto body);

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The weekly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateWeeklyRecurringMeetings(Guid meetingId, WeeklyRecurringSettingsDto body);

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The monthly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateMonthlyRecurringMeetings(Guid meetingId, MonthlyRecurringSettingsDto body);

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The daily recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateDailyRecurringMeetings(Guid meetingId, DailyRecurringSettingsDto body);

        /// <summary>
        /// Changes an existing Non-Project Task into a Recurring Task, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The yearly recurring settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> CreateYearlyRecurringMeetings(Guid meetingId, YearlyRecurringSettingsDto body);

        /// <summary>
        /// Removes one or more instances of a Recurring Non-Project Task based on the `option` you specify: `this` means
        /// to remove a single instance, `all` means to remove all instances, or `future` means to remove all future
        /// instances of the Recurring Task.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Recurring Meeting</param>
        /// <param name="option">The options for the deletion</param>
        Task<AstroResult<DeletedTasksDto>> DeleteRecurringMeetings(Guid meetingId, string option);

        /// <summary>
        /// Reviews potential updates to a Recurring Non-Project Task and report back on the list of changes that would
        /// occur if this Recurring Non-Project Task was updated with these settings.
        ///
        /// When making changes to a Recurring Npt, you may want to investigate the consequences of your changes first
        /// before finalizing the changes.  You can use the Validate Recurring Npts API to examine these changes.  When
        /// you are happy with the changes, call Update Recurring Npts to complete them.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The new settings</param>
        Task<AstroResult<RecurringTaskValidationResultDto>> ValidateRecurringMeetingSettings(Guid meetingId, RecurringTaskSettingsDto body);

        /// <summary>
        /// Updates the settings for a Recurring Non-Project Task and re-generates occurrences of the Recurring Non-Project
        /// Task from the new rules.
        ///
        /// When making changes to a Recurring Npt, you may want to investigate the consequences of your changes first
        /// before finalizing the changes.  You can use the Validate Recurring Npts API to examine these changes.  When
        /// you are happy with the changes, call Update Recurring Npts to complete them.
        ///
        /// A Recurring Task is one that must be completed on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly.  To create a Recurring Task, you must first create a regular Task with the necessary information,
        /// then call one of the Create Recurring Task APIs.  To remove an instance of a Recurring Task, call Delete
        /// Recurring Task and specify one or more instances of the Recurring Task.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The new settings</param>
        Task<AstroResult<RecurringTaskChangeSetDetails>> UpdateRecurringMeetingSettings(Guid meetingId, RecurringTaskSettingsDto body);
    }
}
