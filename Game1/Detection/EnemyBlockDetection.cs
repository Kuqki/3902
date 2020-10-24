﻿using Game1.Collision;
using Game1.Enemy_NPC;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Detection
{
    class EnemyBlockDetection : IDetection
    {
        public IEnemyList enemyList;
        public IBlockList blockList;

        public EnemyBlockDetection(IEnemyList enemyList, IBlockList blockList)
        {
            this.enemyList = enemyList;
            this.blockList = blockList;
        }
        public void update()
        {
            foreach (IEnemy enemy in enemyList.enemyList)
            {
                foreach (IBlock block in blockList.blockList)
                {
                    Rectangle ifCollision = new Rectangle();
                    ifCollision = Rectangle.Intersect(enemy.rectangle, block.rectangle);
                    
                    if (!ifCollision.IsEmpty)
                    {
                        if (ifCollision.Height > ifCollision.Width && enemy.X < block.X)
                        {
                            new EnemyBlockCollisionHandler(enemy, block, ICollision.Left).Execute();
                        } else if (ifCollision.Height > ifCollision.Width && enemy.X > block.X)
                        {
                            new EnemyBlockCollisionHandler(enemy, block, ICollision.Right).Execute();
                        } else if (ifCollision.Height < ifCollision.Width && enemy.Y > block.Y)
                        {
                            new EnemyBlockCollisionHandler(enemy, block, ICollision.Bottom).Execute();
                        } else if (ifCollision.Height < ifCollision.Width && enemy.Y < block.Y)
                        {
                            new EnemyBlockCollisionHandler(enemy, block, ICollision.Top).Execute();
                        } else
                        {
                            new EnemyBlockCollisionHandler(enemy, block, ICollision.Null).Execute();
                        }
                    }
                }
            }
        }
    }
}
