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
    /// API methods related to Jira
    /// </summary>
    public class JiraClient : IJiraClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public JiraClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves a list of Projects from Jira with jiraProjectId for epic
        ///
        /// The Jira API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="jiraProjectId">The unique identifier of this jira project</param>
        public async Task<AstroResult<RetunJiraProjectsDto>> RetrieveProjectsfromJirawithEpic(string jiraProjectId)
        {
            var url = $"/api/data/integrations/jira/projects/{jiraProjectId}/epics";
            return await _client.Request<RetunJiraProjectsDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Retrieves a list of Projects from Jira with jiraProjectId
        ///
        /// The Jira API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        /// <param name="jiraProjectId">The unique identifier of this jira project</param>
        public async Task<AstroResult<RetunJiraProjectsDto>> RetrieveProjectsfromJira(string jiraProjectId)
        {
            var url = $"/api/data/integrations/jira/projects/{jiraProjectId}/project";
            return await _client.Request<RetunJiraProjectsDto>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Retrieves a list of Projects from Jira with coonectid for user
        ///
        /// The Jira API is intended for use by ProjectManager and its business development partners.  Please contact ProjectManager&#39;s sales team to request use of this API.
        ///
        /// </summary>
        public async Task<AstroResult<RetunJiraProjectsDto[]>> RetrieveProjectsfromJira()
        {
            var url = $"/api/data/integrations/jira";
            return await _client.Request<RetunJiraProjectsDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
