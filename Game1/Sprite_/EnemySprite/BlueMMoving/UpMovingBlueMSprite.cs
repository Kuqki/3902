﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_.Enemy_Sprite.OctMoving
{
    class UpMovingBlueMSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 10;

        public UpMovingBlueMSprite()
        {
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.BlueMPosition.Y = GlobalDefinitions.BlueMPosition.Y - (float)1; //change the y axis position of Link
            if (GlobalDefinitions.BlueMPosition.Y == GlobalDefinitions.GraphicsHeight)
            {
                GlobalDefinitions.BlueMPosition.Y = 0;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 5)
            {
                sourceRectangle = new Rectangle(0, 0, 96, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.BlueMPosition.X, (int)GlobalDefinitions.BlueMPosition.Y, 96, 96);
            }


            else
            {
                sourceRectangle = new Rectangle(100, 0, 192, 96);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.BlueMPosition.X, (int)GlobalDefinitions.BlueMPosition.Y, 192, 96);
            }

            spriteBatch.Draw(Texture2DStorage.GetUpMovingBlueMSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
