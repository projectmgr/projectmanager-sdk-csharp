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
    /// A key-value pair of metadata stored against an Integration.
    /// Values are stored as comma-separated strings to support multiple values (e.g. a list of IDs,
    /// names, or reference values).
    /// </summary>
    public class IntegrationMetadataDto : ApiModel
    {

        /// <summary>
        /// The metadata key (e.g. &quot;ProjectStatus&quot;).
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// The metadata value, stored as a comma-separated string to support multiple values.
        /// </summary>
        public string Value { get; set; }
    }
}
