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
    /// A reaction to a specific comment within a discussion thread.
    /// </summary>
    public class DiscussionEmoji : ApiModel
    {

        /// <summary>
        /// The name of the emoji
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The list of user IDs of the users who tagged these emoji
        /// </summary>
        public Guid[] UserIds { get; set; }
    }
}
