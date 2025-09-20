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
    /// RecurringTaskChangeSetDetails
    /// </summary>
    public class RecurringTaskChangeSetDetails : ApiModel
    {

        /// <summary>
        /// The created Task Ids
        /// </summary>
        public Guid[] TaskIds { get; set; }
    }
}
