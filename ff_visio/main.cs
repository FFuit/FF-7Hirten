
//Änderungen:
// 29.10.2017:  Methoden die auf Datenbank zugreifen auf eine reduziert
//              Buttons + TextBoxen bei Alarmschwellen deaktivieren wenn keine Datenbankverbindung

// 04.11.2017:  Kommentare hinzugefügt

// 06.11.2017: Methode Eamail senden umgeschrieben auf Methode Datenbankzugriff + diverse Kmmentare hinzugefügt

// 12.11.2017: Testmailbutton eingefügt, "Sirenenprobe" fertig, rote Panels in Arbeit



//
// under consruction
// benutzer.cs umschreiben auf db methode
// rote Panels


// todo
// progressbar rot hinterlegen




// Standard Bibliotheken von Visual Studio
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// zusätzlich importierte Bibliotheken
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;


namespace ff_visio
{
    public partial class main : Form
    {
        // 
        // Globale Variable definieren
        // 
        static class Global
        {
            // Globale Variable Datum letzteEmail1 + Sirenenprobe definieren
            public static DateTime letzteEmailPrio1;            
            public static DateTime letzteEmailSprobe;

            // Globale Variable Boolean alarmschwellen definieren
            public static Boolean alarmschwellen = false;
        }

        // Neue Threads (Prozesse) erstellen
        Thread thread1;
        Thread thread2;
        Thread thread3;
        Thread thread4;

        public main()
        {
            InitializeComponent();
        }

        // 
        // Loader wird beim Programmstart ausgeführt
        // 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //
        // Button Beenden
        //
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Beendet das Programm
            Application.Exit();
        }

        //
        // Tollstrip Button Benutzer
        //
        private void benutzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Neue Form erstellen
            benutzer form = new benutzer();

            // Neue Form anzeigen
            form.Show();
        }

        //
        // Tollstrip Button Info
        //
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":-)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // Button Trend, öffnet Trend im Standardbrowser
        // 
        private void bt_Trend_Click(object sender, EventArgs e)
        {
            // Adresse zur Webseite
            string link = "http://localhost/ff/index.php";
            // Link öffnen
            System.Diagnostics.Process.Start(link);
        }

        //
        // + Button Druck Alarmschwellen
        //
        private void bt_AswDh_Click(object sender, EventArgs e)
        {
            try
            {
                // String der an Methode Alrmsw_in_DB_schreiben übergeben wird
                string a = "druck";
                // Wert aus TextBox holen
                double AswDruck = Convert.ToDouble(tb_AswDruck.Text);
                // Wert um 0,1 erhöhen
                AswDruck += 0.1;
                // Neuen Wert in Variable schreiben
                string newAswDruck = AswDruck.ToString();
                // Neuen Wert in Datenbank schreiben
                Alarmsw_in_DB_schreiben(newAswDruck, a);
                // aktuellen Werte aus Datenbank holen
                Alarmsw_aus_DB_holen();
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert vorhanden");
            }
        }

        //
        // - Button Druck Alarmschwellen
        //
        private void bt_AswDn_Click(object sender, EventArgs e)
        {
            try
            {
                // String der an Methode Alrmsw_in_DB_schreiben übergeben wird
                string a = "druck";
                // Wert aus TextBox holen
                double AswDruck = Convert.ToDouble(tb_AswDruck.Text);
                // Wert um 0,1 verkleinern
                AswDruck -= 0.1;
                // Neuen Wert in Variable schreiben
                string newAswDruck = AswDruck.ToString();
                // Neuen Wert in Datenbank schreiben
                Alarmsw_in_DB_schreiben(newAswDruck, a);
                // aktuellen Werte aus Datenbank holen
                Alarmsw_aus_DB_holen();
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert vorhanden");
            }
        }

        //
        // + Button TempHalle Alarmschwellen
        //
        private void bt_AswThh_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "temp_halle";
                double AswTempHalle = Convert.ToDouble(tb_AswTempHalle.Text);
                AswTempHalle += 0.1;
                string newAswTempHalle = AswTempHalle.ToString();
                Alarmsw_in_DB_schreiben(newAswTempHalle, a);
                Alarmsw_aus_DB_holen();
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert vorhanden");
            }
        }

        //
        // - Button TempHalle Alarmschwellen
        //
        private void bt_AswThn_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "temp_halle";
                double AswTempHalle = Convert.ToDouble(tb_AswTempHalle.Text);
                AswTempHalle -= 0.1;
                string newAswTempHalle = AswTempHalle.ToString();
                Alarmsw_in_DB_schreiben(newAswTempHalle, a);
                Alarmsw_aus_DB_holen();
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert vorhanden");
            }
        }

        //
        // + Button TempAuto Alarmschwellen
        //
        private void bt_AswTah_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "temp_auto";
                double AswTempAuto = Convert.ToDouble(tb_AswTempAuto.Text);
                AswTempAuto += 0.1;
                string newAswTempAuto = AswTempAuto.ToString();
                Alarmsw_in_DB_schreiben(newAswTempAuto, a);
                Alarmsw_aus_DB_holen();
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert vorhanden");
            }
        }

        //
        // - Button TempAuto Alarmschwellen
        //
        private void bt_AswTan_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "temp_auto";
                double AswTempAuto = Convert.ToDouble(tb_AswTempAuto.Text);
                AswTempAuto -= 0.1;
                string newAswTempAuto = AswTempAuto.ToString();
                Alarmsw_in_DB_schreiben(newAswTempAuto, a);
                Alarmsw_aus_DB_holen();
            }
            catch (Exception)
            {
                MessageBox.Show("Kein gültiger Wert vorhanden");
            }
        }

        //
        // Wennn eine Alarmschwelle händisch eingetragen und mit Enter bestätigt wird:
        //
        private void tb_AswTempAuto_KeyDown(object sender, KeyEventArgs e)
        {
            // Wenn die Enter Taste betätigt wird:
            if (e.KeyCode == Keys.Enter)
            {
                // Variable a welcher Wert an AlarmswinDBschreiben übergeben wird
                string a = "temp_auto";

                //Wert einlesen
                string newAswTempAuto = tb_AswTempAuto.Text;

                // Alarmsw_in_DB_schreiben() ausgühren
                Alarmsw_in_DB_schreiben(newAswTempAuto, a);

                // Alarmsw_aus_DB_holen() ausführen um Text in der Textbox zu aktualisieren
                Alarmsw_aus_DB_holen();
            }
        }
        //
        // Wennn eine Alarmschwelle händisch eingetragen und mit Enter bestätigt wird:
        // Kommentare wie oben
        private void tb_AswDruck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string a = "druck";
                string newAswDruck = tb_AswDruck.Text;
                Alarmsw_in_DB_schreiben(newAswDruck, a);
                Alarmsw_aus_DB_holen();
            }
        }

        //
        // Wennn eine Alarmschwelle verändert wird:
        // Kommentare wie oben
        private void tb_AswTempHalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string a = "temp_halle";
                string newAswTempHalle = tb_AswTempHalle.Text;
                Alarmsw_in_DB_schreiben(newAswTempHalle, a);
                Alarmsw_aus_DB_holen();
            }
        }

        // 
        // Timer: Analogwerte aktualisieren
        //
        private void AktualisiereWerte_Tick(object sender, EventArgs e)
        {
            // thread1 die Methode AnalogwerteVonDbHolen() zuweisen
            thread1 = new Thread(AnalogwerteVonDbHolen);

            // thread1 starten, nach Ausführeung des threads beendet er sich selbst
            thread1.Start();
        }

        //
        //  Timer: Verbindug zu DB + Raspberry prüfen
        //
        private void T_VerbindungPruefen_Tick(object sender, EventArgs e)
        {
            // thread2 die Methode Verbindung_DB_pruefen() zuweisen
            thread2 = new Thread(Verbindung_DB_pruefen);

            // thread2 starten, nach Ausführeung des threads beendet er sich selbst
            thread2.Start();

            // thread3 die Methode Verbindung_RaspPi_prüfen() zuweisen
            thread3 = new Thread(Verbindung_RaspPi_pruefen);

            // thread3 starten, nach Ausführeung des threads beendet er sich selbst
            thread3.Start();
        }

        //
        // Timer: Datum + Uhrzeit aktualisieren
        //
        private void T_DatumUhrzeit_Tick(object sender, EventArgs e)
        {
            // Datumsstring Formatieren
            string datumstr = "dddd, dd.MM.yyyy\nHH:mm:ss";

            // Label Datum 1+2, Datum + Uhrzeit zuweisen
            lb_Datum1.Text = DateTime.Now.ToString(datumstr);
            lb_Datum2.Text = DateTime.Now.ToString(datumstr);
        }

        //
        // Timer: Samstags Testmail "Sirenenprobe"
        // wird alle 60 Sekunden ausgeführt
        private void T_SamstagsMail_Tick(object sender, EventArgs e)
        {
            // thread4 die Methode Sirenenprobe() zuweisen
            thread4 = new Thread(Sirenenprobe);

            // thread3 starten, nach Ausführeung des threads beendet er sich selbst
            thread4.Start();
        }

        //
        // Methode um Textbox.Text von Threads aus zu verändern
        //
        private void SetTextTb(string text, TextBox tb_name)
        {
            if (tb_name.InvokeRequired)
            {
                tb_name.BeginInvoke((MethodInvoker)
                    delegate ()
                    {
                        tb_name.Text = text; ;
                    });
            }
            else
            {
                tb_name.Text = text;
            }
        }

        //
        // Methode um Label.Text von Threads aus zu verändern
        //
        private void SetTextLb(string text, Label lb_name)
        {
            if (lb_name.InvokeRequired)
            {
                lb_name.BeginInvoke((MethodInvoker)
                    delegate ()
                    {
                        lb_name.Text = text; ;
                    });
            }
            else
            {
                lb_name.Text = text;
            }
        }

        //
        // Methode um Label.Background von Threads aus zu verändern
        //
        private void SetFarbeLb(Color farbe, Label lb_name)
        {
            if (lb_name.InvokeRequired)
            {
                lb_name.BeginInvoke((MethodInvoker)
                    delegate ()
                    {
                        lb_name.BackColor = farbe; ;
                    });
            }
            else
            {
                lb_name.BackColor = farbe;
            }
        }

        //
        // Methode um TextBox.Background von Threads aus zu verändern
        //
        private void SetFarbeTb(Color farbe, TextBox tb_name)
        {
            if (tb_name.InvokeRequired)
            {
                tb_name.BeginInvoke((MethodInvoker)
                    delegate ()
                    {
                        tb_name.BackColor = farbe; ;
                    });
            }
            else
            {
                tb_name.BackColor = farbe;
            }
        }

        //
        // Methode um TextBox.Enabled von Threads aus zu verändern
        //
        private void EnableTb(Boolean zustand, TextBox tb_name)
        {
            if (tb_name.InvokeRequired)
            {
                tb_name.BeginInvoke((MethodInvoker)
                    delegate ()
                    {
                        tb_name.Enabled = zustand; ;
                    });
            }
            else
            {
                tb_name.Enabled = zustand;
            }
        }

        //
        // Methode um Button.Enabled von Threads aus zu verändern
        //
        private void EnableBt(Boolean zustand, Button bt_name)
        {
            if (bt_name.InvokeRequired)
            {
                bt_name.BeginInvoke((MethodInvoker)
                    delegate ()
                    {
                        bt_name.Enabled = zustand; ;
                    });
            }
            else
            {
                bt_name.Enabled = zustand;
            }
        }

        //
        // Methode um Panel.visible von Threads aus zu verändern
        //
        private void EnabelPan(Boolean zustand, Panel p_name)
        {
            if (p_name.InvokeRequired)
            {
                p_name.BeginInvoke((MethodInvoker)
                    delegate ()
                    {
                        p_name.Visible = zustand; ;
                    });
            }
            else
            {
                p_name.Visible = zustand;
            }
        }

        //
        // Methode Sirenenprobe
        //
        private void Sirenenprobe()
        {
            // Variablen deklarieren
            // Tag an dem Alarmiert werden soll
            string alarmTag = "Samstag";

            // Heutiger Tag ausgeschrieben
            string heute = DateTime.Now.ToString("dddd");

            // Anfangszeit wo alarmiert werden soll (Datum ist egal, es geht hier nur um die Uhrzeit)
            DateTime anfang = new DateTime(2000, 01, 01, 11, 55, 00);

            // Endzeit wo alarmiert werden soll (Datum ist egal, es geht hier nur um die Uhrzeit)
            DateTime ende = new DateTime(2000, 01, 01, 12, 05, 00);

            // Aktuelles Datum + Uhrzeit
            DateTime jetzt = DateTime.Now;

            // Wenn heute Samstag ist und es gerade zwischen anfang (11:55) und ende(12:05) Uhr ist und das 
            // letzte Samstagsemail vor über einem Tag gesendet wurde:
            if (alarmTag == heute && anfang.TimeOfDay < jetzt.TimeOfDay && jetzt.TimeOfDay < ende.TimeOfDay 
                && Global.letzteEmailSprobe.AddHours(1) < jetzt)
            {
                // Sende E-Mails an alle die Alarmierung 1 oder 2 haben
                for (int i = 1; i <= 2; i++)
                {
                    // SQL Befehl formen
                    string sqlBefehl = "SELECT email FROM benutzer WHERE alarmierung ='" + i + "'";

                    // Methode DatenbakZugriff aufrufen
                    DatenbankZugriff(sqlBefehl, 5, 5);                    
                }                
            }
        }

        //
        // Methode um Analogwerte von Datenbankzu holen und in TextBox zu schreiben
        //
        private void AnalogwerteVonDbHolen()
        {
            // SQL-Befehl formatieren
            string sqlBefehl = "SELECT * FROM analogwerte ORDER BY datetime DESC LIMIT 1;";

            // Methode DatenbakZugriff aufrufen
            DatenbankZugriff(sqlBefehl, 1, 0);
        }

        //
        // Methode um Alarmschwellen aus Datenbank zu holen + in Feld einzutragen
        //
        private void Alarmsw_aus_DB_holen()
        {
            // SQL-Befehl formatieren 
            string sqlBefehl = "SELECT * FROM alarmschwellen WHERE id = 0;";

            // Methode DatenbakZugriff aufrufen
            DatenbankZugriff(sqlBefehl, 2, 0);
        }

        //
        // Methode um Alarmschwellen in Datenbank zu schreiben
        //
        private void Alarmsw_in_DB_schreiben(string wert, string quelle)
        {
            
            // Beistrich in Punkt ändern, bei falscher Benutzereingabe
            if (wert.Contains(","))
            {
                wert = wert.Replace(",", ".");
            }

            // SQL Befehl formen
            string sqlBefehl = "UPDATE alarmschwellen SET " + quelle + " = '" + wert + "' WHERE id = '0';";

            // Methode DatenbakZugriff aufrufen
            DatenbankZugriff(sqlBefehl, 4, 0);
            
        }        
          
        //
        // Methode um Verbindung zur Datenbank zu prüfen
        //
        private void Verbindung_DB_pruefen()
        {
            // SQL-Befehl formatieren
            string sqlBefehl = null;

            DatenbankZugriff(sqlBefehl, 3, 0);
        }

        //
        // Methode um Verbindung zum Raspberry zu prüfen
        //
        private void Verbindung_RaspPi_pruefen()
        {
            // IP-Adresse vom PI
            //string ip_RaspPi = "10.11.71.104";
            string ip_RaspPi = "10.0.0.138";

            // neues Objekt Ping erstellen
            Ping ping_RaspPi = new Ping();

            // Adresse in IP-Adresse Parsen
            IPAddress adresse = IPAddress.Parse(ip_RaspPi);

            // Zeit nach der der Pingversuch abgebrochen werden soll wenn keine Antwort kommt
            int timeout = 2000;

            try
            {
                // Ping ausführen und Erfolg oder Misserfolg in "antwort" schreiben
                PingReply antwort = ping_RaspPi.Send(adresse, timeout);

                // Abfrage ob PING in Ordnung ist

                if (antwort.Status == IPStatus.Success)
                {
                    // Wenn Ping in Ordnung ist: Label Grün färben und OK schreiben
                    SetFarbeLb(Color.Green, lb_FahrzeugVerbunden);
                    SetTextLb("OK", lb_FahrzeugVerbunden);

                    // Wenn keine Verbindung ausführen
                    WennKeineVerbindung();
                }
                else
                {
                    // Wenn PING nicht in Ordnung ist: Label Rot färben und XX schreiben
                    SetFarbeLb(Color.DarkRed, lb_FahrzeugVerbunden);
                    SetTextLb("XX", lb_FahrzeugVerbunden);

                    // Wenn keine Verbindung ausführen
                    WennKeineVerbindung();
                }

            }
            // Wenn PING eine Exception generiert:
            catch (Exception)
            {
                // Label Rot färben und XX schreiben
                SetFarbeLb(Color.DarkRed, lb_FahrzeugVerbunden);
                SetTextLb("XX", lb_FahrzeugVerbunden);

                // Wenn keine Verbindung ausführen
                WennKeineVerbindung();
            }
        }

        //
        // Wenn keine verbindung zu DB oder Raspberry besteht
        //
        private void WennKeineVerbindung()
        {
            // Wenn in in einem der Beiden Labels XX steht: 
            if (lb_FahrzeugVerbunden.Text == "XX" || lb_DbVerbunden.Text == "XX")
            {
                // in Textboxen "--" schreiben
                SetTextTb("--", tb_wertDruck);
                SetTextTb("--", tb_wertTAuto);
                SetTextTb("--", tb_wertTHalle);
            }
            if (lb_DbVerbunden.Text == "XX" || Global.alarmschwellen == false)
            {
                // Textboxen von Alarmschwellen deaktivieren
                EnableTb(false, tb_AswDruck);
                EnableTb(false, tb_AswTempAuto);
                EnableTb(false, tb_AswTempHalle);                

                // + und - Buttons von Alarmschwellen deaktivieren
                EnableBt(false, bt_AswDh);
                EnableBt(false, bt_AswDn);
                EnableBt(false, bt_AswTah);
                EnableBt(false, bt_AswTan);
                EnableBt(false, bt_AswThh);
                EnableBt(false, bt_AswThn);
                EnableBt(false, bt_Trend);

            }
            if (!(lb_DbVerbunden.Text == "XX") && Global.alarmschwellen == true)
            {
                // Textboxen und Buttons von Alarmschwellen aktivieren
                EnableTb(true, tb_AswDruck);
                EnableTb(true, tb_AswTempAuto);
                EnableTb(true, tb_AswTempHalle);
                EnableBt(true, bt_AswDh);
                EnableBt(true, bt_AswDn);
                EnableBt(true, bt_AswTah);
                EnableBt(true, bt_AswTan);
                EnableBt(true, bt_AswThh);
                EnableBt(true, bt_AswThn);
                EnableBt(true, bt_Trend);
            }
        }

        // 
        // Methode die Prüft, ob Alamiert werden muss
        //
        private void Pruefe_Alarmierung()
        {
            // Wenn Datenbank nicht verbunden ist passiert nichts
            if (!(lb_DbVerbunden.Text == "XX"))
            {
                // Abfrage ob Alamiert werden soll + Zellenfarbe verändern
                // Wenn während der Abfrage die Alarmschwelle geändert wird,
                // köntte ein Fehler auftreten, der wird mit Try Catch abgefangen
                try
                {
                    if (Convert.ToDouble(tb_wertDruck.Text) < Convert.ToDouble(tb_AswDruck.Text))
                    {
                        // Alarmpriorität setzen
                        int prio = 1;

                        // SQL Befehl formen
                        string sqlBefehl = "SELECT email FROM benutzer WHERE alarmierung ='" + prio.ToString() + "'";

                        // TextBox Hintergrundfarbe ändern
                        SetFarbeTb(Color.LightCoral, tb_wertDruck);

                        // rotes Panel aktivieren
                        EnabelPan(true, p_Druck);

                        // Methode DatenbakZugriff aufrufen
                        DatenbankZugriff(sqlBefehl, 5, prio);
                    }
                    if (Convert.ToDouble(tb_wertTAuto.Text) < Convert.ToDouble(tb_AswTempAuto.Text))
                    {
                        // Alarmpriorität setzen
                        int prio = 2;

                        // SQL Befehl formen
                        string sqlBefehl = "SELECT email FROM benutzer WHERE alarmierung ='" + prio.ToString() + "'";

                        // TextBox Hintergrundfarbe ändern
                        SetFarbeTb(Color.LightCoral, tb_wertTAuto);

                        // rotes Panel aktivieren
                        EnabelPan(true, p_TempA);

                        // Methode DatenbakZugriff aufrufen
                        DatenbankZugriff(sqlBefehl, 5, prio);
                    }
                    if (Convert.ToDouble(tb_wertTHalle.Text) < Convert.ToDouble(tb_AswTempHalle.Text))
                    {
                        // Alarmpriorität setzen
                        int prio = 2;

                        // SQL Befehl formen
                        string sqlBefehl = "SELECT email FROM benutzer WHERE alarmierung ='" + prio.ToString() + "'";

                        // TextBox Hintergrundfarbe ändern
                        SetFarbeTb(Color.LightCoral, tb_wertTHalle);

                        // rotes Panel aktivieren
                        EnabelPan(true, p_TempH);

                        // Methode DatenbakZugriff aufrufen
                        DatenbankZugriff(sqlBefehl, 5, prio);
                    }


                    // zurückfärben wenn Werte wieder ok sind
                    if (Convert.ToDouble(tb_wertDruck.Text) >= Convert.ToDouble(tb_AswDruck.Text))
                    {
                        SetFarbeTb(System.Drawing.SystemColors.Control, tb_wertDruck);

                        // rotes Panel deaktivieren
                        EnabelPan(false, p_Druck);
                    }
                    if (Convert.ToDouble(tb_wertTAuto.Text) >= Convert.ToDouble(tb_AswTempAuto.Text))
                    {
                        SetFarbeTb(System.Drawing.SystemColors.Control, tb_wertTAuto);

                        // rotes Panel aktivieren
                        EnabelPan(false, p_TempA);
                    }
                    if (Convert.ToDouble(tb_wertTHalle.Text) >= Convert.ToDouble(tb_AswTempHalle.Text))
                    {
                        SetFarbeTb(System.Drawing.SystemColors.Control, tb_wertTHalle);

                        // rotes Panel aktivieren
                        EnabelPan(false, p_TempH);
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Fehler bei vergleich von Alrsw + aktuellem Wert");
                }
            }
        }

        //
        // Progressbar Druck aktualisiert sich, wenn sich der Wert in der TextBox "Druck" ändert
        //
        private void tb_wertDruck_TextChanged(object sender, EventArgs e)
        {
            // Wenn der Wert -- ist:
            if (tb_wertDruck.Text == "--")
            {
                // ist der Wert für die Progressbar 0
                pB_Druck.Value = 0;
            }

            // Wenn ein Wert vorhanden ist:
            else
            {
                // Wert von Textbox in double convertieren
                double druck = Convert.ToDouble(tb_wertDruck.Text);
                // Wert skalieren von 0-10 auf 0-100
                druck = druck * 10;
                // Progressbar befüllen
                pB_Druck.Value = Convert.ToInt16(druck);
            }
        }

        //
        // Progressbar TempHalle aktualisiert sich, wenn sich der Wert in der TextBox TempHalle ändert
        //
        private void tb_wertTHalle_TextChanged(object sender, EventArgs e)
        {
            // Wenn der Wert -- ist:
            if (tb_wertTHalle.Text == "--")
            {
                // Progressbar 0 setzen
                pB_TempHalle.Value = 0;
            }
            else
            {
                // Wert von Textbox in double convertieren
                double temp_Halle = Convert.ToDouble(tb_wertTHalle.Text);
                // Wert skalieren von -5-35 auf 0-100
                temp_Halle = (temp_Halle + 5) / 0.45;
                // Progressbar befüllen
                pB_TempHalle.Value = Convert.ToInt16(temp_Halle);
            }
        }

        //
        // Progressbar TempAuto aktualisiert sich, wenn sich der Wert in der TextBox TempAuto ändert
        //
        private void tb_wertTAuto_TextChanged(object sender, EventArgs e)
        {
            // Wenn der Wert -- ist:
            if (tb_wertTAuto.Text == "--")
            {
                // Progressbar 0 setzen
                pB_TempAuto.Value = 0;
            }
            else
            {
                // Wert von Textbox in double convertieren
                double temp_Auto = Convert.ToDouble(tb_wertTAuto.Text);
                // Wert skalieren von -5-35 auf 0-100
                temp_Auto = (temp_Auto + 5) / 0.45;
                // Progressbar befüllen
                pB_TempAuto.Value = Convert.ToInt32(temp_Auto);
            }
        }

        //
        // Methode für Datenbankzugriff
        //
        private void DatenbankZugriff(string Befehl, int fall , int prio)
        {
            // Variablen für Datenbankzugriff
            string server = "localhost";
            string port = "3306";
            string benutzer = "root";
            string passwort = "";
            string datenbank = "ff_auto";

            // Variablen um E-Mail zu senden
            var eAbsender = new MailAddress("FF.7H.RLF2000@gmail.com", "FF-7H-RLF2000");
            string ePasswort = "FFHirten07";
            string eBetreff = "Achtung Alarm";            
            int ePrio = prio;


            // Verbingungsstring erstellen
            string ConnectionString = String.Format("datasource = {0}; port = {1}; username = {2}; password = {3}; database = {4};",
                                                    server, port, benutzer, passwort, datenbank);

            // Verbindung erstellen
            MySqlConnection DBVerbindung = new MySqlConnection(ConnectionString);
            
            // Fall wird von der Methode übergeben
            switch (fall)
            {
                // wenn Fall "1" ist: Analogwerte von Datenbank holen und in jeweilige TextBox schreiben
                // + bei jedem durchlauf auf Alarmierung prüfen
                // + beim ersten durchlauf, Alarmschwellen aus Datenbank holen und in Textboxen schreiben
                case 1:

                    // wenn Rasberry und Datenbank verbunden sind:
                    if (!(lb_DbVerbunden.Text == "XX" || lb_FahrzeugVerbunden.Text == "XX"))
                    {
                        try
                        {
                            // SQL-Verbindung öffnen
                            DBVerbindung.Open();

                            // Befehl formen
                            MySqlCommand cmd = new MySqlCommand(Befehl, DBVerbindung);

                            // Befehl mit Reader ausführen
                            MySqlDataReader reader = cmd.ExecuteReader();

                            //Textboxen befüllen
                            while (reader.Read())
                            {
                                SetTextTb(reader.GetString(1), tb_wertDruck);
                                SetTextTb(reader.GetString(2), tb_wertTHalle);
                                SetTextTb(reader.GetString(3), tb_wertTAuto);
                            }

                            // Datenbankverbindung schließen
                            DBVerbindung.Close();

                            // Wenn noch keine Alarmschwellen vorhanden sind:
                            if (Global.alarmschwellen == false)
                            {
                                // Alarmsw_aus_DB_holen ausführen
                                Alarmsw_aus_DB_holen();
                            }

                            // Pruefe_Alarmierung ausführen
                            Pruefe_Alarmierung();

                            // break beendet case 1:
                            break;
                        }

                        // Wenn ein Fehler auftritt:
                        catch (Exception)
                        {
                            // break beendet case 1:
                            break;
                        }
                    }
                    // wenn einer der Beiden nicht verbunden ist
                    else
                    {
                        //break beendet case 1: bei keiner Verbindung 
                        break;
                    }

                // wenn Fall "2" ist: Alarmschwellen von Datenbank holen und in jeweilige TextBox schreiben
                case 2:

                    // wenn die Datenbankverbindung aufrecht ist:
                    if (!(lb_DbVerbunden.Text == "XX"))
                    {
                        try
                        {  
                            // SQL-Verbindung öffnen
                            DBVerbindung.Open();

                            // Befehl formen
                            MySqlCommand cmd = new MySqlCommand(Befehl, DBVerbindung);

                            // Befehl mit Reader ausführen
                            MySqlDataReader reader = cmd.ExecuteReader();
                                
                            //reader.GetString in TextBox.Text schreiben via Methode
                            while (reader.Read())
                            {
                                SetTextTb(reader.GetString(1), tb_AswDruck);
                                SetTextTb(reader.GetString(2), tb_AswTempHalle);
                                SetTextTb(reader.GetString(3), tb_AswTempAuto);
                            }

                            // Datenbankverbindung schließen
                            DBVerbindung.Close();

                            // Setzt globale Variable alarmschwellen auf true
                            Global.alarmschwellen = true;

                            // break beendet case 2:
                            break;
                        }
                        catch (Exception)
                        {
                            // break beendet case 2: im Fall einer Exception
                            break;
                        }
                    }
                    // wenn keine Datenbankverbindung aufrecht ist;
                    else
                    {
                        // break beendet case 2: bei keiner Verbindung
                        break;
                    }

                // wenn Fall "3" ist: Prüfen ob eine Verbindung mit der Datenbank möglich ist
                case 3:
                    
                    try
                    {
                        // SQL-Verbindung öffnen
                        DBVerbindung.Open();

                        // Label Grün färben und OK schreiben
                        SetFarbeLb(Color.Green, lb_DbVerbunden);
                        SetTextLb("OK", lb_DbVerbunden);

                        // Wenn keine Verbindung ausführen
                        WennKeineVerbindung();

                        // Verindung schließen
                        DBVerbindung.Close();

                        // break beendet case 3:
                        break;                            
                    }

                    // wenn nicht:
                    catch (Exception)
                    {
                        // Label rot färben und XX schreiben
                        SetFarbeLb(Color.DarkRed, lb_DbVerbunden);
                        SetTextLb("XX", lb_DbVerbunden);

                        // Wenn keine Verbindung ausführen
                        WennKeineVerbindung();
                                                        
                        // break beendet case 3: im Fall einer Exception
                        break;
                    }

                // wenn Fall "4" ist: "gewöhnlichen" SQL-Befehl ausführen 
                case 4:
                    // wenn Datenbankverbindung aufrecht ist:
                    if (!(lb_DbVerbunden.Text == "XX"))
                    {
                        //versuche Befehl auszuführen
                        try
                        {
                            // SQL-Verbindung herstellen
                            DBVerbindung.Open();

                            // SQL-Befehl formen
                            MySqlCommand cmd = new MySqlCommand(Befehl, DBVerbindung);

                            // SQL-Befehl ausführen
                            cmd.ExecuteNonQuery();
                        }

                        // wenn nicht
                        catch (Exception)
                        {
                            MessageBox.Show("Nicht aktualisiert.");
                        }

                        // Verbindung schließen
                        DBVerbindung.Close();

                        // break beendet case 4:
                        break;
                    }
                    // wenn keine Datenbankverbindung aufrecht ist:
                    else
                    {
                        // break beendet case 4: wenn Datenbank nicht verbunden ist
                        break;
                    }

                // wenn Fall "5" ist: E-Mail senden
                case 5:

                    // Variable nachricht deklarieren
                    string nachricht = "";

                    // Wenn die Priorität 1 ist, folgende Nachricht senden
                    if (ePrio == 1)
                    {
                         nachricht = "Ein Alarm der Priorität 1 ist aufgetreten. --> Druck tief";
                    }

                    // Wenn die Priorität 2 ist, folgende Nachricht senden
                    if (ePrio == 2)
                    {
                        nachricht = "Ein Alarm der Priorität 2 ist aufgetreten. --> Temperatur Auto tief";
                    }

                    // Wenn die Priorität 5 ist, folgende Nachricht senden
                    if (ePrio == 5)
                    {
                        nachricht = "Samstags Testmail vom RLF2000.";
                    }

                    // Emails werden nur gesendet, wenn das letzte E-mail vor über einer Stunde gesendet wurde
                    // oder ein Samstags Testmail geschickt wird
                    if (Global.letzteEmailPrio1.AddHours(1) < DateTime.Now || ePrio == 5)
                    {

                        // Versuche Emailadressen von DB abzurufen
                        try
                        {
                            // SQL-Verbindung öffnen
                            DBVerbindung.Open();

                            // Befehl formen
                            MySqlCommand cmd = new MySqlCommand(Befehl, DBVerbindung);

                            // Befehl mit Reader ausführen
                            MySqlDataReader reader = cmd.ExecuteReader();

                            // while Schleife wird so lange ausgeführt wie E-Mail Adressen vorhanden sind
                            while (reader.Read())
                            {
                               // E-Mailadresse wird von reader übergeben
                                var empfaenger = new MailAddress(reader.GetString(0));

                                // Versuche Nachricht zu senden
                                try
                                {
                                    // Verbindug zu Server herstellen
                                    var smtp = new SmtpClient
                                    {
                                        // Verbindungseinstellungen
                                        Host = "smtp.gmail.com",
                                        Port = 587,
                                        EnableSsl = true,
                                        DeliveryMethod = SmtpDeliveryMethod.Network,
                                        Credentials = new NetworkCredential(eAbsender.Address, ePasswort),
                                        Timeout = 20000
                                    };

                                    // Mail zusammensetzen
                                    using (var mail = new MailMessage(eAbsender, empfaenger)
                                    {
                                        //Subject = der Betreff der Nachricht
                                        Subject = eBetreff,

                                        //Body = die eigentliche Nachricht
                                        Body = nachricht
                                    })

                                    // Mail senden
                                    {
                                        // Mail senden
                                        smtp.Send(mail);

                                        // Wenn eprio 1 ist globale Variable letzte Email auf aktuelle Uhrzeit + Datum setzen
                                        if (ePrio == 1)
                                        {
                                            // globale Variable letzteEmailPrio aktualisieren
                                            Global.letzteEmailPrio1 = DateTime.Now;
                                        }

                                        // Wenn eprio 2 ist globale Variable letzte Email auf aktuelle Uhrzeit + Datum setzen
                                        if (ePrio == 2)
                                        {
                                            // globale Variable letzteEmailPrio aktualisieren
                                            Global.letzteEmailPrio1 = DateTime.Now;
                                        }

                                        // Wenn eprio 5 ist globale Variable letzte Email auf aktuelle Uhrzeit + Datum setzen
                                        if (ePrio == 5)
                                        {
                                            // globale Variable letzteEmailTest aktualisieren
                                            Global.letzteEmailSprobe = DateTime.Now;
                                        }

                                        // Messagebox anzeigen
                                        MessageBox.Show("Mail Priorität " + ePrio + " versandt an: " + empfaenger);                                        
                                    }
                                }
                                // wenn beim Email versenden eine Exception auftritt:
                                catch (Exception)
                                {
                                    // Messagebox anzeigen
                                    MessageBox.Show("Mail nicht versandt");                   
                                }
                            }

                            // Datenbankverbindung schleißen
                            DBVerbindung.Close();

                            // break beendet case 5: wenn die E-mails gesendet wurden
                            break;

                        }

                        // wenn nicht
                        catch (Exception ex)
                        {                            
                            // break beendet case 5: bei einem Datenbankfehler
                            break;
                        } 
                        
                    }

                    // Wenn in der letzten Stunde bereits ein Email gesendet wurde:
                    else
                    {
                        // break beendet case 5: wenn in der letzten Stunde bereits ein Email gesendet wurde
                        break;
                    }
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hallo");
        }
    }
}