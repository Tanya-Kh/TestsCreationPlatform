USE [master]
GO
/****** Object:  Database [Tests]    Script Date: 9/21/2020 12:02:58 AM ******/
CREATE DATABASE [Tests]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tests', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tests.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tests_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Tests_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Tests] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tests].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tests] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tests] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tests] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tests] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tests] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tests] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tests] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tests] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tests] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tests] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tests] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tests] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tests] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tests] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tests] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tests] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tests] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tests] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tests] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tests] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tests] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tests] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tests] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tests] SET  MULTI_USER 
GO
ALTER DATABASE [Tests] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tests] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tests] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tests] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tests] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tests] SET QUERY_STORE = OFF
GO
USE [Tests]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 9/21/2020 12:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[AnswerID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionID] [int] NOT NULL,
	[Answer] [nvarchar](50) NOT NULL,
	[IsCorrect] [bit] NOT NULL,
 CONSTRAINT [PK_Answers] PRIMARY KEY CLUSTERED 
(
	[AnswerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 9/21/2020 12:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[QuestionID] [int] IDENTITY(1,1) NOT NULL,
	[TestID] [int] NOT NULL,
	[Question] [nvarchar](max) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionTypes]    Script Date: 9/21/2020 12:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionTypes](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QuestionTypes] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 9/21/2020 12:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[TestID] [int] IDENTITY(1,1) NOT NULL,
	[TestName] [nvarchar](50) NOT NULL,
	[TestDescription] [nvarchar](50) NULL,
	[TopicID] [int] NOT NULL,
	[TestTime] [datetime] NULL,
 CONSTRAINT [PK_Tests] PRIMARY KEY CLUSTERED 
(
	[TestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestsResults]    Script Date: 9/21/2020 12:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestsResults](
	[ResultID] [int] NOT NULL,
	[TestID] [int] NOT NULL,
	[CorrectAnswersTotal] [int] NOT NULL,
	[QuestionsTotal] [int] NOT NULL,
 CONSTRAINT [PK_TestResults] PRIMARY KEY CLUSTERED 
(
	[ResultID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topics]    Script Date: 9/21/2020 12:02:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topics](
	[TopicID] [int] IDENTITY(1,1) NOT NULL,
	[ParentTopicID] [int] NULL,
	[TopicName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[TopicID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (1, 1, N'Harrisburg', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (2, 1, N'Philadephia', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (3, 1, N'Pittsuburg', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (4, 1, N'Hershey', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (5, 2, N'Memphis', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (6, 2, N'Falls', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (7, 2, N'Denver', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (8, 2, N'Penn', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (9, 3, N'New York', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (10, 3, N'Albany', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (11, 3, N'Austin', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (12, 3, N'Madison', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (37, 55, N'Memphis', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (38, 55, N'Thebes', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (39, 55, N'Alexandria', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (40, 55, N'Baltimore', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (41, 56, N'1', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (42, 58, N'776 BC', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (43, 58, N'432 BC', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (44, 58, N'112 BC', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (45, 58, N'6 AD', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (46, 59, N'Anaximander', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [Answer], [IsCorrect]) VALUES (47, 61, N'27', 1)
SET IDENTITY_INSERT [dbo].[Answers] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (1, 2, N'Pennsylvania', 2)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (2, 2, N'Colorado', 2)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (3, 2, N'New York', 2)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (55, 18, N'What was the first capital of ancient Egypt?', 2)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (56, 18, N'How many of the Seven Wonders of the Ancient World still exist?(provide just a number)', 1)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (58, 18, N'When did the first documented Olympic Games take place?', 2)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (59, 18, N'Who is credited with making the first map of the known world? (Provide just a name - one word)', 1)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (61, 18, N'How many years did the Peloponnesian War last? (write just a number)', 1)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (66, 2, N'TEST', 1)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (67, 18, N'TEST', 1)
INSERT [dbo].[Questions] ([QuestionID], [TestID], [Question], [Type]) VALUES (68, 2, N'TEST2', 1)
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
SET IDENTITY_INSERT [dbo].[QuestionTypes] ON 

INSERT [dbo].[QuestionTypes] ([TypeID], [TypeName]) VALUES (1, N'Open')
INSERT [dbo].[QuestionTypes] ([TypeID], [TypeName]) VALUES (2, N'Closed')
SET IDENTITY_INSERT [dbo].[QuestionTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Tests] ON 

INSERT [dbo].[Tests] ([TestID], [TestName], [TestDescription], [TopicID], [TestTime]) VALUES (2, N'United States Capitals', N'Provide capitals for the state you see', 4, NULL)
INSERT [dbo].[Tests] ([TestID], [TestName], [TestDescription], [TopicID], [TestTime]) VALUES (18, N'Ancient World', NULL, 6, NULL)
INSERT [dbo].[Tests] ([TestID], [TestName], [TestDescription], [TopicID], [TestTime]) VALUES (19, N'TEST', NULL, 4, NULL)
INSERT [dbo].[Tests] ([TestID], [TestName], [TestDescription], [TopicID], [TestTime]) VALUES (20, N'TEST2', NULL, 6, NULL)
SET IDENTITY_INSERT [dbo].[Tests] OFF
GO
SET IDENTITY_INSERT [dbo].[Topics] ON 

INSERT [dbo].[Topics] ([TopicID], [ParentTopicID], [TopicName]) VALUES (1, NULL, N'Geography')
INSERT [dbo].[Topics] ([TopicID], [ParentTopicID], [TopicName]) VALUES (2, 1, N'Capitals')
INSERT [dbo].[Topics] ([TopicID], [ParentTopicID], [TopicName]) VALUES (3, 2, N'Europe Capitals')
INSERT [dbo].[Topics] ([TopicID], [ParentTopicID], [TopicName]) VALUES (4, 2, N'North America Capitals')
INSERT [dbo].[Topics] ([TopicID], [ParentTopicID], [TopicName]) VALUES (6, NULL, N'History')
INSERT [dbo].[Topics] ([TopicID], [ParentTopicID], [TopicName]) VALUES (8, 6, N'Middle Ages')
SET IDENTITY_INSERT [dbo].[Topics] OFF
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD  CONSTRAINT [FK_Answers_Questions] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Questions] ([QuestionID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Answers] CHECK CONSTRAINT [FK_Answers_Questions]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_QuestionTypes1] FOREIGN KEY([Type])
REFERENCES [dbo].[QuestionTypes] ([TypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_QuestionTypes1]
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Tests] FOREIGN KEY([TestID])
REFERENCES [dbo].[Tests] ([TestID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Questions] CHECK CONSTRAINT [FK_Questions_Tests]
GO
ALTER TABLE [dbo].[Tests]  WITH CHECK ADD  CONSTRAINT [FK_Tests_Topics] FOREIGN KEY([TopicID])
REFERENCES [dbo].[Topics] ([TopicID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tests] CHECK CONSTRAINT [FK_Tests_Topics]
GO
ALTER TABLE [dbo].[TestsResults]  WITH CHECK ADD  CONSTRAINT [FK_TestsResults_Tests] FOREIGN KEY([TestID])
REFERENCES [dbo].[Tests] ([TestID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TestsResults] CHECK CONSTRAINT [FK_TestsResults_Tests]
GO
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Topics] FOREIGN KEY([ParentTopicID])
REFERENCES [dbo].[Topics] ([TopicID])
GO
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Topics]
GO
USE [master]
GO
ALTER DATABASE [Tests] SET  READ_WRITE 
GO
