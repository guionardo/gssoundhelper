using System;

namespace GSSoundHelper
{

    public static class SoundMute
    {
        static readonly bool OK = false;
        static IAudioEndpointVolume aepv;

        static SoundMute()
        {
            try
            {
                IMMDeviceEnumerator deviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
                const int eRender = 0;
                const int eMultimedia = 1;
                deviceEnumerator.GetDefaultAudioEndpoint(eRender, eMultimedia, out IMMDevice speakers);                
                speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out object aepv_obj);
                aepv = (IAudioEndpointVolume)aepv_obj;

                OK = aepv != null;
            }
            catch (Exception e)
            {
                CatchException(e);
            }
        }

        public static int LastLevel { get; private set; } = 0;
        public static bool GetVolume(out int Level)
        {
            Level = 0;
            float level = 0;
            if (!OK) return false;
            try
            {
                aepv.GetMasterVolumeLevelScalar(ref level);
                Level = (int)(level * 100);
                return true;
            }
            catch (Exception e)
            {
                CatchException(e);
            }
            return false;
        }

        public static bool Mute()
        {
            if (!GetVolume(out int Level))
                return false;
            if (Level == 0)
                return true;

            LastLevel = Level;
            return SetVolume(0);
        }

        public static bool SetVolume(int Level)
        {
            if (!OK) return false;
            try
            {
                Guid ZeroGuid = new Guid();
                aepv.SetMasterVolumeLevelScalar(Level / 100f, ZeroGuid);                
                return true;
            }
            catch (Exception e)
            {
                CatchException(e);
                return false;
            }
        }

        public static bool UnMute()
        {
            if (!OK) return true;
            if (LastLevel == 0)
                return false;
            return SetVolume(LastLevel);
        }

        private static void CatchException(Exception e)
        {
            //TODO: Show Exception
        }
    }
}
