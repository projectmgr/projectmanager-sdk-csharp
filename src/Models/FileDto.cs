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
    /// Represents a file in project manager
    /// </summary>
    public class FileDto : ApiModel
    {

        /// <summary>
        /// The identifier for this file
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// If specified this file belongs to a project. The value is the id of  this project
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// If specified, the file has been associated with this task.
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// The reference for who uploaded the file
        /// </summary>
        public Guid? OwnerId { get; set; }

        /// <summary>
        /// The UTC time the file was created.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// A reference to the folder
        /// </summary>
        public Guid? FolderId { get; set; }

        /// <summary>
        /// The type of the file
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// A user friendly label for the file type
        /// </summary>
        public string FileTypeLabel { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Path to download the file
        /// </summary>
        public string DownloadPath { get; set; }

        /// <summary>
        /// Is the file in the trash can
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Defines the object type the file belongs to.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The name of the file
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id of owner of parent entity
        /// </summary>
        public Guid? EntityOwnerId { get; set; }
    }
}
