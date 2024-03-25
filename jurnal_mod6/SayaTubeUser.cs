using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal_mod6
{
    internal class SayaTubeUser
    {
        private int id;
        private string username;
        private List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            this.username = username;
            Random randomID = new Random();
            id = randomID.Next(10000, 99999);
            uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int nampung = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                nampung += uploadedVideos[i].getPlaycount();
            }
            return nampung;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("user:" + username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i +1) + uploadedVideos[i].getTitle);
            }
        }
    }
}
