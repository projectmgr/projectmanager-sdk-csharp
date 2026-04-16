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
    /// API methods related to MeetingTodos
    /// </summary>
    public class MeetingTodosClient : IMeetingTodosClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public MeetingTodosClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Get todos for a meeting
        /// </summary>
        /// <param name="meetingId">The id of the meeting</param>
        public async Task<AstroResult<MeetingTodoDto[]>> GetMeetingTodos(Guid meetingId)
        {
            var url = $"/api/data/meetings/{meetingId}/todos";
            return await _client.Request<MeetingTodoDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a new todos and associates it with the meeting
        /// </summary>
        /// <param name="meetingId">The id of the meeting</param>
        /// <param name="body">The todos to create</param>
        public async Task<AstroResult<MeetingTodoDto>> CreateMeetingTodos(Guid meetingId, MeetingTodoCreateDto body)
        {
            var url = $"/api/data/meetings/{meetingId}/todos";
            return await _client.RequestWithBody<MeetingTodoDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Update a todos
        /// </summary>
        /// <param name="todoId">The id of the todos</param>
        /// <param name="body">The fields to update</param>
        public async Task<AstroResult<MeetingTodoDto>> UpdateAMeetingTodos(Guid todoId, MeetingTodoUpdateDto body)
        {
            var url = $"/api/data/meetings/todos/{todoId}";
            return await _client.RequestWithBody<MeetingTodoDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Remove meeting todos
        /// </summary>
        /// <param name="todoId">The id of the todos to remove</param>
        public async Task<AstroResult<string>> RemoveMeetingTodos(Guid todoId)
        {
            var url = $"/api/data/meetings/todos/{todoId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
