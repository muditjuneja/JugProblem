using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Jug.REST.Models
{
    public class Jug
    {
        public int Limit { get; set; }
        public int CurrentLevel { get; set; }

        public Jug(int limit)
        {
            this.Limit = limit;
            this.CurrentLevel = 0;
        }

        public void Fill()
        {
            this.CurrentLevel = Limit;
        }

        public void Empty()
        {
            this.CurrentLevel = 0;
        }

        public bool IsFull()
        {
            return this.CurrentLevel == this.Limit;
        }


        public bool IsEmpty()
        {
            return this.CurrentLevel == 0;
        }

        public void TransferContent(Jug otherJug)
        {
            int required = otherJug.Limit - otherJug.CurrentLevel;
            if (this.CurrentLevel > required)
            {
                this.CurrentLevel = this.CurrentLevel - required;
                otherJug.CurrentLevel = otherJug.CurrentLevel + required;
            }
            else
            {
                otherJug.CurrentLevel = otherJug.CurrentLevel + this.CurrentLevel;
                this.CurrentLevel = 0;
            }

        }

    }
}