/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to ProjectTemplate
    /// </summary>
    public interface IProjectTemplateClient
    {

        /// <summary>
        /// Retrieves all ProjectTemplates defined in the system.
        ///
        /// A ProjectTemplate is a definition of default project related data (eg. Tasks) that can be applied
        /// to a new project when it is created.  ProjectTemplates are categorized using the TemplateCategory
        /// system.
        /// </summary>
        Task<AstroResult<ProjectTemplateDto[]>> RetrieveProjectTemplates();

        /// <summary>
        /// Retrieves all ProjectTemplate Categories defined in the system.
        ///
        /// A ProjectTemplate is a definition of default project related data (eg. Tasks) that can be applied
        /// to a new project when it is created.  ProjectTemplates are categorized using the TemplateCategory
        /// system.
        /// </summary>
        Task<AstroResult<ProjectTemplateCategoryDto[]>> RetrieveTemplateCategories();
    }
}
