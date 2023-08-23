using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace BaskentTextli
{
    public partial class Form1 : Form
    {
        int rekor;
        string rekorcu;
        int puan = 0;
        int can = 3;
        int sure = 10;
        public Form1()
        {
            InitializeComponent();
            

        }
       

        List<string> sehirler = new List<string>
        {
           "	Afganistan	-	Kabil	-	Kandahar	-	Kabil	-	İslamabad	-	Herat	"    ,
            "	Arnavutluk	-	Tiran	-	Elbasan	-	İşkodra	-	Tiran	-	Dıraç	"  ,
            "	Cezayir	-	Cezayir	-	Cezayir	-	Konstantin	-	Annâbe	-	Batna	"   ,
            "	Angola	-	Luanda	-	Huambo	-	Luanda	-	Lobito	-	Benguela	"   ,
            "	Arjantin	-	Buenos Aires	-	Córdoba	-	Buenos Aires	-	Rosario	-	Mendoza	"    ,
            "	Ermenistan	-	Erivan	-	Erivan	-	Gümrü	-	Vanadzor	-	Eçmiadzin	" ,
            "	Avustralya	-	Canberra	-	Brisbane	-	Sidney	-	Melbourne 	-	Canberra	"   ,
            "	Avusturya	-	Viyana	-	Viyana	-	Graz	-	Salzburg	-	Linz	"    ,
            "	Azerbaycan	-	Bakü	-	Karabağ	-	Nahçıvan	-	Gence	-	Bakü	"   ,
            "	Bahreyn	-	Manama	-	Muharrak	-	Ar-Rifaca 	-	Madinat Hamad 	-	Manama	"  ,
            "	Bangladeş	-	Dakka	-	Dakka	-	Çitagong	-	Khulna	-	Rajshahi	"    ,
            "	Barbados	-	Bridgetown	-	Speightstown	-	Bridgetown	-	Greenland	-	Bulkeley	"    ,
            "	Belarus	-	Minsk	-	Brest	-	Salihorsk	-	Minsk	-	Lida	"  ,
            "	Belçika	-	Brüksel	-	Liège	-	Antwerpen	-	Gent	-	Brüksel	"  ,
            "	Benin	-	Porto Novo	-	Porto Novo	-	Cotonou	-	Abomey-Calavi	-	Djougou	" ,
            "	Bolivya	-	La Paz	-	Loreto	-	Sucre	-	La Paz	-	Santa Cruz	" ,
            "	Bosna Hersek	-	Saraybosna	-	Tuzla	-	Saraybosna	-	Mostar	-	Zenica	"    ,
            "	Botswana	-	Gaboron	-	Francistown	-	Gaboron	-	Molepolole	-	Selibe-Phikwe	" ,
            "	Brezilya	-	Brasilia	-	Brasilia	-	São Paulo	-	Rio de Janeiro	-	Salvador	"  ,
            "	Brunei	-	Bandar Seri Begawan	-	Kuala Belait	-	Seria	-	Bandar Seri Begawan	-	Tutong	"  ,
            "	Bulgaristan	-	Sofya	-	Filibe	-	Varna	-	Burgaz	-	Sofya	"   ,
            "	Burkina Faso	-	Ouagadougou	-	Bobo-Dioulasso	-	Koudougou	-	Ouagadougou	-	Banfora	" ,
            "	Burundi	-	Bujumbura	-	Bujumbura	-	Muyinga	-	Ruyigi	-	Gitega	" ,
            "	Kamboçya	-	Phnom Penh	-	Battambang	-	Phnom Penh	-	Sihanoukville	-	Poipet	"    ,
            "	Kamerun	-	Yaounde	-	Bafoussam	-	Kumba	-	Yaounde	-	Ngaoundéré	"    ,
            "	Kanada	-	Ottawa	-	Ottawa	-	Vancouver	-	Toronto	-	Montréal	"   ,
            "	Orta Afrika Cumhuriyeti	-	Bangui	-	Bimbo	-	Berbérati	-	Bangui	-	Carnot	"  ,
            "	Çad	-	N'Djamena	-	N'Djamena	-	Moundou	-	Sarh	-	Abéché	"   ,
            "	Şili	-	Santiago	-	Concepción	-	Santiago	-	Cautin	-	Valparaíso	"   ,
            "	Çin	-	Pekin	-	Çongçing	-	Şangay	-	Pekin	-	Çengdu	"    ,
            "	Kolombiya	-	Bogota	-	Medellin	-	Cali	-	Barranquilla	-	Bogota	"    ,
            "	Kongo Cumhuriyeti	-	Brazzaville	-	Brazzaville	-	Pointe-Noire	-	Dolisie	-	Nkayi	"  ,
            "	Kosta Rika	-	San Jose	-	San Jose	-	Golfito	-	Jaco	-	Liberia	" ,
            "	Fildişi Sahili	-	Abidjan	-	Abidjan	-	Bouaké	-	Grand Bassam	-	Yamoussoukro	"   ,
            "	Hırvatistan	-	Zagreb	-	Split	-	Zagreb	-	Rijeka	-	Osijek	" ,
            "	Küba	-	Havana	-	Santiago de Cuba	-	Camagüey	-	Havana	-	Santa Clara	"  ,
            "	Çek Cumhuriyeti	-	Prag	-	Brünn	-	Prag	-	Ostrava	-	Pilsen	"    ,
            "	Danimarka	-	Kopenhag	-	Aarhus	-	Odense	-	Kopenhag	-	Aalborg	" ,
            "	Cibuti	-	Cibuti	-	Cibuti	-	Obuk	-	Tadjourah	-	Loyada 	"   ,
            "	Dominik Cumhuriyeti	-	Santo Domingo	-	Santiago de los Caballeros	-	Santo Domingo Este	-	Santo Domingo	-	Santo Domingo Norte	" ,
            "	Ekvador	-	Quito	-	Quayaguil	-	Quito	-	Cuenca	-	Machala	"  ,
            "	Mısır	-	Kahire	-	İskenderiye	-	Port Said	-	Şarm El-Şeyh	-	Kahire	"    ,
            "	El Salvador	-	San Salvador	-	San Salvador	-	Santa Ana	-	San Miguel	-	Santa Tecla	"    ,
            "	Ekvator Ginesi	-	Malabo	-	 Ebebiyín	-	Bata	-	Aconibe	-	Malabo	"   ,
            "	Estonya	-	Tallinn	-	Narva	-	Tartu	-	Tallinn	-	Pärnu	" ,
            "	Etiyopya	-	Addis Ababa	-	Aksum	-	Addis Ababa	-	Bahir Dar	-	Harar	"    ,
            "	Fiji	-	Suva	-	Suva	-	Lautoka	-	Lami	-	Nadi	"  ,
            "	Fransa	-	Paris	-	Marseille	-	Nice	-	Paris	-	Lyon	"    ,
            "	Finlandiya	-	Helsinki	-	Vantaa	-	Kauniainen	-	Espoo	-	Helsinki	"  ,
            "	Gabon	-	Libreville	-	Port-Gentil	-	Libreville	-	Franceville	-	Oyem	"  ,
            "	Gambiya	-	Banjul	-	Serekunda	-	Brikama	-	Banjul	-	Bakau	" ,
            "	Gürcistan	-	Tiflis	-	Tiflis	-	Batum	-	Zugdidi	-	Ozurgeti	"    ,
            "	Almanya	-	Berlin	-	Stuttgart	-	Bremen	-	Berlin	-	Frankfurt	"  ,
            "	Gana	-	Accra	-	Accra	-	Kumasi	-	Sunyani	-	Tongo	" ,
            "	Yunanistan	-	Atina	-	Patra	-	Selanik	-	Kandiye	-	Atina	"  ,
            "	Guatemala	-	Guatemala	-	Mixco	-	Guatemala	-	Coban	-	Villa Nueva	" ,
            "	Gine	-	Conakry	-	Conakry	-	Boké	-	Faranah	-	Kankan	"  ,
            "	Gine Bissau	-	Bissau	-	Bissau	-	Bafatá	-	Gabú	-	Bissorã	" ,
            "	Honduras	-	Tegucipalga	-	Veracruz	-	Choloma	-	Tegucipalga	-	El Progreso	" ,
            "	Macaristan	-	Budapeşte	-	Budapeşte	-	Pest	-	Borsod-Abaúj-Zemplén	-	Szabolcs-Szatmár-Bereg	"   ,
            "	İzlanda	-	Reykjavik	-	Kópavogur	-	Hafnarfjörður	-	Akureyri	-	Reykjavik	"  ,
            "	Hindistan	-	Delhi	-	Bengaluru	-	Delhi	-	Kalkuta	-	Mumbai	"    ,
            "	Endonezya	-	Cakarta	-	Cakarta	-	Surabaya	-	Medan	-	Bandung	"  ,
            "	İran	-	Tahran	-	Meşhed	-	Tahran	-	Tebriz	-	İsfahan	"  ,
            "	Irak	-	Bağdat	-	Basra	-	Ninova	-	Bağdat	-	Erbil	" ,
            "	İrlanda	-	Dublin	-	Dublin	-	Leinster	-	Ulster	-	Munster	" ,
            "	İsrail	-	Tel Aviv	-	Kudüs	-	Ashdood	-	Hayfa	-	Tel Aviv	"  ,
            "	İtalya	-	Roma	-	Milano	-	Napoli	-	Roma	-	Cenova	" ,
            "	Jamaika	-	Kingston	-	Montego Bay	-	Kingston	-	Spanish Town	-	Portmore	"   ,
            "	Japonya	-	Tokyo	-	Tokyo	-	Yokohama	-	Nagoya	-	Osaka	" ,
            "	Ürdün	-	Amman	-	Zerka	-	Amman	-	İrbid	-	Rüseyfa	" ,
            "	Kazakistan	-	Astana	-	Oral	-	Nur Sultan	-	Astana	-	Çimkent	"  ,
            "	Kenya	-	Nairobi	-	Mombasa	-	Kisumu	-	Nakuru	-	Nairobi	"   ,
            "	Kuzey Kore	-	Pyongyang	-	Pyongyang	-	Sinuiju	-	Sariwon	-	Hamhung	"   ,
            "	Güney Kore	-	Seul	-	Busan	-	Seul	-	Incheon	-	Daegu	" ,
            "	Kuveyt	-	Kuveyt	-	El Ahmadi	-	Hawalli	-	Kuveyt	-	El Manqaf	"  ,
            "	Kırgızistan	-	Bişkek	-	Bişkek	-	Celal-Abad	-	Oş	-	Karakol	"   ,
            "	Laos	-	Vientiane	-	Savannakhet	-	Pakse	-	Phonsavan	-	Vientiane	"  ,
            "	Letonya	-	Riga	-	Jürmala	-	Riga	-	Daugavpils	-	Rezekne	"  ,
            "	Lübnan	-	Beyrut	-	Beyrut	-	Trablusşam	-	Tripoli	-	Biblos	"    ,
            "	Libya	-	Trablus	-	Bingazi	-	el-Beyda	-	Trablus	-	El Hums	"    ,
            "	Litvanya	-	Vilnius	-	Kaunas	-	Klaipėda	-	Vilnius	-	Šiauliai	" ,
            "	Makedonya	-	Üsküp	-	Manastır	-	Kumanova	-	Üsküp	-	Pirlepe	"   ,
            "	Madagaskar	-	Antananarivo	-	Toamasina	-	Antsirabe	-	Fianarantsoa	-	Antananarivo	" ,
            "	Malezya	-	Kuala Lumpur	-	George Town	-	İpoh	-	Kuala Lumpur	-	Kuehing	"    ,
            "	Mali	-	Bamako	-	Bamako	-	Timbuktu	-	Cenne	-	Mopli	"   ,
            "	Malta	-	Valetta	-	Ir-Rabat	-	Valetta	-	Mdina	-	Cottonera	"    ,
            "	Moritanya	-	Nouakchott	-	Nouadhibou	-	Nema	-	Kaedi	-	Nouakchott	" ,
            "	Mauritius	-	Port-Louis	-	Vacoas-Phoenix	-	Port-Louis	-	Beau Bassin-Rose Hill	-	Curepipe	" ,
            "	Meksika	-	Mexico City	-	Mexico City	-	Reynosa	-	Acapulco	-	Cancún	"   ,
            "	Moldova	-	Kişinev	-	Tiraspol	-	Kişinev	-	Beltsy	-	Donduşeni	" ,
            "	Moğolistan	-	Ulanbatur	-	Çoybalsan	-	 Olgi	-	Bayanhongor	-	Ulanbatur	"    ,
            "	Karadağ	-	Podgorica	-	Nikşiç	-	Podgorica	-	Taşlıca	-	Akova	"  ,
            "	Fas	-	Rabat	-	Kazablanka	-	Fas	-	Rabat	-	Marakeş	"    ,
            "	Mozambik	-	Maputo	-	Maputo	-	Matola	-	Beira	-	Nampula	"   ,
            "	Myanmar	-	Nay Pyi Daw	-	Mandalay	-	Bagan	-	Nay Pyi Daw	-	Ava	"    ,
            "	Namibya	-	Windhoek	-	Rundu	-	Windhoek	-	Walvis Bay	-	Swakopmund	" ,
            "	Nepal	-	Katmandu	-	Katmandu	-	Lalitpur	-	Pokhara	-	Bhâratpur 	"   ,
            "	Hollanda	-	Amsterdam	-	Lahey	-	Rotterdam	-	Eindhoven	-	Amsterdam	"    ,
            "	Yeni Zelanda	-	Wellington	-	Christchurch	-	Auckland	-	 Hamilton	-	Wellington	"    ,
            "	Nikaragua	-	Managua	-	Alamikamba	-	Managua	-	Matagalp	-	Bluefields	"  ,
            "	Nijer	-	Niamey	-	Zinder	-	Tanout	-	Niamey	-	Maradi	"  ,
            "	Nijerya	-	Abuja	-	Lagos	-	Abuja	-	İbadan	-	Kano	" ,
            "	Norveç	-	Oslo	-	Oslo	-	Bergen	-	Trondheim	-	Stavanger	"   ,
            "	Umman	-	Muskat	-	Musandam	-	Muskat	-	Al Buraymi	-	Dofar	" ,
            "	Pakistan	-	İslamabad	-	İslamabad	-	Karachi	-	Peşaver	-	Lahor	"    ,
            "	Panama	-	Panama	-	Colón	-	David	-	Panama	-	La Chorrera	"  ,
            "	Papua Yeni Gine	-	Port Moresby	-	Lae	-	Samarai	-	Port Moresby	-	Goroka	"  ,
            "	Paraguay	-	Asuncion	-	San Lorenzo	-	Asuncion	-	Ciudad del este	-	Luque	"  ,
            "	Peru	-	Lima	-	Trujillo	-	Arequipa	-	Callao	-	Lima	"   ,
            "	Filipinler	-	Manila	-	Quezon City	-	Cebu	-	Davao	-	Manila	"   ,
            "	Polonya	-	Varşova	-	Krakow	-	Varşova	-	Lodz	-	Poznan	"    ,
            "	Portekiz	-	Lizbon	-	Lizbon	-	Porto	-	Amadora	-	Braga	"    ,
            "	Katar	-	Doha	-	Al-Rayyan	-	Umm Salal	-	Doha	-	Al-Khor	"   ,
            "	Romanya	-	Bükreş	-	Temeşvar	-	Bükreş	-	 Kaloşvar	-	Yaş	"  ,
            "	Rusya	-	Moskova	-	Saint Petersburg 	-	Moskova	-	Novosibirsk	-	Yekaterinburg	" ,
            "	Ruanda	-	Kigali	-	Butare	-	Gitarama	-	Ruhengeri	-	Kigali	"    ,
            "	Suudi Arabistan	-	Riyad	-	Cidde	-	Riyad	-	Ed Dammam	-	Hufuf	" ,
            "	Senegal	-	Dakar	-	Pikine	-	Touba	-	Dakar	-	Guédiawaye	"   ,
            "	Sırbistan	-	Belgrad	-	Belgrad	-	Novi Sad	-	Kragujevac	-	Nis	" ,
            "	Sierra Leone	-	Freetown	-	Bo	-	Kenema	-	Makeni	-	Freetown	"   ,
            "	Singapur	-	Singapur	-	Singapur	-	Singapur	-	Singapur	-	Singapur	" ,
            "	Slovakya	-	Bratislava	-	Nitra	-	Bratislava	-	Kosice	-	Presov	"    ,
            "	Slovenya	-	Ljubljana	-	Ljubljana	-	Maribor	-	Kamnik	-	Kranj	" ,
            "	Somali	-	Mogadişu	-	Mogadişu	-	Afgooye	-	Boorama	-	Ceek	" ,
            "	Güney Afrika	-	Cape Town	-	Durban	-	Germiston	-	Johannesburg	-	Cape Town	"    ,
            "	İspanya	-	Madrid	-	Barselona	-	Valensiya	-	Madrid	-	Sevilla	" ,
            "	Sri Lanka	-	Colombo	-	Badulla	-	Nuwara Eliya	-	Colombo	-	Jaffna,	"    ,
            "	Sudan	-	Hartum	-	Omdurman	-	Hartum	-	Port Sudan	-	Vad Medeni	"    ,
            "	İsveç	-	Stokholm	-	Göteborg	-	Malmö	-	Stokholm	-	Uppsala	"    ,
            "	İsviçre	-	Bern	-	Zürh	-	Bern	-	Basel	-	Cenevre	"  ,
            "	Suriye	-	Şam	-	Şam	-	Halep	-	Lazkiye	-	Hama	" ,
            "	Tacikistan	-	Duşanbe	-	Hucend	-	Bohtar	-	Kulob	-	Duşanbe	"    ,
            "	Tanzanya	-	Dodoma	-	Aruşa	-	Dodoma	-	Darüsselam	-	Mbeya	" ,
            "	Tayland	-	Bangkok	-	Bangkok	-	Hua Hin	-	Hat Yai	-	Ko Chang	"  ,
            "	Togo	-	Lome	-	Lome	-	Kpalimé	-	Sokodé	-	Kara	"    ,
            "	Trinidad ve Tobago	-	Port of Spain	-	Chaguanas	-	San Fernando	-	Port of Spain	-	Saint Andrew	"    ,
            "	Tunus	-	Tunus	-	Safakes	-	Susa	-	Kayrevan	-	Tunus	"   ,
            "	Türkiye	-	Ankara	-	İstanbul	-	Ankara	-	İzmir	-	Adana	"    ,
            "	Türkmenistan	-	Aşkabat	-	Aşkabat	-	Daşoğuz	-	Türkmenabat	-	Marı	" ,
            "	Ukrayna	-	Kiev	-	Kiev	-	Harkov	-	Dnipro	-	Donetsk	"   ,
            "	Birleşik Arap Emrlikleri	-	Abu Dabi	-	Dubai	-	Sharjah	-	AlAin	-	Abu Dabi	"    ,
            "	Birleşik Krallık	-	Londra	-	Birmingham	-	Manchester	-	Londra	-	Newcastle	"    ,
            "	Amerika Birleşik Devletleri	-	Washington DC	-	NewYork	-	Los Angeles	-	Washington DC	-	LasVegas	"  ,
            "	Uruguay	-	Montevideo	-	Ciudad de la Costa	-	Salto	-	Montevideo	-	Paysandú	"   ,
            "	Özbekistan	-	Taşkent	-	Taşkent	-	Namangan	-	Semerkant	-	Buhara	"  ,
            "	Venezuela	-	Caracas	-	Libertador	-	Caracas	-	Maracaibo	-	Iribarren	"  ,
            "	Yemen	-	Sana	-	Sana	-	Taizz	-	Aden	-	Hudeyde	"
        };

 
        private void soruSec()
        {
            Random random = new Random();
            string soru = sehirler[random.Next(0, 148)];
            string[] words = soru.Split('-');
            lbSoru.Text = words[0];
            lbCevap.Text = words[1];
            btnA.Text = words[2];
            btnB.Text = words[3];
            btnC.Text = words[4];
            btnD.Text = words[5];
            
        }

        private void soruDurumu()
        {
            btnStart.Text = "SONRAKİ";
            lbCevap.Visible = false;
            btnStart.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            soruSec();
        }
        
        private void cevapDurumu()
        {
            timer1.Stop();
            btnStart.Text = "SONRAKİ";
            btnStart.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            timer1.Stop();
        }

        private void dogruDurumu()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            puan = puan + 10;
            lbPuan.Text = puan.ToString();
            btnStart.Text = "SONRAKİ";
            btnStart.Enabled = true;
            timer1.Stop();
            sure = 10;
            lbSure.Text = sure.ToString();
            this.BackColor = Color.Green;
            axWindowsMediaPlayer1.URL = "ses\\clap.wav";
        }

        private void yanlisDurumu()
        {
            this.BackColor = Color.Red;
            axWindowsMediaPlayer1.URL = "ses\\loss.wav";
      

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            lbCevap.Visible = true;
            can--;
            lbCan.Text = can.ToString();
            btnStart.Text = "SONRAKİ";
            btnStart.Enabled = true;
            timer1.Stop();
            sure = 10;
            lbSure.Text = sure.ToString();
            if (can == 0)
            {
                oyunBitis();

            }
        }

        private void oyunBitis()
        {
            btnStart.Text = "TEKRAR";

            btnA.Text = "";
            btnB.Text = "";
            btnC.Text = "";
            btnD.Text = "";
            btnStart.Enabled = true;
            cevapDurumu();
            timer1.Stop();
            btnStart.Text = "TEKRAR";
            btnStart.Enabled = true;
        }
        private void tekrar()
        {
            sure = 10;
            can = 3;
            puan = 0;
            lbPuan.Text = puan.ToString();
            lbSure.Text = sure.ToString();
            btnStart.Enabled = true;
            btnStart.Text = "BAŞLAT";

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.BackColor = Color.Tan;
            if (btnStart.Text == "BAŞLAT")
            {
                can = 3;
                lbCan.Text = can.ToString();
                soruDurumu();
            }
            if (btnStart.Text == "TEKRAR")
            {

                tekrar();
            }
            if (btnStart.Text == "SONRAKİ")
            {
                btnStart.Enabled = true;
                soruDurumu();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lbSure.Text = sure.ToString();

            if (sure == 0)
            {
                yanlisDurumu();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == lbCevap.Text)
            {
                dogruDurumu();
            }
            else
            {
                yanlisDurumu();
            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == lbCevap.Text)
            {
                dogruDurumu();
            }
            else
            {
                yanlisDurumu();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == lbCevap.Text)
            {
                dogruDurumu();
            }
            else
            {
                yanlisDurumu();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == lbCevap.Text)
            {
                dogruDurumu();
            }
            else
            {
                yanlisDurumu();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
} 
