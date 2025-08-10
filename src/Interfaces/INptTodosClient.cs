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
    /// API methods related to NptTodos
    /// </summary>
    public interface INptTodosClient
    {

        /// <summary>
        /// Get todos for a npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        Task<AstroResult<TaskTodoDto[]>> GetNptTodos(Guid nptId);

        /// <summary>
        /// Creates a new todo and associates it with the npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        /// <param name="body">The todo to create</param>
        Task<AstroResult<TaskTodoDto>> CreateNptTodo(Guid nptId, TaskTodoCreateDto body);

        /// <summary>
        /// Update a Todo
        /// </summary>
        /// <param name="todoId">the id of the todo</param>
        /// <param name="body">the fields to update</param>
        Task<AstroResult<TaskTodoDto>> UpdateANptTodo(Guid todoId, TaskTodoUpdateDto body);

        /// <summary>
        /// Remove Npt Todo
        /// </summary>
        /// <param name="todoId">the id of the todo to remove</param>
        Task<AstroResult<string>> RemoveNptTodo(Guid todoId);
    }
}
