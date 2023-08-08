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
    /// API methods related to File
    /// </summary>
    public interface IFileClient
    {

        Task<AstroResult<string>> DownloadsafilewiththespecifieddocumentID.(Guid documentId);

        Task<AstroResult<string>> Uploadsafilewiththespecifiedrequestdto.(string filename);

        Task<AstroResult<string>> Updatesafilewiththespecifiedrequestdto.(Guid fileId, UpdateRequestDto body);
    }
}
