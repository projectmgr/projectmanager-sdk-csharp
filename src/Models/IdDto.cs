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
    /// When uploading a list of unique identifiers to the API, this data structure
    /// represents one individual unique identifier within the list.
    /// </summary>
    public class IdDto : ApiModel
    {

        /// <summary>
        /// A unique identifier.  To determine the meaning of this unique identifier,
        /// see the field to which this value is attached.
        /// </summary>
        public Guid? Id { get; set; }
    }
}
