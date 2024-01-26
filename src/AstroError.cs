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

namespace ProjectManager.SDK
{
    /// <summary>
    /// Information about an API error received from ProjectManager.com
    /// </summary>
    public class AstroError
    {
                
        /// <summary>
        /// A technical description of the error that occurred.  Not suitable for
        /// display to end users.
        /// </summary>
        public string TechnicalError { get; set; }

        /// <summary>
        /// If additional errors beyond the main error in `Message` occurred, they will be
        /// listed here as individual messages.
        /// </summary>
        public string[] AdditionalErrors { get; set; }

        /// <summary>
        /// A description of the error that occurred.  If your application has a user
        /// interface, show this message to explain what went wrong.
        /// </summary>
        public string Message { get; set; }
        
        /// <summary>
        /// The raw JSON result of the error message, for debugging purposes.
        /// </summary>
        public string Content { get; set; }
    }
}
