using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("author 1","Title 1",111);
        _videos[0].AddComment("Author 1","comment 1");
        _videos[0].AddComment("Author 12","comment 12");
        _videos[0].AddComment("Author 13","comment 13");

         _videos[1] = new Video("author 1","Title 1",111);
        _videos[1].AddComment("Author 1","comment 1");
        _videos[1].AddComment("Author 12","comment 12");
        _videos[1].AddComment("Author 13","comment 13");

         _videos[2] = new Video("author 2","Title 2",222);
        _videos[2].AddComment("Author 2","comment 2");
        _videos[2].AddComment("Author 22","comment 22");
        _videos[2].AddComment("Author 23","comment 23");

         _videos[3] = new Video("author 3","Title 3",333);
        _videos[3].AddComment("Author 3","comment 3");
        _videos[3].AddComment("Author 32","comment 32");
        _videos[3].AddComment("Author 33","comment 33");

        for(int i = 0; i <_videos.Length; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayInfo();
            _videos[i].DisplayVideoComment();

        }
    }
}