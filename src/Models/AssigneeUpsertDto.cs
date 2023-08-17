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
    /// An AssigneeUpsert is a create-or-update process that will either create
    /// a new assignment of effort to a TaskAssignee or update an existing effort
    /// amount for an existing TaskAssignee.
    /// </summary>
    public class AssigneeUpsertDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the TaskAssignee to which work is being assigned.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The new amount of effort to assign for this Resource.
        /// </summary>
        public int? AssignedEffort { get; set; }
    }
}
