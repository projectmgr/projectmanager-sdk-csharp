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
    /// API methods related to ProjectCustomer
    /// </summary>
    public interface IProjectCustomerClient
    {

        /// <summary>
        /// Retrieves all ProjectCustomers defined within your Workspace.
        ///
        /// A ProjectCustomer is a code used to identify customers associated with your Projects.  Each ProjectCustomer has a name and a unique identifier.  ProjectCustomers are defined per Workspace and are shared among Projects.
        ///
        /// </summary>
        Task<AstroResult<ProjectCustomerDto[]>> RetrieveProjectCustomers();
    }
}
