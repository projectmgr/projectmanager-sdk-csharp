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
    /// API methods related to ProjectStatus
    /// </summary>
    public class ProjectStatusClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectStatusClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ProjectStatuses defined within your Workspace.
        ///
        /// A ProjectStatus is a named condition used by your business to categorize the completion level
        /// of Tasks and Projects within your Workspace.  You can name your ProjectStatus levels anything
        /// you like and you can reorganize the order of the ProjectPriority levels at any time.
        /// </summary>
        public async Task<AstroResult<PublicProjectStatusDtoListAstroResult>> RetrieveProjectStatuses()
        {
            var url = $"/project-api/public/projects/statuses";
            return await _client.Request<PublicProjectStatusDtoListAstroResult>(HttpMethod.Get, url, null, null, null);
        }
    }
}
