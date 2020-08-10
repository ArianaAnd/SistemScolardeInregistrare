CREATE PROCEDURE rapStudenti
AS
BEGIN
     SELECT Studenti.studentiID, Studenti.nume, Studenti.prenume, Specializare.numeSpecializare, Studenti.adresa, Studenti.email, Studenti.dataInregistrarii,
			Studenti.dataNasterii, Studenti.telefon, Studenti.sex, Judet.numeJudet, Munincipiu.numeMunincipiu, Oras.numeOras
			FROM Studenti
			inner join Specializare on Studenti.studentiID = Specializare.specializareID
			inner join Judet on Studenti.judetID = Judet.judetID
			inner join Munincipiu on Studenti.munincipiuID = Munincipiu.munincipiuID
			inner join Oras on Studenti.oradID = Oras.oradID
END
