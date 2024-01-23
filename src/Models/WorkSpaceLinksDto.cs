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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// A shortcut link within the currently logged in Workspace.
    /// </summary>
    public class WorkSpaceLinksDto : ApiModel
    {

        /// <summary>
        /// The name of the project for this link.
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// This is the link to the api for this business.  Some endpoints may need this value.
        /// </summary>
        public string Workspaceapi { get; set; }
    }
}
