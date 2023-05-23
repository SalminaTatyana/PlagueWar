using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Player
    {
        public string Name { get; set; }
        public string Img { get; set; }
        public string DeadImg { get; set; }
        public int Step { get; set; }
        public int StepCount { get; set; } = 3;
        public List<Button> ActiveBtn { get; set; }
        public int RemainingStep { get; set; }
        public List<int> RGB { get; set; }


        public Player(string name, string img, string deadImg, int step, int stepCount, List<Button> activeBtn, int remainingStep, List<int> rgb)
        {
            Name = name;
            Img = img;
            DeadImg = deadImg;
            Step = step;
            StepCount = stepCount;
            ActiveBtn = activeBtn;
            RemainingStep = remainingStep;
            RGB = rgb;
        }
      
    }

