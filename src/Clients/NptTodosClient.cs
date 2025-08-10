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
    /// API methods related to NptTodos
    /// </summary>
    public class NptTodosClient : INptTodosClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public NptTodosClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Get todos for a npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        public async Task<AstroResult<TaskTodoDto[]>> GetNptTodos(Guid nptId)
        {
            var url = $"/api/data/non-project-tasks/{nptId}/todos";
            return await _client.Request<TaskTodoDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Creates a new todo and associates it with the npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        /// <param name="body">The todo to create</param>
        public async Task<AstroResult<TaskTodoDto>> CreateNptTodo(Guid nptId, TaskTodoCreateDto body)
        {
            var url = $"/api/data/non-project-tasks/{nptId}/todos";
            return await _client.RequestWithBody<TaskTodoDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Update a Todo
        /// </summary>
        /// <param name="todoId">the id of the todo</param>
        /// <param name="body">the fields to update</param>
        public async Task<AstroResult<TaskTodoDto>> UpdateANptTodo(Guid todoId, TaskTodoUpdateDto body)
        {
            var url = $"/api/data/non-project-tasks/todos/{todoId}";
            return await _client.RequestWithBody<TaskTodoDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Remove Npt Todo
        /// </summary>
        /// <param name="todoId">the id of the todo to remove</param>
        public async Task<AstroResult<string>> RemoveNptTodo(Guid todoId)
        {
            var url = $"/api/data/non-project-tasks/todos/{todoId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
