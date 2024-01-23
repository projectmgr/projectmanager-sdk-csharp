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



using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Interfaces
{
    /// <summary>
    /// API methods related to ProjectPriority
    /// </summary>
    public interface IProjectPriorityClient
    {

        /// <summary>
        /// Retrieves all ProjectPriorities defined within your Workspace.
        ///
        /// A ProjectPriority is a named priority level used by your business to determine how to decide which Projects are the most important.  You can name your ProjectPriority levels anything you like and you can reorganize the order of the ProjectPriority levels at any time.
        ///
        /// Note that TaskPriority and ProjectPriority are different classes of priority levels.  Even if they may have similar names, they are different objects and must be tracked separately.
        ///
        /// </summary>
        Task<AstroResult<ProjectPriorityDto[]>> RetrieveProjectPriorities();
    }
}
