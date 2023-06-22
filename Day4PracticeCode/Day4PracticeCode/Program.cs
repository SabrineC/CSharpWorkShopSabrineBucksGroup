// See https://aka.ms/new-console-template for more information
using Day4PracticeCode;

Console.WriteLine("Hello, World!");

//Creating an object
Movie firstmovie = new Movie();
firstmovie.MovieTitle = "The Flash";
firstmovie.MovieReleaseYear = 2023;
firstmovie.MovieReleaseStatus = true;

string firstmoviestuff = $"The name of the movie is {firstmovie.MovieTitle} " +
    $"and it is being released in {firstmovie.MovieReleaseYear} " +
    $"and current status of realeasing is {firstmovie.MovieReleaseStatus}";
Console.WriteLine(firstmoviestuff);

Movie secondmovie = new Movie();
secondmovie.MovieTitle = "Elemental";
secondmovie.MovieReleaseYear = 2023;
secondmovie.MovieReleaseStatus = false;

string secondmoviestuff = $"The name of the movie is {secondmovie.MovieTitle} " +
    $"and it is being released in {secondmovie.MovieReleaseYear} " +
    $"and current status of realeasing is {secondmovie.MovieReleaseStatus}";
Console.WriteLine(secondmoviestuff);

Movie thirdmovie = new Movie();
thirdmovie.MovieTitle = "Indiana Jones and the Dial of Destiny";
thirdmovie.MovieReleaseYear = 2023;
thirdmovie.MovieReleaseStatus = false;

string thirdmoviestuff = $"The name of the movie is {thirdmovie.MovieTitle} " +
    $"and it is being released in {thirdmovie.MovieReleaseYear} " +
    $"and current status of realeasing is {thirdmovie.MovieReleaseStatus}";
Console.WriteLine(thirdmoviestuff);

//creating a video game object with Minecraft
VideoGame firstvideogame = new VideoGame();
firstvideogame.NameOfVideoGame = "Minecraft";
firstvideogame.TypeOfGame = "Online Educational Multiplayer Sandbox";
firstvideogame.TypeOfGamingDevice = "Mobile, XBox, PlayStation, PC";
firstvideogame.GameReleaseYear = 2011;

string firstvideogameoutput = $"Name: {firstvideogame.NameOfVideoGame}" +
    $" Type of Videogame: {firstvideogame.TypeOfGame}" +
    $" Where can you play it: {firstvideogame.TypeOfGamingDevice}" +
    $" Release Year: {firstvideogame.GameReleaseYear}";

Console.WriteLine(firstvideogameoutput);
