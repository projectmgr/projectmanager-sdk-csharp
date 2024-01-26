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



namespace ProjectManager.SDK
{

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class DashboardTypeValues
    {
        /// <summary>
        /// The "My Summary" dashboard
        /// </summary>
        public const string MySummary = "MySummary";
        
        /// <summary>
        /// The portfolio summary dashboard
        /// </summary>
        public const string PortfolioSummary = "PortfolioSummary";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class ProjectPermissionValues
    {
        /// <summary>
        /// Represents a guest user within the project
        /// </summary>
        public const string Guest = "Guest";
        
        /// <summary>
        /// Represents a collaborator who can make some changes to a project
        /// </summary>
        public const string Collaborate = "Collaborate";
        
        /// <summary>
        /// Represents an editor who can make most changes to a project
        /// </summary>
        public const string Editor = "Editor";
        
        /// <summary>
        /// Represents a manager who can make all changes to a project
        /// </summary>
        public const string Manager = "Manager";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class StateValues
    {
        /// <summary>
        /// Indicates that work has not yet started
        /// </summary>
        public const string NotStarted = "NotStarted";
        
        /// <summary>
        /// Some work has started, but it is not yet completed
        /// </summary>
        public const string InProgress = "InProgress";
        
        /// <summary>
        /// Completed successfully
        /// </summary>
        public const string Success = "Success";
        
        /// <summary>
        /// Failed
        /// </summary>
        public const string Fail = "Fail";
    }
}
