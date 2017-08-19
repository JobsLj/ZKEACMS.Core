/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System.Collections.Generic;

namespace ZKEACMS
{
    public class AdminMenu
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int Order { get; set; }
        public string PermissionKey { get; set; }
        public IEnumerable<AdminMenu> Children { get; set; } 
    }
    public static class AdminMenus
    {
        public static List<AdminMenu> Menus { get; } = new List<AdminMenu>
        {
            new AdminMenu
            {
                Title = "�Ǳ���",
                Icon = "glyphicon-dashboard",
                Url = "~/admin",
                Order = 0
            },
            new AdminMenu
            {
                Title = "����",
                Icon = "glyphicon-th-list",
                Order = 1,
                Children = new List<AdminMenu>
                {
                    new AdminMenu
                    {
                        Title = "�����б�",
                        Url = "~/admin/Layout",
                        Icon = "glyphicon-align-justify",
                        PermissionKey = PermissionKeys.ViewLayout
                    },
                    new AdminMenu
                    {
                        Title = "�������",
                        Url = "~/admin/Layout/LayoutWidget",
                        Icon = "glyphicon-th-list",
                        PermissionKey = PermissionKeys.ViewLayout
                    }
                }
            },
            new AdminMenu
            {
                Title = "ҳ��",
                Icon = "glyphicon-eye-open",
                Url = "~/admin/Page",
                Order = 2,
                PermissionKey = PermissionKeys.ViewPage
            },
            new AdminMenu
            {
                Title = "����",
                Icon = "glyphicon-retweet",
                Url = "~/admin/Navigation",
                Order = 3,
                PermissionKey = PermissionKeys.ViewNavigation
            },
            new AdminMenu
            {
                Title = "����",
                Icon = "glyphicon-blackboard",
                Url = "~/admin/Theme",
                Order = 4,
                PermissionKey = PermissionKeys.ViewTheme
            },
            new AdminMenu
            {
                Title = "ý���",
                Icon = "glyphicon-picture",
                Url = "~/admin/Media",
                Order = 5,
                PermissionKey = PermissionKeys.ViewMedia
            },
            new AdminMenu
            {
                Title = "����ͼ",
                Icon = "glyphicon-eye-open",
                Url = "~/admin/Carousel",
                Order = 6,
                PermissionKey = PermissionKeys.ViewCarousel
            },
            new AdminMenu
            {
                Title = "ϵͳ",
                Icon = "glyphicon-cog",
                Order = 1000,
                Children = new List<AdminMenu>
                {
                    new AdminMenu
                    {
                        Title = "�û�",
                        Icon = "glyphicon-user",
                        Url = "~/admin/User",
                        Order = 1,
                        PermissionKey = PermissionKeys.ViewUser
                    },
                    new AdminMenu
                    {
                        Title = "��ɫ",
                        Icon = "glyphicon-eye-open",
                        Url = "~/admin/Roles",
                        Order = 2,
                        PermissionKey = PermissionKeys.ViewRole
                    },
                    new AdminMenu
                    {
                        Title = "������־",
                        Icon = "glyphicon-exclamation-sign",
                        Url = "~/admin/EventViewer",
                        Order = 3,
                        PermissionKey = PermissionKeys.ManageEventViewer
                    },
                    new AdminMenu
                    {
                        Title = "ϵͳ����",
                        Icon = "glyphicon-cog",
                        Url = "~/admin/ApplicationSetting",
                        Order = 4,
                        PermissionKey = PermissionKeys.ViewApplicationSetting
                    }
                }
            }
        };
    }
}
