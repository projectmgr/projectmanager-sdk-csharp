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
    /// The ProjectFile represents an attached file that is connected to a Project
    /// and can be retrieved for download.
    /// </summary>
    public class ProjectFileDto : ApiModel
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
        /// The project task that this file relates to.
        ///
        /// This field will be present when you fetch a single object.
        /// When you query for multiple objects, this field is not included in results by default.
        /// To expand this field, specify the name of this field in the `$expand` parameter.
        /// </summary>
        public ProjectFileTaskDto Task { get; set; }

        /// <summary>
        /// The folder that this file relates to.
        ///
        /// This field will be present when you fetch a single object.
        /// When you query for multiple objects, this field is not included in results by default.
        /// To expand this field, specify the name of this field in the `$expand` parameter.
        /// </summary>
        public ProjectFileFolderDto Folder { get; set; }
    }
}
