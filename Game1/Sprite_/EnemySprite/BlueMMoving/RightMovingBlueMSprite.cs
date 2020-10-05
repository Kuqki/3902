﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.OctMoving
{
    class RightMovingBlueMSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;

        public RightMovingBlueMSprite()
        {
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.OctPosition.X = GlobalDefinitions.OctPosition.X + (float)1; //change the y axis position of Link
            if (GlobalDefinitions.OctPosition.X == GlobalDefinitions.GraphicsWidth)
            {
                GlobalDefinitions.OctPosition.X = 0;
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);//I don't understand why the width of destinationRectangle has to be like this.
            }


            else
            {
                sourceRectangle = new Rectangle(96, 0, 192, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 192, 96);
            }
            spriteBatch.Draw(Texture2DStorage.GetRightMovingBlueMSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
