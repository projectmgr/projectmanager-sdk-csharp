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



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to Discussion
    /// </summary>
    public interface IDiscussionClient
    {

        /// <summary>
        /// Retrieve all comments written about a task
        ///
        /// </summary>
        /// <param name="taskId">The unique ID number of the task to retrieve comments</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        Task<AstroResult<DiscussionDto[]>> RetrieveTaskComments(Guid taskId, string xintegrationname = null);

        /// <summary>
        /// Adds a Markdown-formatted comment to a task.
        ///
        /// Tasks can have discussions attached to them.  These discussions can include text with simple formatting.  Discussion comments are formatted using [Markdown](https://www.markdownguide.org/) and users should be aware that HTML embedding is not permitted due to the risk of cross-site attacks and other embedding challenges.
        ///
        /// </summary>
        /// <param name="taskId">The unique ID number of the task being commented upon</param>
        /// <param name="xintegrationname">The name of the calling system passed along as a header parameter</param>
        /// <param name="body">The Markdown-formatted text of the comment</param>
        Task<AstroResult<DiscussionCreateResponseDto>> CreateTaskComments(Guid taskId, DiscussionCreateDto body, string xintegrationname = null);
    }
}
