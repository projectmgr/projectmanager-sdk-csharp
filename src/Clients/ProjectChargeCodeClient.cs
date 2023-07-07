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
    /// API methods related to ProjectChargeCode
    /// </summary>
    public class ProjectChargeCodeClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProjectChargeCodeClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve all defined ChargeCodes that can be used when creating Tasks.
        ///
        /// A ChargeCode is a code used to identify costs within your Projects.  Each ChargeCode has a name and a unique identifier.  ChargeCodes are defined per Workspace and are shared among Projects.
        ///
        /// </summary>
        public async Task<AstroResult<ProjectChargeCodeDto[]>> RetrieveChargeCodes()
        {
            var url = $"/project-api/public/projects/chargecodes";
            return await _client.Request<ProjectChargeCodeDto[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
