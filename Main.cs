/*
 * Made by: Alex Hegedus(jacekbacsi01) - 2020.01.16-17. -
 * Felhasználtam: -A Discord Dev dokumentációt(kapcsolat felépítése, kommunikáció, használat), -Visual Studio dev dokumentációt(JSON, HTTP Kérések kezelése)
 * Verziók:
 * * V0.1 > -Alap dizájn, első működés, hibakódok kiírása
 ***********
 * * V0.2 > -Egyedi felhasználónév használata annak mentése fájlba, 
 *           és köv. megnyitásnál újra betöltése -URL: szintén ugyan ez...
 *          -Kivételek, hibakódok kezelése újraírva, kibővítve, sok helyzetben tesztelve!
 *          -dizájn felturbózása egy picit :)
 *          
 * Megj.,Desc.: Használd egészséggel, ne írd át a készítő nevét. Kérlek tüntesd fel a készítő nevét ha tovább adod a programot!! :D
 *              Ha észrevételed van, bátran jelezd nekem.
 *              
 *              Használat: Discordon belül szerveredre jobb klikk>Szerver Beállítások>Integrations>Webhooks létrehozol egyet és a linkjét az általam készített programba másolod
 *                         a nevet tudod discordban is változtatni de akár távolról is.
 */
using System;
using System.Collections.Generic;
/*using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Xml;

namespace COMDROID_DISCORD_WEBHOOK_MANAGER
{
    public partial class Main : Form
    {
        int startenin = 0;
        private HttpContent requestContent;

        public Main()
        {
            InitializeComponent();
            LoadUserSettings();
        }
        async void reqHTTP()
        {
            var client = new HttpClient();
            
            // Lekreáljuk a HTTP tartalmat(JSON-formában..)
            if(checkBoxCustomUsrNm.Checked) //Ha be van pipálva akkor küldi az üzenetet, egyedi felhasználónevet
            {
                requestContent = new FormUrlEncodedContent(new[] {              
                new KeyValuePair<string, string>("content", textBoxMsg.Text),
                new KeyValuePair<string, string>("username", textBoxUsrName.Text)
            }); ;
            }
            else //ha nincs akkor csak az üzenetet és azt a nevet fogja használni amit discord szervereden megadtál
            {
                requestContent = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("content", textBoxMsg.Text),   
            });
            }
    
            try
            {
                // Elküldjük a lekérést
                HttpResponseMessage response = await client.PostAsync(textBoxURL.Text, requestContent);
                
                // Lekérjük a választ a szervertől
                HttpContent responseContent = response.Content;

                // Lekérjük az adatfolyamot
                using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                {
                    // Kiírjuk a szerver választ; azokat átformázzuk és úgy firkáljuk ki a kedves usernak :)
                    textBoxResp.Text = await reader.ReadToEndAsync();
                    if (textBoxResp.Text.Contains("message"))
                    {
                        if (textBoxResp.Text.Contains("Invalid Webhook Token"))
                        {
                            MessageBox.Show("Nincs ilyen webhook token! Kérlek ellenőrizd..", "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if(textBoxResp.Text.Contains("Cannot send an empty message"))
                        {
                            MessageBox.Show("Nem küldhetsz üres üzenetet..", "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (textBoxResp.Text.Contains("Unknown Webhook"))
                        {
                            MessageBox.Show("Hiba! Ismeretlen Webhook, ellenőrizd! \nFormátum: https://discordapp.com/api/webhooks/667424566204694529/dC0ubIrouP5pA6hdFli2d7wSIM2ZQvnId_kcu1s2STRz3SDBld1Z5kMkKxgZvxwsDPIe", "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - HIBA", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        if(textBoxResp.Text.Contains("404: Not Found"))
                        {
                            MessageBox.Show("HTTP HIBA 404! Hiba, az oldal nem található, ellenőrizd a Webhook URL-t.", "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Üzenet nem lett elküldve! \nHibakód(JSON):" + textBoxResp.Text, "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Üzenet sikeresen elküldve a Discord szerverre. :)", "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - Üzenet Elküldve!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception eX) //Ha kivétel akad ne crasheljünk már ki :DD -=- if coming an exception we not crash :))
            {
                if (eX.ToString().Contains("URI"))
                {
                    MessageBox.Show("A megadott Webhook Link rossz formátumú.");
                }
                else
                {
                    if (eX.ToString().Contains("A távoli név nem oldható fel"))
                    {
                        MessageBox.Show("Nem sikerült csatlakozni a Discord kiszolgálójához, nem oldható fel a domain cím. Ellenőrizd az internetkapcsolatod!", "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (eX.ToString().Contains("Nem lehet csatlakozni a távoli kiszolgálóhoz"))
                    {
                        MessageBox.Show("Nem sikerült csatlakozni a Discord kiszolgálójához, ellenőrizd az internetkapcsolatod!", "Discord Webhook MSSNGR v0.2 by Alex Hegedűs - HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                    else
                    {
                        MessageBox.Show(eX.ToString());
                    }
                }
            }
        }
        void LoadUserSettings() //program mappájából tölti be az xml-ből a megjegyzett belépési adatokat...
        {
            XmlDocument docc = new XmlDocument(); //uj xml
            if (File.Exists("settings.xml")) //Ha létezik a settings.xml fájl
            {
                docc.Load("settings.xml"); //beállítások betöltése
                foreach (XmlNode node in docc.SelectNodes("//discord_mssngr")) 
                {
                    try
                    {
                        String usrnm = node.SelectSingleNode("username").InnerText;
                        String url = node.SelectSingleNode("url").InnerText;
                        String ischecked = node.SelectSingleNode("ticked").InnerText;
                        textBoxURL.Text = url;
                        textBoxUsrName.Text = usrnm;
                        if (ischecked == "True")
                        {
                            checkBoxCustomUsrNm.Checked = true;
                            //checkBoxSaveURL.Checked = true; 
                        }
                        else
                        {
                            checkBoxCustomUsrNm.Checked = false;
                            //checkBoxSaveURL.Checked = false;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            else //Ha nem létezik a user-settings.xml fájl  -=- if file not exists: user-settings.xml
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<user><username>felhasznalonev</username><url>url cim</url><ticked>True</ticked><creator_keszito>Alex Hegedus</creator_keszito></user>");

                doc.PreserveWhitespace = false;
                doc.Save(@"settings.xml");
                MessageBox.Show("Felhasználó Beállítások fájl-t nem találtam, ezért létrehoztam egy minta fájlt! Fájl neve: 'settings.xml', helye a program mappájában.");

            }
        }
        void SaveSettings() //menti a megjegyezendő cuccokat
        {
            if (startenin == 0) //nem ment mikor elindul a program és beállítja a tickboxot amikor betöltjük a beállításokat, mert az is eventet generál ha a programbol allitod a tick state-et(bugfix) 
                                //if program start setting up tick box and this generate an event for save settings but settings is not loaded before!
            {
                startenin++; //megnöveljük egyel a startenin változót, hogy tudjuk elindult a program és a tickboxot élesíthetjük
                             //we know program started and activate saving
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<discord_mssngr><username>" + textBoxUsrName.Text + "</username><url>" + textBoxURL.Text + "</url><ticked>" + checkBoxCustomUsrNm.Checked.ToString() + "</ticked><creator_keszito>Alex Hegedus</creator_keszito></discord_mssngr>"); //XML tartalmát létrehozzuk

                doc.PreserveWhitespace = false; 
                doc.Save(@"settings.xml"); //Elmenti az beállítások xmlt  -=-  save settings xml              
            }
        }
        private void butSend_Click(object sender, EventArgs e) //küldés gomb
        {
            reqHTTP(); //elindítjuk a http/json adatküldést&fogadást  -=-  start http/json data send/receive
            SaveSettings(); //elmentjük a beállításokat -=- save settings
        }

        private void checkBoxCustomUsrNm_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            if (checkBoxCustomUsrNm.Checked)
            {
                textBoxUsrName.ReadOnly = false;
            }
        }

        private void butAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Alex Hegedűs(jacekbacsi01) GitHub: github.com/jacekbacsi01 Written in C# 2020.01.16. -A Hungarian COM_DROID Team Project.-");
        }
    }
}
