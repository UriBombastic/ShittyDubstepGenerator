namespace WaveTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Diagnostics;
    using System.IO;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string FileCounter()
        {
            return FileCounter("test");
        }

        public string FileCounter(string str)
        {
            int i = 0;

            while (File.Exists(str + i + ".wav"))
            {
                i++;
            }

            return i.ToString();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            ChangeText();
           
        }

        public string RemoveDirs(string str)
        {
            string[] parts = str.Split('\\');
            return parts[parts.Length - 1];
        }
        //static - white noise
        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "test" + FileCounter() + ".wav";
            FileStream stream = new FileStream(fileName, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);


            //header?
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            int samples = 88200 * 4;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            //header and formatting
            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);

            double amplMin = 1000;
            double amplMax = 30000;
            double noteGap = 1.059; //ratio of frequencies between notes. I'm lazy.
            double noteMin = 16.35; //C0
            double noteCount = 64;
            //too much effort
            //   double[] freqs = { 16.35, 17.32, 18.35, 19.45, 20.60, 21.83, 23.12, 24.50, 25.96, 27.50, 29.14, 30.87, 23.70, 34.65, 36.71, 38.89, 41.20, 43.65, 46.25 };

            double aNatural = 220.0;
            double ampl = 10000;
            double perfect = 1.5;
            double concert = 1.498307077;
            double freq = aNatural * perfect;
            int freqCount = 4;

            Random rando = new Random();

            /*for(int x = 0; x < freqCount; x++)
            {
                for(int i = 0; i < samples / 4; i++)
                {
                    double t = (double)i / (double)samplesPerSecond;
                    short s = 
                }
            }*/

            /*  for (int i = 0; i < samples / 4; i++)
              {
                  double t = (double)i / (double)samplesPerSecond;
                  short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                  writer.Write(s);
              }
              freq = aNatural * concert;
              for (int i = 0; i < samples / 4; i++)
              {
                  double t = (double)i / (double)samplesPerSecond;
                  short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                  writer.Write(s);
              }
              for (int i = 0; i < samples / 4; i++)
              {
                  double t = (double)i / (double)samplesPerSecond;
                  short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI) + Math.Sin(t * freq * perfect * 2.0 * Math.PI)));
                  writer.Write(s);
              }
              for (int i = 0; i < samples / 4; i++)
              {
                  double t = (double)i / (double)samplesPerSecond;
                  short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI) + Math.Sin(t * freq * concert * 2.0 * Math.PI)));
                  writer.Write(s);
              }*/

            for (int i = 0; i < samples; i++)
            {
                ampl = (amplMin + amplMax * rando.NextDouble());
                freq = noteMin * Math.Pow(noteGap, noteCount * rando.NextDouble());

                double t = (double)i / (double)samplesPerSecond;
                short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
                writer.Write(s);
            }

            writer.Close();
            stream.Close();
            MessageBox.Show("done DiD iT");
            System.Diagnostics.Process.Start(fileName);
        }
        
        //fromFile
        private void button1_Click(object sender, EventArgs e)
        {
            string readFile = textBox1.Text;
            string writeFile = RemoveDirs(readFile);
            byte[] fileData = File.ReadAllBytes(readFile);
            Debug.WriteLine("Length of " + fileData.Length);

            string fileName = writeFile + ".ToMusic" + FileCounter(writeFile + ".ToMusic") + ".wav";
            FileStream stream = new FileStream(fileName, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            StreamReader Reader = new StreamReader(readFile);

            //header?
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = Convert.ToInt16(txtTracks.Text);//2;
            int samplesPerSecond = Convert.ToInt32(txtSamplesPS.Text);//44100;
            short bitsPerSample = Convert.ToInt16(txtBitsPerSample.Text);//16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond;
            if (chkOverride.Checked)
            {
                bytesPerSecond = Convert.ToInt32(txtBitRate.Text) / 8; //bitrate readily visible in file info duh
            }
            else
            {
                bytesPerSecond = samplesPerSecond * frameSize;
            }
            int waveSize = 4;
            int data = 0x61746164;
            int samples = fileData.Length;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            //header and formatting
            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);

            double amplMin = 1000;
            double amplMax = 30000;
            double noteGap = 1.059; //ratio of frequencies between notes. I'm lazy.
            double noteMin = 16.35; //C0
            double noteCount = 64;
            double ampl = 0; double freq = 0;
            //too much effort
            //   double[] freqs = { 16.35, 17.32, 18.35, 19.45, 20.60, 21.83, 23.12, 24.50, 25.96, 27.50, 29.14, 30.87, 23.70, 34.65, 36.71, 38.89, 41.20, 43.65, 46.25 };




            try
            {
                int method = Convert.ToInt32(textBox2.Text);
                

                switch(method)
                    {

                    case 0:
                //method 0; tears apart data
                for (int i = 0; i < samples; i++)
                {
                    short s = (short)fileData[i];
                    writer.Write(s);
                }
                        break;
                case 1:
                //Method 1: combine bytes
                for (int i = 0; i < samples; i += 2)
                {
                    short s = BitConverter.ToInt16(new byte[2] { fileData[i], fileData[i + 1] }, 0);
                    writer.Write(s);
                }
                break;

                case 2:
                 //Method 2: Just Write Bytes!
                 for(int i = 0; i < samples; i++)
                        {
                            writer.Write(fileData[i]);
                        }


                 break;

                    case 3:

                        for (int i = 1; i <= samples; i++)
                        {
                            writer.Write(fileData[samples- i]);
                        }
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Done Fucked Up:/n" + ex.Message);
            }
            finally
            {

                writer.Close();
                stream.Close();
            }
            MessageBox.Show("done DiD iT");
            System.Diagnostics.Process.Start(fileName);
        }

        private void TextChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void ChangeText()
        {
            if (chkOverride.Checked) return;

            try
            {
                int tracks = Convert.ToInt32(txtTracks.Text);
                int SamplesPerSecond = Convert.ToInt32(txtSamplesPS.Text);
                int BitsPerSample = Convert.ToInt32(txtBitsPerSample.Text);
                txtBitRate.Text = "" + tracks * SamplesPerSecond * BitsPerSample;
            }
            catch
            {

            }
        }
    }
}