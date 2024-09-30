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
    /// Represents information about a Task that is relevant to a ProjectFile
    /// </summary>
    public class ProjectFileTaskDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this Task.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// A short ID that can be used to refer to this Task.  This short ID is
        /// guaranteed to be unique within your Workspace.
        /// </summary>
        public string ShortId { get; set; }

        /// <summary>
        /// The common name of this Task.
        /// </summary>
        public string Name { get; set; }
    }
}
