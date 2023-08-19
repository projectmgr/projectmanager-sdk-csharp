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
    /// A TaskPriority is a named priority level used by your business to determine how to decide
    /// which Tasks are the most important.  You can name your TaskPriority levels anything you like
    /// and you can reorganize the order of the TaskPriority levels at any time.
    /// </summary>
    public class TaskPriorityDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this TaskPriority.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// The name of this TaskPriority.
        /// </summary>
        public string Name { get; set; }
    }
}
