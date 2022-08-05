USE [clinic]
GO
/****** Object:  StoredProcedure [dbo].[SP_ID_UPDATE]    Script Date: 05-08-2022 20:14:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_ID_UPDATE]
@ID int,
@Date datetime,
@Name nvarchar(MAX),
@Age int,
@Sex nvarchar(50),
@Diagnosis nvarchar(MAX),
@Treatment nvarchar(MAX),
@Charges decimal(18, 0)
as
begin
Update Followup set Date=@Date, Name=@Name, Age=@Age, Sex=@Sex, Diagnosis=@Diagnosis, Treatment=@Treatment, Charges=@Charges where ID=@ID
end