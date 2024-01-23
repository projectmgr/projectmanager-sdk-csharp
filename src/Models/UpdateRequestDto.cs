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
    /// Represents an update request for a File within ProjectManager.
    ///
    /// ProjectManager allows you to store Files connected to other elements of your Workspace
    /// such as a Project or a Discussion.  When you upload a File, please allow a few moments
    /// for the File to be processed and verified.  ProjectManager may reject File uploads that
    /// contain problems such as malware. Once a File has completed the upload the process, you
    /// may retrieve it using the DownloadFile API.
    /// </summary>
    public class UpdateRequestDto : ApiModel
    {

        /// <summary>
        /// The new name for the File.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// To assign this File to a Task, specify the TaskId here.
        /// </summary>
        public Guid? Taskid { get; set; }

        /// <summary>
        /// To move this File to a new Folder, specify the Folder&#39;s unique identifier here.
        /// </summary>
        public Guid? Folderid { get; set; }
    }
}
