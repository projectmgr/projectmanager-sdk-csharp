/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
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
    /// API methods related to TaskTodo
    /// </summary>
    public class TaskTodoClient : ITaskTodoClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TaskTodoClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve a list of todos for a task
        /// </summary>
        /// <param name="taskId">the id of the task</param>
        public async Task<AstroResult<TaskTodoDto[]>> GetTodosForATask(Guid taskId)
        {
            var url = $"/api/data/tasks/{taskId}/todos";
            return await _client.Request<TaskTodoDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Create a todo for a task
        /// </summary>
        /// <param name="taskId">the id of the task</param>
        /// <param name="body">the data for creating a todo</param>
        public async Task<AstroResult<TaskTodoDto>> CreateATodoForATask(Guid taskId, TaskTodoCreateDto body)
        {
            var url = $"/api/data/tasks/{taskId}/todos";
            return await _client.RequestWithBody<TaskTodoDto>(HttpMethod.Post, url, null, body);
        }

        /// <summary>
        /// Update a todo for a task
        /// </summary>
        /// <param name="todoId">the id of the task</param>
        /// <param name="body">the data for updating a todo</param>
        public async Task<AstroResult<TaskTodoDto>> UpdateATodo(Guid todoId, TaskTodoUpdateDto body)
        {
            var url = $"/api/data/tasks/todos/{todoId}";
            return await _client.RequestWithBody<TaskTodoDto>(HttpMethod.Put, url, null, body);
        }

        /// <summary>
        /// Remove a todo
        /// </summary>
        /// <param name="todoId">the id of the todo</param>
        public async Task<AstroResult<string>> DeleteATodo(Guid todoId)
        {
            var url = $"/api/data/tasks/todos/{todoId}";
            return await _client.Request<string>(HttpMethod.Delete, url, null);
        }
    }
}
