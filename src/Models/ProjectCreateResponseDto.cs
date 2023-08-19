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
    /// A Project is a collection of Tasks that contributes towards a goal.  Within a Project, Tasks
    /// represent individual items of work that team members must complete.  The sum total of Tasks
    /// within a Project represents the work to be completed for that Project.
    /// </summary>
    public class ProjectCreateResponseDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the project of this project, or null if not assigned.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The unique identifier of the shortid of this project, or null if not assigned.
        /// </summary>
        public string ShortId { get; set; }
    }
}
