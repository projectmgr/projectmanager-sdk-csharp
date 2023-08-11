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



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// TODO - What is this?
    /// </summary>
    public class WorkSpaceLinksDto
    {

        /// <summary>
        /// TODO - What is this?
        /// </summary>
        public string Project { get; set; }

        /// <summary>
        /// This is the link to the api for this business, some legacy endpoints may need this.
        /// </summary>
        public string WorkSpaceApi { get; set; }
    }
}
