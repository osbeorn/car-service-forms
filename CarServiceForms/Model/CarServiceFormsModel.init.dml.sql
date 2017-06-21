-- ServiceItemGroup
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemGroup] ON; 

INSERT INTO [CarServiceForms].[dbo].[ServiceItemGroup] ([Id], [Name], [Type], [Order])
VALUES
(1, 'Električni sistem', 0, 1),
(2, 'Zunanjost vozila', 5, 2),
(3, 'Pnevmatike', 1, 3),
(4, 'Motorni prostor', 3, 4),
(5, 'Vozilo s spodnje strani', 2, 5),
(6, 'Zaključna dela', 4, 6);

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItemGroup] OFF;

-- ServiceItem
SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItem] ON;

INSERT INTO [CarServiceForms].[dbo].[ServiceItem] ([Id], [Description], [HasRemarks], [ServiceItemGroup_Id], [Order])
VALUES
-- Električni sistem
(1, 'Sprednje in zadnje luči: preverite delovanje.', 0, 1, 1),
(2, 'Hupa in kontrolne lučke: preverite delovanje.', 0, 1, 2),
(3, 'Voznikova zračna blazina: vizualna kontrola morebitnih zunanjih poškodb na enoti zračne blazine.', 0, 1, 3),
(4, 'Test sistemov vozila: opravite.', 0, 1, 4),
(5, 'Prikazovalnik servisnih intervalov: resetirajte.', 0, 1, 5),
(6, 'Akumulator: preverite z akumulatorskim testerjem VAS 6161 (obvezno upoštevajte vodiče popravil).', 0, 1, 6),

-- Zunanjost vozila
(7, 'Vratna zadržala in pritrdilni sorniki: namažite', 0, 2, 7),
(8, 'Naprava za čiščenje stekel: preverite delovanje in nastavitev pralnih šob.', 0, 2, 8),
(9, 'Metlice brisalcev: preverite morebitne poškodbe in parkirni položaj.', 0, 2, 9),

-- Pnevmatike
(10, 'Letne pnevmatike [1], zimske penvmatike [2], celoletne pnevmatike [3], vpišite vrsto pnevmatik, ', 1, 3, 10),
(11, 'Pnevmatika rezervnega kolesa: preverite stanje in tekalno površino, vpišite globino profila, ', 1, 3, 11),
(12, 'Pnevmatika SL: preverite stanje in tekalno površino, vpišite globino profila, ', 1, 3, 12),
(13, 'Pnevmatika ZL, preverite stanje in tekalno površino, vpišite globino profila, ', 1, 3, 13),
(14, 'Pnevmatika ZD, preverite stanje in tekalno površino, vpišite globino profila,', 1, 3, 14),
(15, 'Pnevmatika SD, preverite stanje in tekalno površino, vpišite globino profila,: ', 1, 3, 15),
(16, 'Pnevmatike (vsa 4 kolesa in rezervno kolo): preverite tlak.', 0, 3, 16),

-- Vozilo s spodnje strani
(17, 'Motorno olje: izpustite ali izsesajte, zamenjajte oljni filter.', 0, 5, 17),
(18, 'Motor in deli v motornem prostoru (s spodnje strani): vizualna kontrola tesnenja in morebitnih poškodb.', 0, 5, 18),
(19, 'Menjalnik, diferencial in manšete zglobov: vizualna kontrola tesnennja in morebitnih poškodb.', 0, 5, 19),
(20, 'Ročni menjalnik/diferencial spredaj: preverite nivo olja.', 0, 5, 20),
(21, 'Zavorni sistem: vizualna kontrola tesnenja in morebitnih poškodb..', 0, 5, 21),
(22, 'Zavorne obloge spredaj in zadaj: preverite debelino.', 0, 5, 22),
(23, 'Zaščita dna vozila: vizualna kontrola morebitnih poškodb.', 0, 5, 23),
(24, 'Izpušni sistem: vizualna kontrola tesnenja, pritrditve in morebitnih poškodb.', 0, 5, 24),
(25, 'Končniki krmilnih drogov: preverite zračnost, pritrditev in tesnilne manšete.', 0, 5, 25),
(26, 'Zglobi: vizualna kontrola tesnenja in morebitnih poškodb tesnilnih manšet.', 0, 5, 26),
(27, 'Krmilni mehanizem: kontrola tesnenja in morebitnih poškodb na manšetah.', 0, 5, 27),

-- Motorni prostor
(28, 'Akumulator in dodatni akumulator: opravite vizualno kontrolo, preverite magično oko.', 0, 4, 28),
(29, 'Motorno olje: dolijte olje (po potrebi do oznake max).', 0, 4, 29),
(30, 'Motor in deli v motornem prostoru (z zgornje strani): vizualna kontrola tesnenja in morebitnih poškodb.', 0, 4, 30),
(31, 'Naprava za čiščenje stekel: dolijte tekočino.', 0, 4, 31),
(32, 'Hladilni sistem: preverite nivo hladilne tekočine in zaščito pred zamrzovanjem/predvidena vrednost -25°C (arktične države -36°C), vpišite izmerjeno dejansko vrednost:', 1, 4, 32),
(33, 'Protiprašni filter (motroni prostor, če je filter vgrajen): zamenjajte vložek filtra.', 0, 4, 33),
(34, 'Zobati jermen za pogon odmikalnih gredi: preverite stanje in napetost (dizelski motor s polavtomatskim napenjalnikom).', 0, 4, 34),
(35, 'Zavorna tekočina: zamenjajte.', 0, 4, 35),
(36, 'Servo volan: preverite nivo olja.', 0, 4, 36),

-- Zaključna dela
(37, 'Nastavitev žarometov: preverite.', 0, 6, 37),
(38, 'Servisna nalepka "Naslednji servis": označite servis z menjavo olja ali servisni pregled (kar je prej na vrsti) in vpišite datum/štev. km; po potrebi označite tudi obseg dodatnih del (npr. menjava zobatega jermena) in menjavo zavorne tekočine ter vpišite ...', 0, 6, 38),
(39, 'Opravite testno vožnjo.', 0, 6, 39);

SET IDENTITY_INSERT [CarServiceForms].[dbo].[ServiceItem] OFF;