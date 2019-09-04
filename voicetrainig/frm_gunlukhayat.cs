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
    public partial class frm_gunlukhayat : Form
    {
        public frm_gunlukhayat()
        {
            InitializeComponent();
        }

        public void Explanation4()
        {
            commentary4.ToolTipTitle = "Bilgilendirme. . .";
            commentary4.ToolTipIcon = ToolTipIcon.Info;
            commentary4.IsBalloon = true;

            commentary4.SetToolTip(label1, "Senin adın ne?");
            commentary4.SetToolTip(label2, "Benim adım bilgisayar.");
            commentary4.SetToolTip(label3, "Yaşın kaç?");
            commentary4.SetToolTip(label4, "Ben 18 yaşındayım.");
        }


        ToolTip commentary4 = new ToolTip();
        SpeechRecognitionEngine recognizer4 = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer4 = new SpeechSynthesizer();

        //Metotlar
        //Tanıma Motorunun Tanıması Gereken Kelimeleri Belirtiyoruz.
        public void LoadGrammers4()
        {
            Choices words4 = new Choices(new string[] {"What is your name?","How old are you?" });
            GrammarBuilder grammarBuilder4 = new GrammarBuilder(words4);
            Grammar grammar4 = new Grammar(grammarBuilder4);
            recognizer4.LoadGrammar(grammar4);
        }

        public void StartRecognition4()
        {
            recognizer4.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer4_SpeechDetected);
            recognizer4.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(recognizer4_SpeechRecognitionRejected);
            recognizer4.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer4_SpeechRecognized);
            recognizer4.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(recognizer4_RecognizeCompleted);

            //Recognizer.SetInputToDefaultAudioDevice() Bu Metodun Bir Thread içinde Çalıştırılması Gerekir!
            //Ses Tanıma İşlemi
            Thread t1 = new Thread(delegate()
            {
                recognizer4.SetInputToDefaultAudioDevice();
                recognizer4.RecognizeAsync(RecognizeMode.Single);
            });
            t1.Start();
        }

        //Olayları Tanımlayacağız(Event)

        //Kullanıcı Konuşmaya Başladığından Tetiklenen Olay.
        private void recognizer4_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            textBox1.Text = "Ses Algılanıyor. . .";
        }

        //Kullanıcının Konuştuğu Kelimeler Gramerde Bulunuyorsa Tetiklenen Olay.
        private void recognizer4_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "What is your name?")
            {
                speechSynthesizer4.Speak("My name is Computer");
                label1.BackColor = Color.Green;
                label2.Enabled = true;
                label2.Text = "My name is Computer";
            }
            else if (e.Result.Text == "How old are you?")
            {
                speechSynthesizer4.Speak("I am eighteen years old?");
                label3.BackColor = Color.Green;
                label4.Enabled = true;
                label4.Text = "I am eighteen years old";
            }
            textBox1.Text = e.Result.Text;
        }

        //Konusulan Kelimeler Gramerde Bulunmuyorsa Tetiklenen Olay.
        private void recognizer4_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            textBox1.Text = "Ses Algılama Başarısız. . . ";
        }

        //Tanıma İşlemi Başarılı veya Başarısız Olsun Sonuçlandığında Tetiklenen Olay.
        private void recognizer4_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            recognizer4.RecognizeAsync();
        }

        private void frm_gunlukhayat_Load(object sender, EventArgs e)
        {
            Explanation4();
            LoadGrammers4();
            StartRecognition4();
            textBox1.Enabled = false;
        }
    }
}
