using BaseProject.GameStates;
using Microsoft.Xna.Framework;

namespace BaseProject
{
    class Caved_in : GameEnvironment
    {
        protected override void LoadContent()
        {
            screen = new Point(1920, 1080);
            ApplyResolutionSettings();

            GameStateManager.AddGameState("PlayingState", new PlayingState());
            //This allows you to switch between different states of the game, you could for example use it for levels.
            GameStateManager.SwitchTo("PlayingState");

            base.LoadContent();
        }
    }
}
