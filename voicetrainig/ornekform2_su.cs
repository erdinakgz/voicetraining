using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace voicetrainig
{
    public partial class ornekform2_su : Form
    {
        public ornekform2_su()
        {
            InitializeComponent();
        }

        public void Explanation2()
        {
            commentary2.ToolTipTitle = "Bilgilendirme. . .";
            commentary2.ToolTipIcon = ToolTipIcon.Info;
            commentary2.IsBalloon = true;

            commentary2.SetToolTip(button1, "Balık");
        }

        ToolTip commentary2 = new ToolTip();
        SpeechRecognitionEngine recognizer2 = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer2 = new SpeechSynthesizer();

        //Metotlar
        //Tanıma Motorunun Tanıması Gereken Kelimeleri Belirtiyoruz.
        public void LoadGrammers2()
        {
            Choices words2 = new Choices(new string[] { "Fish" });
            GrammarBuilder grammarBuilder2 = new GrammarBuilder(words2);
            Grammar grammar2 = new Grammar(grammarBuilder2);
            recognizer2.LoadGrammar(grammar2);
        }

        //Ses Tanıma İşlemi Sırasında ve Sonrasında Meydana Gelebilecek Olayları Belirliyoruzç.
        public void StartRecognition2()
        {
            recognizer2.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer2_SpeechDetected);
            recognizer2.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(recognizer2_SpeechRecognitionRejected);
            recognizer2.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer2_SpeechRecognized);
            recognizer2.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(recognizer2_RecognizeCompleted);

            //Recognizer.SetInputToDefaultAudioDevice() Bu Metodun Bir Thread içinde Çalıştırılması Gerekir!
            //Ses Tanıma İşlemi
            Thread t1 = new Thread(delegate()
            {
                recognizer2.SetInputToDefaultAudioDevice();
                recognizer2.RecognizeAsync(RecognizeMode.Single);
            });
            t1.Start();
        }

        //Olayları Tanımlayacağız(Event)

        //Kullanıcı Konuşmaya Başladığından Tetiklenen Olay.
        private void recognizer2_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            textBox1.Text = "Ses Algılanıyor. . .";
        }

        //Kullanıcının Konuştuğu Kelimeler Gramerde Bulunuyorsa Tetiklenen Olay.
        private void recognizer2_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Fish")
            {
                speechSynthesizer2.Speak("True");
                button1.Enabled = true;
                button1.BackColor = Color.Green;
            }
            textBox1.Text = e.Result.Text;
        }

        //Konusulan Kelimeler Gramerde Bulunmuyorsa Tetiklenen Olay.
        private void recognizer2_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            textBox1.Text = "Ses Algılama Başarısız. . . ";
        }

        //Tanıma İşlemi Başarılı veya Başarısız Olsun Sonuçlandığında Tetiklenen Olay.
        private void recognizer2_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            recognizer2.RecognizeAsync();
        }

        private void ornekform2_su_Load(object sender, EventArgs e)
        {
            Explanation2();
            LoadGrammers2();
            StartRecognition2();
            textBox1.Enabled = false;
        }
    }
}
