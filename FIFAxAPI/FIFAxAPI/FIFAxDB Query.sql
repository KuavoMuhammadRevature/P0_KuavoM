	create table Teams
(
	teamId int primary key identity not null,
	teamName  varchar(30) not null,
	groupId varchar(4) not null,
	--teamFlagUrl varchar(1000),
	--teamJerseyUrl varchar(1000),
	--teamLogoUrl varchar(1000),

	constraint uc_Teams unique (teamName, groupId)

)
-- CONSTRAINT UC_Person UNIQUE (ID,LastName)
select * from Teams order by teamId
--drop table Teams
--alter table Teams drop column teamFlagUrl;
--alter table Teams drop column teamJerseyUrl;
--alter table Teams drop column teamLogoUrl;

--insert into Teams (teamName, groupId) values('Qatar','A1');
--insert into Teams (teamName, groupId) values('Netherlands','A1');
--insert into Teams (teamName, groupId) values('Senegal','A1');
--insert into Teams (teamName, groupId) values('Ecuador','A1');
--insert into Teams (teamName, groupId) values('England','B1');
--insert into Teams (teamName, groupId) values('USA','B2');
--insert into Teams (teamName, groupId) values('Wales','B3');
--insert into Teams (teamName, groupId) values('Iran','B4');
--insert into Teams (teamName, groupId) values('Argentina','C1');
--insert into Teams (teamName, groupId) values('Poland','C2');
--insert into Teams (teamName, groupId) values('Mexico','C3');
--insert into Teams (teamName, groupId) values('Saudi Arabia','C4');
--insert into Teams (teamName, groupId) values('France','D1');
--insert into Teams (teamName, groupId) values('Denmark','D2');
--insert into Teams (teamName, groupId) values('Tunisia','D3');
--insert into Teams (teamName, groupId) values('Australia','D4');
--insert into Teams (teamName, groupId) values('Germany','E1');
--insert into Teams (teamName, groupId) values('Spain','E2');
--insert into Teams (teamName, groupId) values('Japan','E3');
--insert into Teams (teamName, groupId) values('Costa Rica','E4');
--insert into Teams (teamName, groupId) values('Belgium','F1');
--insert into Teams (teamName, groupId) values('Croatia','F2');
--insert into Teams (teamName, groupId) values('Canada','F3');
--insert into Teams (teamName, groupId) values('Morocco','F4');
--insert into Teams (teamName, groupId) values('Brazil','G1');
--insert into Teams (teamName, groupId) values('Switzerland','G2');
--insert into Teams (teamName, groupId) values('Serbia','G3');
--insert into Teams (teamName, groupId) values('Cameroon','G4');
--insert into Teams (teamName, groupId) values('Portugal','H1');
--insert into Teams (teamName, groupId) values('Uruguay','H2');
--insert into Teams (teamName, groupId) values('Ghana','H3');
--insert into Teams (teamName, groupId) values('Korean Republic','H4');

--update Teams set groupId = 'A2' where teamName = 'Netherlands';
--update Teams set groupId = 'A3' where teamName = 'Senegal';
--update Teams set teamName = 'Austria' where teamName = 'Denmark';

create table Players
(
	playerId int primary key identity not null,
	playerName varchar(50) not null,
	playerPosition varchar(25) not null,
	groupId varchar(4) not null,
	--playerImageUrl varchar(1000),

	constraint uc_Players unique (playerName, groupId)
)
select * from Players 

--Insert Queries
--drop table Teams
--insert into Players values('Félix Sánchez','Coach','A1');
--insert into Players values('Mershaal Barsham','Goalkeeper','A1');
--insert into Players values('Boulem Khoukhi','Left Back','A1');
--insert into Players values('Pedro Miguel','Center Back','A1');
--insert into Players values('Homm Ahmed','Left Back','A1');
--insert into Players values('Tark Salman','Center Back','A1');
--insert into Players values('Salm Al-Hajri','Center Back','A1');
--insert into Players values('Mosab Khidir','Right Back','A1');
--insert into Players values('Karim Boudiaf','Midfielder','A1');
--insert into Players values('Assim Madibo','Midfielder','A1');
--insert into Players values('Ismeel Mohammed','Left Winger','A1');
--insert into Players values('Naif Al-Hadhrami','Right Winger','A1');
-----------------------------
--insert into Players values('Louis van Gaal','Coach','A2');
--insert into Players values('Mark Flekken','Goalkeeper','A2');
--insert into Players values('Daley Blind','Left Back','A2');
--insert into Players values('Matthijs de Ligt','Center Back','A2');
--insert into Players values('Tyrell Malacia','Left Back','A2');
--insert into Players values('Virgil vam Dijk','Center Back','A2');
--insert into Players values('Stefan de Vrij','Center Back','A2');
--insert into Players values('Hans Hateboer','Right Back','A2');
--insert into Players values('Frenkie de Jong','Midfielder','A2');
--insert into Players values('Davy Klaassen','Midfielder','A2');
--insert into Players values('Memphis Depay','Left Winger','A2');
--insert into Players values('Steven Berghuis','Right Winger','A2');
-----------------------------
--insert into Players values('Aliou Cissé','Coach','A3');
--insert into Players values('Seny Dieng','Goalkeeper','A3');
--insert into Players values('Saliou Ciss','Left Back','A3');
--insert into Players values('Abdou Diallo','Center Back','A3');
--insert into Players values('Fodé Ballo-Touré','Left Back','A3');
--insert into Players values('Abou Pape Cissé','Center Back','A3');
--insert into Players values('Bouna Sarr','Right Back','A3');
--insert into Players values('Ibrahima Mbaye','Right Back','A3');
--insert into Players values('Idrissa Pape Gueye','Midfielder','A3');
--insert into Players values('Joseph Lopy','Midfielder','A3');
--insert into Players values('Sadio Mané','Left Winger','A3');
--insert into Players values('Habib Diallo','Forward','A3');
---------------------------
--insert into Players values('Gustavo Alfaro','Coach','A4');
--insert into Players values('Hernán Galíndez','Goalkeeper','A4');
--insert into Players values('Pervis Estupiñán','Left Back','A4');
--insert into Players values('Piero Hincapié','Center Back','A4');
--insert into Players values('Diego Palacios','Left Back','A4');
--insert into Players values('Félix Torres','Center Back','A4');
--insert into Players values('Robert Arboleda','Center Back','A4');
--insert into Players values('Byron Castillo','Right Back','A4');
--insert into Players values('Moisés Caicedo','Midfielder','A4');
--insert into Players values('Carlos Gruezo','Midfielder','A4');
--insert into Players values('Joao Rojas','Left Winger','A4');
--insert into Players values('Gonzalo Plata','Right Winger','A4');
---------------------------
--insert into Players values('Gareth Southgate','Coach','B1');
--insert into Players values('Jordan Pickford','Goalkeeper','B1');
--insert into Players values('Harry Maguire','Center Back','B1');
--insert into Players values('Kyle Walker-Peters','Right Back','B1');
--insert into Players values('Marc Guéhi','Center Back','B1');
--insert into Players values('James Reece','Right Back','B1');
--insert into Players values('John Stones','Center Back','B1');
--insert into Players values('Conor Coady','Center Back','B1');
--insert into Players values('Mason Mount','Midfielder','B1');
--insert into Players values('Declan Rice','Midfielder','B1');
--insert into Players values('Jack Grealish','Left Winger','B1');
--insert into Players values('Tammy Abraham','Forward','B1');
-------------------------
--insert into Players values('Lars Knudsen','Coach','B2');
--insert into Players values('Sean Johnson','Goalkeeper','B2');
--insert into Players values('George Bello','Left Back','B2');
--insert into Players values('Tim Ream','Center Back','B2');
--insert into Players values('Sam Vines','Left Back','B2');
--insert into Players values('Chris Richards','Center Back','B2');
--insert into Players values('Mark McKenzie','Center Back','B2');
--insert into Players values('DeAndre Yedlin','Right Back','B2');
--insert into Players values('Gianluca Busio','Midfielder','B2');
--insert into Players values('Paxton Pomykal','Midfielder','B2');
--insert into Players values('Christian Pulisic','Left Winger','B2');
--insert into Players values('Tyler Boyd','Right Winger','B2');
-------------------------
--insert into Players values('Robert Page','Coach','B3');
--insert into Players values('Wayne Hennessey','Goalkeeper','B3');
--insert into Players values('Ben Davies','Left Back','B3');
--insert into Players values('Chris Mepham','Center Back','B3');
--insert into Players values('Joe Rodon','Center Back','B3');
--insert into Players values('Connor Roberts','Right Back','B3');
--insert into Players values('Neco Williams','Right Back','B3');
--insert into Players values('Chris Gunter','Right Back','B3');
--insert into Players values('Gareth Bale','Midfielder','B3');
--insert into Players values('Brennan Johnson','Midfielder','B3');
--insert into Players values('Daniel James','Left Winger','B3');
--insert into Players values('Kieffer Moore','Forward','B3');
---------------------------
--insert into Players values('Dragan Skočić','Coach','B4');
--insert into Players values('Amir Abedzadeh','Goalkeeper','B4');
--insert into Players values('Omid Noorafkan','Left Back','B4');
--insert into Players values('Hossein Kanaani','Center Back','B4');
--insert into Players values('Milad Mohammadi','Left Back','B4');
--insert into Players values('Aref Aghasi','Center Back','B4');
--insert into Players values('Aref Gholami','Center Back','B4');
--insert into Players values('Saleh Hardani','Right Back','B4');
--insert into Players values('Ahmad Nourollahi','Midfielder','B4');
--insert into Players values('Milad Sarlak','Midfielder','B4');
--insert into Players values('Vahid Amiri','Left Winger','B4');
--insert into Players values('Ali Gholizadeh','Right Winger','B4');
-----------------------------
--insert into Players values('Lionel Scaloni','Coach','C1');
--insert into Players values('Franco Armani','Goalkeeper','C1');
--insert into Players values('Nicolás Otamendi','Center Back','C1');
--insert into Players values('Nahuel Molina','Right Back','C1');
--insert into Players values('Germán Pezella','Center Back','C1');
--insert into Players values('Gonzalo Montiel','Right Back','C1');
--insert into Players values('Lisandro Martínez','Center Back','C1');
--insert into Players values('Cristian Romero','Center Back','C1');
--insert into Players values('Rodrigo de Paul','Midfielder','C1');
--insert into Players values('Giovani Lo Celso','Midfielder','C1');
--insert into Players values('Papu Gómez','Left Winger','C1');
--insert into Players values('Lucas Boyé','Forward','C1');
-----------------------------
--insert into Players values('Czesław Michniewicz','Coach','C2');
--insert into Players values('Łukasz Skorupski','Goalkeeper','C2');
--insert into Players values('Kamil Glik','Left Back','C2');
--insert into Players values('Jan Bednarek','Center Back','C2');
--insert into Players values('Matty Cash','Left Back','C2');
--insert into Players values('Jakub Kiwior','Center Back','C2');
--insert into Players values('Krystian Bielik','Center Back','C2');
--insert into Players values('Robert Gumny','Right Back','C2');
--insert into Players values('Jakub Moder','Midfielder','C2');
--insert into Players values('Mateusz Klich','Midfielder','C2');
--insert into Players values('Adam Buksa','Left Winger','C2');
--insert into Players values('Kamil Grosicki','Right Winger','C2');
---------------------------
--insert into Players values('Gerardo Martino','Coach','C3');
--insert into Players values('Guillermo Ochoa','Goalkeeper','C3');
--insert into Players values('Gerardo Arteaga','Left Back','C3');
--insert into Players values('César Montes','Center Back','C3');
--insert into Players values('Jorge Sánchez','Right Back','C3');
--insert into Players values('Néstor Araujo','Center Back','C3');
--insert into Players values('Héctor Moreno','Center Back','C3');
--insert into Players values('Julian Araujo','Right Back','C3');
--insert into Players values('Luis Romo','Midfielder','C3');
--insert into Players values('Roberto Pizarro','Midfielder','C3');
--insert into Players values('Alexis Vega','Left Winger','C3');
--insert into Players values('Uriel Antuna','Right Winger','C3');
-----------------------------
--insert into Players values('Hervé Renard','Coach','C4');
--insert into Players values('Mohammed Al-Owais','Goalkeeper','C4');
--insert into Players values('Yasser Al-Shahrani','Left Back','C4');
--insert into Players values('Abdulelah Al-Amri','Center Back','C4');
--insert into Players values('Sultan Al-Ghanam','Left Back','C4');
--insert into Players values('Ali Al-Bulaihi','Center Back','C4');
--insert into Players values('Hassan Al-Tambakti','Center Back','C4');
--insert into Players values('Mohammed Al-Burayk	','Right Back','C4');
--insert into Players values('Nasser Al-Dawsari','Midfielder','C4');
--insert into Players values('Abdullah Otaif','Midfielder','C4');
--insert into Players values('Khalid Al-Ghannam','Left Winger','C4');
--insert into Players values('Salem Al-Dosari','Right Winger','C4');
-----------------------------
--insert into Players values('Didier Deschamps','Coach','D1');
--insert into Players values('Hugo Lloris','Goalkeeper','D1');
--insert into Players values('William Saliba','Center Back','D1');
--insert into Players values('Jules Koundé','Center Back','D1');
--insert into Players values('Lucas Digne','Left Back','D1');
--insert into Players values('Benjamin Pavard','Right Back','D1');
--insert into Players values('Presnel Kimpembe','Center Back','D1');
--insert into Players values('Lucas Hernández','Center Back','D1');
--insert into Players values('Johnathan Clauss','Midfielder','D1');
--insert into Players values('Paul Pogba','Midfielder','D1');
--insert into Players values('Antoine Griezmann','Left Winger','D1');
--insert into Players values('Kylian Mbappé','Forward','D1');
-----------------------------
--insert into Players values('Ralf Rangnick','Coach','D2');
--insert into Players values('Heinz Linder','Goalkeeper','D2');
--insert into Players values('Alaba David','Left Back','D2');
--insert into Players values('Gernot Trauner','Center Back','D2');
--insert into Players values('Stefan Lainer','Left Back','D2');
--insert into Players values('Kevin Danso','Center Back','D2');
--insert into Players values('Marco Friedl','Center Back','D2');
--insert into Players values('Christopher Trimmel','Right Back','D2');
--insert into Players values('Valentino Lazaro','Midfielder','D2');
--insert into Players values('Stefan Ilsanker','Midfielder','D2');
--insert into Players values('Karim Onisiwo','Left Winger','D2');
--insert into Players values('Andrew Weimann','Right Winger','D2');
---------------------------
--insert into Players values('Mondher Kebaier','Coach','D3');
--insert into Players values('Aymen Dahmen','Goalkeeper','D3');
--insert into Players values('Ali Abdi','Left Back','D3');
--insert into Players values('Bilel Ifa','Center Back','D3');
--insert into Players values('Montassar Talbi','Center Back','D3');
--insert into Players values('Hamza Mathlouthi','Right Back','D3');
--insert into Players values('Dylon Bronn','Center Back','D3');
--insert into Players values('Rami Kaib','Left Back','D3');
--insert into Players values('Nader Ghandri','Midfielder','D3');
--insert into Players values('Ferjani Sassi','Midfielder','D3');
--insert into Players values('Youssef Msakni','Left Winger','D3');
--insert into Players values('Issam Jebali','Right Winger','D3');
---------------------------
--insert into Players values('René Meulensteen','Coach','D4');
--insert into Players values('Mathew Ryan','Goalkeeper','D4');
--insert into Players values('Aziz Behich','Left Back','D4');
--insert into Players values('Trent Sainsbury','Center Back','D4');
--insert into Players values('Craig Goodwin','Left Back','D4');
--insert into Players values('Bailey Wright','Center Back','D4');
--insert into Players values('Kye Rowles','Center Back','D4');
--insert into Players values('Rhyan Grant','Right Back','D4');
--insert into Players values('Kenny Dougall','Midfielder','D4');
--insert into Players values('Connor Metcalfe','Midfielder','D4');
--insert into Players values('Mathew Leckie','Left Winger','D4');
--insert into Players values('Martin Boyle','Right Winger','D4');
-----------------------------
--insert into Players values('Hansi Flick','Coach','E1');
--insert into Players values('Manuel Neuer','Goalkeeper','E1');
--insert into Players values('Thilo Kehrer','Center Back','E1');
--insert into Players values('Lukas Klostermann','Center Back','E1');
--insert into Players values('Nico Schlotterbeck','Left Back','E1');
--insert into Players values('Benjamin Henrichs','Right Back','E1');
--insert into Players values('Niklas Süle','Center Back','E1');
--insert into Players values('Jonathan Tah','Center Back','E1');
--insert into Players values('Julian Brandt','Midfielder','E1');
--insert into Players values('Julian Stach','Midfielder','E1');
--insert into Players values('Serge Gnabry','Left Winger','E1');
--insert into Players values('Lukas Nmecha','Forward','E1');
-------------------------
--insert into Players values('Enrique Luis','Coach','E2');
--insert into Players values('David Raya','Goalkeeper','E2');
--insert into Players values('Jordi Alba','Left Back','E2');
--insert into Players values('Pau Torres','Center Back','E2');
--insert into Players values('Marcos Alonso','Left Back','E2');
--insert into Players values('Diego Llorente','Center Back','E2');
--insert into Players values('Eric García','Center Back','E2');
--insert into Players values('Dani Carvajal','Right Back','E2');
--insert into Players values('Dani Olmo','Midfielder','E2');
--insert into Players values('Carlos Soler','Midfielder','E2');
--insert into Players values('Yeremi Pino','Left Winger','E2');
--insert into Players values('Ferran Torres','Right Winger','E2');
---------------------------
--insert into Players values('Hajime Moriyasu','Coach','E3');
--insert into Players values('Eiji Kawashima','Goalkeeper','E3');
--insert into Players values('Yüto Nagatomo','Left Back','E3');
--insert into Players values('Maya Yoshida','Center Back','E3');
--insert into Players values('Kō Itakura','Center Back','E3');
--insert into Players values('Miki Yamane','Right Back','E3');
--insert into Players values('Shōgo Taniguchi','Left Back','E3');
--insert into Players values('Hiroki Sakai','Right Back','E3');
--insert into Players values('Daichi Kamada','Midfielder','E3');
--insert into Players values('Reo Hatate','Midfielder','E3');
--insert into Players values('Kaoru Mitoma','Left Winger','E3');
--insert into Players values('Takuma Asano','Right Winger','E3');
-------------------------
--insert into Players values('Luis Fernando Suárez','Coach','E4');
--insert into Players values('Keylor Navas','Goalkeeper','E4');
--insert into Players values('Francisco Calvo','Left Back','E4');
--insert into Players values('Kendall Waston','Center Back','E4');
--insert into Players values('Ian Lawrence','Left Back','E4');
--insert into Players values('Juan Pablo Vargas','Center Back','E4');
--insert into Players values('Daniel Chacón','Center Back','E4');
--insert into Players values('Ricardo Blanco','Right Back','E4');
--insert into Players values('Allen Guevara','Midfielder','E4');
--insert into Players values('Roan Wilson','Midfielder','E4');
--insert into Players values('Jewsion Bennette','Left Winger','E4');
--insert into Players values('Carlos Mora','Right Winger','E4');
-------------------------
--insert into Players values('Roberto Martínez','Coach','F1');
--insert into Players values('Simon Mignolet','Goalkeeper','F1');
--insert into Players values('Toby Alderweireld','Center Back','F1');
--insert into Players values('Timothy Castagne','Right Back','F1');
--insert into Players values('Dedryck Boyata','Center Back','F1');
--insert into Players values('Thomas Meunier','Right Back','F1');
--insert into Players values('Jan Vertonghen','Center Back','F1');
--insert into Players values('Jason Denayer','Center Back','F1');
--insert into Players values('Dennis Praet','Midfielder','F1');
--insert into Players values('Amadou Onana','Midfielder','F1');
--insert into Players values('Eden Hazard','Left Winger','F1');
--insert into Players values('Michy Batshuayi','Forward','F1');
-------------------------
--insert into Players values('Zlatko Dalić','Coach','F2');
--insert into Players values('Ivica Ivušić','Goalkeeper','F2');
--insert into Players values('Borna Barišić','Left Back','F2');
--insert into Players values('Josip Juranović','Center Back','F2');
--insert into Players values('Borna Sosa','Left Back','F2');
--insert into Players values('Domagoj Vida','Center Back','F2');
--insert into Players values('Joško Gvardiol','Center Back','F2');
--insert into Players values('Šime Vrsaljko','Right Back','F2');
--insert into Players values('Nikola Moro','Midfielder','F2');
--insert into Players values('Luca Sučić','Midfielder','F2');
--insert into Players values('Josip Brekalo','Left Winger','F2');
--insert into Players values('Marko Livaja','Forward','F2');
---------------------------
--insert into Players values('John Herdman','Coach','F3');
--insert into Players values('Milan Borjan','Goalkeeper','F3');
--insert into Players values('Alistair Johnston','Right Back','F3');
--insert into Players values('Sam Adekugbe','Left Back','F3');
--insert into Players values('Kamal Miller','Center Back','F3');
--insert into Players values('Richie Laryea','Right Back','F3');
--insert into Players values('Scott Kennedy','Center Back','F3');
--insert into Players values('Zachary Brault-Guillard','Right Back','F3');
--insert into Players values('Alphonso Davies','Midfielder','F3');
--insert into Players values('Liam Fraser','Midfielder','F3');
--insert into Players values('Junior Hoilett','Left Winger','F3');
--insert into Players values('Cyle Larin','Forward','F3');
-------------------------
--insert into Players values('Vahid Halilhodžić','Coach','F4');
--insert into Players values('Munir Mohand','Goalkeeper','F4');
--insert into Players values('Adam Masina','Left Back','F4');
--insert into Players values('Samy Mmaee','Center Back','F4');
--insert into Players values('Yahia Attiyat Allah','Left Back','F4');
--insert into Players values('Sofian Chakla','Center Back','F4');
--insert into Players values('Jawad El Yamiq','Center Back','F4');
--insert into Players values('Soufiane Alakouch','Right Back','F4');
--insert into Players values('Achraf Hakimi','Midfielder','F4');
--insert into Players values('Selim Amallah','Midfielder','F4');
--insert into Players values('Soufiane Rahimi','Left Winger','F4');
--insert into Players values('Zakaria Aboukhal','Right Winger','F4');
-------------------------
--insert into Players values('Tite','Coach','G1');
--insert into Players values('Weverton','Goalkeeper','G1');
--insert into Players values('Marquinhos','Center Back','G1');
--insert into Players values('Dani Alves','Right Back','G1');
--insert into Players values('Éder Militão','Center Back','G1');
--insert into Players values('Danilo','Right Back','G1');
--insert into Players values('Alex Telles','Left Back','G1');
--insert into Players values('Thiago Silva','Center Back','G1');
--insert into Players values('Casemiro','Midfielder','G1');
--insert into Players values('Fabinho','Midfielder','G1');
--insert into Players values('Raohinha','Left Winger','G1');
--insert into Players values('Neymar','Forward','G1');
-----------------------------
--insert into Players values('Murat Yakin','Coach','G2');
--insert into Players values('Gregor Kobel','Goalkeeper','G2');
--insert into Players values('Kevin Mbabu','Left Back','G2');
--insert into Players values('Nico Elvedi','Center Back','G2');
--insert into Players values('Ricardo Rodríguez','Left Back','G2');
--insert into Players values('Manuel Akanji','Center Back','G2');
--insert into Players values('Jordan Lotomba','Center Back','G2');
--insert into Players values('Leonidas Stergiou','Right Back','G2');
--insert into Players values('Granit Xhaka','Midfielder','G2');
--insert into Players values('Fabian Frei','Midfielder','G2');
--insert into Players values('Renato Steffen','Left Winger','G2');
--insert into Players values('Andi Zeqiri','Forward','G2');
---------------------------
--insert into Players values('Dragan Stojković','Coach','G3');
--insert into Players values('Predrag Rajković','Goalkeeper','G3');
--insert into Players values('Mihailo Ristić','Left Back','G3');
--insert into Players values('Aleksa Terzić','Left Back','G3');
--insert into Players values('Nikola Milenković','Center Back','G3');
--insert into Players values('Strahinja Pavlović','Center Back','G3');
--insert into Players values('Stefan Mitrović','Center Back','G3');
--insert into Players values('Filip Mladenović','Left Back','G3');
--insert into Players values('Ivan Ilić','Midfielder','G3');
--insert into Players values('Filip Kostić','Midfielder','G3');
--insert into Players values('Darko Lazović','Left Winger','G3');
--insert into Players values('Luka Jović','Forward','G3');
-----------------------
--insert into Players values('Rigobert Song','Coach','G4');
--insert into Players values('Munir Mohand','Goalkeeper','G4');
--insert into Players values('Adam Masina','Left Back','G4');
--insert into Players values('Samy Mmaee','Center Back','G4');
--insert into Players values('Yahia Attiyat Allah','Left Back','G4');
--insert into Players values('Sofian Chakla','Center Back','G4');
--insert into Players values('Jawad El Yamiq','Center Back','G4');
--insert into Players values('Soufiane Alakouch','Right Back','G4');
--insert into Players values('Achraf Hakimi','Midfielder','G4');
--insert into Players values('Selim Amallah','Midfielder','G4');
--insert into Players values('Soufiane Rahimi','Left Winger','G4');
--insert into Players values('Zakaria Aboukhal','Right Winger','G4');
-------------------------
--insert into Players values('Fernando Santos','Coach','H1');
--insert into Players values('Diogo Costa','Goalkeeper','H1');
--insert into Players values('Pepe','Center Back','H1');
--insert into Players values('Diogo Dalot','Right Back','H1');
--insert into Players values('Nuno Mendes','Left Back','H1');
--insert into Players values('Raphaël Gerreiro','Left Back','H1');
--insert into Players values('Vitinha','Midfielder','H1');
--insert into Players values('Bernardo Silva','Midfielder','H1');
--insert into Players values('Otávio','Midfielder','H1');
--insert into Players values('William Carvalho','Midfielder','H1');
--insert into Players values('André Silva','Left Winger','H1');
--insert into Players values('Cristiano Ronaldo','Forward','H1');
-----------------------------
--insert into Players values('Diego Alonso','Coach','H2');
--insert into Players values('Sergio Rochet','Goalkeeper','H2');
--insert into Players values('Mathías Olivera','Left Back','H2');
--insert into Players values('Ronald Araújo','Center Back','H2');
--insert into Players values('Matías Viña','Left Back','H2');
--insert into Players values('Sebastian Coates','Center Back','H2');
--insert into Players values('José María Giménez','Center Back','H2');
--insert into Players values('Guillermo Varela','Right Back','H2');
--insert into Players values('Manuel Ugarte','Midfielder','H2');
--insert into Players values('Lucas Torreira','Midfielder','H2');
--insert into Players values('Facundo Pellistri','Right Winger','H2');
--insert into Players values('Edinson Cavani','Forward','H2');
-------------------------
--insert into Players values('Otto Addo','Coach','H3');
--insert into Players values('Jojo Wollacott','Goalkeeper','H3');
--insert into Players values('Andy Yiadom','Right Back','H3');
--insert into Players values('Gideon Mensah','Left Back','H3');
--insert into Players values('Daniel Amartey','Center Back','H3');
--insert into Players values('Denis Odoi','Right Back','H3');
--insert into Players values('Jonathan Mensah','Center Back','H3');
--insert into Players values('Alidu Seidu','Center Back','H3');
--insert into Players values('Mohammed Kudus','Midfielder','H3');
--insert into Players values('Edmund Addo','Midfielder','H3');
--insert into Players values('Daniel Afriyie','Left Winger','H3');
--insert into Players values('Maxwell Quaye','Forward','H3');
---------------------------
--insert into Players values('Paulo Bento','Coach','H4');
--insert into Players values('Hyeon-Woo Jo','Goalkeeper','H4');
--insert into Players values('Jin-Su Kim','Left Back','H4');
--insert into Players values('Young-Gwon Kim','Center Back','H4');
--insert into Players values('Tae-Hwan Kim','Left Back','H4');
--insert into Players values('Min-Jae Kim','Center Back','H4');
--insert into Players values('Chul Hong','Left Back','H4');
--insert into Players values('Yong Lee','Right Back','H4');
--insert into Players values('Dong-Hyun Kim','Midfielder','H4');
--insert into Players values('Tae-Hee Nam','Midfielder','H4');
--insert into Players values('Heung-Min Son','Left Winger','H4');
--insert into Players values('Young-Wook Cho','Right Winger','H4');
-----------------------------
--update Players set Country = 'Qatar' where groupId = 'A1';
--update Players set Country = 'Netherlands' where groupId = 'A2';
--update Players set Country = 'Senegal' where groupId = 'A3';
--update Players set Country = 'Ecuador' where groupId = 'A4';
-------------------------------
--update Players set Country = 'England' where groupId = 'B1';
--update Players set Country = 'USA' where groupId = 'B2';
--update Players set Country = 'Wales' where groupId = 'B3';
--update Players set Country = 'Iran' where groupId = 'B4';
-------------------------------

--update Players set Country = 'Argentina' where groupId = 'C1';
--update Players set Country = 'Poland' where groupId = 'C2';
--update Players set Country = 'Mexico' where groupId = 'C3';
--update Players set Country = 'Saudi Arabia' where groupId = 'C4';
-------------------------------
--update Players set Country = 'France' where groupId = 'D1';
--update Players set Country = 'Austria' where groupId = 'D2';
--update Players set Country = 'Tunisia' where groupId = 'D3';
--	update Players set Country = 'Australia' where groupId = 'D4';
--	-----------------------------
--	update Players set Country = 'Germany' where groupId = 'E1';
--	update Players set Country = 'Spain' where groupId = 'E2';
--	update Players set Country = 'Japan' where groupId = 'E3';
--	update Players set Country = 'Costa Rica' where groupId = 'E4';
--	-----------------------------
--	update Players set Country = 'Belgium' where groupId = 'F1';
--	update Players set Country = 'Croatia' where groupId = 'F2';
--	update Players set Country = 'Canada' where groupId = 'F3';
--	update Players set Country = 'Morocco' where groupId = 'F4';
--	-----------------------------
--	update Players set Country = 'Brazil' where groupId = 'G1';
--	update Players set Country = 'Switzerland' where groupId = 'G2';
--	update Players set Country = 'Serbia' where groupId = 'G3';
--	update Players set Country = 'Cameroon' where groupId = 'G4';
--	-----------------------------
--	update Players set Country = 'Portugal' where groupId = 'H1';
--	update Players set Country = 'Uruguay' where groupId = 'H2';
--	update Players set Country = 'Ghana' where groupId = 'H3';
--	update Players set Country = 'South Korea' where groupId = 'H4';
--	-----------------------------
	--select * from Players
	--drop table Players
	--delete from Players where groupId = 'H2'
	--alter table Players drop column playerImageUrl;