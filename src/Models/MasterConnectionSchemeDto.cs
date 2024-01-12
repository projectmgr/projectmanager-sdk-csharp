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
    /// Master Connection Scheme for Providers
    /// </summary>
    public class MasterConnectionSchemeDto : ApiModel
    {

        /// <summary>
        /// The value of the property
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The type of the property
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Send to the client true/false
        /// </summary>
        public bool? SendToClient { get; set; }
    }
}
