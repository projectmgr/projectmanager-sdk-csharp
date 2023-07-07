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
using System.Text.Json;

namespace ProjectManager.SDK
{

    /// <summary>
    /// An API result that contains different values depending on whether the API call succeeded or failed.
    /// Use the `Success` value to determine if the API call succeeded.  If the API call failed, you can
    /// examine the `Error` value to determine what went wrong.
    /// </summary>
    public class AstroResult<T>
    {
        /// <summary>
        /// Error information if the API call failed
        /// </summary>
        public AstroError Error { get; set; }

        /// <summary>
        /// True if the API call succeeded; false otherwise.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// True if the API call failed.
        /// </summary>
        public bool? HasError { get; set; }

        /// <summary>
        /// The HTTP code of the response.
        /// </summary>
        public HttpStatusCode Status { get; set; }

        /// <summary>
        /// The result data, if this API call succeeded
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// If this API was a file download API call, and the API call succeeded, this will contain the file data.
        /// </summary>
        public byte[] FileData { get; set; }

        /// <summary>
        /// Total length of time taken for the server to respond to the API call, minus network roundtrip, in milliseconds.
        /// </summary>
        public long ServerDuration { get; set; }

        /// <summary>
        /// Total length of time taken for the API call including network roundtrip, in milliseconds
        /// </summary>
        public long TotalRoundtrip { get; set; }

        /// <summary>
        /// Logic for parsing an error from the API
        /// </summary>
        /// <param name="client"></param>
        /// <param name="statusCode"></param>
        /// <param name="errorContent"></param>
        internal void ParseError(ProjectManagerClient client, HttpStatusCode statusCode, string errorContent)
        {
            HasError = true;
            Status = statusCode;
            Value = default(T);
            FileData = null;
            try
            {
                if (!string.IsNullOrWhiteSpace(errorContent))
                {
                    var errorResult = JsonSerializer.Deserialize<AstroResult<string>>(errorContent, client._options);
                    if (errorResult != null)
                    {
                        Error = errorResult.Error;
                    }
                }
            }
            catch
            {
                // ignored
            }

            // If anything failed, just create an error message based on the code
            if (Error == null)
            {
                Error = new AstroError()
                {
                    Message = $"{(int)statusCode} {statusCode}",
                    Content = errorContent,
                };
            }
        }
    }
}