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
    /// The TaskFieldProject is a summary of the Project that this TaskField relates to.
    /// </summary>
    public class TaskFieldProjectDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Project.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The ShortId of this Project.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The common name of this Project.
        /// </summary>
        public string Name { get; set; }
    }
}
