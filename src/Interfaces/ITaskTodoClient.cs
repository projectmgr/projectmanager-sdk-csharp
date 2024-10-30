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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to TaskTodo
    /// </summary>
    public interface ITaskTodoClient
    {

        /// <summary>
        /// Retrieve a list of todos for a task
        /// </summary>
        /// <param name="taskId">the id of the task</param>
        Task<AstroResult<TaskTodoDto[]>> GetTodosForATask(Guid taskId);

        /// <summary>
        /// Create a todo for a task
        /// </summary>
        /// <param name="taskId">the id of the task</param>
        /// <param name="body">the data for creating a todo</param>
        Task<AstroResult<TaskTodoDto>> CreateATodoForATask(Guid taskId, TaskTodoCreateDto body);

        /// <summary>
        /// Update a todo for a task
        /// </summary>
        /// <param name="todoId">the id of the task</param>
        /// <param name="body">the data for updating a todo</param>
        Task<AstroResult<TaskTodoDto>> UpdateATodo(Guid todoId, TaskTodoUpdateDto body);

        /// <summary>
        /// Remove a todo
        /// </summary>
        /// <param name="todoId">the id of the todo</param>
        Task<AstroResult<string>> DeleteATodo(Guid todoId);
    }
}
