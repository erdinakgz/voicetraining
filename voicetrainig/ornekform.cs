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
using System.Threading;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace voicetrainig
{
    public partial class ornekform : Form
    {
        public ornekform()
        {
            InitializeComponent();
        }

        public void Explanation()
        {
            commentary.ToolTipTitle = "Bilgilendirme. . .";
            commentary.ToolTipIcon = ToolTipIcon.Info;
            commentary.IsBalloon = true;

            commentary.SetToolTip(button1, "Kartal");
        }

        ToolTip commentary = new ToolTip();
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        //Metotlar
        //Tanıma Moturunun Tanıması Gereken Kelimleri Belirtiyoruz.
        public void LoadGrammers()
        {
            Choices words = new Choices(new string[] { "Eagle" });
            GrammarBuilder grammarBuilder = new GrammarBuilder(words);
            Grammar grammar = new Grammar(grammarBuilder);
            recognizer.LoadGrammar(grammar);
        }
        
       //Ses Tanıma İşlemi Sırasında ve Sonrasında Meydana Gelebilecek Olayları Belirliyoruz.
        public void StartRecognition()
        {
            recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechDetected);
            recognizer.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(recognizer_SpeechRecognitionRejected);
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
            recognizer.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(recognizer_RecognizeCompleted);

            //Recognizer.SetInputToDefaultAudioDevice() Bu Metodun Bir Thread içinde Çalıştırılması Gerekir!
            //Ses Tanıma İşlemi
            Thread t1 = new Thread(delegate()
                {
                    recognizer.SetInputToDefaultAudioDevice();
                    recognizer.RecognizeAsync(RecognizeMode.Single);
                });
            t1.Start();
        }

        //Olayları Tanımlayacağız(Event)

        //Kullanıcı Konuşmaya Başladığında Tetiklenen Olay.
        private void recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            textBox1.Text = "Ses Algılanıyor. . .";
        }

        //Kullanıcının Konuştuğu Kelimeler Gramerde Bulunuyorsa Tetiklenen Olay.
        private void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Eagle")
            {
                speechSynthesizer.Speak("True");
                button1.Enabled = true;
                button1.BackColor = Color.Green;
            }
            textBox1.Text = e.Result.Text;
        }

        //Konusulan Kelimeler Gramerde Bulunmuyorsa Tetiklenen Olay.
        private void recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            textBox1.Text = "Ses Algılama Başarısız. . . ";
        }

        //Tanıma İşlemi Başarılı veya Başarısız Olsun Sonuçlandığında Tetiklenen Olay.
        private void recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            recognizer.RecognizeAsync();
        }

        private void ornekform_Load(object sender, EventArgs e)
        {
            Explanation();
            LoadGrammers();
            StartRecognition();
            textBox1.Enabled = false;
        }
    }
}
