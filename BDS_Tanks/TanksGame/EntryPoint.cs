using System.Media;
using TanksGame.Core;

namespace TanksGame
{
    public class EntryPoint
    {
        public static void Main()
        {
            Engine.Instance.Run();

            //using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            //{
            //    // Configure the audio output.
            //    synthesizer.SetOutputToDefaultAudioDevice();

            //    // Build and speak a prompt.
            //    PromptBuilder builder = new PromptBuilder();
            //    builder.AppendText("Are you ready to play tanks mother faakar");
            //    builder.AppendText("Yes sir");
            //    builder.AppendText("");
            //    builder.AppendText("Destination");
            //    builder.AppendText("Identify target");
            //    synthesizer.Speak(builder);
            //}

            SoundPlayer sp = new SoundPlayer();

            sp.SoundLocation = "../../sample.wav";
            sp.PlaySync();
        }
    }
}