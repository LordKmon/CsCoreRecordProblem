using CSCore;
using CSCore.Codecs.WAV;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteCSCoreProblem
{
    public partial class Form1 : Form
    {
        private WasapiCapture m_SoundKeeper;
        private IWriteable m_Writer;
        private IWaveSource m_FinalSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_StartRecord_Click(object sender, EventArgs event_args)
        {
            //Find and set Device (microphone)
            MMDevice selected_device = null;
            using (var deviceEnumerator = new MMDeviceEnumerator())
            using (var deviceCollection = deviceEnumerator.EnumAudioEndpoints(DataFlow.Capture, DeviceState.Active))
            {
                selected_device = deviceCollection[0];
            }

            // Format that I needed
            WaveFormat need_wave_format = new WaveFormat(16000, 16, 1, AudioEncoding.Pcm);

            m_SoundKeeper = new WasapiCapture();
            m_SoundKeeper.Device = selected_device;
            m_SoundKeeper.Initialize();
            var soundInSource = new SoundInSource(m_SoundKeeper);

            var singleBlockNotificationStream = new SingleBlockNotificationStream(soundInSource.ToSampleSource());
            m_FinalSource = singleBlockNotificationStream.ToWaveSource();

            m_Writer = new WaveWriter("output.wav", m_FinalSource.WaveFormat);

            byte[] buffer = new byte[m_FinalSource.WaveFormat.BytesPerSecond / 2];
            soundInSource.DataAvailable += (s, e) =>
            {
                int read;
                while ((read = m_FinalSource.Read(buffer, 0, buffer.Length)) > 0)
                    m_Writer.Write(buffer, 0, read);
            };

            l_Status.Text = "RECORD !!!";
            m_SoundKeeper.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (m_SoundKeeper == null)
                return;
            
            m_SoundKeeper.Stop();
            m_SoundKeeper.Dispose();
            m_SoundKeeper = null;
            m_FinalSource.Dispose();

            if (m_Writer is IDisposable)
                ((IDisposable)m_Writer).Dispose();

            l_Status.Text = "...";
        }
    }
}

