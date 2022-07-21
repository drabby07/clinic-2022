CREATE proc SP_ID_Insert
@ID nchar(50),
@Date datetime,
@Name nvarchar(MAX),
@Age int,
@Sex nvarchar(50),
@Diagnosis nvarchar(MAX),
@Treatment nvarchar(MAX),
@Charges decimal(18, 0)
as
begin
insert into  Followup(ID,Date, Name, Age, Sex, Diagnosis, Treatment, Charges) values
(@ID,@Date,@Name, @Age, @Sex, @Diagnosis, @Treatment, @Charges)
end
