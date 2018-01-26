using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;

namespace WebHoseApiTestApp.Extensions
{
    public static class StringExtensions
    {
        public static async void Speak(this string text)
        {
            var player = new MediaElement();
            var synth = new SpeechSynthesizer();
            SpeechSynthesisStream audioStream = await synth.SynthesizeTextToStreamAsync(text);
            player.SetSource(audioStream, audioStream.ContentType);
            player.Play();
        }
    }
}
