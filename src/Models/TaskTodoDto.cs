/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A TaskTodo is a sub-task that represents a unit of work on the Task.  You can use
    /// TaskTodo to represent individual items for a larger piece of work.
    /// </summary>
    public class TaskTodoDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this TaskTodo.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The full description of this TaskTodo.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// True if this TaskTodo is complete.
        /// </summary>
        public bool? Complete { get; set; }

        /// <summary>
        /// The timestamp in UTC when this object was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The timestamp in UTC when this object was last modified.
        /// </summary>
        public DateTime? ModifyDate { get; set; }
    }
}
