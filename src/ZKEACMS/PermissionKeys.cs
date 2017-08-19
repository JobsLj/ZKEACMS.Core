/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System.Collections.Generic;

namespace ZKEACMS
{
    public class PermissionKeys
    {
        public const string ViewPage = "Page_View";
        public const string ManagePage = "Page_Manage";

        public const string ViewLayout = "Layout_View";
        public const string ManageLayout = "Layout_Manage";

        public const string ViewNavigation = "Navigation_View";
        public const string ManageNavigation = "Navigation_Manage";

        public const string ViewTheme = "Theme_View";
        public const string ManageTheme = "Theme_Manage";

        public const string ViewMedia = "Media_View";
        public const string ManageMedia = "Media_Manage";

        public const string ViewCarousel = "Carousel_View";
        public const string ManageCarousel = "Carousel_Manage";

        public const string ViewUser = "User_View";
        public const string ManageUser = "User_Manage";

        public const string ViewRole = "Role_View";
        public const string ManageRole = "Role_Manage";

        public const string ViewApplicationSetting = "ApplicationSetting_View";
        public const string ManageApplicationSetting = "ApplicationSetting_Manage";

        public const string ManageEventViewer = "EventViewer_Manage";

        public static List<PermissionDescriptor> KnownPermissions = new List<PermissionDescriptor>
        {
            new PermissionDescriptor { Module="ҳ��",Title="�鿴ҳ��",Key=ViewPage,Description="�鿴ҳ��" },
            new PermissionDescriptor { Module="ҳ��",Title="����ҳ��",Key=ManagePage,Description="����ҳ��" },
            new PermissionDescriptor { Module="����",Title="�鿴����",Key=ViewLayout,Description="�鿴����" },
            new PermissionDescriptor { Module="����",Title="������",Key=ManageLayout,Description="������" },
            new PermissionDescriptor { Module="����",Title="�鿴����",Key=ViewNavigation,Description="�鿴����" },
            new PermissionDescriptor { Module="����",Title="������",Key=ManageNavigation,Description="������" },
            new PermissionDescriptor { Module="����",Title="�鿴����",Key=ViewTheme,Description="�鿴����" },
            new PermissionDescriptor { Module="����",Title="��������",Key=ManageTheme,Description="��������" },
            new PermissionDescriptor { Module="ý���",Title="�鿴ý���",Key=ViewMedia,Description="�鿴ý���" },
            new PermissionDescriptor { Module="ý���",Title="����ý���",Key=ManageMedia,Description="����ý���" },
            new PermissionDescriptor { Module="����ͼ",Title="�鿴����ͼ",Key=ViewCarousel,Description="�鿴����ͼ" },
            new PermissionDescriptor { Module="����ͼ",Title="������ͼ",Key=ManageCarousel,Description="������ͼ" },
            new PermissionDescriptor { Module="��ȫ",Title="�鿴�û�",Key=ViewUser,Description="�鿴�û�" },
            new PermissionDescriptor { Module="��ȫ",Title="�����û�",Key=ManageUser,Description="�����û�" },
            new PermissionDescriptor { Module="��ȫ",Title="�鿴��ɫ",Key=ViewRole,Description="�鿴��ɫ" },
            new PermissionDescriptor { Module="��ȫ",Title="�����ɫ",Key=ManageRole,Description="�����ɫ" },
            new PermissionDescriptor { Module="����",Title="�鿴����",Key=ViewApplicationSetting,Description="�鿴����" },
            new PermissionDescriptor { Module="����",Title="��������",Key=ManageApplicationSetting,Description="��������" },
            new PermissionDescriptor { Module="����",Title="�鿴������־",Key=ManageEventViewer,Description="�鿴ϵͳ�쳣������Ϣ" }
        };
    }
}
