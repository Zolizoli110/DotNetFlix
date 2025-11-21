using DotNetFlixTerminal.Domain;

namespace DotNetFlixTerminal.Data;

public interface IDataAccess
{

    // Methods for loading
    List<EBook> LoadEBooks();
    List<App> LoadApps();
    List<Game> LoadGames();
    List<Image> LoadImages();
    List<Movie> LoadMovies();
    List<Song> LoadSongs();
    List<Podcast> LoadPodcasts();
    // Methods for saving
    void SaveEBooks(List<EBook> books);
    void SaveApps(List<App> apps);
    void SaveGames(List<Game> games);
    void SaveImages(List<Image> images);
    void SaveMovies(List<Movie> movies);
    void SaveSongs(List<Song> songs);
    void SavePodcasts(List<Podcast> podcasts);
}