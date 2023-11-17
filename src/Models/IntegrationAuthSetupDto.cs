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
    /// Integration Auth Setup for Provider.
    /// </summary>
    public class IntegrationAuthSetupDto : ApiModel
    {

        /// <summary>
        /// Master Connection for provider
        /// </summary>
        public string MasterConnection { get; set; }

        /// <summary>
        /// UserConnection for Provider.
        /// </summary>
        public string UserConnection { get; set; }

        /// <summary>
        /// Master Connection scheme for Provider.
        /// </summary>
        public object MasterConnectionSchema { get; set; }
    }
}
