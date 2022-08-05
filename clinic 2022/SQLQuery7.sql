create table Followup
(
 ID int primary key,
 Date datetime,
 Name nvarchar(MAX),
 Age int,
 Sex nvarchar(50),
 Diagnosis nvarchar(MAX),
 Treatment nvarchar(MAX),
 Charges decimal(18,0)
 )