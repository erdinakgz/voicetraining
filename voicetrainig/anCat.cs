using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Threading;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace voicetrainig
{
    public partial class anCat : UserControl
    {
        public anCat()
        {
            InitializeComponent();
        }

        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        ToolTip tt = new ToolTip();

        //Metotlar
        //Tanıma Motorunun Tanıması Gereken Kelimeleri Belirtiyoruz.
        public void LoadGrammers()
        {
            Choices words = new Choices(new string[] { "Cat" });
            GrammarBuilder grammarBuilder = new GrammarBuilder(words);
            Grammar grammar = new Grammar(grammarBuilder);
            recognizer.LoadGrammar(grammar);
        }

        public void Explanation()
        {
            tt.ToolTipTitle = "Bilgilendirme. . .";
            tt.ToolTipIcon = ToolTipIcon.Info;
            tt.IsBalloon = true;

            tt.SetToolTip(pictureBox1, "Kedi");
        }

        public void StartRecognition()
        {
            recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechDetected);
            recognizer.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(recognizer_SpeechRecognitionRejected);
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
            recognizer.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(recognizer_RecognizeCompleted);
        }

        private void recognizer_Start(object sender, EventArgs e)
        {
            //Recognizer.SetInputToDefaultAudioDevice() Bu Metodun Bir Thread içinde Çalıştırılması Gerekir!
            //Ses Tanıma İşlemi
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync(RecognizeMode.Single);
            playBox.Hide();
            pauseBox.Show();

 
            StartRecognition();
        }

        private void recognizer_Stop(object sender, EventArgs e)
        {
            recognizer.RecognizeAsyncCancel();
            label1.Text = "Mikrofon Durduruldu. . .";
        }

        //Olayları Tanımlayacağız(Event)

        //Kullanıcı Konuşmaya Başladığından Tetiklenen Olay.
        private void recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            mainBox.Hide();
            okeyBox.Hide();
            waitBox.Show();
            label1.Text = "Ses Algılanıyor. . .";
        }

        //Kullanıcının Konuştuğu Kelimeler Gramerde Bulunuyorsa Tetiklenen Olay.
        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            mainBox.Hide();
            okeyBox.Show();
            waitBox.Hide();
            if (e.Result.Text == "Cat")
            {
                speechSynthesizer.Speak("True");
                label1.Enabled = true;
                label1.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Wrong Say ! ");
            }
            label1.Text = e.Result.Text;
        }
        //Konusulan Kelimeler Gramerde Bulunmuyorsa Tetiklenen Olay.
        private void recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            mainBox.Show();
            okeyBox.Hide();
            waitBox.Hide();
            label1.Text = "Ses Algılama Başarısız. . . ";
        }

        //Tanıma İşlemi Başarılı veya Başarısız Olsun Sonuçlandığında Tetiklenen Olay.
        private void recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            recognizer.RecognizeAsync();
        }

        private void anCat_Load(object sender, EventArgs e)
        {
            mainBox.Show();
            okeyBox.Hide();
            waitBox.Hide();

            pauseBox.Hide();
            playBox.Show();

            LoadGrammers();
            Explanation();
        }
    }
}
