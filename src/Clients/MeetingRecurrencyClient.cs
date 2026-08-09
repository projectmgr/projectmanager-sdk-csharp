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
    /// API methods related to MeetingRecurrency
    /// </summary>
    public class MeetingRecurrencyClient : IMeetingRecurrencyClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public MeetingRecurrencyClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Changes an existing Meeting into a Recurring Meeting, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Meeting is one that occurs on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly. To create a Recurring Meeting, you must first create a regular Meeting with the necessary information,
        /// then call one of the Create Recurring Meeting APIs. To remove an instance of a Recurring Meeting, call Delete
        /// Recurring Meeting and specify one or more instances of the Recurring Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The weekly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateWeeklyRecurringMeetings(Guid meetingId, WeeklyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/weekly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Changes an existing Meeting into a Recurring Meeting, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Meeting is one that occurs on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly. To create a Recurring Meeting, you must first create a regular Meeting with the necessary information,
        /// then call one of the Create Recurring Meeting APIs. To remove an instance of a Recurring Meeting, call Delete
        /// Recurring Meeting and specify one or more instances of the Recurring Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The monthly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateMonthlyRecurringMeetings(Guid meetingId, MonthlyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/monthly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Changes an existing Meeting into a Recurring Meeting, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Meeting is one that occurs on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly. To create a Recurring Meeting, you must first create a regular Meeting with the necessary information,
        /// then call one of the Create Recurring Meeting APIs. To remove an instance of a Recurring Meeting, call Delete
        /// Recurring Meeting and specify one or more instances of the Recurring Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The daily recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateDailyRecurringMeetings(Guid meetingId, DailyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/daily";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Changes an existing Meeting into a Recurring Meeting, so that it will recur regularly given the specified
        /// rules.
        ///
        /// A Recurring Meeting is one that occurs on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly. To create a Recurring Meeting, you must first create a regular Meeting with the necessary information,
        /// then call one of the Create Recurring Meeting APIs. To remove an instance of a Recurring Meeting, call Delete
        /// Recurring Meeting and specify one or more instances of the Recurring Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The yearly recurring settings</param>
        public async Task<AstroResult<RecurringTaskChangeSetDetails>> CreateYearlyRecurringMeetings(Guid meetingId, YearlyRecurringSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/yearly";
            return await _client.RequestWithBody<RecurringTaskChangeSetDetails>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Removes one or more instances of a Recurring Meeting based on the `option` you specify: `this` means
        /// to remove a single instance, `all` means to remove all instances, or `future` means to remove all future
        /// instances of the Recurring Meeting.
        ///
        /// A Recurring Meeting is one that occurs on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly. To create a Recurring Meeting, you must first create a regular Meeting with the necessary information,
        /// then call one of the Create Recurring Meeting APIs. To remove an instance of a Recurring Meeting, call Delete
        /// Recurring Meeting and specify one or more instances of the Recurring Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Recurring Meeting</param>
        /// <param name="option">The options for the deletion</param>
        public async Task<AstroResult<DeletedTasksDto>> DeleteRecurringMeetings(Guid meetingId, string option)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/{option}";
            return await _client.Request<DeletedTasksDto>(HttpMethod.Delete, url, null);
        }

        /// <summary>
        /// Reviews potential updates to a Recurring Meeting and report back on the list of changes that would
        /// occur if this Recurring Meeting was updated with these settings.
        ///
        /// When making changes to a Recurring Meeting, you may want to investigate the consequences of your changes first
        /// before finalizing the changes. You can use the Validate Recurring Meetings API to examine these changes. When
        /// you are happy with the changes, call Update Recurring Meetings to complete them.
        ///
        /// A Recurring Meeting is one that occurs on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly. To create a Recurring Meeting, you must first create a regular Meeting with the necessary information,
        /// then call one of the Create Recurring Meeting APIs. To remove an instance of a Recurring Meeting, call Delete
        /// Recurring Meeting and specify one or more instances of the Recurring Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The new settings</param>
        public async Task<AstroResult<RecurringTaskValidationResultDto>> ValidateRecurringMeetingSettings(Guid meetingId, RecurringTaskSettingsDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/recurring/settings/validate";
            return await _client.RequestWithBody<RecurringTaskValidationResultDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Updates the settings for a Recurring Meeting and regenerates occurrences of the Recurring Meeting
        /// from the new rules.
        ///
        /// When making changes to a Recurring Meeting, you may want to investigate the consequences of your changes first
        /// before finalizing the changes. You can use the Validate Recurring Meetings API to examine these changes. When
        /// you are happy with the changes, call Update Recurring Meetings to complete them.
        ///
        /// A Recurring Meeting is one that occurs on a specific regular frequency, such as Daily, Weekly, Monthly,
        /// or Yearly. To create a Recurring Meeting, you must first create a regular Meeting with the necessary information,
        /// then call one of the Create Recurring Meeting APIs. To remove an instance of a Recurring Meeting, call Delete
        /// Recurring Meeting and specify one or more instances of the Recurring Meeting.
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
