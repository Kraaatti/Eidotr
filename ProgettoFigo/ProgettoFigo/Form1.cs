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

namespace ProgettoFigo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        string ciao = "";
        string boh = "";
        /// <summary>
        /// Questa funzione permette di mostrare sull'interfaccia il codice scritto dall'utente sulla prima richtextbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_TextChanged(object sender, EventArgs e)
          
        {
            
            Interfaccia.DocumentText = Input.Text + ciao;
            boh = Input.Text;
        }
        /// <summary>
        /// Questa funzione permette di mostrare sull'interfaccia il codice scritto in css dall'utente sulla seconda richtextbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

           
            Interfaccia.DocumentText = richTextBox1.Text + boh;
            ciao = richTextBox1.Text;
        }
        /// <summary>
        /// Questa funzione permette di salvare il codice html su file in una repository scelta dall'utente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, Input.Text);
            }
        }
        /// <summary>
        /// Questa funzione permette di salvare il codice css su file in una repository scelta dall'utente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog2.FileName, richTextBox1.Text);
            }
        }
        /// <summary>
        /// Questa funzione permette di caricare il codice html su file in una repository scelta dall'utente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ci = openFileDialog1.FileName;
                Input.Text = File.ReadAllText(ci);
            }
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {

        }
        /// <summary>
        /// Questa funzione permette di caricare il codice css su file in una repository scelta dall'utente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ci = openFileDialog3.FileName;
                richTextBox1.Text = File.ReadAllText(ci);
            }
        }
    }
}
