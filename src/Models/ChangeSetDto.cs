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
    /// The project task change set
    /// </summary>
    public class ChangeSetDto : ApiModel
    {

        /// <summary>
        /// Project Changeset ID
        /// </summary>
        public int? ProjectChangeSetId { get; set; }

        /// <summary>
        /// The unique identifier of this Changeset
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Task version
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Created by GUID
        /// </summary>
        public Guid? CreateBy { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Change set action
        /// </summary>
        public string Actions { get; set; }

        /// <summary>
        /// Change set in json string
        /// </summary>
        public string ChangeSets { get; set; }

        /// <summary>
        /// Processed date
        /// </summary>
        public DateTime? ProcessDate { get; set; }

        /// <summary>
        /// If process was successful
        /// </summary>
        public bool? Success { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// UI ID
        /// </summary>
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Changeset JSON data
        /// </summary>
        public string JsonData { get; set; }

        /// <summary>
        /// Is change set from UNDO
        /// </summary>
        public bool? IsUndo { get; set; }

        /// <summary>
        /// The state of the changeset
        /// </summary>
        public int? State { get; set; }

        /// <summary>
        /// Business ID
        /// </summary>
        public Guid? BusinessId { get; set; }
    }
}
