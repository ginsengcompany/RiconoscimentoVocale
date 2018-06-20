using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using AVFoundation;
using Foundation;
using RiconoscimentoVocale.Dependency;
using RiconoscimentoVocale.iOS.Dependency;
using UIKit;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace RiconoscimentoVocale.iOS.Dependency
{
    class TextToSpeechImplementation : ITextToSpeech
    {
        public TextToSpeechImplementation() { }

        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("it-IT"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}