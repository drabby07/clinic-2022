USE [clinic]
GO
/****** Object:  StoredProcedure [dbo].[SP_ID_Insert]    Script Date: 05-08-2022 20:14:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_ID_Insert]
@ID int,
@Date datetime = null,
@Name nvarchar(MAX) = null,
@Age int = null,
@Sex nvarchar(50) = null,
@Diagnosis nvarchar(MAX) = null,
@Treatment nvarchar(MAX) = null,
@Charges decimal(18, 0) = null
as
begin
insert into  Followup(ID,Date, Name, Age, Sex, Diagnosis, Treatment, Charges) values
(@ID,@Date,@Name, @Age, @Sex, @Diagnosis, @Treatment, @Charges)
end
