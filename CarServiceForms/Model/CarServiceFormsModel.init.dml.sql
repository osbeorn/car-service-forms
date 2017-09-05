-- ServiceType
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceType] ON;

INSERT INTO [CarServiceForms].[dbo].[ServiceType] ([Id], [Name], [Active], [Deleted])
VALUES
(1, 'Servis z menjavo olja', 1, 0),
(2, 'Servisni pregled (časovno ali kilometrsko pogojeni)', 1, 0),
(3, 'Intervalni servis (fiksno)', 1, 0);

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceType] OFF;

-- ServiceItemGroup
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemGroup] ON; 

INSERT INTO [CarServiceForms].[dbo].[ServiceItemGroup] ([Id], [Name], [Order], [Active], [Deleted], [ServiceType_Id])
VALUES
-- Servis z menjavo olja
(1, 'Elektrika', 1, 1, 0, 1),
(2, 'Vozilo s spodnje strani', 2, 1, 0, 1),
(3, 'Motorni prostor', 3, 1, 0, 1),
(4, 'Zaključna dela', 4, 1, 0, 1),
-- Servisni pregled (časovno ali kilometrsko pogojeni)
(5, 'Električni sistem', 1, 1, 0, 2),
(6, 'Zunanjost vozila', 2, 1, 0, 2),
(7, 'Pnevmatike', 3, 1, 0, 2),
(8, 'Vozilo s spodnje strani', 4, 1, 0, 2),
(9, 'Motorni prostor', 5, 1, 0, 2),
(10, 'Zaključna dela', 6, 1, 0, 2),
-- Intervalni servis (fiksno)
(11, 'Elektrika', 1, 1, 0, 3),
(12, 'Pnevmatike', 2, 1, 0, 3),
(13, 'Vozilo s spodnje strani', 3, 1, 0, 3),
(14, 'Motorni prostor', 4, 1, 0, 3),
(15, 'Zaključna dela', 5, 1, 0, 3);

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemGroup] OFF;

-- ServiceItem
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItem] ON;

INSERT INTO [CarServiceForms].[dbo].[ServiceItem] ([Id], [Name], [HasRemarks], [Order], [Active], [Deleted], [ServiceItemGroup_Id])
VALUES
-- Servis z menjavo olja
--   Elektrika
(1, 'Akumulator: preverite z akumulatorskim testerjem VAS 6161 (obvezno upoštevajte vodiče popravil).', 0, 1, 1, 0, 1),
--   Vozilo s spodnje strani
(2, 'Motorno olje: izpustite ali izsesajte, zamenjajte oljni filter.', 0, 1, 1, 0, 2),
(3, 'Zavorni sistem: vizualna kontrola tesnenja in morebitnih poškodb.', 0, 2, 1, 0, 2),
(4, 'Debelina zavornih oblog in stanje zavornih kolutov spredaj in zadaj: preverite.', 0, 3, 1, 0, 2),
--   Motorni prostor
(5, 'Motorno olje: dolijte olje do oznake max.', 0, 1, 1, 0, 3),
--   Zaključna dela
(6, 'Prikazovalnik servisnih intervalov: ponastavite z diagnostičnim testerjem vozila.', 0, 1, 1, 0, 4),
(8, 'Servisna nalepka "Naslednji servis": označite naslednji servis in nalepko nalepite na B-stebriček na voznikovi strani.', 0, 3, 1, 0, 4),

-- Servisni pregled (časovno ali kilometrsko pogojeni)
--   Električni sistem
(9, 'Sprednje in zadnje luči: preverite delovanje.', 0, 1, 1, 0, 5),
(10, 'Hupa in kontrolne lučke: preverite delovanje.', 0, 2, 1, 0, 5),
(11, 'Voznikova zračna blazina: vizualna kontrola morebitnih zunanjih poškodb na enoti zračne blazine.', 0, 3, 1, 0, 5),
(12, 'Test sistemov vozila: opravite.', 0, 4, 1, 0, 5),
(13, 'Prikazovalnik servisnih intervalov: resetirajte.', 0, 5, 1, 0, 5),
--   Zunanjost vozila
(14, 'Vratna zadržala in pritrdilni sorniki: namažite', 0, 1, 1, 0, 6),
(15, 'Naprava za čiščenje stekel: preverite delovanje in nastavitev pralnih šob.', 0, 2, 1, 0, 6),
(16, 'Metlice brisalcev: preverite morebitne poškodbe in parkirni položaj.', 0, 3, 1, 0, 6),
--   Pnevmatike
(17, 'Letne pnevmatike [1], zimske pnevmatike [2], celoletne pnevmatike [3], vpišite vrsto pnevmatik: _____', 1, 1, 1, 0, 7),
(18, 'Pnevmatika rezervnega kolesa: preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 2, 1, 0, 7),
(19, 'Pnevmatika SL, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 3, 1, 0, 7),
(20, 'Pnevmatika SD, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 4, 1, 0, 7),
(21, 'Pnevmatika ZL, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 5, 1, 0, 7),
(22, 'Pnevmatika ZD, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 6, 1, 0, 7),
(23, 'Pnevmatike (vsa 4 kolesa in rezervno kolo): preverite tlak.', 0, 7, 1, 0, 7),
--   Vozilo s spodnje strani
(24, 'Motorno olje: izpustite ali izsesajte, zamenjajte oljni filter.', 0, 1, 1, 0, 8),
(25, 'Motor in deli v motornem prostoru (s spodnje strani): vizualna kontrola tesnenja in morebitnih poškodb.', 0, 2, 1, 0, 8),
(26, 'Menjalnik, diferencial in manšete zglobov: vizualna kontrola tesnenja in morebitnih poškodb.', 0, 3, 1, 0, 8),
(27, 'Ročni menjalnik/diferencial spredaj: preverite nivo olja.', 0, 4, 1, 0, 8),
(28, 'Zavorni sistem: vizualna kontrola tesnenja in morebitnih poškodb.', 0, 5, 1, 0, 8),
(29, 'Zavorne obloge spredaj in zadaj: preverite debelino.', 0, 6, 1, 0, 8),
(30, 'Zaščita dna vozila: vizualna kontrola morebitnih poškodb.', 0, 7, 1, 0, 8),
(31, 'Izpušni sistem: vizualna kontrola tesnenja, pritrditve in morebitnih poškodb.', 0, 7, 1, 0, 8),
(32, 'Končniki krmilnih drogov: preverite zračnost, pritrditev in tesnilne manšete.', 0, 8, 1, 0, 8),
(33, 'Zglobi: vizualna kontrola tesnenja in morebitnih poškodb tesnilnih manšet.', 0, 10, 1, 0, 8),
(34, 'Krmilni mehanizem: kontrola tesnenja in morebitnih poškodb na manšetah.', 0, 1, 1, 0, 8),
--   Motorni prostor
(35, 'Akumulator in dodatni akumulator: opravite vizualno kontrolo, preverite magično oko.', 0, 1, 1, 0, 9),
(36, 'Motorno olje: dolijte olje do oznake max.', 0, 2, 1, 0, 9),
(37, 'Motor in deli v motornem prostoru (z zgornje strani): vizualna kontrola tesnenja in morebitnih poškodb.', 0, 3, 1, 0, 9),
(38, 'Naprava za čiščenje stekel: dolijte tekočino.', 0, 4, 1, 0, 9),
(39, 'Hladilni sistem: preverite nivo hladilne tekočine in zaščito pred zamrzovanjem/predvidena vrednost -25°C (arktične države -36°C), vpišite izmerjeno dejansko vrednost: _____', 1, 5, 1, 0, 9),
(40, 'Protiprašni filter (motorni prostor, če je filter vgrajen): zamenjajte vložek filtra.', 0, 6, 1, 0, 9),
(41, 'Zobati jermen za pogon odmikalnih gredi: preverite stanje in napetost (dizelski motor s polavtomatskim napenjalnikom).', 0, 7, 1, 0, 9),
(42, 'Zavorna tekočina: zamenjajte.', 0, 8, 1, 0, 9),
(43, 'Servo volan: preverite nivo olja.', 0, 9, 1, 0, 9),
--   Zaključna dela
(44, 'Nastavitev žarometov: preverite.', 0, 1, 1, 0, 10),
(45, 'Servisna nalepka "Naslednji servis": označite servis z menjavo olja ali servisni pregled (kar je prej na vrsti) in vpišite datum/štev. km; po potrebi označite tudi obseg dodatnih del (npr. menjava zobatega jermena) in menjavo zavorne tekočine.', 0, 2, 1, 0, 10),
(46, 'Opravite testno vožnjo.', 0, 3, 1, 0, 10),

-- Intervalni servis (fiksno)
--  Elektrika
(47, 'Akumulator: preverite z akumulatorskim testerjem VAS 6161 (obvezno upoštevajte vodiče popravil).', 0, 1, 1, 0, 11),
--  Pnevmatike
(48, 'Letne pnevmatike [1], zimske pnevmatike [2], celoletne pnevmatike [3], vpišite vrsto pnevmatik: _____', 1, 1, 1, 0, 12),
(49, 'Tlak v pnevmatikah vseh 4 koles: preverite.', 0, 2, 1, 0, 12),
(50, 'Garnitura za popravilo pnevmatik: preverite morebitne poškodbe in porabljeno količino; preverite in vpišite datum uporabnosti tesnilnega sredstva: _____', 1, 3, 1, 0, 12),
(51, 'Indikator nadzora tlaka v penvmatikah: po korekciji tlaka ga kalibrirajte.', 0, 4, 1, 0, 12),
(52, 'Pnevmatika SL: preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 5, 1, 0, 12),
(53, 'Pnevmatika SD, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 6, 1, 0, 12),
(54, 'Pnevmatika ZL, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 7, 1, 0, 12),
(55, 'Pnevmatika ZD, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 8, 1, 0, 12),
--  Vozilo s spodnje strani
(56, 'Motorno olje: izpustite ali izsesajte, zamenjajte oljni filter.', 0, 1, 1, 0, 13),
(57, 'Zavorni sistem: zamenjajte zavorno tekočino (nato preverite delovanje med testno vožnjo).', 0, 2, 1, 0, 13),
(58, 'Zavorni sistem: vizualna kontrola tesnenja in morebitnih poškodb.', 0, 3, 1, 0, 13),
(59, 'Debelina zavornih obloh in stanje zavornih kolutov spredaj in zadaj: preverite.', 0, 4, 1, 0, 13),
--  Motorni prostor
(60, 'Motorno olje: dolijte olje do oznake max.', 0, 1, 1, 0, 14),
--  Zaključna dela
(61, 'Prikazovalnik servisnih intervalov: ponastavite z diagnostičnim testerjem vozila.', 0, 1, 1, 0, 15),
(62, 'Prikazovalnik servisnih intervalov: prekodirajte.', 0, 2, 1, 0, 15),
(63, 'Servisna nalepka "Naslednji servis": označite naslednji servis in nalepko nalepite na B-stebriček na voznikovi strani.', 0, 5, 1, 0, 15);

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItem] OFF;

-- Settings
SET IDENTITY_INSERT [CarServiceForms].[dbo].[Settings] ON;

INSERT INTO [CarServiceForms].[dbo].[Settings] ([Id], [Key], [Value])
VALUES
(1, 'payment_deadline', '30');

SET IDENTITY_INSERT [CarServiceForms].[dbo].[Settings] OFF;

---- InvoiceItemDescription
--SET IDENTITY_INSERT [CarServiceForms].[dbo].[InvoiceItemDescription] ON;

--INSERT INTO [CarServiceForms].[dbo].[InvoiceItemDescription] ([Id], [Value])
--VALUES
--(1, 'SERVIS Z MENJAVO OLJA'),
--(2, 'SERVISNI PREGLED (ČASOVNO ALI KILOMETRSKO POGOJENI)'),
--(3, 'INTERVALNI SERVIS (FIKSNO)');

--SET IDENTITY_INSERT [CarServiceForms].[dbo].[InvoiceItemDescription] OFF;