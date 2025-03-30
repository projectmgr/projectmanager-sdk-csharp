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
    /// This is the projectId being restored to
    /// </summary>
    public class ProjectRestoreProjectDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the Project.  This value is set by the system and cannot
        /// be set with a CreateProject or changed with an UpdateProject call.
        /// </summary>
        public Guid? Id { get; set; }
    }
}
