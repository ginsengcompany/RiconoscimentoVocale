using System;

namespace RiconoscimentoVocale.Dependency
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
