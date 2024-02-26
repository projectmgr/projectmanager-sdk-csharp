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
    /// The specific change action made against a project
    /// </summary>
    public class ProjectChangeDto : ApiModel
    {

        /// <summary>
        /// Project Change ID
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Workspace ID
        /// </summary>
        public Guid? BusinessId { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Version of this Project Change
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
        /// Processed date
        /// </summary>
        public DateTime? ProcessDate { get; set; }

        /// <summary>
        /// The status of the Project Change
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Project Change as JSON data
        /// </summary>
        public object ChangeData { get; set; }
    }
}
