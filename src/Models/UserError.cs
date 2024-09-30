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
    /// Represents an individual error for a specific Resource that could not be created in the context
    /// of a bulk Resource creation API call.
    /// </summary>
    public class UserError : ApiModel
    {

        /// <summary>
        /// The email of the Resource that could not be created
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A description of the reason this Resource could not be created
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// A status code explaining the category of reason this Resource could not be created
        /// </summary>
        public string StatusCode { get; set; }
    }
}
