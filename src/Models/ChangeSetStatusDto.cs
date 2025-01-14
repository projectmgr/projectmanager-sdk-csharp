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
    /// Returns the id of a specific ChangeSet
    /// </summary>
    public class ChangeSetStatusDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Changeset
        /// </summary>
        public Guid? ChangeSetId { get; set; }

        /// <summary>
        /// The unique identifier of the entity affected by this Changeset.  For example, if this
        /// Changeset was created for a Task, this value will be the unique identifier for the Task.
        /// </summary>
        public Guid? Id { get; set; }
    }
}
