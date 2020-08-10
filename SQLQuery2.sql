create table Taxa (TaxaID int primary key identity (1, 1), SpecializareID int foreign key references Specializare(specializareID),
NumeID int foreign key references Studenti(studentiID), PrenumeID int foreign key references Studenti (studentiID), DataAdmiterii varchar(50),
lunaID int foreign key references Luna(LunaID), Suma int)

select * from Taxa

