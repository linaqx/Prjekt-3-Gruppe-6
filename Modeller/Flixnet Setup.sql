--use Projekt3_Gruppe6;
use dmab0917_1026423;


drop table 
EntertainmentFavoriteList, PersonFavoriteList, FavoriteList, EntertainmentPerson, UserFriend, Comment, 
[Session], 
[User], UserRank, Actor, PersonRole, Person, Episode, Season, Movie, Series, EntertainmentRole,
[Role], EntertainmentGenre, Entertainment, Genre, [Language], Country;

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

--create table FilmingLocation
--	(
--	id int identity(1,1),
--	[name] nvarchar(50) NOT NULL,
--	constraint PKFilmingLocation_id primary key(id)
--	);

create table Entertainment
	(
	id int identity(1,1),
	title nvarchar(50) NOT NULL unique,
	country_id int,
	language_id int,
	releaseDate date,
	filmingLocation nvarchar(500),
	storyline nvarchar(500),
	information nvarchar(200),
	isMovie bit,
	constraint PKEntertainment_id primary key(id),
	constraint FKEntertainment_Country foreign key(country_id) references Country(id),
	constraint FKEntertainment_Language foreign key(language_id) references [Language](id)
	);

create table EntertainmentGenre
	(
	entertainment_id int,
	genre_id int,
	constraint CPKEntertainmentGenre_Entertainment_id_Genre_id primary key(entertainment_id, genre_id),
	constraint FKEntertainmentGenre_Entertainment foreign key(entertainment_id) references Entertainment(id),
	constraint FKEntertainmentGenre_Genre foreign key(genre_id) references Genre(id)
	);

--create table EntertainmentFilmingLocation
--	(
--	entertainment_id int,
--	filmingLocation_id int,
--	constraint CPKEntertainmentFilmingLocation_Entertainment_id_FilmingLocation_id primary key(entertainment_id, filmingLocation_id),
--	constraint FKEntertainmentFilmingLocation_Entertainment foreign key(entertainment_id) references Entertainment(id),
--	constraint FKEntertainmentFilmingLocation_FilmingLocation foreign key(filmingLocation_id) references FilmingLocation(id)
--	);

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
	constraint FKPersonRole_Role foreign key(role_id) references [Role](id),
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
	[password] nvarchar(200) NOT NULL,
	salt nvarchar(200),
--	session_id nvarchar(50),
	userRank_id int,
	constraint PKUser_id primary key(person_id),
	constraint FKUser_Person foreign key(person_id) references Person(id),
	constraint FKUser_UserRank foreign key(userRank_id) references UserRank(id)
	);

create table [Session]
	(
	id int identity(1,1),
	person_id int,
	session_id nvarchar(50),
	constraint PKSession_id primary key(id),
	constraint FKSession_User foreign key(person_id) references [User](person_id)
	);

	create table Comment
	(
	id int identity(1,1),
	entertainment_id int,
	[user_id] int,
	[message] nvarchar(250),
	constraint PKComment_entertainment_id primary key(id),
	constraint FKComment_Movie foreign key(entertainment_id) references Movie(entertainment_id),
	constraint FKComment_User foreign key([user_id]) references [User](person_id)
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

insert into Entertainment values ('Iron Man', 2, 1, '2008-04-30', 'New York', 'After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.', 'Some extra information!', 1);
insert into Entertainment values ('Iron Man 2', 2, 1, '2010-04-29', 'New York', 'With the world now aware of his identity as Iron Man, Tony Stark must contend with both his declining health and a vengeful mad man with ties to his fathers legacy.', 'Some more awesome information!!', 1);
insert into Entertainment values ('Lucifer', 2, 1, '1010-10-10', 'New York', 'Lucifer Morningstar has decided hes had enough of being the dutiful servant in Hell and decides to spend some time on Earth to better understand humanity. He settles in Los Angeles - the City of Angels.', 'Lucifer ROCKS!', 0);
insert into Entertainment values ('Arrow', 2, 1, '1010-10-10', 'New York', 'Spoiled billionaire playboy Oliver Queen is missing and presumed dead when his yacht is lost at sea. He returns five years later a changed man, determined to clean up the city as a hooded vigilante armed with a bow.', 'Go team Arrow!', 0);

insert into Movie values (1);
insert into Movie values (2);
insert into Series values (3);
insert into Series values (4);

insert into Genre values ('Action');
insert into Genre values ('Horror');
insert into Genre values ('Fantasy');

insert into EntertainmentGenre values (1, 1);
insert into EntertainmentGenre values (2, 1);
insert into EntertainmentGenre values (3, 1);
insert into EntertainmentGenre values (3, 3);
insert into EntertainmentGenre values (4, 1);

--insert into FilmingLocation values ('New York');
--insert into FilmingLocation values ('Copenhagen');
--insert into FilmingLocation values ('Paris');

--insert into EntertainmentFilmingLocation values (1, 1);
--insert into EntertainmentFilmingLocation values (2, 1);
--insert into EntertainmentFilmingLocation values (3, 3);
--insert into EntertainmentFilmingLocation values (4, 2);

insert into UserRank values ('Normal');
insert into UserRank values ('Premium');
insert into UserRank values ('Admin');

insert into Person values ('Andreas', 'Larsen', 'BigBy´s hand');
insert into Person values ('Mathias', 'Ytte', 'Kringle');
insert into Person values ('Katrine', 'Vindbaek', 'Pebbernødder');

insert into [User] values (1, 'Linaqx', 'mail@mail.com', 'password', 'salt', 3);
insert into [User] values (2, 'Ytte', 'test@email.com', '1234', 'salt', 3);
insert into [User] values (3, 'KatrineVM', 'kmail@wow.com', 'taellertilfirepaajapansk', 'salt', 3);

insert into Comment values (1, 1, 'It´s so freakin´ awesome!!!!');
insert into Comment values (1, 2, 'I can´t but agree!');

insert into FavoriteList values (1, 'Marvel', 'Most awesome epic super of all time');
insert into FavoriteList values	(1, 'Series', 'All my series');

insert into EntertainmentFavoriteList values (1, 1);
--insert into EntertainmentFavoriteList values (1, 3);
insert into EntertainmentFavoriteList values (3, 1);
insert into EntertainmentFavoriteList values (2, 2);
insert into EntertainmentFavoriteList values (4, 2);

insert into PersonFavoriteList values (1, 1);
insert into PersonFavoriteList values (1, 2);

use master;

