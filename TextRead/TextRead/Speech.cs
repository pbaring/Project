using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace TextRead
{
    class Speech
    {

        public void ReadText(string text)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(text);
            Console.WriteLine(synth);
        }
        
    }
}
