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
    /// Represents a file associated with a Task in project manager
    /// </summary>
    public class TaskFileDto : ApiModel
    {

        /// <summary>
        /// The identifier for this file
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the file
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The url of the file which can be used for downloading
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The date the file was created/uploaded
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The file type (e.g. extension or MIME type)
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// The display label for the file type
        /// </summary>
        public string FileTypeLabel { get; set; }

        /// <summary>
        /// File size in bytes (for task attachment lists / Gantt grid)
        /// </summary>
        public int? Size { get; set; }
    }
}
