using BaseProject;
using BaseProject.Engine;
using BaseProject.Engine.Custom.Audio;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
/// <summary>
/// This class handles variables that stay the same no matter what. You cannot change them outside of this class due to them being a get property in this class, and the variables that get used in here also being privates.
/// </summary>
class Config : GameObjectList
{
    public override void HandleInput(InputHelper inputHelper)
    {
        Audio.Mute(inputHelper);

        base.HandleInput(inputHelper);
    }
}
