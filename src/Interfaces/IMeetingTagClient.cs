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
    /// API methods related to MeetingTag
    /// </summary>
    public interface IMeetingTagClient
    {

        /// <summary>
        /// Replaces the existing tags on a Meeting with a newly provided list.
        /// A tag is a connection between a Meeting and a Tag. Each Meeting can have zero, one or many tags.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The replacement list of tags for this Meeting</param>
        Task<AstroResult<TaskTagDto[]>> ReplaceMeetingTags(Guid meetingId, NameDto[] body);

        /// <summary>
        /// Add one or more tags to a Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The tags to add</param>
        Task<AstroResult<TaskTagDto[]>> AddTagsToMeeting(Guid meetingId, NameDto[] body);

        /// <summary>
        /// Removes one or more tags from a Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The tags to remove</param>
        Task<AstroResult<string>> RemoveTagsFromMeeting(Guid meetingId, NameDto[] body);

        /// <summary>
        /// Returns the list of tags assigned to the specified Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        Task<AstroResult<TaskTagDto[]>> RetrieveTagsForAMeeting(Guid meetingId);
    }
}
