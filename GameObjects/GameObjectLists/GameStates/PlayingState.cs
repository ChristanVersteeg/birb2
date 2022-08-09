using BaseProject.Engine;
using BaseProject.Engine.Custom.Audio;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.GameStates
{
    //This is your main class where you run the game in.
    class PlayingState : GameObjectList
    {
        #region INITIALIZERS
        readonly TimerList timerList;
        readonly Debug debug;
        readonly Config config;
        #endregion

        public PlayingState()
        {
            #region ADD
            timerList = new TimerList();
            this.Add(timerList);

            config = new Config();
            this.Add(config);

            debug = new Debug();
            this.Add(debug);
            #endregion
        }

        public override void Reset()
        {
            //Should be called if you want to reset things to their original values.
            //Obviously you'd have to put code in here that makes the variables reset.
        }

        public override void Update(GameTime gameTime)
        {
            //Never remove this, if you do, the game will no longer update.
            base.Update(gameTime);
        }

        public void Example() 
        {
            //If you want to call audio, here's an example
            Audio.bonk.Play();
            Audio.engineIdle.Play();
            //And you can also stop the ones you add in the Stop function of the audio class
            Audio.Stop("EngineIdle"); //Apparantly it requires string, which is garbage, but you''ll have to live with it, I'm not gonna refactor that now lol
        }
    }
}