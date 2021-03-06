/****** Object:  Table [dbo].[Company]    Script Date: 09/06/2018 13:58:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Logo] [varchar](50) NULL,
	[SystemCnName] [varchar](50) NULL,
	[SystemEnName] [varchar](100) NULL,
	[Color] [varchar](10) NULL,
	[Banner] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[AddTime] [datetime] NOT NULL,
	[Remark] [varchar](max) NULL,
	[AdminId] [int] NOT NULL,
	[PushOffline] [bit] NOT NULL,
	[SMSAllow] [bit] NOT NULL,
	[MemberId] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所属经销商Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Company', @level2type=N'COLUMN',@level2name=N'MemberId'
GO
INSERT [dbo].[Company] ([Id], [Name], [Logo], [SystemCnName], [SystemEnName], [Color], [Banner], [Phone], [AddTime], [Remark], [AdminId], [PushOffline], [SMSAllow], [MemberId]) VALUES (1, N'AAA', N'111', N'111', N'111', N'226E5B', NULL, NULL, CAST(0x0000A65801157780 AS DateTime), N'', 1, 0, 0, 6)
INSERT [dbo].[Company] ([Id], [Name], [Logo], [SystemCnName], [SystemEnName], [Color], [Banner], [Phone], [AddTime], [Remark], [AdminId], [PushOffline], [SMSAllow], [MemberId]) VALUES (2, N'BBB', N'', N'222', N'222', N'FFFFFF', NULL, NULL, CAST(0x0000A66C00F9DEC1 AS DateTime), N'', 1, 0, 0, 0)
INSERT [dbo].[Company] ([Id], [Name], [Logo], [SystemCnName], [SystemEnName], [Color], [Banner], [Phone], [AddTime], [Remark], [AdminId], [PushOffline], [SMSAllow], [MemberId]) VALUES (3, N'CCC', N'333', N'333', N'333', N'DAE022', NULL, NULL, CAST(0x0000A6BA00C521F5 AS DateTime), N'', 1, 0, 1, 6)
INSERT [dbo].[Company] ([Id], [Name], [Logo], [SystemCnName], [SystemEnName], [Color], [Banner], [Phone], [AddTime], [Remark], [AdminId], [PushOffline], [SMSAllow], [MemberId]) VALUES (4, N'DDD', NULL, N'444', N'Test', N'0066AA', NULL, NULL, CAST(0x0000A94600EE84E6 AS DateTime), N'备注', 1, 0, 0, 0)
INSERT [dbo].[Company] ([Id], [Name], [Logo], [SystemCnName], [SystemEnName], [Color], [Banner], [Phone], [AddTime], [Remark], [AdminId], [PushOffline], [SMSAllow], [MemberId]) VALUES (5, N'EEE', NULL, N'555', N'Test2', N'0066AA', NULL, NULL, CAST(0x0000A94600F579F0 AS DateTime), N'备注', 1, 0, 0, 0)
/****** Object:  Default [DF__Company__AddTime__571DF1D5]    Script Date: 09/06/2018 13:58:53 ******/
ALTER TABLE [dbo].[Company] ADD  DEFAULT (getdate()) FOR [AddTime]
GO
/****** Object:  Default [DF__Company__PushOff__5812160E]    Script Date: 09/06/2018 13:58:53 ******/
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((0)) FOR [PushOffline]
GO
/****** Object:  Default [DF__Company__SMSAllo__59063A47]    Script Date: 09/06/2018 13:58:53 ******/
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((0)) FOR [SMSAllow]
GO
/****** Object:  Default [DF__Company__MemberI__797309D9]    Script Date: 09/06/2018 13:58:53 ******/
ALTER TABLE [dbo].[Company] ADD  DEFAULT ((0)) FOR [MemberId]
GO
