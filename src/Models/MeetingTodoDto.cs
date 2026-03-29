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
    /// A MeetingTodo is a sub-item that represents a unit of work on the Meeting. You can use
    /// MeetingTodo to represent individual items for a larger piece of work (e.g. agenda items, action items).
    /// </summary>
    public class MeetingTodoDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this MeetingTodo.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The full description of this MeetingTodo.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// True if this MeetingTodo is complete.
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
