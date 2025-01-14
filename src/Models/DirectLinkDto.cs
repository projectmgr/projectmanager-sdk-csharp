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
    /// This class contains the URL to use to authenticate with the Integration Provider.
    /// </summary>
    public class DirectLinkDto : ApiModel
    {

        /// <summary>
        /// The URL to use to authenticate with the Integration Provider.
        /// </summary>
        public string Url { get; set; }
    }
}
