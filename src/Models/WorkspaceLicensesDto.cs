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
    /// A summary of the paid user licenses for the workspace the current user is logged on to.
    /// </summary>
    public class WorkspaceLicensesDto : ApiModel
    {

        /// <summary>
        /// The number of paid user licenses purchased for this workspace.
        /// </summary>
        public int? Purchased { get; set; }

        /// <summary>
        /// The number of paid user licenses currently in use by active (non-guest) users.
        /// </summary>
        public int? Used { get; set; }

        /// <summary>
        /// The number of active guest users in this workspace.
        /// </summary>
        public int? GuestUsed { get; set; }

        /// <summary>
        /// The number of purchased licenses still available. This can be negative when the workspace
        /// has more active users than purchased licenses.
        /// </summary>
        public int? Remaining { get; set; }
    }
}
