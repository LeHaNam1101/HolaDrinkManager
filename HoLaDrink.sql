USE [master]
GO
/****** Object:  Database [HoLaDrinkManager]    Script Date: 17/6/2023 2:10:51 AM ******/
CREATE DATABASE [HoLaDrinkManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HoLaDrinkManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HoLaDrinkManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HoLaDrinkManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HoLaDrinkManager.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HoLaDrinkManager] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HoLaDrinkManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HoLaDrinkManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [HoLaDrinkManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HoLaDrinkManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HoLaDrinkManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HoLaDrinkManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HoLaDrinkManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HoLaDrinkManager] SET  MULTI_USER 
GO
ALTER DATABASE [HoLaDrinkManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HoLaDrinkManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HoLaDrinkManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HoLaDrinkManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HoLaDrinkManager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HoLaDrinkManager] SET QUERY_STORE = OFF
GO
USE [HoLaDrinkManager]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 7/9/2022 4:32:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/9/2022 4:32:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[userName] [nvarchar](100) NOT NULL,
	[passWord] [nvarchar](1000) NOT NULL,
	[displayName] [nvarchar](100) NOT NULL,
	[type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 7/9/2022 4:32:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[idBill] [int] IDENTITY(1,1) NOT NULL,
	[dateCheckin] [date] NOT NULL,
	[dateCheckout] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 7/9/2022 4:32:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[idBillInfo] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idDrinks] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idBillInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/9/2022 4:32:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[idCategory] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drinks]    Script Date: 7/9/2022 4:32:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drinks](
	[idDrinks] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDrinks] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableCoffee]    Script Date: 7/9/2022 4:32:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableCoffee](
	[idTable] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[status] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([userName], [passWord], [displayName], [type]) VALUES (N'a', N'1234', N'Staff A', 0)
INSERT [dbo].[Account] ([userName], [passWord], [displayName], [type]) VALUES (N'admin', N'admin01', N'Admin01', 1)
INSERT [dbo].[Account] ([userName], [passWord], [displayName], [type]) VALUES (N'b', N'0', N'Staff B', 0)
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (27, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 1, 1, 10, 90900)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (28, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 5, 1, 0, 71000)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (29, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 3, 1, 0, 40000)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (30, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 4, 1, 30, 42000)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (31, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 2, 1, 50, 50000)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (32, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 1, 1, 0, 22222)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (33, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-08' AS Date), 1, 1, 0, 20000)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (34, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 2, 1, 70, 15000)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (35, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-07' AS Date), 2, 1, 100, 0)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (36, CAST(N'2022-07-08' AS Date), NULL, 1, 0, 0, NULL)
INSERT [dbo].[Bill] ([idBill], [dateCheckin], [dateCheckout], [idTable], [status], [discount], [totalPrice]) VALUES (37, CAST(N'2022-07-08' AS Date), NULL, 5, 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idDrinks], [count]) VALUES (39, 27, 3, 1)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idDrinks], [count]) VALUES (42, 29, 1, 2)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idDrinks], [count]) VALUES (43, 30, 4, 2)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idDrinks], [count]) VALUES (44, 31, 4, 2)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idDrinks], [count]) VALUES (45, 31, 1, 2)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idDrinks], [count]) VALUES (49, 34, 6, 2)
INSERT [dbo].[BillInfo] ([idBillInfo], [idBill], [idDrinks], [count]) VALUES (50, 35, 9, 2)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([idCategory], [name]) VALUES (1, N'Trà sữa')
INSERT [dbo].[Category] ([idCategory], [name]) VALUES (2, N'Coffee')
INSERT [dbo].[Category] ([idCategory], [name]) VALUES (4, N'sinh tố')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Drinks] ON 

INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (1, N'Cà phê nâu', 2, 20000)
INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (2, N'Cà phê đen ', 2, 20000)
INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (3, N'Trà sữa trân châu', 1, 30000)
INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (4, N'Trà sữa cầu vồng', 1, 30000)
INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (5, N'Bạc xỉu', 2, 35500)
INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (6, N'Trà sữa cô đơn thực sự', 1, 25000)
INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (9, N'Cà phê đá', 2, 20000)
INSERT [dbo].[Drinks] ([idDrinks], [name], [idCategory], [price]) VALUES (17, N'Sinh tố dứa', 4, 50000)
SET IDENTITY_INSERT [dbo].[Drinks] OFF
GO
SET IDENTITY_INSERT [dbo].[TableCoffee] ON 

INSERT [dbo].[TableCoffee] ([idTable], [name], [status]) VALUES (1, N'Bàn 1', N'Trống')
INSERT [dbo].[TableCoffee] ([idTable], [name], [status]) VALUES (2, N'Bàn 2', N'Trống')
INSERT [dbo].[TableCoffee] ([idTable], [name], [status]) VALUES (3, N'Bàn 3', N'Trống')
INSERT [dbo].[TableCoffee] ([idTable], [name], [status]) VALUES (4, N'Bàn 4', N'Trống')
INSERT [dbo].[TableCoffee] ([idTable], [name], [status]) VALUES (5, N'Bàn 5', N'Trống')
SET IDENTITY_INSERT [dbo].[TableCoffee] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [passWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [dateCheckin]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (N'Enter name of Category!') FOR [name]
GO
ALTER TABLE [dbo].[Drinks] ADD  DEFAULT (N'Enter name of Drinks!') FOR [name]
GO
ALTER TABLE [dbo].[TableCoffee] ADD  DEFAULT (N'Enter name of table!') FOR [name]
GO
ALTER TABLE [dbo].[TableCoffee] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableCoffee] ([idTable])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([idBill])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idDrinks])
REFERENCES [dbo].[Drinks] ([idDrinks])
GO
ALTER TABLE [dbo].[Drinks]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[Category] ([idCategory])
GO
/****** Object:  StoredProcedure [dbo].[GetListBillByDate]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetListBillByDate]
@dateCheckin DATE,
@dateCheckout DATE
AS
BEGIN
    SELECT t.name AS [Tên bàn],b.dateCheckin AS [Ngày checkin],b.dateCheckout AS [Ngày checkout],b.discount AS [Khuyến mãi] ,b.totalPrice AS [Tổng tiền]
FROM Bill AS b, dbo.TableCoffee AS t
WHERE dateCheckin >= @dateCheckin AND dateCheckout <= @dateCheckout 
AND b.status = 1 AND t.idTable = b.idTable 

END
GO
/****** Object:  StoredProcedure [dbo].[GetTableList]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetTableList]
AS SELECT * FROM dbo.TableCoffee
GO
/****** Object:  StoredProcedure [dbo].[InsertBill]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertBill]
@idTable int
AS
BEGIN
    INSERT INTO dbo.Bill
    (
        dateCheckin,
        dateCheckout,
        idTable,
        status,
		discount
    )
    VALUES
    (   GETDATE(), -- dateCheckin - date
        NULL, -- dateCheckout - date
        @idTable,         -- idTable - int
        0,          -- status - int
		0
        )
END
GO
/****** Object:  StoredProcedure [dbo].[InsertBillInfor]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertBillInfor]
	@idBill int,
	@idDrink int,
	@count int
	AS 
	BEGIN
	    DECLARE @isExistsBillInfo INT 
		DECLARE @drinkCount INT =1
		SELECT @isExistsBillInfo = b.idBillInfo ,@drinkCount = b.count 
		FROM dbo.BillInfo AS b
		WHERE idBill = @idBill AND idDrinks = @idDrink
		IF (@isExistsBillInfo >0)
		BEGIN
		    DECLARE @newCount INT = @drinkCount + @count 
			IF (@newCount >0)
			UPDATE dbo.BillInfo SET count = @drinkCount + @count WHERE idDrinks = @idDrink
			ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idDrinks = @idDrink
		END
		ELSE
BEGIN
	    INSERT dbo.BillInfo
(
    idBill,
    idDrinks,
    count
)
VALUES
(   @idBill, -- idBill - int
    @idDrink, -- idDrinks - int
    @count  -- count - int
    )
	END
	END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccount]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateAccount]
@userName NVARCHAR(100), 
@displayName NVARCHAR(100),
@passWord NVARCHAR(100),
@newPassword NVARCHAR(100)
AS
BEGIN
    DECLARE @isCorrectPassword INT
	SELECT @isCorrectPassword = COUNT(*) FROM dbo.Account WHERE userName = @userName AND passWord = @passWord
	IF(@isCorrectPassword =1)
	BEGIN
	    IF(@newPassword = NULL OR @newPassword ='')
		BEGIN
		    UPDATE dbo.Account SET displayName = @displayName WHERE userName = @userName
		END
		ELSE
		 UPDATE dbo.Account SET displayName = @displayName, passWord = @newPassword WHERE userName = @userName
	END
END
GO
/****** Object:  StoredProcedure [dbo].[User_login]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[User_login]
@userName NVARCHAR(50), @passWord NVARCHAR(50)
AS
BEGIN
    SELECT * FROM dbo.Account WHERE userName = @userName AND passWord = @passWord
END
GO
/****** Object:  Trigger [dbo].[UpdateBill]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[UpdateBill]
ON [dbo].[Bill]
FOR UPDATE
AS
BEGIN
    DECLARE @idBill INT;
    SELECT @idBill = idBill
    FROM inserted;

    DECLARE @idTable INT;
    SELECT @idTable = idTable
    FROM dbo.Bill
    WHERE idBill = @idBill;
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	IF (@count = 0)
	UPDATE dbo.TableCoffee SET status = N'Trống' WHERE idTable = @idTable
END;
GO
ALTER TABLE [dbo].[Bill] ENABLE TRIGGER [UpdateBill]
GO
/****** Object:  Trigger [dbo].[DeleteBillInfo]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DeleteBillInfo]
ON [dbo].[BillInfo] FOR DELETE
AS
BEGIN
   DECLARE @idBillInfo INT
   DECLARE @idBill INT
   SELECT @idBillInfo = Deleted.idBillInfo, @idBill = Deleted.idBill FROM Deleted
   DECLARE @idTable INT
   SELECT @idTable = idTable FROM dbo.Bill WHERE idBill =@idBill
   DECLARE @count INT =0
   SELECT @count = COUNT(*) FROM dbo.BillInfo bi, dbo.Bill b WHERE bi.idBill = b.idBill AND b.idBill = @idBill AND b.status = 0
   IF(@count =0)
   UPDATE dbo.TableCoffee SET status = N'Trống' WHERE idTable = @idTable
END
GO
ALTER TABLE [dbo].[BillInfo] ENABLE TRIGGER [DeleteBillInfo]
GO
/****** Object:  Trigger [dbo].[UpdateBillInfo]    Script Date: 7/9/2022 4:32:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateBillInfo]
ON [dbo].[BillInfo]
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @idBill INT;
    SELECT @idBill = Inserted.idBill
    FROM Inserted;
    DECLARE @idTable INT;
    SELECT @idTable = idTable
    FROM dbo.Bill
    WHERE idBill = @idBill
          AND status = 0;
    UPDATE dbo.TableCoffee
    SET status = N'Có người'
    WHERE @idTable = idTable;
END;
GO
ALTER TABLE [dbo].[BillInfo] ENABLE TRIGGER [UpdateBillInfo]
GO
USE [master]
GO
ALTER DATABASE [HoLaDrinkManager] SET  READ_WRITE 
GO
