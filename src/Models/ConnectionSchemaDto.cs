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
    /// This class contains the URL or AuthScheme to use to authenticate with the Integration Provider.
    /// </summary>
    public class ConnectionSchemaDto : ApiModel
    {

        /// <summary>
        /// Whether or not the Integration Provider is connected.
        /// </summary>
        public bool? Connected { get; set; }

        /// <summary>
        /// The URL to use to authenticate with the Integration Provider.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// This class contains the AuthScheme to use to authenticate with the Integration Provider.
        /// </summary>
        public object AuthScheme { get; set; }
    }
}
