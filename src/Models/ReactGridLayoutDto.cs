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
    /// A setting for react grid layout sizes
    /// </summary>
    public class ReactGridLayoutDto : ApiModel
    {

        /// <summary>
        /// Used for large screen size (1200)
        /// </summary>
        public ReactGridLayoutItemDto[] Lg { get; set; }

        /// <summary>
        /// Used for medium screen size (996)
        /// </summary>
        public ReactGridLayoutItemDto[] Md { get; set; }

        /// <summary>
        /// Used for small screen size (768)
        /// </summary>
        public ReactGridLayoutItemDto[] Sm { get; set; }

        /// <summary>
        /// Used for extra small screen size (480)
        /// </summary>
        public ReactGridLayoutItemDto[] Xs { get; set; }

        /// <summary>
        /// Used for super small screen size (0)
        /// </summary>
        public ReactGridLayoutItemDto[] Xxs { get; set; }
    }
}
