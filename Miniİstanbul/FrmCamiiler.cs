using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniİstanbul
{
    public partial class FrmCamiiler : Form
    {
        public FrmCamiiler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sultan Ahmet Camii veya Sultânahmed Camiî, 1609-1617 yılları arasında Osmanlı Padişahı I. Ahmed tarafından İstanbul'daki tarihî yarımadada, Mimar Sedefkâr Mehmed Ağa'ya yaptırılmıştır.[1] Cami; mavi, yeşil ve beyaz renkli İznik çinileriyle bezendiği için ve yarım kubbeleri ile büyük kubbesinin içi de yine mavi ağırlıklı kalem işleriyle süslendiği için Avrupalılar tarafından \"Mavi Camii (Blue Mosque)\" olarak adlandırılır. Ayasofya'nın 1935 yılında camiden müzeye dönüştürülmesiyle, İstanbul'un ana camii konumuna ulaşmıştır.\r\n\r\nAslında Sultanahmet Camii külliyesiyle birlikte, İstanbul’daki en büyük eserlerden biridir. Bu külliye bir cami, medreseler, hünkar kasrı, arasta, dükkânlar, hamam, çeşme, sebiller, türbe, darüşşifa, sıbyan mektebi, imarethane ve kiralık odalardan oluşmaktadır. Bu yapıların bir kısmı günümüze ulaşamamıştır.";
            pictureBox1. ImageLocation=@"C:\\Users\\yilma\\source\\repos\\Miniİstanbul\\Miniİstanbul\\Resources\\sultanahmet.jpg";
            webBrowser1.Navigate ("https://www.google.com/maps/place/Sultanahmet+Camii/@41.0060468,28.9741051,17z/data=!4m10!1m2!2m1!1ssultan+ahmet+cami!3m6!1s0x14cab9bd6570f4e1:0xe52df7368a157ca4!8m2!3d41.0054096!4d28.9768138!15sChFzdWx0YW4gYWhtZXQgY2FtaVoTIhFzdWx0YW4gYWhtZXQgY2FtaZIBBm1vc3F1ZeABAA!16zL20vMDF5ZnZf?entry=ttu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Yeni Cami ya da Valide Sultan Camii, İstanbul'da 1597 yılında Sultan III. Murad'ın eşi Safiye Sultan'ın emriyle temeli atılan ve 1665'te zamanın padişahı IV. Mehmed'in annesi Turhan Hatice Sultan'ın büyük çabaları ve bağışlarıyla tamamlanıp ibadete açılan camidir.\r\n\r\nŞehrin silüetine ve görselliğine önemli ölçüde katkı sağlayan [1] Yeni Cami, İstanbul'da Osmanlı ailesi tarafından yaptırılan büyük camilerin son örneğidir.[2] Osmanlı dönemi Türk mimarisinde yapımı en uzun sürede tamamlanabilen cami olarak bilinir. Mimar Davut Ağa tarafından yapılmaya başlanmış, Mimar Dalgıç Ahmed Ağa devam ettirmiş ancak Safiye Sultan'ın ölümü ile yarım kalan inşaat, başlangıcından 66 yıl sonra dönemin mimarbaşısı Mustafa Ağa tarafından IV. Mehmed zamanında bitirilebilmiştir.\r\n\r\nCami deniz kenarına inşa edilmiştir ancak denizle mesafesi sonradan denizin doldurulması sonucu artmıştır.";
            pictureBox1.ImageLocation = @"C:\Users\yilma\source\repos\Miniİstanbul\Miniİstanbul\Resources\yeni camii.JPG";
            webBrowser1.Navigate("https://www.google.com/maps/place/Yeni+Cami/@41.0169901,28.9670831,17z/data=!3m1!4b1!4m6!3m5!1s0x14cab9eba0aba48d:0x653381c9eafc239c!8m2!3d41.0169862!4d28.9719594!16zL20vMGQ1eGd3?entry=ttu");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ayasofya (anlamı: \"Kutsal Bilgelik\"; Grekçe: Ἁγία Σοφία, romanize: Agia Sofia), eski adıyla Kutsal Bilgelik Kilisesi ve Ayasofya Müzesi veya günümüzdeki resmî adıyla Ayasofya-i Kebîr Câmi-i Şerîfi (Kutsal Büyük Ayasofya Camii),[4][5] İstanbul'da yer alan bir cami ve eski bazilika, katedral ve müzedir. Bizans İmparatoru I. Justinianus tarafından, 532-537 yılları arasında İstanbul'un tarihî yarımadasındaki eski şehir merkezine inşa ettirilmiş bazilika planlı bir patrik katedrali olmuştur. 1453 yılında İstanbul'un Osmanlılar tarafından fethedilmesinden sonra II. Mehmed tarafından camiye dönüştürülmüştür. Mustafa Kemal Atatürk tarafından 1934 yılında yayımlanan Bakanlar Kurulu Kararnamesi ile müzeye dönüştürülmüş, kazı ve tadilat çalışmaları başlatılmış ve 1935'ten 2020'ye kadar müze olarak hizmet vermiştir. 2020 yılında ise müze statüsü iptal edilerek cami statüsü verilmiştir.\r\n\r\nAyasofya, mimari bakımdan merkezî planı birleştiren kubbeli bazilika tipinde bir yapı olup, kubbe geçişi ve taşıyıcı sistem özellikleriyle mimarlık tarihinde önemli bir dönüm noktası olarak ele alınır. Hristiyanlar için hem sembolik hem de eksen olma anlamının yanında, turistik ve ruhsal bir çekim merkezidir.\r\n\r\nAyasofya adındaki \"Aya\" sözcüğü \"kutsal\" anlamına gelir. \"Sofya\" sözcüğü ise Grekçede \"bilgelik\" anlamındaki sophos sözcüğünden gelir.[6] Dolayısıyla \"Aya Sofya\" adı, Nasıralı İsa'ya atfen \"Kutsal Bilgelik\" ya da \"İlahî Bilgelik\" anlamına gelmekte olup Hristiyan ilahiyatında Tanrı'nın üç niteliğinden biri sayılır.[7][8] Miletli İsidoros ve Trallesli Antemius'un[3][9] yönettiği Ayasofya'nın inşaatında yaklaşık 10.000 işçinin[10][11][12] çalıştığı ve İmparator I. Jüstinyen'in bu iş için büyük bir servet harcadığı belirtilir.[13] Bu çok eski binanın bir özelliği, yapımında kullanılan bazı sütun, kapı ve taşların binadan daha eski yapı ve tapınaklardan getirilmiş olmasıdır.[14][15]";
            pictureBox1.ImageLocation  = @"C:\Users\yilma\source\repos\Miniİstanbul\Miniİstanbul\Resources\ayasofya.jpg";
            webBrowser1.Navigate ("https://www.google.com/maps/place/Ayasofya+Camii/@41.008587,28.9775947,17z/data=!3m1!4b1!4m6!3m5!1s0x14cab9be92011c27:0x236e6f6f37444fae!8m2!3d41.008583!4d28.980175!16zL20vMGJyNXE?entry=ttu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Büyük Mecidiye Camii ya da Ortaköy Camii, İstanbul Boğaziçi’nde Beşiktaş ilçesinin, Ortaköy semtinde sahilde bulunan Neobarok tarzında bir camiidir.\r\n\r\nCami, Sultan Abdülmecid tarafından Ermeni asıllı Mimar Nigoğos Balyan’a 1853 yılında yaptırılmıştır. Bütün selatin camilerinde olduğu gibi harim ve hünkar bölümü olmak üzere iki kısımdan oluşur. Geniş ve yüksek pencereler Boğaz’ın değişken ışıklarını caminin içine taşıyacak biçimde düzenlenmiştir.\r\n\r\nMerdivenle çıkılan yapının tek şerefeli iki minaresi vardır. Duvarları beyaz kesme taştan yapılmıştır. Tek kubbenin duvarları pembe mozaiktendir. Mihrap mozaik ve mermerden, minber ise somaki kaplı mermerden yapılmıştır ve ince bir işçiliğin ürünüdür.";
            pictureBox1.ImageLocation = @"C:\\Users\\yilma\\source\\repos\\Miniİstanbul\\Miniİstanbul\\Resources\\ORTAKÖY CAMİİ.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/B%C3%BCy%C3%BCk+Mecidiye+Camii/@41.0474208,29.0267454,18.5z/data=!4m14!1m7!3m6!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc!2sB%C3%BCy%C3%BCk+Mecidiye+Camii!8m2!3d41.0472151!4d29.0269478!16zL20vMGJwYmJy!3m5!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc!8m2!3d41.0472151!4d29.0269478!16zL20vMGJwYmJy?entry=ttu");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Fatih Camii ve Külliyesi, İstanbul'un Fatih ilçesinde II. Mehmed tarafından yaptırılmış olan cami ve külliyedir. Külliye içinde 16 adet medrese, darüşşifa (hastane), tabhane (konukevi) imaret (aşevi), kütüphane ve hamam bulunmaktadır. Şehrin yedi tepesinden birinde inşa edilmiştir. Cami 1766 depreminde yıkıldıktan sonra onarılarak 1771'de bugünkü halini almıştır. 1999 Gölcük Depreminde zemininde kaymalar tespit edilen camide 2008 yılında Vakıflar Genel Müdürlüğü tarafından zemin güçlendirme ve restorasyon çalışmalarına başlandı ve 2012 yılında tekrar ibadete açılmıştır.[2]";
            pictureBox1.ImageLocation = @"C:\\Users\\yilma\\source\\repos\\Miniİstanbul\\Miniİstanbul\\Resources\\FATİH CAMİİ.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Fatih+C%C3%A2mii/@41.0192985,28.9450034,15.75z/data=!4m10!1m2!2m1!1sfatih+camii!3m6!1s0x14caba21ca2b1031:0xbcb8746d3c867663!8m2!3d41.0196532!4d28.9499187!15sCgtmYXRpaCBjYW1paVoNIgtmYXRpaCBjYW1paZIBBm1vc3F1ZeABAA!16s%2Fm%2F0hhrzpk?entry=ttu");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Süleymaniye Camii Klasik Osmanlı Mimarisinin en önemli örneklerinden biridir. Yapımından günümüze dek İstanbul'da yüzü aşkın deprem gerçekleşmesine karşın, caminin duvarlarında en ufak bir çatlak oluşmamıştır. Dört fil ayağı üzerine oturan caminin kubbesi 53 m yüksekliğinde ve 27,5 m çapındadır. Bu ana kubbe, Ayasofya'da da görüldüğü gibi, iki yarım kubbe ile desteklenmektedir. Kubbe kasnağında 32 pencere bulunmaktadır. Cami avlusunun dört köşesinde birer minare bulunmaktadır. Bu minarelerin camiye bitişik iki tanesi üçer şerefeli ve 76 m yüksekliğinde, cami avlusunun kuzey köşesinde son cemaat yeri giriş cephesi duvarının köşesinde bulunan diğer iki minare ise ikişer şerefeli ve 56 m yüksekliğindedir. Camii, içindeki kandil islerini temizleyecek hava akımına uygun inşa edilmiştir. Yani cami içinde, yağ lambalarından çıkan islerin tek bir noktada toplanmasını sağlayan bir hava akımı yaratacak şekilde inşa edilmiştir. Camiden çıkan isler ana giriş kapısının üzerindeki odada toplanmış ve bu isler mürekkep yapımında kullanılmıştır.";
            pictureBox1.ImageLocation = @"C:\Users\yilma\source\repos\Miniİstanbul\Miniİstanbul\Resources\Süleymaniye.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/S%C3%BCleymaniye+Camii/@41.016051,28.9613908,17z/data=!3m1!4b1!4m6!3m5!1s0x14cab98d3ac01031:0x8accf5042157cfed!8m2!3d41.016047!4d28.9639711!16zL20vMDJxNm1i?entry=ttu");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Bayezid Camii (Beyazıt Camii ve Beyazıd Camii olarak da bilinir) İstanbul'un Beyazıt semtinde Sultan II. Bayezid tarafından yaptırılmış bir cami.\r\n\r\nOsmanlı klasik dönem mimarisinin erken dönem eserleri arasında bir yapıdır[2]. Semte dağınık bir şekilde inşa edilmiş olan külliyenin ana elemanı durumundaki parçasıdır[3]. Mimarının kim olduğu kesin olarak bilinmez, Mimar Hayrettin, Mimar Kemaleddin veya Yakupşah bin Sultanşah tarafından yapıldığına dair görüşler vardır.[1] İstanbul’da orijinalliğini koruyan en eski selatin camii olarak kabul edilir.[2] II. Bayezid’in mezarı, caminin haziresinde bulunur.";
            pictureBox1.ImageLocation = @"C:\Users\yilma\source\repos\Miniİstanbul\Miniİstanbul\Resources\BEYAZIT CAMİİ.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Beyaz%C4%B1t+Camii/@41.0103293,28.9637103,16.75z/data=!4m6!3m5!1s0x14cab991d73292a1:0xc5894f505ceb16fa!8m2!3d41.010222!4d28.9652026!16zL20vMDYwY2xx?entry=ttu");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 frmanasayfa = new Form1();
            frmanasayfa.Show();
            this.Hide();
        }

        private void FrmCamiiler_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
