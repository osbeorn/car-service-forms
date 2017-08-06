-- ServiceItemGroup
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemGroup] ON; 

INSERT INTO [CarServiceForms].[dbo].[ServiceItemGroup] ([Id], [Name], [Order], [Enabled])
VALUES
(1, 'Električni sistem', 1, 1),
(2, 'Zunanjost vozila', 2, 1),
(3, 'Pnevmatike', 3, 1),
(4, 'Motorni prostor', 5, 1),
(5, 'Vozilo s spodnje strani', 4, 1),
(6, 'Zaključna dela', 6, 1);

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemGroup] OFF;

-- ServiceItem
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItem] ON;

INSERT INTO [CarServiceForms].[dbo].[ServiceItem] ([Id], [Name], [HasRemarks], [ServiceItemGroup_Id], [Order], [Enabled])
VALUES
-- Električni sistem
(1, 'Sprednje in zadnje luči: preverite delovanje.', 0, 1, 1, 1),
(2, 'Hupa in kontrolne lučke: preverite delovanje.', 0, 1, 2, 1),
(3, 'Voznikova zračna blazina: vizualna kontrola morebitnih zunanjih poškodb na enoti zračne blazine.', 0, 1, 3, 1),
(4, 'Test sistemov vozila: opravite.', 0, 1, 4, 1),
(5, 'Prikazovalnik servisnih intervalov: resetirajte.', 0, 1, 5, 1),
(6, 'Akumulator: preverite z akumulatorskim testerjem VAS 6161 (obvezno upoštevajte vodiče popravil).', 0, 1, 6, 1),

-- Zunanjost vozila
(7, 'Vratna zadržala in pritrdilni sorniki: namažite', 0, 2, 7, 1),
(8, 'Naprava za čiščenje stekel: preverite delovanje in nastavitev pralnih šob.', 0, 2, 8, 1),
(9, 'Metlice brisalcev: preverite morebitne poškodbe in parkirni položaj.', 0, 2, 9, 1),

-- Pnevmatike
(10, 'Letne pnevmatike [1], zimske pnevmatike [2], celoletne pnevmatike [3], vpišite vrsto pnevmatik: _____', 1, 3, 10, 1),
(11, 'Tlak v pnevmatikah vseh 4 koles: preverite.', 0, 3, 11, 1),
(12, 'Garnitura za popravilo pnevmatik: preverite morebitne poškodbe in porabljeno količino; preverite in vpišite datum uporabnosti tesnilnega sredstva: _____', 1, 3, 12, 1),
(13, 'Indikator nadzora tlaka v penvmatikah: po korekciji tlaka ga kalibrirajte.', 0, 3, 13, 1),
(14, 'Pnevmatika rezervnega kolesa: preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 3, 14, 1),
(15, 'Pnevmatika SL: preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 3, 15, 1),
(16, 'Pnevmatika SD, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 3, 16, 1),
(17, 'Pnevmatika ZL, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 3, 17, 1),
(18, 'Pnevmatika ZD, preverite stanje in tekalno površino, vpišite globino profila: _____', 1, 3, 18, 1),
(19, 'Pnevmatike (vsa 4 kolesa in rezervno kolo): preverite tlak.', 0, 3, 19, 1),

-- Vozilo s spodnje strani
(20, 'Motorno olje: izpustite ali izsesajte, zamenjajte oljni filter.', 0, 5, 20, 1),
(21, 'Motor in deli v motornem prostoru (s spodnje strani): vizualna kontrola tesnenja in morebitnih poškodb.', 0, 5, 21, 1),
(22, 'Zavorni sistem: zamenjajte zavorno tekočino (nato preverite delovanje med testno vožnjo).', 0, 5, 22, 1),
(23, 'Menjalnik, diferencial in manšete zglobov: vizualna kontrola tesnenja in morebitnih poškodb.', 0, 5, 23, 1),
(24, 'Ročni menjalnik/diferencial spredaj: preverite nivo olja.', 0, 5, 24, 1),
(25, 'Zavorni sistem: vizualna kontrola tesnenja in morebitnih poškodb.', 0, 5, 25, 1),
(26, 'Zavorne obloge spredaj in zadaj: preverite debelino.', 0, 5, 26, 1),
(27, 'Zaščita dna vozila: vizualna kontrola morebitnih poškodb.', 0, 5, 27, 1),
(28, 'Izpušni sistem: vizualna kontrola tesnenja, pritrditve in morebitnih poškodb.', 0, 5, 28, 1),
(29, 'Končniki krmilnih drogov: preverite zračnost, pritrditev in tesnilne manšete.', 0, 5, 29, 1),
(30, 'Zglobi: vizualna kontrola tesnenja in morebitnih poškodb tesnilnih manšet.', 0, 5, 30, 1),
(31, 'Krmilni mehanizem: kontrola tesnenja in morebitnih poškodb na manšetah.', 0, 5, 31, 1),

-- Motorni prostor
(32, 'Akumulator in dodatni akumulator: opravite vizualno kontrolo, preverite magično oko.', 0, 4, 32, 1),
(33, 'Motorno olje: dolijte olje (po potrebi do oznake max), normativ VW 50200. Količina polnjenja 3,2 l.', 0, 4, 33, 1),
(34, 'Motor in deli v motornem prostoru (z zgornje strani): vizualna kontrola tesnenja in morebitnih poškodb.', 0, 4, 34, 1),
(35, 'Naprava za čiščenje stekel: dolijte tekočino.', 0, 4, 35, 1),
(36, 'Hladilni sistem: preverite nivo hladilne tekočine in zaščito pred zamrzovanjem/predvidena vrednost -25°C (arktične države -36°C), vpišite izmerjeno dejansko vrednost: _____', 1, 4, 36, 1),
(37, 'Protiprašni filter (motorni prostor, če je filter vgrajen): zamenjajte vložek filtra.', 0, 4, 37, 1),
(38, 'Zobati jermen za pogon odmikalnih gredi: preverite stanje in napetost (dizelski motor s polavtomatskim napenjalnikom).', 0, 4, 38, 1),
(39, 'Zavorna tekočina: zamenjajte.', 0, 4, 39, 1),
(40, 'Servo volan: preverite nivo olja.', 0, 4, 40, 1),

-- Zaključna dela
(41, 'Prikazovalnik servisnih intervalov: ponastavite z diagnostičnim testerjem vozila.', 0, 6, 41, 1),
(42, 'Prikazovalnik servisnih intervalov: prekodirajte.', 0, 6, 42, 1),
(43, 'Nastavitev žarometov: preverite.', 0, 6, 43, 1),
(44, 'Servisna nalepka "Naslednji servis": označite servis z menjavo olja ali servisni pregled (kar je prej na vrsti) in vpišite datum/štev. km; po potrebi označite tudi obseg dodatnih del (npr. menjava zobatega jermena) in menjavo zavorne tekočine.', 0, 6, 44, 1),
(45, 'Servisna nalepka "Naslednji servis": označite naslednji servis in nalepko nalepite na B-stebriček na voznikovi strani.', 0, 6, 45, 1),
(46, 'Opravite testno vožnjo.', 0, 6, 46, 1);


SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItem] OFF;

-- ServiceItemServiceType
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemServiceType] ON;

INSERT INTO [CarServiceForms].[dbo].[ServiceItemServiceType] ([Id], [ServiceType], [ServiceItem_Id])
VALUES
-- Intervalni servis (fiksno) = 0
(1, 0, 6), -- električni sistem
(2, 0, 10), -- pnevmatike
(3, 0, 11),
(4, 0, 12),
(5, 0, 13),
(6, 0, 15),
(7, 0, 16),
(8, 0, 17),
(9, 0, 18),
(10, 0, 20), -- vozilo s spodnje strani
(11, 0, 22),
(12, 0, 25),
(13, 0, 26),
(14, 0, 33), -- motorni prostor
(15, 0, 41), -- zaključna dela
(16, 0, 42),
(17, 0, 44),

-- Servisni pregled (časovno ali kilometrsko pogojeni) = 1
(18, 1, 1), -- električni sistem
(19, 1, 2),
(20, 1, 3),
(21, 1, 4),
(22, 1, 5),
(23, 1, 7), -- zunanjost vozila
(24, 1, 8),
(25, 1, 9),
(26, 1, 10), -- pnevmatike
(27, 1, 14),
(28, 1, 15),
(29, 1, 16),
(30, 1, 17),
(31, 1, 18),
(32, 1, 19),
(33, 1, 20), -- vozilo s spodnje strani
(34, 1, 21),
(35, 1, 23),
(36, 1, 24),
(37, 1, 25),
(38, 1, 26),
(39, 1, 27),
(40, 1, 28),
(41, 1, 29),
(42, 1, 30),
(43, 1, 31),
(44, 1, 32), -- motorni prostor
(45, 1, 33),
(46, 1, 34),
(47, 1, 35),
(48, 1, 36),
(49, 1, 37),
(50, 1, 38),
(51, 1, 39),
(52, 1, 40),
(53, 1, 43), -- zaključna dela
(54, 1, 44),
(55, 1, 46),

-- Servis z menjavo olja = 2
(56, 2, 6), -- električni sistem
(57, 2, 20), -- vozilo s spodnje strani
(58, 2, 25),
(59, 2, 26),
(60, 2, 33), -- motorni prostor
(61, 2, 41), -- zaključna dela
(62, 2, 45);

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemServiceType] OFF;

-- Settings
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemServiceType] ON;

INSERT INTO [CarServiceForms].[dbo].[Settings] ([Id], [Key], [Value])
VALUES
(1, 'payment_deadline', '30');

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemServiceType] OFF;