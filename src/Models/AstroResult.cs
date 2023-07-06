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
using System.Net;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// An API result that contains different values depending on whether the API call succeeded or failed.
    /// Use the `Success` value to determine if the API call succeeded.  If the API call failed, you can
    /// examine the `Error` value to determine what went wrong.
    /// </summary>
    public class AstroResult<T>
    {

        /// <summary>
        /// If the API call failed, this will contain information about the error that occurred.
        /// </summary>
        public AstroError Error { get; set; }

        /// <summary>
        /// True if the API call succeeded; false otherwise.
        /// </summary>
        public bool? Success { get; set; }

        /// <summary>
        /// True if the API call failed.
        /// </summary>
        public bool? HasError { get; set; }

        /// <summary>
        /// The HTTP code of the response.
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
        
        /// <summary>
        /// If successful, this is the data returned from the API call
        /// </summary>
        public T Value { get; set; }
        
        /// <summary>
        /// If this API downloaded a file, this contains the raw bytes of the file
        /// </summary>
        public byte[] FileData { get; set; }
        
        /// <summary>
        /// The length of time it took the server to process this API request in milliseconds, if known
        /// </summary>
        public int? ServerDuration { get; set; }

        /// <summary>
        /// Total roundtrip duration in milliseconds
        /// </summary>
        public long TotalRoundtrip { get; set; }
    }
}
