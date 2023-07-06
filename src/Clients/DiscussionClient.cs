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
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to Discussion
    /// </summary>
    public class DiscussionClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public DiscussionClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Adds a Markdown-formatted comment to a task.
        ///
        /// Tasks can have discussions attached to them.  These discussions can include text with simple
        /// formatting.  Discussion comments are formatted using [Markdown](https://www.markdownguide.org/)
        /// and users should be aware that HTML embedding is not permitted due to the risk of cross-site
        /// attacks and other embedding challenges.
        /// </summary>
        /// <param name="taskId">The unique ID number of the task being commented upon</param>
        /// <param name="body">The Markdown-formatted text of the comment</param>
        public async Task<AstroResult<DiscussionCreateResponseDtoAstroResult>> CreateTaskComments(Guid taskId, DiscussionCreateDto body)
        {
            var url = $"/project-api/public/tasks/{taskId}/discussions";
            return await _client.Request<DiscussionCreateResponseDtoAstroResult>(HttpMethod.Post, url, null, body, null);
        }
    }
}
