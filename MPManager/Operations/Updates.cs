using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SessionManagement
{
    internal static class Updates
    {
          public static string NewUpdateDownloadUrl(string urli)
        {
            using (WebClient client = new WebClient())
            {
                string value = client.DownloadString(urli);
                if (value != null)
                {
                    string[] words = value.Split('"');
                    for (int i = 0; i < words.Length; i++) 
                    {
                        if (words[i].Equals("filename"))
                        {
                            string[] words2 = words[i + 2].Split(' ');
                            if (words2.Length == 3)
                            {
                                if (!Global.strAppVersion.Equals(words2[2].Trim()))
                                {
                                   
                                    return GetDownloadUrlFromUrl(value);
                                }
                            }
                        }
                    }
                }
                return "";
            }
        }

        private static string GetDownloadUrlFromUrl(string value) {
              int indexStar = value.IndexOf("\"url\": \"") + 8;
              string subst1 = value.Substring(indexStar);
              int indexStop = subst1.IndexOf("\",");
              string subst2 = subst1.Substring(0,indexStop);
              return subst2;
        } 

    }
}
