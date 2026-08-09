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
        /// Retrieve a list of Meetings.
        ///
        /// This endpoint does not use OData. If `projectId` is provided, results are limited to that Project.
        /// </summary>
        /// <param name="projectId">Optional project id to scope results</param>
        Task<AstroResult<MeetingDto[]>> GetMeetings(Guid? projectId = null);

        /// <summary>
        /// Creates a new Meeting for the current user.
        /// If you specify an assignee for this Meeting, that user will be assigned to it.
        /// If you do not specify an assignee, the Meeting will be automatically assigned to you.
        /// </summary>
        /// <param name="body">The data used to create the Meeting</param>
        Task<AstroResult<MeetingDto>> CreateMeeting(MeetingCreateDto body);

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
    }
}
