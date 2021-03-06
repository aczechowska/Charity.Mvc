USE [charity-donation]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'ubrania, które nadają się do ponownego użycia')
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'ubrania, do wyrzucenia')
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'zabawki')
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'książki')
GO
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'inne')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Institutions] ON 

GO
INSERT [dbo].[Institutions] ([Id], [Description], [Name]) VALUES (1, N'Cel i misja: Pomoc dla osób nie posiadających miejsca zamieszkania', N'Fundacja "Bez domu"')
GO
INSERT [dbo].[Institutions] ([Id], [Description], [Name]) VALUES (2, N'Cel i misja: Pomoc osobom znajdującym się w trudnej sytuacji życiowej', N'Fundacja "Dla dzieci"')
GO
SET IDENTITY_INSERT [dbo].[Institutions] OFF
GO
