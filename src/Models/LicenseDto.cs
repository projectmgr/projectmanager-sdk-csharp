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
    /// A License represents a subscription to a particular product or bundle of products
    /// within ProjectManager.
    /// </summary>
    public class LicenseDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this License.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The SKU code of this License, used for billing purposes.
        /// </summary>
        public string LicenseSku { get; set; }

        /// <summary>
        /// The SKU code of the bundle of this License, used for billing purposes.
        /// </summary>
        public string BundleSku { get; set; }

        /// <summary>
        /// True if this license is optional.
        /// </summary>
        public bool? Optional { get; set; }
    }
}
