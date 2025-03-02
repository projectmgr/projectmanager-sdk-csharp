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
    /// Represents a state with its details.
    /// </summary>
    public class StateDto : ApiModel
    {

        /// <summary>
        /// Gets or sets the unique identifier for the state.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the code of the state.
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the state.
        /// </summary>
        public string Name { get; set; }
    }
}
