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
    /// API methods related to ProjectTemplate
    /// </summary>
    public class ProjectTemplateClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectTemplateClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves all ProjectTemplates defined in the system.
        ///
        /// A ProjectTemplate is a definition of default project related data (eg. Tasks) that can be applied to a new project when it is created.
        ///
        /// </summary>
        public async Task<AstroResult<ProjectTemplateDto[]>> RetrieveProjectTemplates()
        {
            var url = $"/project-api/public/projects/templates";
            return await _client.Request<ProjectTemplateDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
