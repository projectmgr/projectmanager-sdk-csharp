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
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to NptStatus
    /// </summary>
    public interface INptStatusClient
    {

        /// <summary>
        /// Get a list of task statuses that can be used by npt tasks.
        /// </summary>
        Task<AstroResult<NptStatusDto[]>> GetNptTaskStatuses();
    }
}
