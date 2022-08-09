using BaseProject.Engine;
using BaseProject.Engine.Custom.Audio;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseProject.Engine.Custom.Audio
{
    /// <summary>
    /// Manages all the audio in the game
    /// </summary>
    class Audio : LoadSoundEffects
    {
        static private protected bool audioIsMuted;
        static public void Mute(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.M))
            {
                if (audioIsMuted)
                {
                    Timer.timer1.TimerReset();
                    Stop();
                }
                audioIsMuted = true;
                if (Timer.timer1.Time < 25) audioIsMuted = false;
            }
        }

        static public void Play(string soundEffect)
        {
            if (!audioIsMuted)
            {
                //Examples
                //SoundEffectInstances
                if (soundEffect == "Booster")
                    if (instBooster.State == SoundState.Stopped) 
                    { 
                        instBooster.Stop();
                        instBooster.Play();
                    }

                //SoundEffects
                if (soundEffect == "Bonk")
                    bonk.Play(0.1f, 0, 0);
            }
        }

        static public void Stop(string soundEffect = null)
        {
            //Examples
            if (soundEffect == "EngineIdle" || audioIsMuted)
                instEngineIdle.Stop();

            if (soundEffect == "BackgroundMusic" || audioIsMuted)
                instBackgroundMusic.Pause();
            else instBackgroundMusic.Resume();
        }
    }
}

