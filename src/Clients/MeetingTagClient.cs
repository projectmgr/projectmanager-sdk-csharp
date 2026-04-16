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
    /// API methods related to MeetingTag
    /// </summary>
    public class MeetingTagClient : IMeetingTagClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public MeetingTagClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Replaces the existing tags on a Meeting with a newly provided list.
        /// A tag is a connection between a Meeting and a Tag. Each Meeting can have zero, one or many tags.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The replacement list of tags for this Meeting</param>
        public async Task<AstroResult<TaskTagDto[]>> ReplaceMeetingTags(Guid meetingId, NameDto[] body)
        {
            var url = $"/api/data/meetings/{meetingId}/tags";
            return await _client.RequestWithBody<TaskTagDto[]>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Add one or more tags to a Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The tags to add</param>
        public async Task<AstroResult<TaskTagDto[]>> AddTagsToMeeting(Guid meetingId, NameDto[] body)
        {
            var url = $"/api/data/meetings/{meetingId}/tags";
            return await _client.RequestWithBody<TaskTagDto[]>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Removes one or more tags from a Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        /// <param name="body">The tags to remove</param>
        public async Task<AstroResult<string>> RemoveTagsFromMeeting(Guid meetingId, NameDto[] body)
        {
            var url = $"/api/data/meetings/{meetingId}/tags";
            return await _client.RequestWithBody<string>(HttpMethod.Delete, url, null, body);
        }

        /// <summary>
        /// Returns the list of tags assigned to the specified Meeting.
        /// </summary>
        /// <param name="meetingId">The unique identifier of the Meeting</param>
        public async Task<AstroResult<TaskTagDto[]>> RetrieveTagsForAMeeting(Guid meetingId)
        {
            var url = $"/api/data/meetings/{meetingId}/tags";
            return await _client.Request<TaskTagDto[]>(HttpMethod.Get, url, null);
        }
    }
}
