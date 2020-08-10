CREATE PROCEDURE isAdminValid
(
 @Admin NVARCHAR(50),
 @Parola NVARCHAR(50)
)
 AS 
   BEGIN 

   DECLARE @IsAdminValid BIT
   SET @IsAdminValid = 0

   IF EXISTS (SELECT * FROM tblAdmin Where [Admin] = @Admin
   AND Parola = @Parola)
   BEGIN 
   SET @IsAdminValid = 1
   END
   SELECT @IsAdminValid
   END