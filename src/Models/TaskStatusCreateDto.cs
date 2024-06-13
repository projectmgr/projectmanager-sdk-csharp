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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A TaskStatus is a named status level used by your business to determine how to measure the
    /// progress of Tasks.  You can define your own named status levels that are appropriate for
    /// your business and determine which status levels are considered done.
    /// </summary>
    public class TaskStatusCreateDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this TaskStatus.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this TaskStatus.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A numerical value that can be used to sort TaskStatus values according to the
        /// needs of your business.
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// A numerical value that can be used to sort TaskStatus values according to the
        /// needs of your business.
        /// </summary>
        public bool? IsDone { get; set; }
    }
}
