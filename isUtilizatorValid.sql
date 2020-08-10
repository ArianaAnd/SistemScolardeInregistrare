CREATE PROCEDURE isUtilizatorValid
(
 @NumeUtilizator NVARCHAR(50),
 @Parola NVARCHAR(50)
)
 AS 
   BEGIN 

   DECLARE @IsUtilizatorValid BIT
   SET @IsUtilizatorValid = 0

   IF EXISTS (SELECT * FROM tblUtilizatori Where [Nume Utilizator] = @NumeUtilizator
   AND Parola = @Parola)
   BEGIN 
   SET @IsUtilizatorValid = 1
   END
   SELECT @IsUtilizatorValid
   END