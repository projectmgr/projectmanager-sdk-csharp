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
    /// API methods related to MeetingTodos
    /// </summary>
    public interface IMeetingTodosClient
    {

        /// <summary>
        /// Get todos for a meeting
        /// </summary>
        /// <param name="meetingId">The id of the meeting</param>
        Task<AstroResult<MeetingTodoDto[]>> GetMeetingTodos(Guid meetingId);

        /// <summary>
        /// Creates a new todos and associates it with the meeting
        /// </summary>
        /// <param name="meetingId">The id of the meeting</param>
        /// <param name="body">The todos to create</param>
        Task<AstroResult<MeetingTodoDto>> CreateMeetingTodos(Guid meetingId, MeetingTodoCreateDto body);

        /// <summary>
        /// Update a todos
        /// </summary>
        /// <param name="todoId">The id of the todos</param>
        /// <param name="body">The fields to update</param>
        Task<AstroResult<MeetingTodoDto>> UpdateAMeetingTodos(Guid todoId, MeetingTodoUpdateDto body);

        /// <summary>
        /// Remove meeting todos
        /// </summary>
        /// <param name="todoId">The id of the todos to remove</param>
        Task<AstroResult<string>> RemoveMeetingTodos(Guid todoId);
    }
}
