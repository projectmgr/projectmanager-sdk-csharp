/***
 * ProjectManager API for C#
 *
 * (c) 2023-2023 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2023 ProjectManager.com, Inc.
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
    public class DiscussionCreateDto : ApiModel
    {

        /// <summary>
        /// The text of the comment to add to the discussion, in Markdown format.
        ///
        /// Discussion comments are formatted using [Markdown](https://www.markdownguide.org/)
        /// and users should be aware that HTML embedding is not permitted due to the risk of cross-site
        /// attacks and other embedding challenges.
        /// </summary>
        public string Text { get; set; }
    }
}
