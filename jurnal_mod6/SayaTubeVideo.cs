using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal_mod6
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            Debug.Assert(title.Length <= 200 && title != null, "title tidak dapat dimasukkan");
            this.title = checked(title);
            this.playCount = 0;

        }

        public string getTitle(string v) { return title; }

        public int getPlaycount()
        {
            return playCount;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount < 25000000, "play count tidak dapat ditambahkan karena lebih dari 25.000.000");
            Debug.Assert(this.playCount + playCount < int.MaxValue, "jumlah play count melebihi batas");
            this.playCount = checked(this.playCount + playCount); this.playCount = playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id + "\n" + "Judul: " + title + "\n" + "Play count: " + playCount + "\n");

        }
    }
}
