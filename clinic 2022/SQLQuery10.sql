USE [clinic]
GO
/****** Object:  StoredProcedure [dbo].[SP_ID_DELETE]    Script Date: 05-08-2022 20:15:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[SP_ID_DELETE]
@ID int
as
begin
delete Followup where ID=@ID
end