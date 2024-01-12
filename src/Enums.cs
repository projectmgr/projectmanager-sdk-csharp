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
        public const string MySummary = "MySummary";
        public const string PortfolioSummary = "PortfolioSummary";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class ProjectPermissionValues
    {
        public const string Guest = "Guest";
        public const string Collaborate = "Collaborate";
        public const string Editor = "Editor";
        public const string Manager = "Manager";
    }

    /// <summary>
    /// To prevent enum parsing errors, all enums are rendered as constants.
    /// </summary>
    public static class StateValues
    {
        public const string NotStarted = "NotStarted";
        public const string InProgress = "InProgress";
        public const string Success = "Success";
        public const string Fail = "Fail";
    }
}
