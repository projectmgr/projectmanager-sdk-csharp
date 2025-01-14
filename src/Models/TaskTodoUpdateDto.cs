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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// The properties for updating a task dto
    /// </summary>
    public class TaskTodoUpdateDto : ApiModel
    {

        /// <summary>
        /// The full description of this TaskTodo.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// True if this TaskTodo is complete.
        /// </summary>
        public bool? Complete { get; set; }
    }
}
