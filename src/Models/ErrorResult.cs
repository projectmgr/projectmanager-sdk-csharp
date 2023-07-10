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
    /// Represents a failed API request.
    /// </summary>
    public class ErrorResult
    {

        /// <summary>
        /// A description of the type of error that occurred.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A short title describing the error.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// If an error code is applicable, this contains an error number.
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// If detailed information about this error is available, this value contains more information.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// If this error corresponds to a specific instance or object, this field indicates which one.
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// The full content of the HTTP response.
        /// </summary>
        public string Content { get; set; }
    }
}
