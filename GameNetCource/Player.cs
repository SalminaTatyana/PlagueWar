using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNetCource
{
    public class Player
    {
        public string Img { get; set; }
        public int Step { get; set; }
        public int StepCount { get; set; } = 3;
        public List<Button> ActiveBtn { get; set; }
        public int RemainingStep { get; set; }


        public Player(string img, int step, int stepCount, List<Button> activeBtn, int remainingStep)
        {
            Img = img;
            Step = step;
            StepCount=stepCount;
            ActiveBtn = activeBtn;
            RemainingStep = remainingStep;
        }
    }
}
