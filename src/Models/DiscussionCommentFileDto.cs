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
    /// The DiscussionCommentFile represents a file that has been attached to a discussion
    /// and is available for download.
    /// </summary>
    public class DiscussionCommentFileDto : ApiModel
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
        /// The url of the DownloadFile API to retrieve this file
        /// </summary>
        public string Url { get; set; }
    }
}
