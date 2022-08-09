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

            GameStateManager.AddGameState("StoryState", new StoryState());
            GameStateManager.AddGameState("StartScreenState", new StartScreenState());
            GameStateManager.AddGameState("PlayingState", new PlayingState());
            GameStateManager.AddGameState("GameOverState", new GameOverState());
            gameStateManager.AddGameState("WinState", new WinState());
            GameStateManager.SwitchTo("StartScreenState");
            GameStateManager.SwitchTo("StoryState");

            base.LoadContent();
        }
    }
}
