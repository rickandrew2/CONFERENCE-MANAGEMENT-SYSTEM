using MySql.Data.MySqlClient;
using System;
using NAudio.Wave;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Conference_Management_System
{
    public partial class Welcome : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private bool closing = false;

        public Welcome()
        {
            InitializeComponent();

            // Disable the maximize button
            this.MaximizeBox = false;
            string mysqlCon = "server=127.0.0.1; user=root; database=conference_data; password=;";
            MySqlConnection mysql = new MySqlConnection(mysqlCon);

            try
            {
                mysql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mysql.Close();
            }

            string filePath = @"C:\Users\Rick\Downloads\SM (Shoemartl) Philippines Theme Song! (revised).wav";
            waveOutDevice = new WaveOutEvent();
            audioFileReader = new AudioFileReader(filePath);
            waveOutDevice.Init(audioFileReader);

            // Set the volume to 50%
            waveOutDevice.Volume = 0.3f;

            // Hook up the playback finished event to restart the playback
            waveOutDevice.PlaybackStopped += WaveOutDevice_PlaybackStopped;

            // Play background music
            waveOutDevice.Play();
        }

        private void WaveOutDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (!closing)
            {
                // Stop playback
                waveOutDevice.Stop();

                // Rewind the audio file to the beginning
                audioFileReader.Position = 0;

                // Start playback again
                waveOutDevice.Play();
            }
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Set the closing flag to true to stop the loop
            closing = true;

            // Stop background music
            waveOutDevice?.Stop();
            // Don't dispose here
            // waveOutDevice?.Dispose();
            // audioFileReader?.Dispose();

            base.OnFormClosing(e);
        }
    }
}
