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
    /// A ProjectFolder is a named storage location that can contain Projects.
    /// </summary>
    public class ProjectFolderDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ProjectFolder.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ProjectFolder.
        /// </summary>
        public string Name { get; set; }
    }
}
