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
    /// API methods related to Jira
    /// </summary>
    public interface IJiraClient
    {

        /// <summary>
        /// Retrieves a list of Projects from Jira with jiraProjectId for epic
        ///
        /// The Jira API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="jiraProjectId">The unique identifier of this jira project</param>
        Task<AstroResult<RetunJiraProjectsDto>> RetrieveProjectsfromJirawithEpic(string jiraProjectId);

        /// <summary>
        /// Retrieves a list of Projects from Jira with jiraProjectId
        ///
        /// The Jira API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="jiraProjectId">The unique identifier of this jira project</param>
        Task<AstroResult<RetunJiraProjectsDto>> RetrieveProjectsfromJira(string jiraProjectId);

        /// <summary>
        /// Retrieves a list of Projects from Jira with coonectid for user
        ///
        /// The Jira API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        Task<AstroResult<RetunJiraProjectsDto[]>> RetrieveProjectsfromJira();
    }
}
