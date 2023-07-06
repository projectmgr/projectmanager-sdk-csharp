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
    /// API methods related to Changeset
    /// </summary>
    public class ChangesetClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ChangesetClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve a Changeset by its unique ID.
        ///
        /// A Changeset is an individual edit that has been made to a project.  Since multiple users can
        /// edit a project at the same time, individual Changesets are applied in a sequential fashion. If
        /// a Changeset causes a conflict or cannot be applied, it will be rejected.  You can examine a
        /// Changeset to determine its conflict resolution status.
        ///
        /// When checking the status of a Changeset, you can call either RetrieveChangeset or
        /// RetrieveCompletedChangeset.  Using RetrieveChangeset will give you the immediate status of the
        /// Changeset.  Using RetrieveCompletedChangeset will delay the response until the Changeset has
        /// finished processing.
        /// </summary>
        /// <param name="changeSetId">The unique ID number of the Changeset to retrieve</param>
        public async Task<AstroResult<ChangesetGetResponseDtoAstroResult>> RetrieveChangeset(Guid changeSetId)
        {
            var url = $"/project-api/public/changesets/{changeSetId}";
            return await _client.Request<ChangesetGetResponseDtoAstroResult>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Retrieve a Changeset by its unique ID. This endpoint waits for the Changeset to complete its
        /// processing prior to returning a result.
        ///
        /// A Changeset is an individual edit that has been made to a project.  Since multiple users can
        /// edit a project at the same time, individual Changesets are applied in a sequential fashion. If
        /// a Changeset causes a conflict or cannot be applied, it will be rejected.  You can examine a
        /// Changeset to determine its conflict resolution status.
        ///
        /// When checking the status of a Changeset, you can call either RetrieveChangeset or
        /// RetrieveCompletedChangeset.  Using RetrieveChangeset will give you the immediate status of the
        /// Changeset.  Using RetrieveCompletedChangeset will delay the response until the Changeset has
        /// finished processing.
        ///
        /// Although most Changesets complete instantly, some Changesets may need additional time to
        /// complete.  If the Changeset cannot be processed within a reasonable length of time, this API
        /// call may fail.  If this API fails, it will return a status error indicating the Changeset is
        /// still being processed.
        /// </summary>
        /// <param name="changeSetId">The unique ID number of the Changeset to retrieve</param>
        public async Task<AstroResult<ChangesetGetResponseDtoAstroResult>> RetrieveCompletedChangeset(Guid changeSetId)
        {
            var url = $"/project-api/public/changesets/{changeSetId}/poll";
            return await _client.Request<ChangesetGetResponseDtoAstroResult>(HttpMethod.Get, url, null, null, null);
        }
    }
}
