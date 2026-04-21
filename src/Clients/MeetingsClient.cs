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
    /// API methods related to Meetings
    /// </summary>
    public class MeetingsClient : IMeetingsClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public MeetingsClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve a list of Meetings.
        ///
        /// This endpoint does not use OData. If `projectId` is provided, results are limited to that Project.
        /// </summary>
        /// <param name="projectId">Optional project id to scope results</param>
        public async Task<AstroResult<MeetingDto[]>> GetMeetings(Guid? projectId = null)
        {
            var url = $"/api/data/meetings";
            var options = new Dictionary<string, object>();
            if (projectId != null) { options["projectId"] = projectId; }
            return await _client.Request<MeetingDto[]>(HttpMethod.Get, url, options);
        }

        /// <summary>
        /// Creates a new Meeting for the current user.
        /// If you specify an assignee for this Meeting, that user will be assigned to it.
        /// If you do not specify an assignee, the Meeting will be automatically assigned to you.
        /// </summary>
        /// <param name="body">The data used to create the Meeting</param>
        public async Task<AstroResult<MeetingDto>> CreateMeeting(MeetingCreateDto body)
        {
            var url = $"/api/data/meetings";
            return await _client.RequestWithBody<MeetingDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Retrieve a Meeting by its unique identifier or by its short ID.
        /// A Meeting has both a unique identifier, which is a GUID, and a short ID, which is a small text label that is unique only within your Workspace.
        /// </summary>
        /// <param name="meetingId">the id of the meeting</param>
        public async Task<AstroResult<MeetingDetailsDto>> GetMeeting(string meetingId)
        {
            var url = $"/api/data/meetings/{meetingId}";
            return await _client.Request<MeetingDetailsDto>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Updates a Meeting by its unique identifier, which is a GUID.
        /// </summary>
        /// <param name="meetingId">the id of the meeting</param>
        /// <param name="body">the fields to update</param>
        public async Task<AstroResult<MeetingDto>> UpdateMeeting(Guid meetingId, MeetingUpdateDto body)
        {
            var url = $"/api/data/meetings/{meetingId}";
            return await _client.RequestWithBody<MeetingDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Removes a Meeting by its unique identifier, which is a GUID.
        /// </summary>
        /// <param name="meetingId">the id of the meeting to remove</param>
        public async Task<AstroResult<string>> RemoveMeeting(Guid meetingId)
        {
            var url = $"/api/data/meetings/{meetingId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }

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
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateWeeklyRecurringMeetings(Guid meetingId, WeeklyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/weekly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

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
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateMonthlyRecurringMeetings(Guid meetingId, MonthlyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/monthly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

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
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateDailyRecurringMeetings(Guid meetingId, DailyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/daily";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

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
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateYearlyRecurringMeetings(Guid meetingId, YearlyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/yearly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

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
        public async Task<AstroResult<DeletedTasksDto>> DeleteRecurringMeetings(Guid meetingId, string option)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/{option}";
            return await _client.Request<DeletedTasksDto>(HttpMethod.Delete, url, null);
        }

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
        public async Task<AstroResult<RecurringTaskValidationResultDto>> ValidateRecurringMeetingSettings(Guid meetingId, RecurringTaskSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/settings/validate";
            return await _client.RequestWithBody<RecurringTaskValidationResultDto>(HttpMethod.Post, url, null, body);
        }

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
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> UpdateRecurringMeetingSettings(Guid meetingId, RecurringTaskSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/settings";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Put, url, null, body);
        }
    }
}
