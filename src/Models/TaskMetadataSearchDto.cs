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
    /// Task Metadata Search DTO
    /// </summary>
    public class TaskMetadataSearchDto : ApiModel
    {

        /// <summary>
        /// Task ID
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Customer or system metadata
        /// </summary>
        public object Metadata { get; set; }
    }
}
