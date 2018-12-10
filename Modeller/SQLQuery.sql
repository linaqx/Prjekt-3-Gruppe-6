use dmab0917_1026423;
--use Projekt3_Gruppe6;

--select * from EntertainmentGenre;

--select * from Entertainment, EntertainmentGenre where Entertainment.id = EntertainmentGenre.entertainment_id;

--select * from EntertainmentGenre, Genre where EntertainmentGenre.genre_id = Genre.id;

select Entertainment.id, Entertainment.title, Entertainment.releaseDate, Entertainment.storyline, Entertainment.information, Country.[name] as country,
[Language].[name] as [language], Genre.[name] as genre, FilmingLocation.[name] as filmingLocation, Entertainment.isMovie as isMovie
from Movie
INNER JOIN Entertainment on (Entertainment.id = Movie.entertainment_id)
INNER JOIN Country on (Entertainment.country_id = Country.id)
INNER JOIN [Language] on (Entertainment.language_id = [Language].id)
INNER JOIN EntertainmentFilmingLocation on (Entertainment.id = EntertainmentFilmingLocation.entertainment_id)
INNER JOIN FilmingLocation on (EntertainmentFilmingLocation.filmingLocation_id = FilmingLocation.id)
INNER JOIN EntertainmentGenre on (Entertainment.id = EntertainmentGenre.entertainment_id)
INNER JOIN Genre on (EntertainmentGenre.genre_id = Genre.id)
where  Movie.entertainment_id = 5;



----------Find all entertainments----------
select Entertainment.id, Entertainment.title, Entertainment.releaseDate, Entertainment.isMovie from Entertainment;



----------Find all specific favorit entertainments----------
--select Entertainment.id, Entertainment.title, Entertainment.releaseDate
--from Entertainment
--INNER JOIN EntertainmentFavoriteList on (EntertainmentFavoriteList.entertainment_id = Entertainment.id)
--where EntertainmentFavoriteList.favoriteList_id = 1;



----------Find all Person FavoriteLists----------
--select FavoriteList.id, FavoriteList.[name], FavoriteList.[description] from PersonFavoriteList, FavoriteList where PersonFavoriteList.person_id = 1 and PersonFavoriteList.favoriteList_id = FavoriteList.id;



----------Insert Entertainment----------
--insert into Entertainment(title, country_id, language_id, releaseDate, storyline, information) output inserted.id values (@title, @country_id, @language_id, @releaseDate, @storyline, @information);



----------Insert Movie----------
--insert into Movie(entertainment_id) values (@entertainment_id);



----------Insert into EntertainmentGenre----------
--insert into EntertainmentGenre (entertainment_id, genre_id) values (@entertainment_id, @genre_id);



----------Insert into EntertainmentFilmingLocation----------
--insert into EntertainmentFilmingLocation (entertainment_id, filmingLocation_id) values (@entertainment_id, @filmingLocation_id);



----------Find all Genre----------
--select Genre.id, Genre.[name] from Genre;



----------Find all FilmingLocation----------
--select FilmingLocation.id, FilmingLocation.[name] from FilmingLocation;



----------Find all Language----------
--select [Language].id, [Language].[name] from [Language];



----------Find all Countries----------
--select Country.id, Country.[name] from Country;




----------Find all Favoritelists by person id---------- ER ALLEREDE LAVET ANDETSTEDS
--select * from PersonFavoriteList where person_id = @id;



----------Find all Entertainments by FavoriteList id----------
--select Entertainment.id, Entertainment.title, Entertainment.releaseDate from Entertainment, EntertainmentFavoriteList where EntertainmentFavoriteList.favoriteList_id = 1 and EntertainmentFavoriteList.entertainment_id = Entertainment.id;



----------Add Entertainment to FavoriteList by Entertainment id and FavoriteList id-----------
--insert into EntertainmentFavoriteList (entertainment_id, favoriteList_id) values (@entertainment_id, @favoriteList_id);



----------Get Movie by id----------
--select * from Entertainment, Movie where Entertainment.id = @id and Entertainment.id = Movie.entertainment_id;



----------Create new FavoriteList----------
--insert into FavoriteList (author, [name], [description]) values (@author, @name, @description);
--select * from FavoriteList;


----------Add User to FavoriteList----------
--select * from PersonFavoriteList;
--insert into PersonFavoriteList (person_id, favoriteList_id) values (@person_id, @favoriteList_id);
--select * from PersonFavoriteList;



----------Remove User from FavoriteList----------
--select * from PersonFavoriteList;
--delete from PersonFavoriteList where person_id = @person_id and favoriteList_id = @favoriteList_id;
--select * from PersonFavoriteList;



----------Add comment to movie----------

--select * from Comment;

select * from Entertainment, Movie where Entertainment.id = Movie.entertainment_id;



----------Find Movie by Id----------
--select * from Movie, Entertainment, Genre, FilmingLocation where Entertainment.id = Movie.entertainment_id and Entertainment.id = ;







use master;