using DotNetFlixTerminal.Domain;
using System;
using System.Collections.Generic;

namespace DotNetFlixTerminal.Presentation
{

    public class MainMenu()
    {
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("  Hi! What do you want to do today?");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Manage E-books");
                Console.WriteLine("2. Manage Movies");
                Console.WriteLine("3. Manage Songs");
                Console.WriteLine("4. Manage Video-games");
                Console.WriteLine("5. Manage Apps");
                Console.WriteLine("6. Manage Podcasts");
                Console.WriteLine("7. Manage Images");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Type 'off' to close the program.");
                Console.WriteLine("===================================");
                Console.Write("Select: ");

                string choice = Console.ReadLine();
                if (choice == "off")
                    return;

                switch (choice)
                {
                    case "1": OpenEbooks(); break;
                    // case "2": OpenMovies(); break;
                    // case "3": OpenSongs(); break;
                    // case "4": OpenGames(); break;
                    // case "5": OpenApps(); break;
                    // case "5": OpenPodcasts(); break;
                    // case "6": OpenImages(); break;
                }

                
            }

        }

        private void OpenEbooks()
        {
            var ui=new EbooksUI(new Ebooks());
            ui.Run();
        }

    //     private void OpenMovies()
    //     {
    //         var ui=new MoviesUI(new Movies());
    //         ui.Run();
    //     }

    //     private void OpenSongs()
    //     {
    //         var ui=new SongsUI(new Songs());
    //         ui.Run();
    //     }

    //     private void OpenGames()
    //     {
    //         var ui=new VideoGamesUI(new VideoGames());
    //         ui.Run();
    //     }

    //     private void OpenApps()
    //     {
    //         var ui=new AppsUI(new Apps());
    //         ui.Run();
    //     }

    //     private void OpenPodcasts()
    //     {
    //         var ui=new PodcastsUI(new Podcasts());
    //         ui.Run();
    //     }

    //     private void OpenImages()
    //     {
    //         var ui=new ImagesUI(new Images());
    //         ui.Run();
    //     }
    // }
    public class EbooksUI
    {
        private EBooks _db;

        public EbooksUI (EBooks db)
        {
            _db = db;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== Book Manager ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. List Books");
                Console.WriteLine("3. Find Book");
                Console.WriteLine("4. Exit");

                Console.Write("Select: ");
                string choice = Console.ReadLine();

                if (choice == "1") AddBookFlow();
                else if (choice == "2") ListBooksFlow();
                else if (choice == "3") FindBookFlow();
                else if (choice == "4") return;
            }
        }

        private void AddEBookFlow()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Year: ");
            string yearText = Console.ReadLine();
            int year;

            if (!int.TryParse(yearText, out year))
            {
                Console.WriteLine("Invalid year.");
                return;
            }

            string result = _db.AddEBook(title, author, year);
            Console.WriteLine(result);
        }

        private void ListBooksFlow()
        {
            //You need to implement the code here
            Console.WriteLine("===List of books: ===");
            var books = _db.GetBooks();
            for(int i=0;i<books.Count();i++)
            {
                Console.WriteLine("{0} | {1}", books[i].Id, books[i].Title);
            }

        }

        private void FindBookFlow()
        {
            // You need to implemnet the code here
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Book myBook = _db.FindBook(title);
            if(myBook == null)
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("Your book: {0} | {1} , written by {2} , was published in {3}", myBook.Id, myBook.Title, myBook.Author, myBook.Year);
        }

        
    }

    // public class SongsUI
    // {
    //     private Songs _db;

    //     public SongsUI (Songs db)
    //     {
    //         _db = db;
    //     }

    //     public void Run()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("\n=== Book Manager ===");
    //             Console.WriteLine("1. Add Song");
    //             Console.WriteLine("2. List Songs");
    //             Console.WriteLine("3. Find Song");
    //             Console.WriteLine("4. Exit");

    //             Console.Write("Select: ");
    //             string choice = Console.ReadLine();

    //             if (choice == "1") AddSongFlow();
    //             else if (choice == "2") ListSongFlow();
    //             else if (choice == "3") FindSongFlow();
    //             else if (choice == "4") return;
    //         }
    //     }

    //     private void AddSongFlow()
    //     {
    //         Console.Write("Title: ");
    //         string title = Console.ReadLine();

    //         Console.Write("Author: ");
    //         string author = Console.ReadLine();

    //         Console.Write("Year: ");
    //         string yearText = Console.ReadLine();
    //         int year;

    //         if (!int.TryParse(yearText, out year))
    //         {
    //             Console.WriteLine("Invalid year.");
    //             return;
    //         }

    //         string result = _db.AddEBook(title, author, year);
    //         Console.WriteLine(result);
    //     }

    //     private void ListSongFlow()
    //     {
    //         //You need to implement the code here
    //         Console.WriteLine("===List of books: ===");
    //         var books = _db.GetBooks();
    //         for(int i=0;i<books.Count();i++)
    //         {
    //             Console.WriteLine("{0} | {1}", books[i].Id, books[i].Title);
    //         }

    //     }

    //     private void FindSongFlow()
    //     {
    //         // You need to implemnet the code here
    //         Console.Write("Enter title: ");
    //         string title = Console.ReadLine();
    //         Book myBook = _db.FindBook(title);
    //         if(myBook == null)
    //         {
    //             Console.WriteLine("Not Found");
    //         }
    //         Console.WriteLine("Your book: {0} | {1} , written by {2} , was published in {3}", myBook.Id, myBook.Title, myBook.Author, myBook.Year);
    //     }

        
    // }

    // public class MoviesUI
    // {
    //     private Movies _db;

    //     public MoviesUI(Movies db)
    //     {
    //         _db = db;
    //     }

    //     public void Run()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("\n=== Movie Manager ===");
    //             Console.WriteLine("1. Add Movie");
    //             Console.WriteLine("2. List Movies");
    //             Console.WriteLine("3. Find Movie");
                
    //             Console.WriteLine("4. Exit");

    //             Console.Write("Select: ");
    //             string choice = Console.ReadLine();

    //             if (choice == "1") AddMovieFlow();
    //             else if (choice == "2") ListMoviesFlow();
    //             else if (choice == "3") FindMovieFlow();
                
    //             else if (choice == "4") return;
    //         }
    //     }

    //     private void AddMovieFlow()
    //     {
    //         Console.Write("Title: ");
    //         string title = Console.ReadLine();

    //         Console.Write("Director: ");
    //         string director = Console.ReadLine();

    //         Console.Write("Genres: ");
    //         string genres = Console.ReadLine();

    //         Console.Write("Release Year: ");
    //         if (!int.TryParse(Console.ReadLine(), out int year))
    //         {
    //             Console.WriteLine("Invalid year.");
    //             return;
    //         }

    //         Console.Write("Language: ");
    //         string language = Console.ReadLine();

    //         Console.Write("Duration (minutes): ");
    //         if (!int.TryParse(Console.ReadLine(), out int duration))
    //         {
    //             Console.WriteLine("Invalid duration.");
    //             return;
    //         }

    //         string result = _db.AddMovie(title, director, genres, year, language, duration);
    //         Console.WriteLine(result);
    //     }

    //     private void ListMoviesFlow()
    //     {
    //         Console.WriteLine("=== List of Movies ===");
    //         var movies = _db.GetMovies();
    //         foreach (var m in movies)
    //             Console.WriteLine($"{m.Id} | {m.Title}");
    //     }

    //     private void FindMovieFlow()
    //     {
    //         Console.Write("Enter title: ");
    //         string title = Console.ReadLine();
    //         var movie = _db.FindMovie(title);

    //         if (movie == null)
    //         {
    //             Console.WriteLine("Not Found.");
    //             return;
    //         }

    //         Console.WriteLine($"Movie: {movie.Title} | {movie.Director} | {movie.ReleaseYear}");
    //     }

        
        
    // }
    // public class VideoGamesUI
    // {
    //     private VideoGames _db;

    //     public VideoGamesUI(VideoGames db)
    //     {
    //         _db = db;
    //     }

    //     public void Run()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("\n=== Video Game Manager ===");
    //             Console.WriteLine("1. Add Game");
    //             Console.WriteLine("2. List Games");
    //             Console.WriteLine("3. Find Game");
    //             Console.WriteLine("4. Exit");

    //             string choice = Console.ReadLine();

    //             if (choice == "1") AddGameFlow();
    //             else if (choice == "2") ListGamesFlow();
    //             else if (choice == "3") FindGameFlow();
    //             else if (choice == "4") return;
    //         }
    //     }

    //     private void AddGameFlow()
    //     {
    //         Console.Write("Title: ");
    //         string title = Console.ReadLine();

    //         Console.Write("Genre: ");
    //         string genre = Console.ReadLine();

    //         Console.Write("Publisher: ");
    //         string publisher = Console.ReadLine();

    //         Console.Write("Release Year: ");
    //         int.TryParse(Console.ReadLine(), out int year);

    //         Console.Write("Platforms: ");
    //         string platforms = Console.ReadLine();

    //         string result = _db.AddGame(title, genre, publisher, year, platforms);
    //         Console.WriteLine(result);
    //     }

    //     private void ListGamesFlow()
    //     {
    //         Console.WriteLine("=== Video Games ===");
    //         foreach (var g in _db.GetGames())
    //             Console.WriteLine($"{g.Id} | {g.Title}");
    //     }

    //     private void FindGameFlow()
    //     {
    //         Console.Write("Enter title: ");
    //         var game = _db.FindGame(Console.ReadLine());

    //         if (game == null)
    //         {
    //             Console.WriteLine("Not found");
    //             return;
    //         }

    //         Console.WriteLine($"{game.Title} | {game.Genre} | {game.ReleaseYear}");
    //     }

        
    // }

    // public class AppsUI
    // {
    //     private Apps _db;

    //     public AppsUI(Apps db)
    //     {
    //         _db = db;
    //     }

    //     public void Run()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("\n=== App Manager ===");
    //             Console.WriteLine("1. Add App");
    //             Console.WriteLine("2. List Apps");
    //             Console.WriteLine("3. Find App");
                
    //             Console.WriteLine("4. Exit");

    //             string choice = Console.ReadLine();

    //             if (choice == "1") AddAppFlow();
    //             else if (choice == "2") ListAppsFlow();
    //             else if (choice == "3") FindAppFlow();
                
    //             else if (choice == "4") return;
    //         }
    //     }

    //     private void AddAppFlow()
    //     {
    //         Console.Write("Title: ");
    //         string title = Console.ReadLine();

    //         Console.Write("Version: ");
    //         string version = Console.ReadLine();

    //         Console.Write("Publisher: ");
    //         string publisher = Console.ReadLine();

    //         Console.Write("Supported Platforms: ");
    //         string platforms = Console.ReadLine();

    //         Console.Write("File Size (MB): ");
    //         double.TryParse(Console.ReadLine(), out double size);

    //         string result = _db.AddApp(title, version, publisher, platforms, size);
    //         Console.WriteLine(result);
    //     }

    //     private void ListAppsFlow()
    //     {
    //         foreach (var a in _db.GetApps())
    //             Console.WriteLine($"{a.Id} | {a.Title}");
    //     }

    //     private void FindAppFlow()
    //     {
    //         var app = _db.FindApp(Console.ReadLine());
    //         if (app == null) Console.WriteLine("Not found.");
    //         else Console.WriteLine($"{app.Title} | {app.Version}");
    //     }

        
    // }

    // public class PodcastsUI
    // {
    //     private Podcasts _db;

    //     public PodcastsUI(Podcasts db)
    //     {
    //         _db = db;
    //     }

    //     public void Run()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("\n=== Podcast Manager ===");
    //             Console.WriteLine("1. Add Podcast");
    //             Console.WriteLine("2. List Podcasts");
    //             Console.WriteLine("3. Find Podcast");
                
    //             Console.WriteLine("4. Exit");

    //             string choice = Console.ReadLine();

    //             if (choice == "1") AddPodcastFlow();
    //             else if (choice == "2") ListPodcastsFlow();
    //             else if (choice == "3") FindPodcastFlow();
                
    //             else if (choice == "4") return;
    //         }
    //     }

    //     private void AddPodcastFlow()
    //     {
    //         Console.Write("Title: ");
    //         string title = Console.ReadLine();

    //         Console.Write("Release Year: ");
    //         int.TryParse(Console.ReadLine(), out int year);

    //         Console.Write("Host(s): ");
    //         string hosts = Console.ReadLine();

    //         Console.Write("Guest(s): ");
    //         string guests = Console.ReadLine();

    //         Console.Write("Episode Number: ");
    //         int.TryParse(Console.ReadLine(), out int epNum);

    //         Console.Write("Language: ");
    //         string language = Console.ReadLine();

    //         Console.WriteLine(_db.AddPodcast(title, year, hosts, guests, epNum, language));
    //     }

    //     private void ListPodcastsFlow()
    //     {
    //         foreach (var p in _db.GetPodcasts())
    //             Console.WriteLine($"{p.Id} | {p.Title}");
    //     }

    //     private void FindPodcastFlow()
    //     {
    //         var p = _db.FindPodcast(Console.ReadLine());
    //         if (p == null) Console.WriteLine("Not found");
    //         else Console.WriteLine($"{p.Title} | EP {p.EpisodeNumber}");
    //     }

    //     private void DeletePodcastFlow()
    //     {
    //         Console.WriteLine(_db.DeletePodcast(Console.ReadLine()) ? "Deleted." : "Not found.");
    //     }

    //     public class ImagesUI
    //     {
    //         private Images _db;

    //         public ImagesUI(Images db)
    //         {
    //             _db = db;
    //         }

    //         public void Run()
    //         {
    //             while (true)
    //             {
    //                 Console.WriteLine("\n=== Image Manager ===");
    //                 Console.WriteLine("1. Add Image");
    //                 Console.WriteLine("2. List Images");
    //                 Console.WriteLine("3. Find Image");
    //                 Console.WriteLine("4. Exit");

    //                 string choice = Console.ReadLine();

    //                 if (choice == "1") AddImageFlow();
    //                 else if (choice == "2") ListImagesFlow();
    //                 else if (choice == "3") FindImageFlow();
                    
    //                 else if (choice == "4") return;
    //             }
    //         }

    //         private void AddImageFlow()
    //         {
    //             Console.Write("Title: ");
    //             string title = Console.ReadLine();

    //             Console.Write("Resolution: ");
    //             string resolution = Console.ReadLine();

    //             Console.Write("Format: ");
    //             string format = Console.ReadLine();

    //             Console.Write("File Size (MB): ");
    //             double.TryParse(Console.ReadLine(), out double size);

    //             Console.Write("Date Taken: ");
    //             string date = Console.ReadLine();

    //             Console.WriteLine(_db.AddImage(title, resolution, format, size, date));
    //         }

    //         private void ListImagesFlow()
    //         {
    //             foreach (var img in _db.GetImages())
    //                 Console.WriteLine($"{img.Id} | {img.Title}");
    //         }

    //         private void FindImageFlow()
    //         {
    //             var img = _db.FindImage(Console.ReadLine());
    //             if (img == null) Console.WriteLine("Not found.");
    //             else Console.WriteLine($"{img.Title} | {img.Resolution}");
    //         }

    //         private void DeleteImageFlow()
    //         {
    //             Console.WriteLine(_db.DeleteImage(Console.ReadLine()) ? "Deleted." : "Not found.");
    //         }
    //     }

    // }



}

