using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_Track.FrameWork
{
    public static class APIActionName
    {
        public static class Login
        {
            public const string Authenticate = nameof(Authenticate);
        }
		public static class SupportData
		{
			public const string GetSupportDataAsyn = nameof(GetSupportDataAsyn);
			public const string SaveSupportDataAsyn = nameof(SaveSupportDataAsyn);
			public const string DeleteSupportDataAsyn = nameof(DeleteSupportDataAsyn);
		}
		public static class UserDetail
		{
			public const string GetUserDetailsAsync = nameof(GetUserDetailsAsync);
			public const string GetUserDetailsByIdAsync = nameof(GetUserDetailsByIdAsync);
			public const string AddUserDetailsAsync = nameof(AddUserDetailsAsync);
			public const string UpdateUserDetailsAsync = nameof(UpdateUserDetailsAsync);
			public const string DeleteUserDetailsAsync = nameof(DeleteUserDetailsAsync);
			public const string DeactiveUserDetailsAsync = nameof(DeactiveUserDetailsAsync);
			public const string ChangePasswordAsync = nameof(ChangePasswordAsync);
			public const string ActiveUserDetailsAsync = nameof(ActiveUserDetailsAsync);
			public const string GetUserRightsAsync = nameof(GetUserRightsAsync);
		}
		public static class UserRights
		{
			public const string GetUserRightsAsync = nameof(GetUserRightsAsync);
			public const string SaveUserRightsAsync = nameof(SaveUserRightsAsync);
			public const string GetRoleAndModuleAsync = nameof(GetRoleAndModuleAsync);
			public const string GetUserRightsByRoleAsync = nameof(GetUserRightsByRoleAsync);
		}
		public static class UserRole
		{
			public const string GetUserRoleAsync = nameof(GetUserRoleAsync);
			public const string GetUserRoleDetailsById = nameof(GetUserRoleDetailsById);
			public const string SaveUserRoleAsyn = nameof(SaveUserRoleAsyn);
			public const string DeleteUserRoleDetailsAsyn = nameof(DeleteUserRoleDetailsAsyn);

		}

		public static class ProjectDetails
        {
            public const string GetProjectDetailsAsync = nameof(GetProjectDetailsAsync);
            public const string Project = nameof(Project);
            public const string GetProjectDetailsByIdAsync = nameof(GetProjectDetailsByIdAsync);
            public const string AddProjectDetailsAsync = nameof(AddProjectDetailsAsync);
            public const string UpdateProjectDetailsAsync = nameof(UpdateProjectDetailsAsync);
            public const string DeleteProjectDetailsAsync = nameof(DeleteProjectDetailsAsync);
           
        }  
    }
}