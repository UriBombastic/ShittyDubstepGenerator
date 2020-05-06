using System;
namespace WaveTest2
{
    public enum WaveExampleType
    {
        ExampleSineWave = 0
    }

    public class WaveGenerator
    {
        WaveHeader header;
        WaveFormatChunk format;
        WaveDataChunk data;

        public WaveGenerator(WaveExampleType type)
        {
            header = new WaveHeader();
            format = new WaveFormatChunk();
            data = new WaveDataChunk();

            switch(type)
            {
                case WaveExampleType.ExampleSineWave:

                    //Number of samples = sample rate * channels * bytes per sample
                    uint numSamples = format.dwSamplesPerSec * format.wChannels;

                    //initialize the 16-bit array
                    data.shortArray = new short[numSamples]; //initialize array length to numSamples? 

                    int amplitude = 32760; //Max Amplitude for 16 bit audio @ 32760 (because I know I'll inevitably turn it higher)
                    double freq = 440.0f; //Concert A: 440 hz

                    // The "angle" used in the function, adjusted for the number of channels and sample rate.
                    // This value is like the period of the wave.
                    double t = (Math.PI * 2 * freq) / (format.dwSamplesPerSec * format.wChannels);

                    for(uint i = 0; i < numSamples - 1; i++)
                    {
                        //Fill witha  simple sine wave at max amplitude
                        for(int channel = 0; channel < format.wChannels; channel++)
                        {
                            data.shortArray[i + channel] = Convert.ToInt16(amplitude * Math.Sin(t * i)); //isn't this just overwriting itself?
                        } // With i @ 0 and channel at 1 shortarray[1] will be accessed then overwritten with i @ 1 and channel @ 0. Fuck.
                    }

                    //calculate data chunk size in bytes
                    data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));

                    break;
            }
        }

    }
}
