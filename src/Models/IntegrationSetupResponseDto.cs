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
    /// This class contains the information about the WorkSpace setup
    /// </summary>
    public class IntegrationSetupResponseDto : ApiModel
    {

        /// <summary>
        /// Returns true if the customer needs to authenticate the integration
        /// </summary>
        public bool? RequiresAuthentication { get; set; }

        /// <summary>
        /// The URL to use to run the setup for the integration
        /// </summary>
        public string Url { get; set; }
    }
}
