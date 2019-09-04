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
    public partial class ornekform3_kara : Form
    {
        public ornekform3_kara()
        {
            InitializeComponent();
        }

        SpeechRecognitionEngine recognizer3 = new SpeechRecognitionEngine();
        SpeechSynthesizer speechSynthesizer3 = new SpeechSynthesizer();

        //Metotlar
        //Tanıma Motorunun Tanıması Gereken Kelimeleri Belirtiyoruz.
        public void LoadGrammers3()
        {
            Choices words3 = new Choices(new string[] { "Cat","Leon","Dog","Elephant","Fox","Horse" });
            GrammarBuilder grammarBuilder3 = new GrammarBuilder(words3);
            Grammar grammar3 = new Grammar(grammarBuilder3);
            recognizer3.LoadGrammar(grammar3);
        }

        public void StartRecognition3()
        {
            recognizer3.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer3_SpeechDetected);
            recognizer3.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(recognizer3_SpeechRecognitionRejected);
            recognizer3.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer3_SpeechRecognized);
            recognizer3.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(recognizer3_RecognizeCompleted);

            //Recognizer.SetInputToDefaultAudioDevice() Bu Metodun Bir Thread içinde Çalıştırılması Gerekir!
            //Ses Tanıma İşlemi
            Thread t1 = new Thread(delegate()
            {
                recognizer3.SetInputToDefaultAudioDevice();
                recognizer3.RecognizeAsync(RecognizeMode.Single);
            });
            t1.Start();
        }

        //Olayları Tanımlayacağız(Event)

        //Kullanıcı Konuşmaya Başladığından Tetiklenen Olay.
        private void recognizer3_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            textBox1.Text = "Ses Algılanıyor. . .";
        }

        //Kullanıcının Konuştuğu Kelimeler Gramerde Bulunuyorsa Tetiklenen Olay.
        private void recognizer3_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "Cat")
            {
                speechSynthesizer3.Speak("True");
                button1.Enabled = true;
                button1.BackColor = Color.Green;
            }
            else if (e.Result.Text == "Leon")
            {
                speechSynthesizer3.Speak("True");
                button2.Enabled = true;
                button2.BackColor = Color.Green;
            }
            else if (e.Result.Text == "Dog")
            {
                speechSynthesizer3.Speak("True");
                button3.Enabled = true;
                button3.BackColor = Color.Green;
            }
            else if (e.Result.Text == "Elephant")
            {
                speechSynthesizer3.Speak("True");
                button4.Enabled = true;
                button4.BackColor = Color.Green;
            }
            else if (e.Result.Text == "Fox")
            {
                speechSynthesizer3.Speak("True");
                button5.Enabled = true;
                button5.BackColor = Color.Green;
            }
            else if (e.Result.Text == "Horse")
            {
                speechSynthesizer3.Speak("True");
                button6.Enabled = true;
                button6.BackColor = Color.Green;
            }
            textBox1.Text = e.Result.Text;
        }
        //Konusulan Kelimeler Gramerde Bulunmuyorsa Tetiklenen Olay.
        private void recognizer3_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            textBox1.Text = "Ses Algılama Başarısız. . . ";
        }

        //Tanıma İşlemi Başarılı veya Başarısız Olsun Sonuçlandığında Tetiklenen Olay.
        private void recognizer3_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            recognizer3.RecognizeAsync();
        }

        private void ornekform3_kara_Load(object sender, EventArgs e)
        {
            LoadGrammers3();
            StartRecognition3();
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
