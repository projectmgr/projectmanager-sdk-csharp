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
    /// Represents a document or file attached to a timesheet day entry.
    /// </summary>
    public class TimesheetFileResponseDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of the document.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the file (including extension).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The download or access URL for the file.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The file type or extension (e.g., &quot;pdf&quot;, &quot;png&quot;).
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// A user-friendly label describing the file type (e.g., &quot;PDF Document&quot;).
        /// </summary>
        public string FileTypeLabel { get; set; }

        /// <summary>
        /// The date and time the file was uploaded or created.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// The ID of the project associated with the file.
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// The type of project (e.g., &quot;project&quot;, &quot;admin&quot;).
        /// </summary>
        public string ProjectType { get; set; }

        /// <summary>
        /// The ID of the task this file is associated with, if any.
        /// </summary>
        public Guid? TaskId { get; set; }

        /// <summary>
        /// A new file name for the document, if renamed.
        /// </summary>
        public string NewFilename { get; set; }

        /// <summary>
        /// Whether other users can read the document.
        /// </summary>
        public bool? CanRead { get; set; }

        /// <summary>
        /// A thumbnail URL for previewing the file (if applicable).
        /// </summary>
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// An optional external provider ID (e.g., for integrations).
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// Indicates whether the current user has permission to delete the file.
        /// </summary>
        public bool? CanDelete { get; set; }

        /// <summary>
        /// Indicates whether the file is locked and cannot be modified.
        /// </summary>
        public bool? IsLocked { get; set; }

        /// <summary>
        /// The object type identifier used by the frontend (&quot;pm.models.Document&quot;).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Indicates whether the document has unsaved changes (used by frontend only).
        /// </summary>
        public bool? Dirty { get; set; }

        /// <summary>
        /// Indicates whether the document is marked for deletion (used by frontend only).
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Indicates whether the document is newly added (used by frontend only).
        /// </summary>
        public bool? IsNew { get; set; }
    }
}
