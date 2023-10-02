/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A TaskTag is a connection between a Task and a Tag.  Each Task can have zero, one or many
    /// TaskTags associated with it.  TaskTags can be assigned and removed from the Task to help you
    /// classify your Tasks and prioritize work.
    /// </summary>
    public class TimesheetTaskTagDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this TaskStatus.
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// The unique identifier of the TaskTag id.
        /// </summary>
        public Guid? TagId { get; set; }

        /// <summary>
        /// The name of this TaskStatus.
        /// </summary>
        public string Name { get; set; }
    }
}
