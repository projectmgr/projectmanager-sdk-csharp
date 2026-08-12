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
    /// The result of moving a single Task into a TaskStatus.  One result is returned per
    /// requested Task move, in the same order as the request.
    /// </summary>
    public class TaskStatusMoveResultDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Task that was moved.
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Whether the move was accepted for this Task.
        /// </summary>
        public bool? Success { get; set; }

        /// <summary>
        /// The reason the move was rejected, when Success is false.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// When the Task belongs to a Project, the move is applied asynchronously as a Changeset
        /// and this contains its unique identifier.  You can use RetrieveChangeset to check the
        /// progress of the move.  This is null when the move was applied immediately.
        /// </summary>
        public Guid? ChangeSetId { get; set; }
    }
}
