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
    /// Tasks can have discussions attached to them.  These discussions can include text with simple
    /// formatting.  Discussion comments are formatted using [Markdown](https://www.markdownguide.org/)
    /// and users should be aware that HTML embedding is not permitted due to the risk of cross-site
    /// attacks and other embedding challenges.
    /// </summary>
    public class DiscussionCommentDto : ApiModel
    {

        /// <summary>
        /// The unique ID of the discussion comment.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The text of the comment to add to the discussion, in Markdown format.
        ///
        /// Discussion comments are formatted using [Markdown](https://www.markdownguide.org/)
        /// and users should be aware that HTML embedding is not permitted due to the risk of cross-site
        /// attacks and other embedding challenges.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The unique ID of the resource that wrote this comment.
        /// </summary>
        public Guid? AuthorId { get; set; }

        /// <summary>
        /// The unique ID of the resource that wrote this comment.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// The timestamp when the comment was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The timestamp when the comment was modified, if it is different from the create date.
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// The list of emoji reactions to this discussion comment, if any.  This object will
        /// be null if no emoji reactions have been recorded on this discussion comment.
        /// </summary>
        public DiscussionEmoji[] Emoji { get; set; }

        /// <summary>
        /// The list of files associated with this Comment, if any.
        ///
        /// This field will be present when you fetch a single object.
        /// When you query for multiple objects, this field is not included in results by default.
        /// To expand this field, specify the name of this field in the `$expand` parameter.
        /// </summary>
        public DiscussionCommentFileDto[] Files { get; set; }
    }
}
