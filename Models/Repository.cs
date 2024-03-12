using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new List<Course>();
        static Repository()
        {
            _courses = new List<Course>{
                new Course (){Id=1,
                Title="Çığlık",
                Description="Edvard Munch",
                Content="Çığlık, Norveçli ressam Edvard Munch tarafından yapılan 1893 tarihli tablo. Eserin Norveççe adı Skrik, ilk kez sergilendiği Almanca adı ise Der Schrei der Natur'dur. Tablodaki ıstırap çeken yüz, sanatın en ikonik imgelerinden biri haline gelmiştir ve insanın kaygısını sembolize ettiği düşünülmektedir.",
                image="ciglik.jpg",
                Tags=new string[] {"Sanat", "Resim"},
                isActive=true,
                isHome=true
                },
                new Course (){Id=2,
                Title="Mona Lisa",
                Description="Leonardo da Vinci",
                image="monalisa2.jpg",
                Content="Mona Lisa, İtalya'nın Floransa şehrindeki Rönesans sırasında Leonardo da Vinci tarafından kavak bir pano üzerine Sfumato tekniği ile resmedilmiş 16. yüzyıl yağlı boya portresidir. Resim hâlen Paris'teki Louvre Müzesi'nde Francesco del Giocondo'nun karısı, Lisa Gherardini Portresi başlığı altında sergilenmektedir.",
                Tags=new string[]{"Sanat", "Resim"},
                isActive=true,
                isHome=true
                },
                new Course (){Id=3,
                Title="Kaplumbağa Terbiyecisi",
                Description="Osman Hamdi Bey",
                image="kTerbiyecisi.jpg",
                Content="Kaplumbağa Terbiyecisi, Osman Hamdi Bey'in 1906 ve 1907 yıllarında iki farklı versiyonunu çizdiği tablosudur.",
                isActive=true,
                isHome=false
                },
                new Course (){Id=4,
                Title="İnci Küpeli Kız",
                Description="Johannes Vermeer",
                image="inciKupeliKiz.jpg",
                Content="İnci Küpeli Kız, Hollandalı ressam Johannes Vermeer'in başyapıtlarından biri olan tablodur. Adından anlaşılacağı gibi odak noktası bir inci küpedir. Eser, 1902'den beri Lahey'de, Mauritshuis'te sergilenmektedir ve çeşitli edebî incelemelere konu olmuştur.",
                isActive=false,
                isHome=true},

                new Course (){Id=5,
                Title="Persistence of Memory (Belleğin Azmi)",
                Description="Salvador Dali",
                image="belleginazmi.jpg",
                Content="'Belleğin Azmi' adındaki eser 'Eriyen Saatler' adıyla da bilinmektedir. Salvador Dali'nin en bilinen eseridir. Ünlü gerçeküstü tabloda yumuşaklık ve sertlik anlayışına ışık tutulmuştur. Resmin merkezinde canavara betimlemesine rastlanır ve bu Dali'nin birçok eserinde bulunur. Sanatçının kendisini betimlediği algısına yol açmıştır. New York'ta The Moders Art Galery'de sergilenmektedir.",
                isActive=true,
                isHome=true},

                new Course (){Id=6,
                Title="The Last Supper (Son Akşam Yemeği)",
                Description="Leonardo da Vinci",
                image="sonyemek.jpg",
                Content="Eser 15. yüzyıl'da Duke Lodovico Sforza'nın isteği üzerine yapılmıştır. İsa Mesih'in havarileriyle beraber yediği son akşam yemeğini temsil eder. Eser günümüzde Milano'da bulunan Maria delle Grazie'de sergilenmektedir.",
                isActive=true,
                isHome=true},

                new Course (){Id=7,
                Title=" Battaglia di San Romano (San Romano Muharebesi)",
                Description="Paolo Uccello",
                image="sonyemek.jpg",
                Content="Üç ayrı tablo şeklinde savaş zamanları ve hissettikleri tasvir edilmiştir. Londra'da National Gallery'de sergilenmekted",
                isActive=true,
                isHome=true},


            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }

        }
        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}