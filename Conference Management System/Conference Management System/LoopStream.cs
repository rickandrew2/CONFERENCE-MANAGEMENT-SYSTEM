using NAudio.Wave;

namespace Conference_Management_System
{
    internal class LoopStream
    {
        private AudioFileReader audioFileReader;

        public LoopStream(AudioFileReader audioFileReader)
        {
            this.audioFileReader = audioFileReader;
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}