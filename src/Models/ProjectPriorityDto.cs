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
    /// A ProjectPriority is a named priority level used by your business to determine how to decide
    /// which Tasks are the most important.  You can name your ProjectPriority levels anything you like
    /// and you can reorganize the order of the ProjectPriority levels at any time.
    /// </summary>
    public class ProjectPriorityDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ProjectPriority.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ProjectPriority.
        /// </summary>
        public string Name { get; set; }
    }
}
