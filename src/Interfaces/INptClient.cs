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
    /// API methods related to Npt
    /// </summary>
    public interface INptClient
    {

        /// <summary>
        /// Gets a Npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        Task<AstroResult<NptDetailsDto>> GetNpt(string nptId);

        /// <summary>
        /// Update a Npt
        /// </summary>
        /// <param name="nptId">the id of the npt</param>
        /// <param name="body">the fields to update</param>
        Task<AstroResult<NptDto>> UpdateNpt(Guid nptId, NptUpdateDto body);

        /// <summary>
        /// Remove Npt
        /// </summary>
        /// <param name="nptId">the id of the npt to remove</param>
        Task<AstroResult<string>> RemoveNpt(Guid nptId);

        /// <summary>
        /// Creates a new Npt
        /// </summary>
        /// <param name="body">The data used to create the Npt</param>
        Task<AstroResult<NptDto>> CreateNpt(NptCreateDto body);
    }
}
