using System.Net.Mime;
using System.Text.Json;
using DotNetFlixTerminal.Domain;

namespace DotNetFlixTerminal.Data;

public class FileDataAccess : IDataAccess
{
    private readonly string _filePath;
    private readonly JsonSerializerOptions _jsonOptions;
    
    public FileDataAccess(string filePath)
    {
        _filePath = filePath;
        _jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    }

    public List<EBook> LoadEBooks()
    {
        if (!File.Exists(_filePath))
            return new List<EBook>();

        string json = File.ReadAllText(_filePath);
        List<EBook>? data = JsonSerializer.Deserialize<List<EBook>>(json);
        return data ?? new List<EBook>();
    }

    public List<App> LoadApps()
    {
        if (!File.Exists(_filePath))
            return new List<App>();
        
        string json = File.ReadAllText(_filePath);
        List<App>? data = JsonSerializer.Deserialize<List<App>>(json);
        return data ?? new List<App>();
    }

    public List<Game> LoadGames()
    {
        if (!File.Exists(_filePath))
            return new List<Game>();
        
        string json = File.ReadAllText(_filePath);
        List<Game>? data = JsonSerializer.Deserialize<List<Game>>(json);
        return data ?? new List<Game>();
    }

    public List<Image> LoadImages()
    {
        if (!File.Exists(_filePath))
            return new List<Image>();
        
        string json = File.ReadAllText(_filePath);
        List<Image>? data = JsonSerializer.Deserialize<List<Image>>(json);
        return data ?? new List<Image>();
    }

    public List<Movie> LoadMovies()
    {
        if (!File.Exists(_filePath))
            return new List<Movie>();
        
        string json = File.ReadAllText(_filePath);
        List<Movie>? data = JsonSerializer.Deserialize<List<Movie>>(json);
        return data ?? new List<Movie>();
    }

    public List<Song> LoadSongs()
    {
        if (!File.Exists(_filePath))
            return new List<Song>();
        
        string json = File.ReadAllText(_filePath);
        List<Song>? data = JsonSerializer.Deserialize<List<Song>>(json);
        return data ?? new List<Song>();
    }

    public List<Podcast> LoadPodcasts()
    {
        if (!File.Exists(_filePath))
            return new List<Podcast>();
        
        string json = File.ReadAllText(_filePath);
        List<Podcast>? data = JsonSerializer.Deserialize<List<Podcast>>(json);
        return data ?? new List<Podcast>();
    }

    public void SaveEBooks(List<EBook> books)
    {
        string json = JsonSerializer.Serialize(books, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    public void SaveApps(List<App> apps)
    {
        string json = JsonSerializer.Serialize(apps, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    public void SaveGames(List<Game> games)
    {
        string json = JsonSerializer.Serialize(games, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    public void SaveImages(List<Image> images)
    {
        string json = JsonSerializer.Serialize(images, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    public void SaveMovies(List<Movie> movies)
    {
        string json = JsonSerializer.Serialize(movies, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    public void SaveSongs(List<Song> songs)
    {
        string json = JsonSerializer.Serialize(songs, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }

    public void SavePodcasts(List<Podcast> podcasts)
    {
        string json = JsonSerializer.Serialize(podcasts, _jsonOptions);
        File.WriteAllText(_filePath, json);
    }
}