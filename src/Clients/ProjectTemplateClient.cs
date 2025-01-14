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



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to ProjectTemplate
    /// </summary>
    public class ProjectTemplateClient : IProjectTemplateClient
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
        /// A ProjectTemplate is a definition of default project related data (eg. Tasks) that can be applied
        /// to a new project when it is created.  ProjectTemplates are categorized using the TemplateCategory
        /// system.
        /// </summary>
        public async Task<AstroResult<ProjectTemplateDto[]>> RetrieveProjectTemplates()
        {
            var url = $"/api/data/projects/templates";
            return await _client.Request<ProjectTemplateDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Retrieves all ProjectTemplate Categories defined in the system.
        ///
        /// A ProjectTemplate is a definition of default project related data (eg. Tasks) that can be applied
        /// to a new project when it is created.  ProjectTemplates are categorized using the TemplateCategory
        /// system.
        /// </summary>
        public async Task<AstroResult<ProjectTemplateCategoryDto[]>> RetrieveTemplateCategories()
        {
            var url = $"/api/data/projects/templates/categories";
            return await _client.Request<ProjectTemplateCategoryDto[]>(HttpMethod.Get, url, null);
        }
    }
}
