
namespace _7LS;
class Program
{
    static void Main(string[] args)
    {
        Song S1 = new Song("moshe", 23);
        Song S2 = new Song("nikki", 22);
        Song S3 = new Song("choice", 8);
        Song[] songs = { S1, S2, S3 };
        /*
        TotalSound(S1, S2);
        System.Console.WriteLine(LongestSong(songs));
        */
        /*
        string a = "john adam doe";
        System.Console.WriteLine(secondWord(a));
        */
        /*Q1
        static string secondWord(string _name)
        {
            int inx = _name.IndexOf(' '), lastInx = _name.LastIndexOf(' '), cnt = 0;
            if (inx == -1)
                return _name;

            for (int i = inx + 1; i < _name.Length; i++)
            {
                if (_name[i] == ' ')
                {
                    return _name.Substring(inx + 1, cnt);
                }
                cnt++;
            }
            return _name.Substring(inx + 1);
        }*//*Q2
        static void TotalSound(Song a, Song b)
        {
            int Time_song = a.GetLength();
            int song_Time = b.GetLength();
            System.Console.WriteLine(Time_song + song_Time);
        }*//*Q3
        static string LongestSong(Song[] songs)
        {
            int biggests_so_far = songs[0].GetLength();
            string biggests_name = songs[0].GetName();

            for (int i = 1; i == songs.Length; i++)
            {
                if (songs[i].GetLength() > biggests_so_far)
                {
                    biggests_so_far = songs[i].GetLength();
                    biggests_name = songs[i].GetName();
                }
            }
            return biggests_name;
        }*//*Q4
        static void ChangeName(Song a)
        {
            string name = a.GetName();
            name = secondWord(name);
            a.SetName(name);
        }*/

        Console.ReadKey();
    }
}
