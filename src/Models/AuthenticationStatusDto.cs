/***
 * ProjectManager API for C#
 *
 * (c) 2023-2025 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2025 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Set the connection status of an integration
    /// </summary>
    public class AuthenticationStatusDto : ApiModel
    {

        /// <summary>
        /// Set to true if the connection was successful. False is not supported right now.
        /// </summary>
        public bool? Connected { get; set; }
    }
}
