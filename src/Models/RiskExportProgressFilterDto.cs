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
    /// Risk Progress Filter Settings
    /// </summary>
    public class RiskExportProgressFilterDto : ApiModel
    {

        /// <summary>
        /// Include risks that are open
        /// </summary>
        public bool? IsOpen { get; set; }

        /// <summary>
        /// Include risks that are closed
        /// </summary>
        public bool? IsClosed { get; set; }
    }
}
