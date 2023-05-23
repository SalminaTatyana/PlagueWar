using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameNetCource
{
    [Serializable]
    public class Player
    {
        public string Name { get; set; }
        [JsonIgnore]
        public string Img { get; set; }
        [JsonIgnore]
        public string DeadImg { get; set; }
        [JsonIgnore]
        public int Step { get; set; }
        [JsonIgnore]
        public int StepCount { get; set; } =  3;
        [JsonIgnore]
        public List<Button> ActiveBtn { get; set; }
        [JsonIgnore]
        public List<string> ActiveBtnName { get; set; }
        public Dictionary<string,bool> IsActiveBtn { get; set; }
        public Dictionary<string,bool> IsAliveBtn { get; set; }
        [JsonIgnore]
        public int RemainingStep { get; set; }
        [JsonIgnore]
        public List<int> RGB { get; set; }

        public Player()
        {
          
        }
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
            IsActiveBtn = new Dictionary<string, bool>();
            IsAliveBtn = new Dictionary<string, bool>();
            ActiveBtnName = new List<string>();
        }
        //проверить наличие вражеских кнопок в окружении активных живых кнопок
        public bool checkButtonAnoutherPlayer(Button btn)
        {
            bool result = false;
            foreach (var item in ActiveBtn)
            {
                if (item.IsAlive)
                {
                    if (item.Top != null)
                    {
                        if (item.Top == btn)
                        {
                            result = true;
                        }
                    }
                    if (item.Bottom != null)
                    {
                        if (item.Bottom == btn)
                        {
                            result = true;

                        }
                    }
                    if (item.Left != null)
                    {
                        if (item.Left == btn)
                        {
                            result = true;

                        }
                    }
                    if (item.Right != null)
                    {
                        if (item.Right == btn)
                        {
                            result = true;

                        }
                    }
                    if (item.TopLeft != null)
                    {
                        if (item.TopLeft == btn)
                        {
                            result = true;

                        }
                    }
                    if (item.BottomLeft != null)
                    {
                        if (item.BottomLeft == btn)
                        {
                            result = true;

                        }
                    }
                    if (item.TopRight != null)
                    {
                        if (item.TopRight == btn)
                        {
                            result = true;

                        }
                    }
                    if (item.BottomRight != null)
                    {
                        if (item.BottomRight == btn)
                        {
                            result = true;

                        }
                    }
                }

            }
            return result;
        }
        //проверить жива ли эта кнопка и принадлежит ли она кому-то
        public bool checkButton(Button btn)
        {
            bool result = false;
            if (ActiveBtn.Contains(btn))
            {
                if (ActiveBtn[ActiveBtn.IndexOf(btn)].IsAlive)
                {
                        result = true;
                }
            }
            return result;
        }
        //проверить активна ли эта кнопка 
        public bool checkActiveButton(Button btn)
        {
            bool result = ActiveBtn.Contains(btn);
            return result;
        }
        
        //проверить наличие мертвых вирусов 
        public bool checkDaedVirus(Button btn)
        {
            bool result = false;
           
                if (!btn.IsAlive&&this.ActiveBtn.Contains(btn))
                {
                    result = true;
                }
            return result;
        }

    }
}
