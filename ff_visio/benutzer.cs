//
// einige Fehler wenn "falsche Werte in DGV eingetragen werden"
//




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

using System.Threading;

namespace ff_visio
{
    public partial class benutzer : Form
    {

        // Neue Threads (Prozesse) erstellen
        Thread thread1;

        public benutzer()
        {
            InitializeComponent();
        }
        
        //
        // Loader
        //
        private void benutzer_Load(object sender, EventArgs e)
        {


            Verbindung_DB_pruefen();
            
            // Wenn das Fenster Benutzer geöffnet wird, werden folgende Methoden ausgeführt            
            DGVaktualisieren();
        }

        //
        // Button Schließen -> Schließt das Fenster mit einer Erinnerung zum Speichern
        //
        private void bt_schliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        // Button Testmail senden
        private void bt_testMail_Click(object sender, EventArgs e)
        {
            // lokale Variablen deklarieren
            int zeilenNr;
            int zeile;
            string id;
            string sqlBefehl;

            if (!(lb_DbVerbunden.Text == "XX"))
            {
                // Anzahl der ausgewählten Zeilen bestimmen
                zeile = dgv_benutzer.Rows.GetRowCount(DataGridViewElementStates.Selected);

                // wenn mindestens eine Zeile markiert worden ist:
                if (zeile > 0)
                {
                    // for-Schleife so oft ausführen wie Zeilen vorhanden sind
                    for (int i = 0; i < zeile; i++)
                    {
                        // Nummer der ausgewählten Zeile in zeilenNr speichern
                        zeilenNr = Convert.ToInt16(dgv_benutzer.SelectedRows[i].Index.ToString());

                        // "zeilenNr" als "id" speicheren
                        id = dgv_benutzer.Rows[zeilenNr].Cells["ID"].Value.ToString();

                        // SQL-Befehl formatieren
                        sqlBefehl = "SELECT email FROM benutzer WHERE id ='" + id.ToString() + "'";

                        //Methode DBzugriff ausführen
                        DatenbankZugriff(sqlBefehl, 5, 0);
                    }
                }
                //Wenn keine Zeile gewählt ist --> Fehlermeldung
                else
                {
                    MessageBox.Show("Bitte die gesamte Zeile markieren.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        //
        //  Timer: Verbindug zu DB + Raspberry prüfen
        //
        private void T_VerbindungPruefen_Tick(object sender, EventArgs e)
        {
            // thread1 die Methode Verbindung_DB_pruefen() zuweisen
            thread1 = new Thread(Verbindung_DB_pruefen);
            // thread1 starten, nach Ausführeung des threads beendet er sich selbst
            thread1.Start();

        }

        //
        // Methode um Verbindung zur Datenbank zu prüfen
        //
        private void Verbindung_DB_pruefen()
        {
            // SQL-Befehl formatieren
            string sqlBefehl = null;

            //Methode DatenbankZugriff aufrufen
            DatenbankZugriff(sqlBefehl, 3, 0);
        }        

        //
        // DatagridView aktualisieren
        //
        private void DGVaktualisieren()
        {
            // SQL-Befehl formen
            string sqlBefehl = "SELECT id as ID,  vorname as 'Vorname', nachname as 'Nachname', email as 'E-Mail', alarmierung as 'Alarmierung' FROM benutzer";

            // Methode DatenbakZugriff aufrufen
            DatenbankZugriff(sqlBefehl, 1, 0);
        }

        //
        // Wenn sich der Inhalt einer Zelle ändert
        //
        private void dgv_benutzer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                // Text von geänderter Zeile im DataGridView auslesen und in Variablen speichern
                //Feld ID auslesen und in id speichern
                string id = dgv_benutzer.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                //Feld Nachname auslesen und in nachname speichern
                string nachname = dgv_benutzer.Rows[e.RowIndex].Cells["Nachname"].Value.ToString();

                //Feld Vorname auslesen und in vorname speichern
                string vorname = dgv_benutzer.Rows[e.RowIndex].Cells["Vorname"].Value.ToString();

                //Feld E-Mail auslesen und in email speichern
                string email = dgv_benutzer.Rows[e.RowIndex].Cells["E-Mail"].Value.ToString();

                //Feld Alarmierung auslesen und in alamierung speichern
                string alarmierung = dgv_benutzer.Rows[e.RowIndex].Cells["Alarmierung"].Value.ToString();

                // SQL-Befehl formatieren
                string sqlBefehl = "UPDATE benutzer SET nachname ='" + nachname + "', vorname ='" + vorname + "', email ='"
                                    + email + "', alarmierung = '" + alarmierung + "' WHERE id ='" + id + "'";

                // Methode DBzugriff aufrufen
                DatenbankZugriff(sqlBefehl, 4, 0);
            }
            catch(Exception)
            {
                MessageBox.Show("Fehler");
            }       
        }

        //
        // Button Aktualisieren
        //
        private void aktualisierenToolStripButton_Click(object sender, EventArgs e)
        {
            //DGVaktualisieren ausführen
            DGVaktualisieren();
        }

        //
        // Button Hinzufügen
        //
        private void hinzufuegen_Click(object sender, EventArgs e)
        {

            // SQL-Befehl formatieren
            string sqlBefehl = "INSERT INTO benutzer (nachname, vorname, email, alarmierung) " +
                            "VALUES ('x','x','x','x')";

            // Methode DBzugriff ausführen
            DatenbankZugriff(sqlBefehl, 4, 0);

            //DGV Aktualisieren
            DGVaktualisieren();            
        }       

        //
        // Button Löschen
        //
        private void bt_loeschen_Click(object sender, EventArgs e)
        {
            // lokale Variablen deklarieren
            int zeilenNr;
            int zeile;
            string id;

            if (!(lb_DbVerbunden.Text == "XX"))
            {
                // Anzahl der ausgewählten Zeilen bestimmen
                zeile = dgv_benutzer.Rows.GetRowCount(DataGridViewElementStates.Selected);

                // wenn mindestens eine Zeile markiert worden ist:
                if (zeile > 0)
                {
                    // for-Schleife so oft ausführen wie Zeilen vorhanden sind
                    for (int i = 0; i < zeile; i++)
                    {
                        // Nummer der ausgewählten Zeile in zeilenNr speichern
                        zeilenNr = Convert.ToInt16(dgv_benutzer.SelectedRows[i].Index.ToString());

                        // "zeilenNr" als "id" speicheren
                        id = dgv_benutzer.Rows[zeilenNr].Cells["ID"].Value.ToString();

                        // SQL-Befehl formatieren
                        string sqlBefehl = "DELETE FROM benutzer WHERE id ='" + id + "'";

                        // Methode DBzugriff ausführen
                        DatenbankZugriff(sqlBefehl, 4, 0);
                    }
                }
                //Wenn keine Zeile gewählt ist --> Fehlermeldung
                else
                {
                    MessageBox.Show("Bitte die gesamte Zeile markieren.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //DGV aktualisieren
            DGVaktualisieren();
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
        // Wenn keine verbindung zu DB besteht
        //
        private void WennKeineVerbindung()
        {            
            
            if (!(lb_DbVerbunden.Text == "XX") )
            {
                
                //DGV leeren

            }
            
        }
    
        //
        // Methode für Datenbankzugriff
        //
        private void DatenbankZugriff(string Befehl, int fall, int prio)
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
                // Tabelle abrufen
                case 1:
                    // Wenn Datenbank verbunden ist
                    if (!(lb_DbVerbunden.Text == "XX"))
                    {
                        // Aktualisiere die Tabelle
                        try
                        {
                            // SQL-Verbindung öffnen
                            DBVerbindung.Open();

                            // SQL-Befehl formatieren
                            MySqlCommand cmd = new MySqlCommand(Befehl, DBVerbindung);

                            // DataReader erstellen und Befehl (cmd) ausführen
                            MySqlDataReader reader = cmd.ExecuteReader();

                            // Werte von reader in Tabelle übertragen
                            DataTable tabelle = new DataTable();
                            tabelle.Load(reader);

                            // Tabelle dem DataGridView zuweisen
                            dgv_benutzer.DataSource = tabelle;
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                            break;

                        }
                        DBVerbindung.Close();

                        break;
                    }
                    else
                    {
                        //MessageBox.Show("Datenbank nicht verbunden.");
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

                    if (!(lb_DbVerbunden.Text == "XX"))
                    {
                        // Variable nachricht deklarieren
                        string nachricht = "";

                        // Wenn die Priorität 1 ist, folgende Nachricht senden
                        if (ePrio == 1)
                        {
                            nachricht = "Testmail von RLF200 FF-7Hirten Priorität 1";
                        }

                        // Wenn die Priorität 2 ist, folgende Nachricht senden
                        if (ePrio == 2)
                        {
                            nachricht = nachricht = "Testmail von RLF200 FF-7Hirten Priorität 2";
                        }


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

                                        //Messagebox anzeigen
                                        MessageBox.Show("Mail versandt an: " + empfaenger);
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
                    else
                    {
                        break;
                    }
            }       
        }
    }
        

     
    
}

