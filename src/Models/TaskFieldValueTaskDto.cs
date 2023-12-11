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
    /// The TaskFieldTask is a summary of the Task that this TaskFieldValue relates to.
    /// </summary>
    public class TaskFieldValueTaskDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Task.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique Short Id of this Task.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The common name of this Task.
        /// </summary>
        public string Name { get; set; }
    }
}
