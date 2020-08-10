USE [SistemScolar]
GO
/****** Object:  StoredProcedure [dbo].[rapTaxa]    Script Date: 05/08/2020 11:59:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[rapTaxa]
AS
BEGIN
     SELECT Taxa.taxaID, Specializare.numeSpecializare, Studenti.nume, Studenti.prenume, Taxa.DataAdmiterii, Taxa.Suma, Luna.Luna
	 From Taxa
	 inner join Specializare on Taxa.taxaID = Specializare.specializareID
	 inner join Studenti on Taxa.NumeID = Studenti.studentiID
	 inner join Luna on Taxa.LunaID = Luna.LunaID
END

