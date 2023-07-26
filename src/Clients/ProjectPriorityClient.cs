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
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to ProjectPriority
    /// </summary>
    public class ProjectPriorityClient : IProjectPriorityClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectPriorityClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ProjectPriorities defined within your Workspace.
        ///
        /// A ProjectPriority is a named priority level used by your business to determine how to decide which Tasks are the most important.  You can name your ProjectPriority levels anything you like and you can reorganize the order of the ProjectPriority levels at any time.
        ///
        /// Note that TaskPriority and ProjectPriority are different classes of priority levels.  Even if they may have similar names, they are different objects and must be tracked separately.
        ///
        /// </summary>
        public async Task<AstroResult<ProjectPriorityDto[]>> RetrieveProjectPriorities()
        {
            var url = $"/api/data/projects/priorities";
            return await _client.Request<ProjectPriorityDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
