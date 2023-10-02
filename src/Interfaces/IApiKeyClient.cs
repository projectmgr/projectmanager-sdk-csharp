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
    /// API methods related to ApiKey
    /// </summary>
    public interface IApiKeyClient
    {

        /// <summary>
        /// Returns new api key
        ///
        /// </summary>
        /// <param name="body">api key details</param>
        Task<AstroResult<ApiKeyDto>> Createsanapikeyforthecurrentuser(ApiKeyCreateDto body);

        /// <summary>
        /// Returns list of workspace&#39;s api keys
        ///
        /// </summary>
        Task<AstroResult<ApiKeyDto[]>> Returnslistofcreatedapikeysforcurrentworkspace();

        /// <summary>
        /// Revokes all api keys in given workspace
        ///
        /// </summary>
        Task<AstroResult<string>> Revokesallapikeys();

        /// <summary>
        /// Revoke single api key in given workspace
        ///
        /// </summary>
        /// <param name="id">Internal key id</param>
        Task<AstroResult<string>> Revokesingleapikey(Guid id);
    }
}
