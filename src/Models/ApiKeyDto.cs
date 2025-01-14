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
    /// Represents api access key entity
    /// </summary>
    public class ApiKeyDto : ApiModel
    {

        /// <summary>
        /// Internal access token id
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Created by user id
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// Expires date
        /// </summary>
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Bearer Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Name of token
        /// </summary>
        public string Name { get; set; }
    }
}
