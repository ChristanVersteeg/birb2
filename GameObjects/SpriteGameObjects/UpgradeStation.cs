using System;
using System.Collections.Generic;
using System.Text;
using BaseProject.Engine.Custom.Audio;
using BaseProject.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BaseProject.GameObjects.SpriteGameObjects
{
    class UpgradeStation : SpriteGameObject
    {
        public UpgradeStation(Vector2 position) : base("StationAssets/Upgrade_Station")
        {
            this.position = position;
        }

        public override void Update(GameTime gameTime)
        {
            CurrentSelected = CurrentUpgradeNumber - 1;
            CurrentSelected2 = CurrentUpgradeNumber - 1;
            base.Update(gameTime);
        }

        //variables for the upgradeMenu
        static public bool UpgradeScreenActive;
        private int CurrentUpgradePage;
        static public int CurrentUpgradeNumber;
        private readonly int[] UpgradeLevel = new int[4];
        private readonly int[] UpgradeLevel2 = new int[4];
        private int CurrentSelected = 0;
        private int CurrentSelected2 = 0;
        public int DrillPrice = 4000;
        public int FuelPrice = 2500;
        public int InvPrice = 2000;
        public int HealthPrice = 2000;
        public int DrillSpeedPrice = 4000;
        public int BoosterPrice = 2000;
        public int WheelPrice = 1500;
        public int FuelStationPrice = 1500;
        //main void for the upgradeMenu
        public void UpgradeMenus(InputHelper inputHelper, SpriteGameObject upgrademenu, SpriteGameObject upgradeselecter, Miner miner, Fuelbar fuelbarminer, Inventory inventory, Healthbar healthbar, SpriteGameObject upgradeSpeedMenu)
        {
            if (UpgradeScreenActive)//bool that enables the menu
            {
                upgradeselecter.Visible = true;
                miner.Velocity = new Vector2(0);
                miner.gravityBool = false;

                //Plays the select sounds when you cycle through the upgrades.
                if (inputHelper.KeyPressed(Keys.S) || (inputHelper.KeyPressed(Keys.W)) || (inputHelper.KeyPressed(Keys.A)) || (inputHelper.KeyPressed(Keys.D))) Audio.Play("Select");

                //input switches to select the upgrades
                if (inputHelper.KeyPressed(Keys.S)) CurrentUpgradeNumber += 1;

                if (inputHelper.KeyPressed(Keys.W) && CurrentUpgradeNumber != 1) CurrentUpgradeNumber -= 1;

                if (inputHelper.KeyPressed(Keys.A) || inputHelper.KeyPressed(Keys.D))
                {
                    if (CurrentUpgradePage == 0) CurrentUpgradePage = 1; else if (CurrentUpgradePage == 1) CurrentUpgradePage = 0;
                }

                //all the upgrade information & actions
                if (CurrentUpgradePage == 0)//upgrade page 1
                {
                    upgradeSpeedMenu.Visible = false;
                    upgrademenu.Visible = true;
                    PlayingState.upgradeDrillText.Visible = true;
                    PlayingState.upgradeFuelText.Visible = true;
                    PlayingState.upgradeCargoText.Visible = true;
                    PlayingState.upgradeHealthText.Visible = true;
                    PlayingState.DrillSpeedText.Visible = false;
                    PlayingState.BoosterSpeedText.Visible = false;
                    PlayingState.WheelSpeedText.Visible = false;
                    PlayingState.FuelStationText.Visible = false;

                    if (CurrentUpgradeNumber == 1)//drill upgrade  -cost 4000
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 354);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 0 && PlayingState.money >= DrillPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            DrillPrice = 150000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 1 && PlayingState.money >= DrillPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            DrillPrice = 1000000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 2 && PlayingState.money >= DrillPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            DrillPrice = 0;
                        }
                    }
                    if (CurrentUpgradeNumber == 2)//fuel upgrade -cost 2500
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 430);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 0 && PlayingState.money >= FuelPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            FuelPrice = 30000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 1 && PlayingState.money >= FuelPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            FuelPrice = 200000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 2 && PlayingState.money >= FuelPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            FuelPrice = 0;
                        }
                    }
                    if (CurrentUpgradeNumber == 3)//inventory upgrade -cost 1500
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 510);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 0 && PlayingState.money >= InvPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            InvPrice = 30000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 1 && PlayingState.money >= InvPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            InvPrice = 150000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 2 && PlayingState.money >= InvPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            InvPrice = 0;
                        }
                    }
                    if (CurrentUpgradeNumber == 4)//health upgrade -cost 1500
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 587);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 0 && PlayingState.money >= HealthPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            HealthPrice = 30000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 1 && PlayingState.money >= HealthPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            HealthPrice = 200000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel[CurrentSelected] == 2 && PlayingState.money >= HealthPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            HealthPrice = 0;
                        }
                    }
                }
                else if (CurrentUpgradePage == 1)//upgrade page 2
                {
                    upgrademenu.Visible = false;
                    PlayingState.upgradeDrillText.Visible = false;
                    PlayingState.upgradeFuelText.Visible = false;
                    PlayingState.upgradeCargoText.Visible = false;
                    PlayingState.upgradeHealthText.Visible = false;
                    PlayingState.DrillSpeedText.Visible = true;
                    PlayingState.BoosterSpeedText.Visible = true;
                    PlayingState.WheelSpeedText.Visible = true;
                    PlayingState.FuelStationText.Visible = true;
                    upgradeSpeedMenu.Visible = true;
                    if (CurrentUpgradeNumber == 1)//drillspeed upgrade  -cost 4000
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 354);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel2[CurrentSelected2] == 0 && PlayingState.money >= DrillSpeedPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            DrillSpeedPrice = 75000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel2[CurrentSelected2] == 1 && PlayingState.money >= DrillSpeedPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            DrillSpeedPrice = 0;
                        }
                    }
                    if (CurrentUpgradeNumber == 2)//booster upgrade -cost 2500
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 430);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel2[CurrentSelected2] == 0 && PlayingState.money >= BoosterPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            BoosterPrice = 20000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel2[CurrentSelected2] == 1 && PlayingState.money >= BoosterPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            BoosterPrice = 0;
                        }
                    }
                    if (CurrentUpgradeNumber == 3)//wheel upgrade -cost 1500
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 510);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel2[CurrentSelected2] == 0 && PlayingState.money >= WheelPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            WheelPrice = 15000;
                        }
                        else if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel2[CurrentSelected2] == 1 && PlayingState.money >= WheelPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            WheelPrice = 0;
                        }
                    }
                    if (CurrentUpgradeNumber == 4)//fuel Station upgrade -cost 1500
                    {
                        upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 587);
                        if (inputHelper.KeyPressed(Keys.Space) && UpgradeLevel2[CurrentSelected2] == 0 && PlayingState.money >= FuelStationPrice)
                        {
                            ButtonEffects(upgradeselecter, healthbar, fuelbarminer, inventory, miner);
                            FuelStationPrice = 0;
                        }
                    }
                }
                if (CurrentUpgradeNumber == 5)//exit
                {
                    upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, 667);
                    if (inputHelper.KeyPressed(Keys.Space))
                    {
                        UpgradeScreenActive = false;
                        CurrentUpgradeNumber = 0;
                    }
                }

            }
            else //turning off the visuals of the menu
            {
                upgradeSpeedMenu.Visible = false;
                upgrademenu.Visible = false;
                upgradeselecter.Visible = false;
                upgradeselecter.Position = new Vector2(upgradeselecter.Position.X, GameEnvironment.Screen.Y / 2 - 268);
                miner.gravityBool = true;
                CurrentUpgradePage = 0;
                PlayingState.upgradeDrillText.Visible = false;
                PlayingState.upgradeFuelText.Visible = false;
                PlayingState.upgradeCargoText.Visible = false;
                PlayingState.upgradeHealthText.Visible = false;
                PlayingState.DrillSpeedText.Visible = false;
                PlayingState.BoosterSpeedText.Visible = false;
                PlayingState.WheelSpeedText.Visible = false;
                PlayingState.FuelStationText.Visible = false;
            }
        }
        //all the basic effects of the buttons
        private void ButtonEffects(SpriteGameObject upgradeselecter, Healthbar healthbar, Fuelbar fuelbarminer, Inventory inventory, Miner miner)
        {
            if (CurrentUpgradePage == 0)
            {
                if (CurrentSelected == 0)//drill
                {
                    PlayingState.drillLevel++;
                    PlayingState.money -= DrillPrice;
                }
                else if (CurrentSelected == 1)//fuel
                {
                    PlayingState.money -= FuelPrice;
                    fuelbarminer.Upgrade();
                }
                else if (CurrentSelected == 2)//inv
                {
                    PlayingState.money -= InvPrice;
                    inventory.Upgrade();
                }
                else if (CurrentSelected == 3)//health
                {
                    PlayingState.money -= HealthPrice;
                    healthbar.Upgrade();
                }
                UpgradeLevel[CurrentSelected] += 1;
            }
            else if (CurrentUpgradePage == 1)
            {
                if (CurrentSelected2 == 0)//drillSpeed
                {
                    PlayingState.money -= DrillSpeedPrice;
                    miner.Upgrade("ExponentialDrillSpeed");
                }
                else if (CurrentSelected2 == 1)//booster
                {
                    PlayingState.money -= BoosterPrice;
                    miner.Upgrade("BoosterSpeed");
                }
                else if (CurrentSelected2 == 2)//wheel
                {
                    PlayingState.money -= WheelPrice;
                    miner.Upgrade("WheelSpeed");
                }
                else if (CurrentSelected2 == 3)//fuelStation
                {
                    PlayingState.money -= FuelStationPrice;
                    PlayingState.fuelStationBool = true;
                }
                UpgradeLevel2[CurrentSelected2] += 1;
            }//general actions for buttons
            Audio.Play("Buy");
            CurrentUpgradeNumber = 0;
            upgradeselecter.Position = new Vector2(GameEnvironment.Screen.X / 2 - 199, GameEnvironment.Screen.Y / 2 - 268);
        }

    }
}
