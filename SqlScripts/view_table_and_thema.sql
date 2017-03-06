USE [Binnenschifffahrt]
GO
/****** Object:  Table [dbo].[T_Fragenbogen_Thema]    Script Date: 02/26/2017 20:47:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Fragenbogen_Thema](
	[FragebogenNr] [int] NOT NULL,
	[Thema] [nchar](20) NOT NULL,
	[Beschreib] [nchar](100) NULL,
 CONSTRAINT [PK_T_FRAGENBOGEN_THEMA] PRIMARY KEY CLUSTERED 
(
	[FragebogenNr] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (1, N'Exam 1 Thema        ', N'Description Thema 1                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (2, N'Exam 2 Thema        ', N'Description Thema 2                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (3, N'Exam 3 Thema        ', N'Description Thema 3                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (4, N'Exam 4 Thema        ', N'Description Thema 4                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (5, N'Exam 5 Thema        ', N'Description Thema 5                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (6, N'Exam 6 Thema        ', N'Description Thema 6                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (7, N'Exam 7 Thema        ', N'Description Thema 7                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (8, N'Exam 8 Thema        ', N'Description Thema 8                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (9, N'Exam 9 Thema        ', N'Description Thema 9                                                                                 ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (10, N'Exam 10 Thema       ', N'Description Thema 10                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (11, N'Exam 11 Thema       ', N'Description Thema 11                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (12, N'Exam 12 Thema       ', N'Description Thema 12                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (13, N'Exam 13 Thema       ', N'Description Thema 13                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (14, N'Exam 14 Thema       ', N'Description Thema 14                                                                                ')
INSERT [dbo].[T_Fragenbogen_Thema] ([FragebogenNr], [Thema], [Beschreib]) VALUES (15, N'Exam 15 Thema       ', N'Description Thema 15                                                                                ')
/****** Object:  View [dbo].[View_Topics_And_Questions]    Script Date: 02/26/2017 20:47:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Topics_And_Questions]
AS
SELECT     dbo.T_SBF_Binnen.P_Id, dbo.T_SBF_Binnen.Frage, dbo.T_SBF_Binnen.Antwort1, dbo.T_SBF_Binnen.Antwort2, dbo.T_SBF_Binnen.Antwort3, dbo.T_SBF_Binnen.Antwort4, 
                      dbo.T_Fragebogen_unter_Maschine.FragebogenNr, dbo.T_SBF_Binnen.RichtigeAntwort
FROM         dbo.T_Fragebogen_unter_Maschine INNER JOIN
                      dbo.T_SBF_Binnen ON dbo.T_Fragebogen_unter_Maschine.F_Id_SBF_Binnen = dbo.T_SBF_Binnen.P_Id
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_Fragebogen_unter_Maschine"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 96
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_SBF_Binnen"
            Begin Extent = 
               Top = 6
               Left = 249
               Bottom = 126
               Right = 415
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Topics_And_Questions'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Topics_And_Questions'
GO
