using BaseProject;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;

namespace BaseProject.Engine
{
    /// <summary>
    /// A class that makes timers.
    /// </summary>
    class Timer : GameObjectList
    {
        #region SETUP
        //Defines new Timers.
        static public Timer timer1;
        static public Timer timer2;
        static public Timer timer3;
        static public Timer timer4;
        static public Timer timer5;

        //Makes the variables that Timer uses.
        private protected float time, timeSeconds;
        internal float seconds, millis, startTimeSeconds, startTimeMillis;
        #endregion

        #region VARIABLE PROPERTIES
        /// <summary>
        /// Returns time in miliseconds
        /// </summary>
        public float Time
        {
            get
            {
                return time;
            }
        }

        /// <summary>
        /// Returns time in seconds
        /// </summary>
        public float TimeSeconds
        {
            get
            {
                return timeSeconds;
            }
        }
        #endregion

        //Resets the Timers time variable.
        public void TimerReset(string millisORseconds = "millis")
        {
            if (millisORseconds == "millis")
            {
                time = 0;
                startTimeMillis = millis;
            }

            if (millisORseconds == "seconds")
            {
                timeSeconds = 0;
                startTimeSeconds = seconds;
            }
        }

        //Updates the Timers
        public override void Update(GameTime gameTime)
        {
            millis = (float)gameTime.TotalGameTime.TotalMilliseconds;
            time = (float)gameTime.TotalGameTime.TotalMilliseconds - startTimeMillis;

            seconds = (float)gameTime.TotalGameTime.TotalSeconds;
            timeSeconds = (float)gameTime.TotalGameTime.TotalSeconds - startTimeSeconds;

            base.Update(gameTime);
        }
    }
}

