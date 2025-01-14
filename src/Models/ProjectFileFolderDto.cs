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
    /// A Folder is a named storage location that can contain Files.
    /// </summary>
    public class ProjectFileFolderDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Folder.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this Folder.
        /// </summary>
        public string Name { get; set; }
    }
}
