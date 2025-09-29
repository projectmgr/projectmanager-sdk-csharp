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
    /// Contains details of recurring NPT task deletions.
    /// </summary>
    public class DeletedTasksDto : ApiModel
    {

        /// <summary>
        /// The total number of tasks that were deleted.
        /// </summary>
        public int? DeletedCount { get; set; }

        /// <summary>
        /// The unique identifiers of the tasks that were deleted.
        /// </summary>
        public Guid[] DeletedTaskIds { get; set; }
    }
}
