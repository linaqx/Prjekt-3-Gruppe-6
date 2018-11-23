use dmab0917_1026423;

--select * from EntertainmentGenre;

--select * from Entertainment, EntertainmentGenre where Entertainment.id = EntertainmentGenre.entertainment_id;

--select * from EntertainmentGenre, Genre where EntertainmentGenre.genre_id = Genre.id;

--select Entertainment.id, Entertainment.title, Entertainment.releaseDate, Entertainment.storyline, Entertainment.information, Country.[name] as country, 
--[Language].[name] as [language], FilmingLocation.[name] as filmingLocation, Genre.[name] as genre 
--from Entertainment
--INNER JOIN Country on (Entertainment.country_id = Country.id)
--INNER JOIN [Language] on (Entertainment.language_id = [Language].id)
--INNER JOIN FilmingLocation on (EntertainmentFilmingLocation.filmingLocation_id = FilmingLocation.id)
--INNER JOIN EntertainmentGenre on (Entertainment.id = EntertainmentGenre.genre_id)
--INNER JOIN Genre as genre on (EntertainmentGenre.genre_id = Genre.id);

--select Entertainment.id, Entertainment.title, Entertainment.releaseDate from Entertainment;




select Entertainment.id, Entertainment.title, Entertainment.releaseDate
from Entertainment
INNER JOIN PersonFavoriteList on (PersonFavoriteList.person_id = Person.id)


--where PersonFavoriteList.favoriteList_id = FavoriteList.id and PersonFavoriteList.person_id = Person.id and EntertainmentFavoriteList.entertainment_id = Entertainment.id and EntertainmentFavoriteList.favoriteList_id = FavoriteList.id;


-- Person - FavoriteList - PersonFavoriteList - Entertainment - EntertainmentFavoriteList











use master;