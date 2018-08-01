using System;
using System.Collections.Generic;
using System.Linq;

using Terraria;
using Terraria.ID;

namespace LootBags
{
    // Represents a leaf in the prize tree, holding a number of
    // possibilities for the actual prize obtained
    public class Loot
    {
        public double percent = -1;
        public int item = ItemID.None;
        public int min = 1;
        public int max = 1;
        public int amount = 0;
        public int type = 1;

        public Loot(double percent = -1, int item = ItemID.None, int min = 1, int max = 1, int type = 1)
        {
            this.percent = percent;
            this.item = item;
            this.min = min;
            this.max = max;
            this.type = type;
        }

        public virtual Loot Roll()
        {
            this.amount = (this.max == 0) ? this.min : Main.rand.Next(this.min, this.max + 1);
            
            return this;
        }
    }

    // Extends Prizes to represent a Node in the tree, which contains
    // one or more PrizeNodes and/or Prize leafs
    
    public class LootNode : Loot
    {
        public List<Loot> children = new List<Loot>();

        public LootNode(double percent, int type)
        {
            this.percent = percent;
            this.type = type;
        }

        public LootNode(double percent) : this(percent, 0) { }
        public LootNode() : this(1, 0) { }

        public LootNode AddChildren(params Loot[] children)
        {
            this.children.AddRange(children);
            return this;
        }

        public override Loot Roll()
        {
            
            // sum all the chances of the children together
            double totalWeight = (from entry in this.children select entry.percent).Sum();

            // then multiply this by the upper bound (+1 ?)
            double chance = Main.rand.NextDouble() * totalWeight;

            foreach (Loot child in this.children)
            {
                if (chance < child.percent)
                {
                    return child.Roll();
                }
                else
                {
                    chance -= child.percent;
                }
            }
            

                // either there were no children,
                // or somehow we managed to run out of them
                return this;
        }
    }
    
}