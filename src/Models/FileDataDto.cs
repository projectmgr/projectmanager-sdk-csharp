/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// File Data
    /// </summary>
    public class FileDataDto : ApiModel
    {

        /// <summary>
        /// Task files count
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Last update data
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Last read date
        /// </summary>
        public DateTime? LastReadDate { get; set; }
    }
}
