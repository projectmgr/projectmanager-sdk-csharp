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
    /// API methods related to Me
    /// </summary>
    public interface IMeClient
    {

        /// <summary>
        /// Retrieve information about the currently logged on user.
        ///
        /// This API call will always succeed with a 200 OK if called with valid authentication information. If the authentication information provided is not valid, calling this API will return a 401 Authentication Failed error message.  If successful, this API returns information about the user including its home URL, email address, user name, and workspace name.
        ///
        /// </summary>
        Task<AstroResult<WorkSpaceUserInfoDto>> RetrieveMe();
    }
}
