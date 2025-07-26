using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video = new Video();
        video._title = "Mr Bones";
        video._author = "Shakes Tshabalala";
        video._length = 123.88;

        Video video1 = new Video();
        video1._title = "Swaziland";
        video1._author = "Sibenkhosi Mchobokazi";
        video1._length = 233.97;

        Video video2 = new Video();
        video2._title = "Gathering Zion";
        video2._author = "Zakhele Mago";
        video2._length = 3292.0867;


        Comment comment = new Comment();
        comment._nameOfPerson = "Chris Junior";
        comment._textComment = "This is such a creative visual artwork";

        Comment comment1 = new Comment();
        comment1._nameOfPerson = "Ali Dlamini";
        comment1._textComment = "Wow this is really on fire";

        Comment comment2 = new Comment();
        comment2._nameOfPerson = "Spice Kenny";
        comment2._textComment = "Love how this takes reminds me when I serve mission in Ghana";

        Comment comment3 = new Comment();
        comment3._nameOfPerson = "Live Jackson";
        comment3._textComment = "Absolutely love it";

        Comment comment4 = new Comment();
        comment4._nameOfPerson = "Sibe Dlamini";
        comment4._textComment = "So boring";

        video._comment.Add(comment);
        video._comment.Add(comment4);
        video1._comment.Add(comment1);
        video2._comment.Add(comment2);
        video2._comment.Add(comment3);
        
        Console.WriteLine("-------");

        video.DisplayVideos();
        comment.DisplayTextComment();
        comment4.DisplayTextComment();

        Console.WriteLine("-------");

        video1.DisplayVideos();
        comment1.DisplayTextComment();

        Console.WriteLine("-------");

        video2.DisplayVideos();
        comment2.DisplayTextComment();
        comment3.DisplayTextComment();
    }
}