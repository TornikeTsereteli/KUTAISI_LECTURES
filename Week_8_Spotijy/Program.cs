using Week_8_Spotijy.Spotijy;

Song song1 = new Song("title1", 2003, 300);
Song song2 = new Song("title2", 2003, 300);
Song song3 = new Song("title3", 2003, 300);
Song song4 = new Song("title3", 2003, 300);

Console.WriteLine(song1.Title);
Console.WriteLine(song1.Likes);


Album album = new Album("album1", 2003);

album.AddSongs([song1, song2, song3,song4]);

//
// foreach (var song in album.Songs)
// {
//     Console.WriteLine(song);
// }


Console.WriteLine(album.ToString());




