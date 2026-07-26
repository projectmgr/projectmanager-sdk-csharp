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
    /// A resource affected by a holiday. Additional fields may be added later.
    /// </summary>
    public class HolidayResourceDto : ApiModel
    {

        /// <summary>
        /// The resource identifier.
        /// </summary>
        public Guid? Id { get; set; }
    }
}
