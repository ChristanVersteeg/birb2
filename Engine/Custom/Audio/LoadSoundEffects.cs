using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseProject.Engine.Custom.Audio
{
    //All examples
    class LoadSoundEffects
    {
        //SoundEffectInstances
        static public readonly SoundEffect engineIdle;
        static public readonly SoundEffectInstance instEngineIdle;
        static public readonly SoundEffect booster;
        static public readonly SoundEffectInstance instBooster;
        static public readonly SoundEffect backgroundMusic;
        static public readonly SoundEffectInstance instBackgroundMusic;


        //SoundEffects
        static public readonly SoundEffect bonk;

        static LoadSoundEffects()
        {
            string folderPath = "SoundEffects/";

            //SoundEffectInstances
            engineIdle = GameEnvironment.AssetManager.Content.Load<SoundEffect>(folderPath + "engineIdle");
            instEngineIdle = engineIdle.CreateInstance();

            booster = GameEnvironment.AssetManager.Content.Load<SoundEffect>(folderPath + "booster");
            instBooster = booster.CreateInstance();

            backgroundMusic = GameEnvironment.AssetManager.Content.Load<SoundEffect>("backgroundMusic");
            instBackgroundMusic = backgroundMusic.CreateInstance();

            //SoundEffects
            bonk = GameEnvironment.AssetManager.Content.Load<SoundEffect>(folderPath + "bonk");

            float lowerVolume = 0.05f;
            //Volumes of the SoundEffectInstances
            instEngineIdle.Volume = 0.3f;
            instBooster.Volume = lowerVolume;

            instBackgroundMusic.Volume = lowerVolume;
            instBackgroundMusic.IsLooped = true;
            instBackgroundMusic.Play();
        }
    }
}
