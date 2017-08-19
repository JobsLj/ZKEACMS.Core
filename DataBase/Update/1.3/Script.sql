SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CMS_Redirection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[InComingUrl] [nvarchar](500) NOT NULL,
	[DestinationURL] [nvarchar](500) NOT NULL,
	[IsPermanent] [bit] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Status] [int] NULL,
	[CreateBy] [nvarchar](50) NULL,
	[CreatebyName] [nvarchar](100) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateBy] [nvarchar](50) NULL,
	[LastUpdateByName] [nvarchar](100) NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_CMS_Redirection] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@ActionType', N'zh-CN', N'ActionType', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@CreateBy', N'zh-CN', N'CreateBy', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@CreatebyName', N'zh-CN', N'������', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@CreateDate', N'zh-CN', N'��������', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@Description', N'zh-CN', N'����', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@DestinationURL', N'zh-CN', N'��ת��ַ', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@ID', N'zh-CN', N'ID', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@InComingUrl', N'zh-CN', N'���ʵ�ַ', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@IsPermanent', N'zh-CN', N'���ã�', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@LastUpdateBy', N'zh-CN', N'LastUpdateBy', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@LastUpdateByName', N'zh-CN', N'������', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@LastUpdateDate', N'zh-CN', N'��������', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@Status', N'zh-CN', N'״̬', N'UrlRedirect', N'EntityProperty')
INSERT [dbo].[Language] ([LanKey], [CultureName], [LanValue], [Module], [LanType]) VALUES (N'UrlRedirect@Title', N'zh-CN', N'����', N'UrlRedirect', N'EntityProperty')
GO
INSERT [dbo].[Permission] ([PermissionKey], [RoleId], [Title], [Description], [Module], [Status], [CreateBy], [CreatebyName], [CreateDate], [LastUpdateBy], [LastUpdateByName], [LastUpdateDate]) VALUES (N'UrlRedirect_Manage', 1, N'����URL �ض���', NULL, N'URL �ض���', NULL, N'admin', N'ZKEASOFT', CAST(N'2017-08-14 14:55:58.170' AS DateTime), N'admin', N'ZKEASOFT', CAST(N'2017-08-14 14:55:58.170' AS DateTime))
INSERT [dbo].[Permission] ([PermissionKey], [RoleId], [Title], [Description], [Module], [Status], [CreateBy], [CreatebyName], [CreateDate], [LastUpdateBy], [LastUpdateByName], [LastUpdateDate]) VALUES (N'UrlRedirect_View', 1, N'�鿴URL �ض���', NULL, N'URL �ض���', NULL, N'admin', N'ZKEASOFT', CAST(N'2017-08-14 14:55:58.120' AS DateTime), N'admin', N'ZKEASOFT', CAST(N'2017-08-14 14:55:58.120' AS DateTime))