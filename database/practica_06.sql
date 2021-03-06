IF EXISTS (
  SELECT
    name
  FROM
    sys.databases
  WHERE
    name = N'practica_06'
) DROP DATABASE practica_06
GO
  CREATE DATABASE practica_06
GO
  USE [practica_06]
GO
SET
  ANSI_NULLS ON
GO
SET
  QUOTED_IDENTIFIER ON
GO
  CREATE TABLE [dbo].[Catalog](
    [Id] [int] NOT NULL,
    [Name] [varchar](100) NOT NULL,
    [Price] [float] NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) WITH (
      PAD_INDEX = OFF,
      STATISTICS_NORECOMPUTE = OFF,
      IGNORE_DUP_KEY = OFF,
      ALLOW_ROW_LOCKS = ON,
      ALLOW_PAGE_LOCKS = ON,
      OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
  ) ON [PRIMARY]
GO
SET
  ANSI_NULLS ON
GO
SET
  QUOTED_IDENTIFIER ON
GO
  CREATE TABLE [dbo].[Product](
    [Id] [int] IDENTITY(1, 1) NOT NULL,
    [id_report] [int] NOT NULL,
    [Name] [varchar](100) NOT NULL,
    [Price] [float] NOT NULL,
    [Quantity] [int] NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) WITH (
      PAD_INDEX = OFF,
      STATISTICS_NORECOMPUTE = OFF,
      IGNORE_DUP_KEY = OFF,
      ALLOW_ROW_LOCKS = ON,
      ALLOW_PAGE_LOCKS = ON,
      OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
  ) ON [PRIMARY]
GO
SET
  ANSI_NULLS ON
GO
SET
  QUOTED_IDENTIFIER ON
GO
  CREATE TABLE [dbo].[Report](
    [Id] [int] NOT NULL,
    [Client] [varchar](100) NOT NULL,
    [Date] [varchar](100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) WITH (
      PAD_INDEX = OFF,
      STATISTICS_NORECOMPUTE = OFF,
      IGNORE_DUP_KEY = OFF,
      ALLOW_ROW_LOCKS = ON,
      ALLOW_PAGE_LOCKS = ON,
      OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
  ) ON [PRIMARY]
GO
SET
  ANSI_NULLS ON
GO
SET
  QUOTED_IDENTIFIER ON
GO
  CREATE TABLE [dbo].[Users](
    [UserName] [varchar](50) NOT NULL,
    [Name] [varchar](50) NOT NULL,
    [Password] [varchar](50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserName] ASC) WITH (
      PAD_INDEX = OFF,
      STATISTICS_NORECOMPUTE = OFF,
      IGNORE_DUP_KEY = OFF,
      ALLOW_ROW_LOCKS = ON,
      ALLOW_PAGE_LOCKS = ON,
      OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
  ) ON [PRIMARY]
GO
ALTER TABLE
  [dbo].[Product] WITH CHECK
ADD
  FOREIGN KEY([id_report]) REFERENCES [dbo].[Report] ([Id])
GO
INSERT INTO
  [dbo].[Catalog]
VALUES(10, 'Televisor', 9000);
INSERT INTO
  [dbo].[Catalog]
VALUES(11, 'Laptop DELL', 15000);
INSERT INTO
  [dbo].[Catalog]
VALUES(12, 'Refrigeradora', 20000);
INSERT INTO
  [dbo].[Catalog]
VALUES(13, 'Abanico', 900);
INSERT INTO
  [dbo].[Catalog]
VALUES(14, 'Plancha', 2000);
INSERT INTO
  [dbo].[Catalog]
VALUES(15, 'Cocina', 10000);
GO
INSERT INTO
  [dbo].[Report]
VALUES
  (1, 'Amanda barrios', '10-Octubre-2015');
INSERT INTO
  [dbo].[Report]
VALUES
  (2, 'Derian Cordoba', '15-Mayo-2017');
INSERT INTO
  [dbo].[Report]
VALUES
  (3, 'Ricardo Cordoba', '20-Enero-2016');
GO
INSERT INTO
  [dbo].[Product] (Name, Price, Quantity, id_report)
VALUES('Televisor', 9000, 2, 1);
INSERT INTO
  [dbo].[Product] (Name, Price, Quantity, id_report)
VALUES('Laptop DELL', 15000, 3, 1);
INSERT INTO
  [dbo].[Product] (Name, Price, Quantity, id_report)
VALUES('Refrigeradora', 20000, 4, 1);
INSERT INTO
  [dbo].[Product] (Name, Price, Quantity, id_report)
VALUES('Abanico', 900, 5, 2);
INSERT INTO
  [dbo].[Product] (Name, Price, Quantity, id_report)
VALUES('Plancha', 2000, 6, 2);
INSERT INTO
  [dbo].[Product] (Name, Price, Quantity, id_report)
VALUES('Televisor', 9000, 5, 3);
GO
INSERT INTO
  [dbo].[Users] ([UserName], [Name], [Password])
VALUES
  ('admin', 'Admin', 'admin2021');
INSERT INTO
  [dbo].[Users] ([UserName], [Name], [Password])
VALUES
  ('derian', 'Derian Cordoba', 'user2021');
GO
INSERT INTO
  [dbo].[Users] ([UserName], [Name], [Password])
VALUES
  ('wilmer', 'Wilmer Matamoros', 'wilmer2021');
GO