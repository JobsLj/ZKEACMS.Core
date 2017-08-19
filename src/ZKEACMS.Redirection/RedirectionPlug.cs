/* http://www.zkea.net/ 
 * Copyright 2017 ZKEASOFT 
 * http://www.zkea.net/licenses 
 *
 * ����һ����׼����Ŀ�ļ������Ҫ��һ���µĲ�����븴�������Ŀ�ļ���Ȼ��������
 * 1. AssemblyInfo.cs �޸� AssemblyProduct��Guid
 * 2. StandardPlug.cs �޸����ƺ�����
 * 3. zkea.plugin �޸� ID ��ֵΪ�µ�GUID������Ӧ�޸���������ơ�
 */
using Easy.Mvc.Resource;
using Easy.Mvc.Route;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Easy.RepositoryPattern;
using ZKEACMS.Redirection.Service;

namespace ZKEACMS.Redirection
{
    public class RedirectionPlug : PluginBase
    {
        public override IEnumerable<RouteDescriptor> RegistRoute()
        {
            yield return new RouteDescriptor
            {
                RouteName = "RedirectRoute",
                Template = "{*path}",
                Defaults = new { controller = "UrlRedirection", action = "RedirectTo" },
                Constraints = new { path = new RedirectRouteConstraint() },
                Priority = 0
            };
        }

        public override IEnumerable<AdminMenu> AdminMenu()
        {
            yield return new AdminMenu
            {
                Title = "URL�ض���",
                Url = "~/Admin/UrlRedirection",
                Icon = "glyphicon-random",
                Order = 12,
                PermissionKey = PermissionKeys.ViewUrlRedirect
            };
        }

        protected override void InitScript(Func<string, ResourceHelper> script)
        {

        }

        protected override void InitStyle(Func<string, ResourceHelper> style)
        {

        }

        public override IEnumerable<PermissionDescriptor> RegistPermission()
        {
            yield return new PermissionDescriptor
            {
                Module = "URL�ض���",
                Title = "�鿴�ض���",
                Description = "�鿴�ض���",
                Key = PermissionKeys.ViewUrlRedirect
            };
            yield return new PermissionDescriptor
            {
                Module = "URL�ض���",
                Title = "�����ض���",
                Description = "�����ض���",
                Key = PermissionKeys.ManageUrlRedirect
            };
        }

        public override IEnumerable<Type> WidgetServiceTypes()
        {
            return null;
        }

        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddTransient<IUrlRedirectService, UrlRedirectService>();
        }
    }
}