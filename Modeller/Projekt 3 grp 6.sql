use Projekt3_Gruppe6;



drop table EntertainmentFavoriteList, PersonFavoriteList, FavoriteList, EntertainmentPerson, UserFriend, 
[User], UserRank, Actor, PersonRole, Person, Episode, Season, Movie, Series, EntertainmentRole,
[Role], EntertainmentFilmingLocation, EntertainmentGenre, Entertainment, FilmingLocation, Genre, [Language], Country;

create table Country
	(
	id int identity(1,1),
	[name] nvarchar(50) unique NOT NULL,
	constraint PKCountry_id primary key(id)
	);

create table [Language]
	(
	id int identity(1,1),
	[name] nvarchar(50) unique NOT NULL,
	 constraint PKLanguage_id primary key(id)
	 );

create table Genre
	(
	id int identity(1,1),
	[name] nvarchar(50) unique NOT NULL,
	constraint PKGenre_id primary key(id)
	);

create table FilmingLocation
	(
	id int identity(1,1),
	[name] nvarchar(50) NOT NULL,
	constraint PKFilmingLocation_id primary key(id)
	);

create table Entertainment
	(
	id int identity(1,1),
	title nvarchar(50) NOT NULL,
	country_id int,
	language_id int,
	releaseDate date,
	storyline nvarchar(500),
	information nvarchar(200),
	constraint PKEntertainment_id primary key(id),
	constraint FKEntertainment_Country foreign key(country_id) references Country(id),
	constraint FKEntertainment_Language foreign key(language_id) references Language(id)
	);

create table EntertainmentGenre
	(
	entertainment_id int,
	genre_id int,
	constraint CPKEntertainmentGenre_Entertainment_id_Genre_id primary key(entertainment_id, genre_id),
	constraint FKEntertainmentGenre_Entertainment foreign key(entertainment_id) references Entertainment(id),
	constraint FKEntertainmentGenre_Genre foreign key(genre_id) references Genre(id)
	);

create table EntertainmentFilmingLocation
	(
	entertainment_id int,
	filmingLocation_id int,
	constraint CPKEntertainmentFilmingLocation_Entertainment_id_FilmingLocation_id primary key(entertainment_id, filmingLocation_id),
	constraint FKEntertainmentFilmingLocation_Entertainment foreign key(entertainment_id) references Entertainment(id),
	constraint FKEntertainmentFilmingLocation_FilmingLocation foreign key(filmingLocation_id) references FilmingLocation(id)
	);

create table [Role]
	(
	id int identity(1,1),
	characterName nvarchar(50) NOT NULL,
	information nvarchar(200),
	constraint PKRole_id primary key(id),
	);

create table EntertainmentRole
	(
	entertainment_id int,
	role_id int,
	constraint CPKEntertainmentRole_Entertainment_id_Role_id primary key(entertainment_id, role_id),
	constraint FKEntertainmentRole_Entertainment foreign key(entertainment_id) references Entertainment(id),
	constraint FKEntertainmentRole_Role foreign key(entertainment_id) references Role(id)
	);

create table Series
	(
	entertainment_id int,
	constraint PKSeries_entertainment_id primary key(entertainment_id),
	constraint FKSeries_Entertainment foreign key(entertainment_id) references Entertainment(id)
	);

create table Movie
	(
	entertainment_id int,
	constraint PKMovie_entertainment_id primary key(entertainment_id),
	constraint FKMovie_Entertainment foreign key(entertainment_id) references Entertainment(id)
	);

create table Season
	(
	id int identity(1,1),
	number int unique NOT NULL,
	constraint PKSeason_id primary key(id)
	);

create table Episode
	(
	id int identity(1,1),
	episode int NOT NULL,
	season_id int,
	series_id int,
	title nvarchar(100) NOT NULL,
	releaseDate Date,
	storyline nvarchar(500),
	constraint PKEpisode_id primary key(id),
	constraint FKEpisode_Season foreign key(season_id) references Season(id),
	constraint FKEpisode_Series foreign key(series_id) references Series(entertainment_id)
	);

create table Person
	(
	id int identity(1,1),
	firstName nvarchar(50) NOT NULL,
	lastName nvarchar(50) NOT NULL,
	information nvarchar(200),
	constraint PKPerson primary key(id)
	);

create table PersonRole
	(
	role_id int,
	person_id int,
	constraint CPKPersonRole_role_id_person_id primary key(role_id, person_id),
	constraint FKPersonRole_Role foreign key(role_id) references Role(id),
	constraint FKPersoneRole_Person foreign key(person_id) references Person(id)
	);

create table Actor
	(
	person_id int,
	constraint PKActor_person_id primary key(person_id),
	constraint FKActor_Person foreign key(person_id) references Person(id)
	);

create table UserRank
	(
	id int identity(1,1),
	[name] nvarchar(50) NOT NULL,
	constraint PKUserRank_id primary key(id),
	);

create table [User]
	(
	person_id int,
	userName nvarchar(50) unique NOT NULL,
	email nvarchar(200) NOT NULL,
	[password] nvarchar(50) NOT NULL,
	userRank_id int,
	constraint PKUser_id primary key(person_id),
	constraint FKUser_Person foreign key(person_id) references Person(id),
	constraint FKUser_UserRank foreign key(userRank_id) references UserRank(id)
	);

create table UserFriend
	(
	primUser_id int,
	friendUser_id int,
	constraint CPKUserFriend_primUser_id_friendUser_id primary key(primUser_id, friendUser_id),
	constraint FKUserFriend_prim_User foreign key(primUser_id) references [User](person_id),
	constraint FKUserFriend_friend_User foreign key(friendUser_id) references [User](person_id)
	);

create table EntertainmentPerson
	(
	entertainment_id int,
	person_id int,
	constraint CPKEntertainmentPerson_entertainment_id_person_id primary key(entertainment_id),
	constraint FKEntertainmentPerson_Entertainment foreign key(entertainment_id) references Entertainment(id),
	constraint FKEntertainmentPerson_Person foreign key(person_id) references Person(id)
	);

create table FavoriteList
	(
	id int identity(1,1),
	author int,
	[name] nvarchar(50) NOT NULL,
	[description] nvarchar(100),
	constraint PKFavoriteList_id primary key(id),
	constraint FKFavoriteList_User foreign key(author) references [User](person_id)
	);

create table PersonFavoriteList
	(
	person_id int,
	favoriteList_id int,
	constraint CPKPersonFavoriteList_person_id_favoriteList_id primary key(person_id, favoriteList_id),
	constraint FKPersonFavoriteList_Person foreign key(person_id) references Person(id),
	constraint FKPersonFavoriteList_FavoriteList foreign key(favoriteList_id) references FavoriteList(id)
	);

create table EntertainmentFavoriteList
	(
	entertainment_id int,
	favoriteList_id int,
	constraint CPKEntertainmentFavoriteList_entertainment_id_favoriteList_id primary key(entertainment_id, favoriteList_id),
	constraint FKEntertainmentFavoriteList_Entertainment foreign key(entertainment_id) references Entertainment(id),
	constraint FKEntertainmentFavoriteList_FavoriteList foreign key(favoriteList_id) references FavoriteList(id)
	);



insert into Country values ('Denmark');
insert into Country values ('USA');
insert into Country values ('France');

insert into [Language] values ('English');
insert into [Language] values ('Danish');
insert into [Language] values ('French');

insert into Entertainment values ('Iron Man', 2, 1, '2008-04-30','After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.', 'Some extra information!');
insert into Entertainment values ('Iron Man 2', 2, 1, '2010-04-29', 'With the world now aware of his identity as Iron Man, Tony Stark must contend with both his declining health and a vengeful mad man with ties to his fathers legacy.', 'Some more awesome information!!');
insert into Entertainment values ('Lucifer', 2, 1, NULL, 'Lucifer Morningstar has decided hes had enough of being the dutiful servant in Hell and decides to spend some time on Earth to better understand humanity. He settles in Los Angeles - the City of Angels.', 'Lucier ROCKS!');
insert into Entertainment values ('Arrow', 2, 1, NULL, 'Spoiled billionaire playboy Oliver Queen is missing and presumed dead when his yacht is lost at sea. He returns five years later a changed man, determined to clean up the city as a hooded vigilante armed with a bow.', 'Go team Arrow!');

insert into Movie values (1);
insert into Movie values (2);
insert into Series values (3);
insert into Series values (4);

use master;