using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            Debug.Assert(username.Length <= 100 && username != null, "username tidak dapat dimasukkan");
            this.username = checked(username);
            this.id = 0;
        }

        public int GetTotalVideoPlayCount()
        {
            int count = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                count += uploadedVideos[i].getPlaycount();
            }
            return count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
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
