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
    /// A ProjectStatus is a named condition used by your business to categorize the completion level
    /// of Tasks and Projects within your Workspace.  You can name your ProjectStatus levels anything
    /// you like and you can reorganize the order of the ProjectPriority levels at any time.
    /// </summary>
    public class ProjectStatusDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ProjectStatus.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ProjectStatus.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Is this a deleted status
        /// </summary>
        public bool? Isdeleted { get; set; }
    }
}
