/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
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
    /// API methods related to ProjectVersion
    /// </summary>
    public class ProjectVersionClient : IProjectVersionClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectVersionClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns projects versions including version, user who made changes
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project</param>
        public async Task<AstroResult<ProjectVersionDto[]>> RetrieveProjectVersions(Guid projectId)
        {
            var url = $"/api/data/projects/{projectId}/versions";
            return await _client.Request<ProjectVersionDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Exports and returns project version as an MS Project XML attachment
        /// </summary>
        /// <param name="projectChangeId">Project change Guid</param>
        public async Task<AstroResult<byte[]>> DownloadMSProjectXml(Guid projectChangeId)
        {
            var url = $"/api/data/projects/{projectChangeId}/version/download";
            return await _client.Request<byte[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Restores a Project to the state it was in at a specific Version in time.
        ///
        /// If successful, all changes made to the Project since this Version will be undone and the Project will
        /// return to its former state.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to restore</param>
        /// <param name="version">The version number to restore to</param>
        public async Task<AstroResult<string>> RestoreProjectVersion(Guid projectId, int version)
        {
            var url = $"/api/data/projects/{projectId}/version/{version}/restore";
            return await _client.Request<string>(HttpMethod.Post, url, null);
        }

        /// <summary>
        /// Create a Copy of a Project as of a specific Version, optionally moving it to a new Timezone.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to copy</param>
        /// <param name="version">The version number of the Project to copy</param>
        /// <param name="timezoneOffset">If specified, sets the default timezone of the newly copied Project to this specified timezone</param>
        public async Task<AstroResult<string>> CopyProjectVersion(Guid projectId, int version, int? timezoneOffset = null)
        {
            var url = $"/api/data/projects/{projectId}/version/{version}/copy";
            var options = new Dictionary<string, object>();
            if (timezoneOffset != null) { options["timezoneOffset"] = timezoneOffset; }
            return await _client.Request<string>(HttpMethod.Post, url, options);
        }
    }
}
