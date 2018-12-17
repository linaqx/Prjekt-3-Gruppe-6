using Model___Layer.Model;
using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace WCF___library.DB
{
    public class EntertainmentDB : IEntertainmentDB
    {
        private readonly string sql_FIND_ALL_ENTERTAINMENT = "select Entertainment.id, Entertainment.title, Entertainment.releaseDate, Entertainment.isMovie from Entertainment;";
        private readonly string sql_FIND_ALL_ENTERTAINMENT_ON_FAVORITELIST = "select Entertainment.id, Entertainment.title, Entertainment.releaseDate, Entertainment.isMovie from Entertainment INNER JOIN EntertainmentFavoriteList on(EntertainmentFavoriteList.entertainment_id = Entertainment.id) where EntertainmentFavoriteList.favoriteList_id = @id;";

        private readonly string sql_FIND_ALL_GENRE = "select Genre.id, Genre.[name] from Genre;";
        private readonly string sql_FIND_ALL_LANGUAGE = "select [Language].id, [Language].[name] from [Language];";
        private readonly string sql_FIND_ALL_COUNTRIES = "select Country.id, Country.[name] from Country;";

        private readonly string sql_INSERT_ENTERTAINMENT = "insert into Entertainment(title, country_id, language_id, releaseDate, storyline, information, isMovie) output inserted.id values (@title, @country_id, @language_id, @releaseDate, @storyline, @information, @isMovie);";
        private readonly string sql_INSERT_MOVIE = "insert into Movie(entertainment_id) values (@entertainment_id);";
        private readonly string sql_INSERT_ENTERTAINMENTGENRE = "insert into EntertainmentGenre (entertainment_id, genre_id) values (@entertainment_id, @genre_id);";
        private readonly string sql_INSERT_COMMENT = "insert into Comment(entertainment_id, [user_id], [message]) values(@entertainment_id, @user_id, @message);";

        private readonly string sql_FIND_MOVIE_BY_ID = "select Entertainment.id, Entertainment.title, Entertainment.releaseDate, Entertainment.storyline, Entertainment.information, Entertainment.country_id, Entertainment.language_id, Genre.[name] as genre, Entertainment.filmingLocation, Entertainment.isMovie as isMovie from Movie INNER JOIN Entertainment on(Entertainment.id = Movie.entertainment_id) INNER JOIN EntertainmentGenre on(Entertainment.id = EntertainmentGenre.entertainment_id) INNER JOIN Genre on(EntertainmentGenre.genre_id = Genre.id) where Movie.entertainment_id = @id;";

        private readonly string sql_FIND_GENRE_ON_MOVIE = "select Genre.id, Genre.[name] as genre from Entertainment INNER JOIN EntertainmentGenre on (Entertainment.id = EntertainmentGenre.entertainment_id) INNER JOIN Genre on (EntertainmentGenre.genre_id = Genre.id) where Entertainment.id = @entertainment_id;";
        private readonly string sql_FIND_COUNTRY_ON_MOVIE = "select Country.id, Country.[name] as country from Country, Entertainment where Entertainment.country_id = Country.id and Entertainment.id = @entertainment_id;";
        private readonly string sql_FIND_LANGUAGE_ON_MOVIE = "select [Language].id, [Language].[name] as [language] from [Language], Entertainment where Entertainment.language_id = [Language].id and Entertainment.id = @entertainment_id";
        private readonly string sql_FIND_COMMENTS_ON_MOVIE = "select Comment.id, Comment.entertainment_id, [User].person_id, [User].userName, Comment.[message] from Comment INNER JOIN Entertainment on (Comment.entertainment_id = Entertainment.id) INNER JOIN[User] on(Comment.[user_id] = [User].person_id) where Comment.entertainment_id = @entertainment_id;";

        private SqlCommand findAllEntertainments;
        private SqlCommand findAllPrivateEntertainments;
        private SqlCommand findAllGenres;
        private SqlCommand findAllLanguages;
        private SqlCommand findAllCountries;

        private SqlCommand findMovieById;
        private SqlCommand findGenreByName;
        private SqlCommand findCountryOnMovie;
        private SqlCommand findLanguageOnMovie;
        private SqlCommand findCommentsOnMovie;

        private SqlCommand insertEntertainment;
        private SqlCommand insertMovie;
        private SqlCommand insertEntertainmentGenre;
        private SqlCommand inserComment;

        private SqlConnection con;

        public EntertainmentDB()
        {
            con = DBConnection.GetInstance().GetConnection();

            findAllEntertainments = con.CreateCommand();
            findAllPrivateEntertainments = con.CreateCommand();
            findAllGenres = con.CreateCommand();
            findAllLanguages = con.CreateCommand();
            findAllCountries = con.CreateCommand();

            findMovieById = con.CreateCommand();
            findGenreByName = con.CreateCommand();
            findCountryOnMovie = con.CreateCommand();
            findLanguageOnMovie = con.CreateCommand();
            findCommentsOnMovie = con.CreateCommand();

            insertEntertainment = con.CreateCommand();
            insertMovie = con.CreateCommand();
            insertEntertainmentGenre = con.CreateCommand();
            inserComment = con.CreateCommand();
        }

        public List<Entertainment> GetAllEntertainments()
        {
            findAllEntertainments.CommandText = sql_FIND_ALL_ENTERTAINMENT;
            List<Entertainment> temp = GetEntertainments(findAllEntertainments);
            return temp;
        }

        public List<Entertainment> GetPersonalEntertainments(int id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@id",
                Value = id
            };

            findAllPrivateEntertainments.Parameters.Add(parameter);
            findAllPrivateEntertainments.CommandText = sql_FIND_ALL_ENTERTAINMENT_ON_FAVORITELIST;
            List<Entertainment> temp = GetEntertainments(findAllPrivateEntertainments);
            return temp;
        }

        private List<Entertainment> GetEntertainments(SqlCommand sqlCommand)
        {
            List<Entertainment> temp = new List<Entertainment>();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Entertainment e = new Entertainment
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Title = reader.GetString(reader.GetOrdinal("title")),
                    ReleaseDate = reader.GetDateTime(reader.GetOrdinal("releaseDate")),
                    IsMovie = reader.GetBoolean(reader.GetOrdinal("isMovie"))
                };

                temp.Add(e);

            }
            reader.Close();
            return temp;
        }

        public List<Genre> GetAllGenres()
        {
            findAllGenres.CommandText = sql_FIND_ALL_GENRE;
            List<Genre> temp = new List<Genre>();
            SqlDataReader reader = findAllGenres.ExecuteReader();
            while (reader.Read())
            {
                Genre g = new Genre
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
                temp.Add(g);
            }

            reader.Close();

            return temp;
        }

        public List<Language> GetAllLanguages()
        {
            findAllLanguages.CommandText = sql_FIND_ALL_LANGUAGE;
            List<Language> temp = new List<Language>();
            SqlDataReader reader = findAllLanguages.ExecuteReader();
            while (reader.Read())
            {
                Language l = new Language
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
                temp.Add(l);
            }

            reader.Close();

            return temp;
        }

        public List<Country> GetAllCountries()
        {
            findAllCountries.CommandText = sql_FIND_ALL_COUNTRIES;
            List<Country> temp = new List<Country>();
            SqlDataReader reader = findAllCountries.ExecuteReader();
            while (reader.Read())
            {
                Country c = new Country
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
                temp.Add(c);
            }

            reader.Close();

            return temp;
        }

        public void StartInsertMovieTransaction(Movie m)
        {
            TransactionOptions to = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, to))
            {
                int insertedId = InsertEntertainment(m);
                InsertMovie(insertedId, m);
                InsertEntertainmentGenre(insertedId, m);

                scope.Complete();
            }

        }

        private int InsertEntertainment(Movie m)
        {
            int insertedId = -1;
            insertEntertainment.CommandText = sql_INSERT_ENTERTAINMENT;

            insertEntertainment.Parameters.AddWithValue("@title", m.Title);
            insertEntertainment.Parameters.AddWithValue("@country_id", m.Country.Id);
            insertEntertainment.Parameters.AddWithValue("@language_id", m.Language.Id);
            insertEntertainment.Parameters.AddWithValue("@releaseDate", m.ReleaseDate);
            insertEntertainment.Parameters.AddWithValue("@storyline", m.StoryLine);
            insertEntertainment.Parameters.AddWithValue("@information", m.Information);
            insertEntertainment.Parameters.AddWithValue("@isMovie", m.IsMovie);

            insertedId = (int)insertEntertainment.ExecuteScalar();

            return insertedId;
        }

        private void InsertMovie(int insertedId, Movie m)
        {
            insertMovie.CommandText = sql_INSERT_MOVIE;
            insertMovie.Parameters.AddWithValue("@entertainment_id", insertedId);
            insertMovie.ExecuteNonQuery();
        }

        private void InsertEntertainmentGenre(int insertedId, Movie m)
        {
            insertEntertainmentGenre.CommandText = sql_INSERT_ENTERTAINMENTGENRE;
            insertEntertainmentGenre.Parameters.AddWithValue("@entertainment_id", insertedId);
            insertEntertainmentGenre.Parameters.AddWithValue("@genre_id", m.Genre.Id);
            insertEntertainmentGenre.ExecuteNonQuery();
        }

        public Movie GetMovieById(int id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@id",
                Value = id
            };

            findMovieById.Parameters.Add(parameter);
            findMovieById.CommandText = sql_FIND_MOVIE_BY_ID;

            Movie movie = new Movie();
            SqlDataReader reader = findMovieById.ExecuteReader();

            while (reader.Read())
            {
                movie = BuildMovie(reader);
            }

            reader.Close();

            movie.Genre = FindGenreOnMovie(movie.Id);
            movie.Country = FindCountryOnMovie(movie.Id);
            movie.Language = FindLanguageOnMovie(movie.Id);
            movie.Comments = FindCommentsOnMovie(movie.Id);

            return movie;
        }

        private Movie BuildMovie(SqlDataReader reader)
        {
            Movie temp = new Movie
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Title = reader.GetString(reader.GetOrdinal("title")),
                ReleaseDate = reader.GetDateTime(reader.GetOrdinal("releaseDate")),
                StoryLine = reader.GetString(reader.GetOrdinal("storyline")),
                Information = reader.GetString(reader.GetOrdinal("information")),
                FilmingLocation = reader.GetString(reader.GetOrdinal("filmingLocation")),
                IsMovie = reader.GetBoolean(reader.GetOrdinal("isMovie")),
            };
            return temp;
        }

        private Genre FindGenreOnMovie(int entertainment_id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@entertainment_id",
                Value = entertainment_id
            };

            findGenreByName.Parameters.Add(parameter);
            findGenreByName.CommandText = sql_FIND_GENRE_ON_MOVIE;
            Genre temp = new Genre();
            SqlDataReader reader = findGenreByName.ExecuteReader();
            while (reader.Read())
            {
                Genre genre = new Genre
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("genre"))
                };

                temp = genre;
            }

            reader.Close();

            return temp;
        }

        private Country FindCountryOnMovie(int entertainment_id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@entertainment_id",
                Value = entertainment_id
            };

            findCountryOnMovie.Parameters.Add(parameter);
            findCountryOnMovie.CommandText = sql_FIND_COUNTRY_ON_MOVIE;
            Country temp = new Country();
            SqlDataReader reader = findCountryOnMovie.ExecuteReader();
            while (reader.Read())
            {
                Country country = new Country
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("country"))
                };

                temp = country;
            }

            reader.Close();

            return temp;
        }

        private Language FindLanguageOnMovie(int entertainment_id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@entertainment_id",
                Value = entertainment_id
            };

            findLanguageOnMovie.Parameters.Add(parameter);
            findLanguageOnMovie.CommandText = sql_FIND_LANGUAGE_ON_MOVIE;
            Language temp = new Language();
            SqlDataReader reader = findLanguageOnMovie.ExecuteReader();
            while (reader.Read())
            {
                Language language = new Language
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("language"))
                };

                temp = language;
            }

            reader.Close();

            return temp;
        }

        /// <summary>
        /// Finds Comments on a specific Movie
        /// </summary>
        /// <param name="entertainment_id"></param>
        /// <returns>List<Comment></returns>
        private List<Comment> FindCommentsOnMovie(int entertainment_id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@entertainment_id",
                Value = entertainment_id
            };

            findCommentsOnMovie.Parameters.Add(parameter);
            findCommentsOnMovie.CommandText = sql_FIND_COMMENTS_ON_MOVIE;
            List<Comment> comments = new List<Comment>();
            SqlDataReader reader = findCommentsOnMovie.ExecuteReader();
            while (reader.Read())
            {
                User user = new User
                {
                    Id = reader.GetInt32(reader.GetOrdinal("person_id")),
                    UserName = reader.GetString(reader.GetOrdinal("username"))
                };

                Comment comment = new Comment
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Entertainment_Id = reader.GetInt32(reader.GetOrdinal("entertainment_id")),
                    User = user,
                    Message = reader.GetString(reader.GetOrdinal("message")),
                };

                comments.Add(comment);
            }

            reader.Close();

            return comments;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comment"></param>
        public void InsertComment(Comment comment)
        {
            TransactionOptions transactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, transactionOptions))
            {
                inserComment.CommandText = sql_INSERT_COMMENT;
                inserComment.Parameters.AddWithValue("@entertainment_id", comment.Entertainment_Id);
                inserComment.Parameters.AddWithValue("@user_id", comment.User.Id);
                inserComment.Parameters.AddWithValue("@message", comment.Message);
                inserComment.ExecuteNonQuery();
                scope.Complete();
            }
        }

    }
}
