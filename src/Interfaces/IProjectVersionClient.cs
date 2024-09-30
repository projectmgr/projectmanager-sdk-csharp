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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to ProjectVersion
    /// </summary>
    public interface IProjectVersionClient
    {

        /// <summary>
        /// Returns projects versions including version, user who made changes
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project</param>
        Task<AstroResult<ProjectVersionDto[]>> RetrieveProjectVersions(Guid projectId);

        /// <summary>
        /// Exports and returns project version as an MS Project XML attachment
        /// </summary>
        /// <param name="projectChangeId">Project change Guid</param>
        Task<AstroResult<byte[]>> DownloadMSProjectXml(Guid projectChangeId);

        /// <summary>
        /// Restores a Project to the state it was in at a specific Version in time.
        ///
        /// If successful, all changes made to the Project since this Version will be undone and the Project will
        /// return to its former state.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to restore</param>
        /// <param name="version">The version number to restore to</param>
        Task<AstroResult<string>> RestoreProjectVersion(Guid projectId, int version);

        /// <summary>
        /// Create a Copy of a Project as of a specific Version, optionally moving it to a new Timezone.
        /// </summary>
        /// <param name="projectId">The unique identifier of the Project to copy</param>
        /// <param name="version">The version number of the Project to copy</param>
        /// <param name="timezoneOffset">If specified, sets the default timezone of the newly copied Project to this specified timezone</param>
        Task<AstroResult<string>> CopyProjectVersion(Guid projectId, int version, int? timezoneOffset = null);
    }
}
