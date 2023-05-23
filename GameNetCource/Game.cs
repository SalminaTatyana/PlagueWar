using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNetCource
{
    public partial class Game : Form
    {
        //инициализация игроков
        Player playerOne = new Player("One", "img/player1.png", "img/player2Dead.png", 0, 3, new List<Button>(), 100, new List<int> { 189, 0, 255 });
        Player playerTwo = new Player("Two", "img/player2.png", "img/player1Dead.png", 0, 3, new List<Button>(), 100, new List<int> { 255, 230, 0 });
        //инициализация всех кнопок
        static Button Button10 = new Button(false);
        static Button Button9 = new Button(false);
        static Button Button8 = new Button(false);
        static Button Button7 = new Button(false);
        static Button Button6 = new Button(false);
        static Button Button5 = new Button(false);
        static Button Button4 = new Button(false);
        static Button Button3 = new Button(false);
        static Button Button2 = new Button(false);
        static Button Button1 = new Button(false);
        //2 строка
        static Button Button20 = new Button(false);
        static Button Button19 = new Button(false);
        static Button Button18 = new Button(false);
        static Button Button17 = new Button(false);
        static Button Button16 = new Button(false);
        static Button Button15 = new Button(false);
        static Button Button14 = new Button(false);
        static Button Button13 = new Button(false);
        static Button Button12 = new Button(false);
        static Button Button11 = new Button(false);
        //3 строка
        static Button Button30 = new Button(false);
        static Button Button29 = new Button(false);
        static Button Button28 = new Button(false);
        static Button Button27 = new Button(false);
        static Button Button26 = new Button(false);
        static Button Button25 = new Button(false);
        static Button Button24 = new Button(false);
        static Button Button23 = new Button(false);
        static Button Button22 = new Button(false);
        static Button Button21 = new Button(false);
        //4 строка
        static Button Button40 = new Button(false);
        static Button Button39 = new Button(false);
        static Button Button38 = new Button(false);
        static Button Button37 = new Button(false);
        static Button Button36 = new Button(false);
        static Button Button35 = new Button(false);
        static Button Button34 = new Button(false);
        static Button Button33 = new Button(false);
        static Button Button32 = new Button(false);
        static Button Button31 = new Button(false);
        //5 строка
        static Button Button50 = new Button(false);
        static Button Button49 = new Button(false);
        static Button Button48 = new Button(false);
        static Button Button47 = new Button(false);
        static Button Button46 = new Button(false);
        static Button Button45 = new Button(false);
        static Button Button44 = new Button(false);
        static Button Button43 = new Button(false);
        static Button Button42 = new Button(false);
        static Button Button41 = new Button(false);
        //6 строка
        static Button Button60 = new Button(false);
        static Button Button59 = new Button(false);
        static Button Button58 = new Button(false);
        static Button Button57 = new Button(false);
        static Button Button56 = new Button(false);
        static Button Button55 = new Button(false);
        static Button Button54 = new Button(false);
        static Button Button53 = new Button(false);
        static Button Button52 = new Button(false);
        static Button Button51 = new Button(false);
        //7 строка
        static Button Button70 = new Button(false);
        static Button Button69 = new Button(false);
        static Button Button68 = new Button(false);
        static Button Button67 = new Button(false);
        static Button Button66 = new Button(false);
        static Button Button65 = new Button(false);
        static Button Button64 = new Button(false);
        static Button Button63 = new Button(false);
        static Button Button62 = new Button(false);
        static Button Button61 = new Button(false);
        //8 строка                   
        static Button Button80 = new Button(false);
        static Button Button79 = new Button(false);
        static Button Button78 = new Button(false);
        static Button Button77 = new Button(false);
        static Button Button76 = new Button(false);
        static Button Button75 = new Button(false);
        static Button Button74 = new Button(false);
        static Button Button73 = new Button(false);
        static Button Button72 = new Button(false);
        static Button Button71 = new Button(false);
        //9 строка                   
        static Button Button90 = new Button(false);
        static Button Button89 = new Button(false);
        static Button Button88 = new Button(false);
        static Button Button87 = new Button(false);
        static Button Button86 = new Button(false);
        static Button Button85 = new Button(false);
        static Button Button84 = new Button(false);
        static Button Button83 = new Button(false);
        static Button Button82 = new Button(false);
        static Button Button81 = new Button(false);
        //10 строка                  
        static Button Button100 = new Button(false);
        static Button Button99 = new Button(false);
        static Button Button98 = new Button(false);
        static Button Button97 = new Button(false);
        static Button Button96 = new Button(false);
        static Button Button95 = new Button(false);
        static Button Button94 = new Button(false);
        static Button Button93 = new Button(false);
        static Button Button92 = new Button(false);
        static Button Button91 = new Button(false);
        List<Button> Buttons = new List<Button>
        { Button1,Button2,Button3,Button4,Button5,Button6,Button7,Button8,Button9,Button10,
          Button11,Button12,Button13,Button14,Button15,Button16,Button17,Button18,Button19,Button20,
          Button21,Button22,Button23,Button24,Button25,Button26,Button27,Button28,Button29,Button30,
          Button31,Button32,Button33,Button34,Button35,Button36,Button37,Button38,Button39,Button40,
          Button41,Button42,Button43,Button44,Button45,Button46,Button47,Button48,Button49,Button50,
          Button51,Button52,Button53,Button54,Button55,Button56,Button57,Button58,Button59,Button60,
          Button61,Button62,Button63,Button64,Button65,Button66,Button67,Button68,Button69,Button70,
          Button71,Button72,Button73,Button74,Button75,Button76,Button77,Button78,Button79,Button80,
          Button81,Button82,Button83,Button84,Button85,Button86,Button87,Button88,Button89,Button90,
          Button91,Button92,Button93,Button94,Button95,Button96,Button97,Button98,Button99,Button100
        };
        public Game()
        {
            InitializeComponent();
            foreach (var item in Buttons)
            {
                item.IsAlive = true;
                item.IsActive = false;
            }
            //инициализация всех кнопок
            Button10.Name = button10;
            Button9.Name = button9;
            Button8.Name = button8;
            Button7.Name = button7;
            Button6.Name = button6;
            Button5.Name = button5;
            Button4.Name = button4;
            Button3.Name = button3;
            Button2.Name = button2;
            Button1.Name = button1;
            //2 строка
            Button20.Name = button20;
            Button19.Name = button19;
            Button18.Name = button18;
            Button17.Name = button17;
            Button16.Name = button16;
            Button15.Name = button15;
            Button14.Name = button14;
            Button13.Name = button13;
            Button12.Name = button12;
            Button11.Name = button11;
            //3 строка
            Button30.Name = button30;
            Button29.Name = button29;
            Button28.Name = button28;
            Button27.Name = button27;
            Button26.Name = button26;
            Button25.Name = button25;
            Button24.Name = button24;
            Button23.Name = button23;
            Button22.Name = button22;
            Button21.Name = button21;
            //4 строка
            Button40.Name = button40;
            Button39.Name = button39;
            Button38.Name = button38;
            Button37.Name = button37;
            Button36.Name = button36;
            Button35.Name = button35;
            Button34.Name = button34;
            Button33.Name = button33;
            Button32.Name = button32;
            Button31.Name = button31;
            //5 строка
            Button50.Name = button50;
            Button49.Name = button49;
            Button48.Name = button48;
            Button47.Name = button47;
            Button46.Name = button46;
            Button45.Name = button45;
            Button44.Name = button44;
            Button43.Name = button43;
            Button42.Name = button42;
            Button41.Name = button41;
            //6 строка
            Button60.Name = button60;
            Button59.Name = button59;
            Button58.Name = button58;
            Button57.Name = button57;
            Button56.Name = button56;
            Button55.Name = button55;
            Button54.Name = button54;
            Button53.Name = button53;
            Button52.Name = button52;
            Button51.Name = button51;
            //7 строка
            Button70.Name = button70;
            Button69.Name = button69;
            Button68.Name = button68;
            Button67.Name = button67;
            Button66.Name = button66;
            Button65.Name = button65;
            Button64.Name = button64;
            Button63.Name = button63;
            Button62.Name = button62;
            Button61.Name = button61;
            //8 строка
            Button80.Name = button80;
            Button79.Name = button79;
            Button78.Name = button78;
            Button77.Name = button77;
            Button76.Name = button76;
            Button75.Name = button75;
            Button74.Name = button74;
            Button73.Name = button73;
            Button72.Name = button72;
            Button71.Name = button71;
            //9 строка
            Button90.Name = button90;
            Button89.Name = button89;
            Button88.Name = button88;
            Button87.Name = button87;
            Button86.Name = button86;
            Button85.Name = button85;
            Button84.Name = button84;
            Button83.Name = button83;
            Button82.Name = button82;
            Button81.Name = button81;
            //10 строка
            Button100.Name = button100;
            Button99.Name = button99;
            Button98.Name = button98;
            Button97.Name = button97;
            Button96.Name = button96;
            Button95.Name = button95;
            Button94.Name = button94;
            Button93.Name = button93;
            Button92.Name = button92;
            Button91.Name = button91;
            //наполнение ближайшего окружения кнопок 
            //строка 1
            Button10.Right = Button9;
            Button9.Right = Button8;
            Button8.Right = Button7;
            Button7.Right = Button6;
            Button6.Right = Button5;
            Button5.Right = Button4;
            Button4.Right = Button3;
            Button3.Right = Button2;
            Button2.Right = Button1;
            Button9.Left = Button10;
            Button8.Left = Button9;
            Button7.Left = Button8;
            Button6.Left = Button7;
            Button5.Left = Button6;
            Button4.Left = Button5;
            Button3.Left = Button4;
            Button2.Left = Button3;
            Button1.Left = Button2;
            Button10.Bottom = Button20;
            Button9.Bottom = Button19;
            Button8.Bottom = Button18;
            Button7.Bottom = Button17;
            Button6.Bottom = Button16;
            Button5.Bottom = Button15;
            Button4.Bottom = Button14;
            Button3.Bottom = Button13;
            Button2.Bottom = Button12;
            Button1.Bottom = Button11;
            Button10.BottomRight = Button19;
            Button9.BottomRight = Button18;
            Button8.BottomRight = Button17;
            Button7.BottomRight = Button16;
            Button6.BottomRight = Button15;
            Button5.BottomRight = Button14;
            Button4.BottomRight = Button13;
            Button3.BottomRight = Button12;
            Button2.BottomRight = Button11;
            Button9.BottomLeft = Button20;
            Button8.BottomLeft = Button19;
            Button7.BottomLeft = Button18;
            Button6.BottomLeft = Button17;
            Button5.BottomLeft = Button16;
            Button4.BottomLeft = Button15;
            Button3.BottomLeft = Button14;
            Button2.BottomLeft = Button13;
            Button1.BottomLeft = Button12;
            //2 строка
            Button20.Right = Button19;
            Button19.Right = Button18;
            Button18.Right = Button17;
            Button17.Right = Button16;
            Button16.Right = Button15;
            Button15.Right = Button14;
            Button14.Right = Button13;
            Button13.Right = Button12;
            Button12.Right = Button11;
            Button19.Left = Button20;
            Button18.Left = Button19;
            Button17.Left = Button18;
            Button16.Left = Button17;
            Button15.Left = Button16;
            Button14.Left = Button15;
            Button13.Left = Button14;
            Button12.Left = Button13;
            Button11.Left = Button12;
            Button20.Bottom = Button30;
            Button19.Bottom = Button29;
            Button18.Bottom = Button28;
            Button17.Bottom = Button27;
            Button16.Bottom = Button26;
            Button15.Bottom = Button25;
            Button14.Bottom = Button24;
            Button13.Bottom = Button23;
            Button12.Bottom = Button22;
            Button11.Bottom = Button21;
            Button20.Top = Button10;
            Button19.Top = Button9;
            Button18.Top = Button8;
            Button17.Top = Button7;
            Button16.Top = Button6;
            Button15.Top = Button5;
            Button14.Top = Button4;
            Button13.Top = Button3;
            Button12.Top = Button2;
            Button11.Top = Button1;
            Button19.TopLeft = Button10;
            Button18.TopLeft = Button9;
            Button17.TopLeft = Button8;
            Button16.TopLeft = Button7;
            Button15.TopLeft = Button6;
            Button14.TopLeft = Button5;
            Button13.TopLeft = Button4;
            Button12.TopLeft = Button3;
            Button11.TopLeft = Button2;
            Button20.TopRight = Button9;
            Button19.TopRight = Button8;
            Button18.TopRight = Button7;
            Button17.TopRight = Button6;
            Button16.TopRight = Button5;
            Button15.TopRight = Button4;
            Button14.TopRight = Button3;
            Button13.TopRight = Button2;
            Button12.TopRight = Button1;
            Button20.BottomRight = Button29;
            Button19.BottomRight = Button28;
            Button18.BottomRight = Button27;
            Button17.BottomRight = Button26;
            Button16.BottomRight = Button25;
            Button15.BottomRight = Button24;
            Button14.BottomRight = Button23;
            Button13.BottomRight = Button22;
            Button12.BottomRight = Button21;
            Button19.BottomLeft = Button30;
            Button18.BottomLeft = Button29;
            Button17.BottomLeft = Button28;
            Button16.BottomLeft = Button27;
            Button15.BottomLeft = Button26;
            Button14.BottomLeft = Button25;
            Button13.BottomLeft = Button24;
            Button12.BottomLeft = Button23;
            Button11.BottomLeft = Button22;
            //3 строка
            Button30.Right = Button29;
            Button29.Right = Button28;
            Button28.Right = Button27;
            Button27.Right = Button26;
            Button26.Right = Button25;
            Button25.Right = Button24;
            Button24.Right = Button23;
            Button23.Right = Button22;
            Button22.Right = Button21;
            Button29.Left = Button30;
            Button28.Left = Button29;
            Button27.Left = Button28;
            Button26.Left = Button27;
            Button25.Left = Button26;
            Button24.Left = Button25;
            Button23.Left = Button24;
            Button22.Left = Button23;
            Button21.Left = Button22;
            Button30.Bottom = Button40;
            Button29.Bottom = Button39;
            Button28.Bottom = Button38;
            Button27.Bottom = Button37;
            Button26.Bottom = Button36;
            Button25.Bottom = Button35;
            Button24.Bottom = Button34;
            Button23.Bottom = Button33;
            Button22.Bottom = Button32;
            Button21.Bottom = Button31;
            Button30.Top = Button20;
            Button29.Top = Button19;
            Button28.Top = Button18;
            Button27.Top = Button17;
            Button26.Top = Button16;
            Button25.Top = Button15;
            Button24.Top = Button14;
            Button23.Top = Button13;
            Button22.Top = Button12;
            Button21.Top = Button11;
            Button29.TopLeft = Button20;
            Button28.TopLeft = Button19;
            Button27.TopLeft = Button18;
            Button26.TopLeft = Button17;
            Button25.TopLeft = Button16;
            Button24.TopLeft = Button15;
            Button23.TopLeft = Button14;
            Button22.TopLeft = Button13;
            Button21.TopLeft = Button12;
            Button30.TopRight = Button19;
            Button29.TopRight = Button18;
            Button28.TopRight = Button17;
            Button27.TopRight = Button16;
            Button26.TopRight = Button15;
            Button25.TopRight = Button14;
            Button24.TopRight = Button13;
            Button23.TopRight = Button12;
            Button22.TopRight = Button11;
            Button30.BottomRight = Button39;
            Button29.BottomRight = Button38;
            Button28.BottomRight = Button37;
            Button27.BottomRight = Button36;
            Button26.BottomRight = Button35;
            Button25.BottomRight = Button34;
            Button24.BottomRight = Button33;
            Button23.BottomRight = Button32;
            Button22.BottomRight = Button31;
            Button29.BottomLeft = Button40;
            Button28.BottomLeft = Button39;
            Button27.BottomLeft = Button38;
            Button26.BottomLeft = Button37;
            Button25.BottomLeft = Button36;
            Button24.BottomLeft = Button35;
            Button23.BottomLeft = Button34;
            Button22.BottomLeft = Button33;
            Button21.BottomLeft = Button32;
            //4 строка
            Button40.Right = Button39;
            Button39.Right = Button38;
            Button38.Right = Button37;
            Button37.Right = Button36;
            Button36.Right = Button35;
            Button35.Right = Button34;
            Button34.Right = Button33;
            Button33.Right = Button32;
            Button32.Right = Button31;
            Button39.Left = Button40;
            Button38.Left = Button39;
            Button37.Left = Button38;
            Button36.Left = Button37;
            Button35.Left = Button36;
            Button34.Left = Button35;
            Button33.Left = Button34;
            Button32.Left = Button33;
            Button31.Left = Button32;
            Button40.Bottom = Button50;
            Button39.Bottom = Button49;
            Button38.Bottom = Button48;
            Button37.Bottom = Button47;
            Button36.Bottom = Button46;
            Button35.Bottom = Button45;
            Button34.Bottom = Button44;
            Button33.Bottom = Button43;
            Button32.Bottom = Button42;
            Button31.Bottom = Button41;
            Button40.Top = Button30;
            Button39.Top = Button29;
            Button38.Top = Button28;
            Button37.Top = Button27;
            Button36.Top = Button26;
            Button35.Top = Button25;
            Button34.Top = Button24;
            Button33.Top = Button23;
            Button32.Top = Button22;
            Button31.Top = Button21;
            Button39.TopLeft = Button30;
            Button38.TopLeft = Button29;
            Button37.TopLeft = Button28;
            Button36.TopLeft = Button27;
            Button35.TopLeft = Button26;
            Button34.TopLeft = Button25;
            Button33.TopLeft = Button24;
            Button32.TopLeft = Button23;
            Button31.TopLeft = Button22;
            Button40.TopRight = Button29;
            Button39.TopRight = Button28;
            Button38.TopRight = Button27;
            Button37.TopRight = Button26;
            Button36.TopRight = Button25;
            Button35.TopRight = Button24;
            Button34.TopRight = Button23;
            Button33.TopRight = Button22;
            Button32.TopRight = Button21;
            Button40.BottomRight = Button49;
            Button39.BottomRight = Button48;
            Button38.BottomRight = Button47;
            Button37.BottomRight = Button46;
            Button36.BottomRight = Button45;
            Button35.BottomRight = Button44;
            Button34.BottomRight = Button43;
            Button33.BottomRight = Button42;
            Button32.BottomRight = Button41;
            Button39.BottomLeft = Button50;
            Button38.BottomLeft = Button49;
            Button37.BottomLeft = Button48;
            Button36.BottomLeft = Button47;
            Button35.BottomLeft = Button46;
            Button34.BottomLeft = Button45;
            Button33.BottomLeft = Button44;
            Button32.BottomLeft = Button43;
            Button31.BottomLeft = Button42;
            //5 строка
            Button50.Right = Button49;
            Button49.Right = Button48;
            Button48.Right = Button47;
            Button47.Right = Button46;
            Button46.Right = Button45;
            Button45.Right = Button44;
            Button44.Right = Button43;
            Button43.Right = Button42;
            Button42.Right = Button41;
            Button49.Left = Button50;
            Button48.Left = Button49;
            Button47.Left = Button48;
            Button46.Left = Button47;
            Button45.Left = Button46;
            Button44.Left = Button45;
            Button43.Left = Button44;
            Button42.Left = Button43;
            Button41.Left = Button42;
            Button50.Bottom = Button50;
            Button49.Bottom = Button59;
            Button48.Bottom = Button58;
            Button47.Bottom = Button57;
            Button46.Bottom = Button56;
            Button45.Bottom = Button55;
            Button44.Bottom = Button54;
            Button43.Bottom = Button53;
            Button42.Bottom = Button52;
            Button41.Bottom = Button51;
            Button50.Top = Button40;
            Button49.Top = Button39;
            Button48.Top = Button38;
            Button47.Top = Button37;
            Button46.Top = Button36;
            Button45.Top = Button35;
            Button44.Top = Button34;
            Button43.Top = Button33;
            Button42.Top = Button32;
            Button41.Top = Button31;
            Button49.TopLeft = Button40;
            Button48.TopLeft = Button39;
            Button47.TopLeft = Button38;
            Button46.TopLeft = Button37;
            Button45.TopLeft = Button36;
            Button44.TopLeft = Button35;
            Button43.TopLeft = Button34;
            Button42.TopLeft = Button33;
            Button41.TopLeft = Button32;
            Button50.TopRight = Button39;
            Button49.TopRight = Button38;
            Button48.TopRight = Button37;
            Button47.TopRight = Button36;
            Button46.TopRight = Button35;
            Button45.TopRight = Button34;
            Button44.TopRight = Button33;
            Button43.TopRight = Button32;
            Button42.TopRight = Button31;
            Button50.BottomRight = Button59;
            Button49.BottomRight = Button58;
            Button48.BottomRight = Button57;
            Button47.BottomRight = Button56;
            Button46.BottomRight = Button55;
            Button45.BottomRight = Button54;
            Button44.BottomRight = Button53;
            Button43.BottomRight = Button52;
            Button42.BottomRight = Button51;
            Button49.BottomLeft = Button60;
            Button48.BottomLeft = Button59;
            Button47.BottomLeft = Button58;
            Button46.BottomLeft = Button57;
            Button45.BottomLeft = Button56;
            Button44.BottomLeft = Button55;
            Button43.BottomLeft = Button54;
            Button42.BottomLeft = Button53;
            Button41.BottomLeft = Button52;
            //6 строка
            Button60.Right = Button59;
            Button59.Right = Button58;
            Button58.Right = Button57;
            Button57.Right = Button56;
            Button56.Right = Button55;
            Button55.Right = Button54;
            Button54.Right = Button53;
            Button53.Right = Button52;
            Button52.Right = Button51;
            Button59.Left = Button60;
            Button58.Left = Button59;
            Button57.Left = Button58;
            Button56.Left = Button57;
            Button55.Left = Button56;
            Button54.Left = Button55;
            Button53.Left = Button54;
            Button52.Left = Button53;
            Button51.Left = Button52;
            Button60.Bottom = Button70;
            Button59.Bottom = Button69;
            Button58.Bottom = Button68;
            Button57.Bottom = Button67;
            Button56.Bottom = Button66;
            Button55.Bottom = Button65;
            Button54.Bottom = Button64;
            Button53.Bottom = Button63;
            Button52.Bottom = Button62;
            Button51.Bottom = Button61;
            Button60.Top = Button50;
            Button59.Top = Button49;
            Button58.Top = Button48;
            Button57.Top = Button47;
            Button56.Top = Button46;
            Button55.Top = Button45;
            Button54.Top = Button44;
            Button53.Top = Button43;
            Button52.Top = Button42;
            Button51.Top = Button41;
            Button59.TopLeft = Button50;
            Button58.TopLeft = Button49;
            Button57.TopLeft = Button48;
            Button56.TopLeft = Button47;
            Button55.TopLeft = Button46;
            Button54.TopLeft = Button45;
            Button53.TopLeft = Button44;
            Button52.TopLeft = Button43;
            Button51.TopLeft = Button42;
            Button60.TopRight = Button49;
            Button59.TopRight = Button48;
            Button58.TopRight = Button47;
            Button57.TopRight = Button46;
            Button56.TopRight = Button45;
            Button55.TopRight = Button44;
            Button54.TopRight = Button43;
            Button53.TopRight = Button42;
            Button52.TopRight = Button41;
            Button60.BottomRight = Button69;
            Button59.BottomRight = Button68;
            Button58.BottomRight = Button67;
            Button57.BottomRight = Button66;
            Button56.BottomRight = Button65;
            Button55.BottomRight = Button64;
            Button54.BottomRight = Button63;
            Button53.BottomRight = Button62;
            Button52.BottomRight = Button61;
            Button59.BottomLeft = Button70;
            Button58.BottomLeft = Button69;
            Button57.BottomLeft = Button68;
            Button56.BottomLeft = Button67;
            Button55.BottomLeft = Button66;
            Button54.BottomLeft = Button65;
            Button53.BottomLeft = Button64;
            Button52.BottomLeft = Button63;
            Button51.BottomLeft = Button62;
            //7 строка
            Button70.Right = Button69;
            Button69.Right = Button68;
            Button68.Right = Button67;
            Button67.Right = Button66;
            Button66.Right = Button65;
            Button65.Right = Button64;
            Button64.Right = Button63;
            Button63.Right = Button62;
            Button62.Right = Button61;
            Button69.Left = Button70;
            Button68.Left = Button69;
            Button67.Left = Button68;
            Button66.Left = Button67;
            Button65.Left = Button66;
            Button64.Left = Button65;
            Button63.Left = Button64;
            Button62.Left = Button63;
            Button61.Left = Button62;
            Button70.Bottom = Button80;
            Button69.Bottom = Button79;
            Button68.Bottom = Button78;
            Button67.Bottom = Button77;
            Button66.Bottom = Button76;
            Button65.Bottom = Button75;
            Button64.Bottom = Button74;
            Button63.Bottom = Button73;
            Button62.Bottom = Button72;
            Button61.Bottom = Button71;
            Button70.Top = Button60;
            Button69.Top = Button59;
            Button68.Top = Button58;
            Button67.Top = Button57;
            Button66.Top = Button56;
            Button65.Top = Button55;
            Button64.Top = Button54;
            Button63.Top = Button53;
            Button62.Top = Button52;
            Button61.Top = Button51;
            Button69.TopLeft = Button60;
            Button68.TopLeft = Button59;
            Button67.TopLeft = Button58;
            Button66.TopLeft = Button57;
            Button65.TopLeft = Button56;
            Button64.TopLeft = Button55;
            Button63.TopLeft = Button54;
            Button62.TopLeft = Button53;
            Button61.TopLeft = Button52;
            Button70.TopRight = Button59;
            Button69.TopRight = Button58;
            Button68.TopRight = Button57;
            Button67.TopRight = Button56;
            Button66.TopRight = Button55;
            Button65.TopRight = Button54;
            Button64.TopRight = Button53;
            Button63.TopRight = Button52;
            Button62.TopRight = Button51;
            Button70.BottomRight = Button79;
            Button69.BottomRight = Button78;
            Button68.BottomRight = Button77;
            Button67.BottomRight = Button76;
            Button66.BottomRight = Button75;
            Button65.BottomRight = Button74;
            Button64.BottomRight = Button73;
            Button63.BottomRight = Button72;
            Button62.BottomRight = Button71;
            Button69.BottomLeft = Button80;
            Button68.BottomLeft = Button79;
            Button67.BottomLeft = Button78;
            Button66.BottomLeft = Button77;
            Button65.BottomLeft = Button76;
            Button64.BottomLeft = Button75;
            Button63.BottomLeft = Button74;
            Button62.BottomLeft = Button73;
            Button61.BottomLeft = Button72;
            //8 строка
            Button80.Right = Button79;
            Button79.Right = Button78;
            Button78.Right = Button77;
            Button77.Right = Button76;
            Button76.Right = Button75;
            Button75.Right = Button74;
            Button74.Right = Button73;
            Button73.Right = Button72;
            Button72.Right = Button71;
            Button79.Left = Button80;
            Button78.Left = Button79;
            Button77.Left = Button78;
            Button76.Left = Button77;
            Button75.Left = Button76;
            Button74.Left = Button75;
            Button73.Left = Button74;
            Button72.Left = Button73;
            Button71.Left = Button72;
            Button80.Bottom = Button90;
            Button79.Bottom = Button89;
            Button78.Bottom = Button88;
            Button77.Bottom = Button87;
            Button76.Bottom = Button86;
            Button75.Bottom = Button85;
            Button74.Bottom = Button84;
            Button73.Bottom = Button83;
            Button72.Bottom = Button82;
            Button71.Bottom = Button81;
            Button80.Top = Button70;
            Button79.Top = Button69;
            Button78.Top = Button68;
            Button77.Top = Button67;
            Button76.Top = Button66;
            Button75.Top = Button65;
            Button74.Top = Button64;
            Button73.Top = Button63;
            Button72.Top = Button62;
            Button71.Top = Button61;
            Button79.TopLeft = Button70;
            Button78.TopLeft = Button69;
            Button77.TopLeft = Button68;
            Button76.TopLeft = Button67;
            Button75.TopLeft = Button66;
            Button74.TopLeft = Button65;
            Button73.TopLeft = Button64;
            Button72.TopLeft = Button63;
            Button71.TopLeft = Button62;
            Button80.TopRight = Button69;
            Button79.TopRight = Button68;
            Button78.TopRight = Button67;
            Button77.TopRight = Button66;
            Button76.TopRight = Button65;
            Button75.TopRight = Button64;
            Button74.TopRight = Button63;
            Button73.TopRight = Button62;
            Button72.TopRight = Button61;
            Button80.BottomRight = Button89;
            Button79.BottomRight = Button88;
            Button78.BottomRight = Button87;
            Button77.BottomRight = Button86;
            Button76.BottomRight = Button85;
            Button75.BottomRight = Button84;
            Button74.BottomRight = Button83;
            Button73.BottomRight = Button82;
            Button72.BottomRight = Button81;
            Button79.BottomLeft = Button90;
            Button78.BottomLeft = Button89;
            Button77.BottomLeft = Button88;
            Button76.BottomLeft = Button87;
            Button75.BottomLeft = Button86;
            Button74.BottomLeft = Button85;
            Button73.BottomLeft = Button84;
            Button72.BottomLeft = Button83;
            Button71.BottomLeft = Button82;
            //9 строка
            Button90.Right = Button89;
            Button89.Right = Button88;
            Button88.Right = Button87;
            Button87.Right = Button86;
            Button86.Right = Button85;
            Button85.Right = Button84;
            Button84.Right = Button83;
            Button83.Right = Button82;
            Button82.Right = Button81;
            Button89.Left = Button90;
            Button88.Left = Button89;
            Button87.Left = Button88;
            Button86.Left = Button87;
            Button85.Left = Button86;
            Button84.Left = Button85;
            Button83.Left = Button84;
            Button82.Left = Button83;
            Button81.Left = Button82;
            Button90.Bottom = Button100;
            Button89.Bottom = Button99;
            Button88.Bottom = Button98;
            Button87.Bottom = Button97;
            Button86.Bottom = Button96;
            Button85.Bottom = Button95;
            Button84.Bottom = Button94;
            Button83.Bottom = Button93;
            Button82.Bottom = Button92;
            Button81.Bottom = Button91;
            Button90.Top = Button80;
            Button89.Top = Button79;
            Button88.Top = Button78;
            Button87.Top = Button77;
            Button86.Top = Button76;
            Button85.Top = Button75;
            Button84.Top = Button74;
            Button83.Top = Button73;
            Button82.Top = Button72;
            Button81.Top = Button71;
            Button89.TopLeft = Button80;
            Button88.TopLeft = Button79;
            Button87.TopLeft = Button78;
            Button86.TopLeft = Button77;
            Button85.TopLeft = Button76;
            Button84.TopLeft = Button75;
            Button83.TopLeft = Button74;
            Button82.TopLeft = Button73;
            Button81.TopLeft = Button72;
            Button90.TopRight = Button79;
            Button89.TopRight = Button78;
            Button88.TopRight = Button77;
            Button87.TopRight = Button76;
            Button86.TopRight = Button75;
            Button85.TopRight = Button74;
            Button84.TopRight = Button73;
            Button83.TopRight = Button72;
            Button82.TopRight = Button71;
            Button90.BottomRight = Button99;
            Button89.BottomRight = Button98;
            Button88.BottomRight = Button97;
            Button87.BottomRight = Button96;
            Button86.BottomRight = Button95;
            Button85.BottomRight = Button94;
            Button84.BottomRight = Button93;
            Button83.BottomRight = Button92;
            Button82.BottomRight = Button91;
            Button89.BottomLeft = Button100;
            Button88.BottomLeft = Button99;
            Button87.BottomLeft = Button98;
            Button86.BottomLeft = Button97;
            Button85.BottomLeft = Button96;
            Button84.BottomLeft = Button95;
            Button83.BottomLeft = Button94;
            Button82.BottomLeft = Button93;
            Button81.BottomLeft = Button92;
            //10 строка
            Button100.Right = Button99;
            Button99.Right = Button98;
            Button98.Right = Button97;
            Button97.Right = Button96;
            Button96.Right = Button95;
            Button95.Right = Button94;
            Button94.Right = Button93;
            Button93.Right = Button92;
            Button92.Right = Button91;
            Button99.Left = Button100;
            Button98.Left = Button99;
            Button97.Left = Button98;
            Button96.Left = Button97;
            Button95.Left = Button96;
            Button94.Left = Button95;
            Button93.Left = Button94;
            Button92.Left = Button93;
            Button91.Left = Button92;
            Button100.Top = Button90;
            Button99.Top = Button89;
            Button98.Top = Button88;
            Button97.Top = Button87;
            Button96.Top = Button86;
            Button95.Top = Button85;
            Button94.Top = Button84;
            Button93.Top = Button83;
            Button92.Top = Button82;
            Button91.Top = Button81;
            Button99.TopLeft = Button90;
            Button98.TopLeft = Button89;
            Button97.TopLeft = Button88;
            Button96.TopLeft = Button87;
            Button95.TopLeft = Button86;
            Button94.TopLeft = Button85;
            Button93.TopLeft = Button84;
            Button92.TopLeft = Button83;
            Button91.TopLeft = Button82;
            Button100.TopRight = Button89;
            Button99.TopRight = Button88;
            Button98.TopRight = Button87;
            Button97.TopRight = Button86;
            Button96.TopRight = Button85;
            Button95.TopRight = Button84;
            Button94.TopRight = Button83;
            Button93.TopRight = Button82;
            Button92.TopRight = Button81;
            label2.Text = "Игрок 1";
            this.WindowState = FormWindowState.Maximized;
            Move(Button10, playerOne, playerTwo);
            Round(playerOne, playerTwo);
            Move(Button91, playerTwo, playerOne);

        }
        public void Move(Button btn, Player player, Player playerPending)
        {
            //инициализация изображения и активация кнопки
            try
            {
                btn.Name.BackgroundImage = Image.FromFile(player.Img);
                btn.Name.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch
            {
                btn.Name.BackColor = Color.FromArgb(player.RGB[0], player.RGB[1], player.RGB[2]);
            }
            player.Step += 1;
            if ((playerOne.checkButton(btn) && player.Name == "Two") || (playerTwo.checkButton(btn) && player.Name == "One"))
            {
                btn.IsAlive = false;
                if (player.Name == "Two")
                {
                    playerOne.ActiveBtn.RemoveAt(playerOne.ActiveBtn.IndexOf(btn));
                }
                if (player.Name == "One")
                {
                    playerTwo.ActiveBtn.RemoveAt(playerTwo.ActiveBtn.IndexOf(btn));
                }
                try
                {
                    btn.Name.BackgroundImage = Image.FromFile(player.DeadImg);
                    btn.Name.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {
                    btn.Name.BackColor = Color.FromArgb(player.RGB[0], player.RGB[1], player.RGB[2]);
                }
            }
            player.ActiveBtn.Add(btn);
            btn.IsActive = true;
                        
            if (player.Name == "One")
            {
                btn.isDisabledPlayer1 = true;
                btn.isDisabledPlayer2 = false;
            }
            if (player.Name == "Two")
            {
                btn.isDisabledPlayer1 = false;
                btn.isDisabledPlayer2 = true;
            }
        }
        public void Round(Player playerOne, Player playerTwo)
        {
            int[] color = new int[3] { 93, 141, 20 };
            foreach (var item in Buttons)
            {
                item.Name.Enabled = false;
                item.Name.BackColor = Color.FromArgb(14, 52, 89);
            }
            if (playerOne.Step < 3)
            {
                List<Button> DeadActiveBtn = new List<Button>();

                foreach (var item in playerOne.ActiveBtn)
                {
                    if (item.IsAlive)
                    {
                        activateButton(item, color);
                    }
                    else
                    {
                        if (item.Top != null)
                        {
                            if (item.Top.IsAlive && playerOne.ActiveBtn.Contains(item.Top))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.Bottom != null)
                        {
                            if
                            (item.Bottom.IsAlive && playerOne.ActiveBtn.Contains(item.Bottom))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.Left != null)
                        {
                            if (item.Left.IsAlive && playerOne.ActiveBtn.Contains(item.Left))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.Right != null)
                        {
                            if
                            (item.Right.IsAlive && playerOne.ActiveBtn.Contains(item.Right))

                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.TopLeft != null)
                        {
                            if (item.TopLeft.IsAlive && playerOne.ActiveBtn.Contains(item.TopLeft))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.BottomRight != null)
                        {
                            if
                            (item.BottomRight.IsAlive && playerOne.ActiveBtn.Contains(item.BottomRight))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.BottomLeft != null)
                        {
                            if (item.BottomLeft.IsAlive && playerOne.ActiveBtn.Contains(item.BottomLeft))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.TopRight != null)
                        {
                            if
                            (item.TopRight.IsAlive && playerOne.ActiveBtn.Contains(item.TopRight))

                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }

                    }
                }
                for (int i = 0; i < DeadActiveBtn.Count; i++)
                {
                    checkAndActiveDeadBtn(DeadActiveBtn[i], playerOne, color, DeadActiveBtn);

                }
                foreach (var item in playerTwo.ActiveBtn)
                {
                    if (item.IsAlive)
                    {
                        if (playerOne.checkButtonAnoutherPlayer(item))
                        {
                            item.Name.Enabled = true;
                            item.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);
                        }
                    }

                }
                foreach (var item in playerOne.ActiveBtn)
                {
                    item.Name.Enabled = false;
                    item.Name.BackColor = Color.FromArgb(14, 52, 89);
                }
                int activeMoveCount = 0;
                for (int i = 0; i < Buttons.Count; i++)
                {
                    if (Buttons[i].Name.Enabled)
                    {
                        activeMoveCount++;
                    }
                }
                if (activeMoveCount==0)
                {
                    EndGame winTask = new EndGame("Игрок 2");
                    winTask.ShowDialog();
                }

            }
            else if (playerTwo.Step < 3)
            {
                List<Button> DeadActiveBtn = new List<Button>();
                foreach (var item in playerTwo.ActiveBtn)
                {
                    if (item.IsAlive)
                    {
                        activateButton(item, color);
                    }
                    else
                    {
                        if (item.Top != null)
                        {
                            if (item.Top.IsAlive && playerTwo.ActiveBtn.Contains(item.Top))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.Bottom != null)
                        {
                            if
                            (item.Bottom.IsAlive && playerTwo.ActiveBtn.Contains(item.Bottom))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.Left != null)
                        {
                            if (item.Left.IsAlive && playerTwo.ActiveBtn.Contains(item.Left))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.Right != null)
                        {
                            if
                            (item.Right.IsAlive && playerTwo.ActiveBtn.Contains(item.Right))

                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.TopLeft != null)
                        {
                            if (item.TopLeft.IsAlive && playerTwo.ActiveBtn.Contains(item.TopLeft))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.BottomRight != null)
                        {
                            if
                            (item.BottomRight.IsAlive && playerTwo.ActiveBtn.Contains(item.BottomRight))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.BottomLeft != null)
                        {
                            if (item.BottomLeft.IsAlive && playerTwo.ActiveBtn.Contains(item.BottomLeft))
                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                        if (item.TopRight != null)
                        {
                            if
                            (item.TopRight.IsAlive && playerTwo.ActiveBtn.Contains(item.TopRight))

                            {
                                activateButton(item, color);
                                DeadActiveBtn.Add(item);

                            }
                        }
                    }

                }
                for (int i = 0; i < DeadActiveBtn.Count; i++)
                {
                    checkAndActiveDeadBtn(DeadActiveBtn[i], playerTwo, color, DeadActiveBtn);

                }

                foreach (var item in playerTwo.ActiveBtn)
                {
                    item.Name.Enabled = false;
                    item.Name.BackColor = Color.FromArgb(14, 52, 89);
                }
                foreach (var item in playerOne.ActiveBtn)
                {
                    if (item.IsAlive)
                    {
                        if (playerTwo.checkButtonAnoutherPlayer(item))
                        {
                            item.Name.Enabled = true;
                            item.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);
                        }
                    }

                }
                int activeMoveCount = 0;
                for (int i = 0; i < Buttons.Count; i++)
                {
                    if (Buttons[i].Name.Enabled)
                    {
                        activeMoveCount++;
                    }
                }
                if (activeMoveCount == 0)
                {
                    EndGame winTask = new EndGame("Игрок 1");
                    winTask.ShowDialog();
                }
            }
            else
            {
                playerOne.Step = 0;
                playerTwo.Step = 0;
                Round(playerOne, playerTwo);
            }
            foreach (var item in Buttons)
            {
                if (!item.IsAlive)
                {
                    item.Name.Enabled = false;
                    item.Name.BackColor = Color.FromArgb(14, 52, 89);
                }
            }
        }
        public void activateButton(Button item, int[] color)
        {
            if (item.Top != null)
            {
                item.Top.Name.Enabled = true;
                item.Top.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);
            }
            if (item.Bottom != null)
            {
                item.Bottom.Name.Enabled = true;
                item.Bottom.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);
            }
            if (item.Left != null)
            {
                item.Left.Name.Enabled = true;
                item.Left.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);
            }
            if (item.Right != null)
            {
                item.Right.Name.Enabled = true;
                item.Right.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);
            }
            if (item.TopLeft != null)
            {
                item.TopLeft.Name.Enabled = true;
                item.TopLeft.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);
            }
            if (item.BottomLeft != null)
            {
                item.BottomLeft.Name.Enabled = true;
                item.BottomLeft.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);

            }
            if (item.TopRight != null)
            {
                item.TopRight.Name.Enabled = true;
                item.TopRight.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);

            }
            if (item.BottomRight != null)
            {
                item.BottomRight.Name.Enabled = true;
                item.BottomRight.Name.BackColor = Color.FromArgb(color[0], color[1], color[2]);

            }
        }
        public void checkPlayer(Button btn)
        {
            if (playerOne.Step < 3)
            {
                Move(btn, playerOne, playerTwo);
            }
            else if (playerTwo.Step < 3)
            {
                Move(btn, playerTwo, playerOne);

            }
            if (playerOne.Step < 3 || playerTwo.Step == 3)
            {
                label2.Text = "Игрок 1";
            }
            else if (playerOne.Step == 3)
            {
                label2.Text = "Игрок 2";
            }
            Round(playerOne, playerTwo);
        }

        public void checkAndActiveDeadBtn(Button item, Player player, int[] color, List<Button> DeadActiveBtn)
        {
            if (item.Top != null)
            {
                if (player.checkDaedVirus(item.Top) && !DeadActiveBtn.Contains(item.Top))
                {
                    activateButton(item.Top, color);
                    DeadActiveBtn.Add(item.Top);
                }
            }
            if (item.Bottom != null)
            {
                if (player.checkDaedVirus(item.Bottom) && !DeadActiveBtn.Contains(item.Bottom))
                {
                    activateButton(item.Bottom, color);
                    DeadActiveBtn.Add(item.Bottom);

                }
            }
            if (item.Right != null)
            {
                if (player.checkDaedVirus(item.Right) && !DeadActiveBtn.Contains(item.Right))
                {
                    activateButton(item.Right, color);
                    DeadActiveBtn.Add(item.Right);

                }
            }
            if (item.Left != null)
            {
                if (player.checkDaedVirus(item.Left) && !DeadActiveBtn.Contains(item.Left))
                {
                    activateButton(item.Left, color);
                    DeadActiveBtn.Add(item.Left);

                }
            }
            if (item.BottomLeft != null)
            {
                if (player.checkDaedVirus(item.BottomLeft) && !DeadActiveBtn.Contains(item.BottomLeft))
                {
                    activateButton(item.BottomLeft, color);
                    DeadActiveBtn.Add(item.BottomLeft);

                }
            }
            if (item.BottomRight != null)
            {
                if (player.checkDaedVirus(item.BottomRight) && !DeadActiveBtn.Contains(item.BottomRight))
                {
                    activateButton(item.BottomRight, color);
                    DeadActiveBtn.Add(item.BottomRight);

                }
            }
            if (item.TopLeft != null)
            {
                if (player.checkDaedVirus(item.TopLeft) && !DeadActiveBtn.Contains(item.TopLeft))
                {
                    activateButton(item.TopLeft, color);
                    DeadActiveBtn.Add(item.TopLeft);

                }
            }
            if (item.TopRight != null)
            {
                if (player.checkDaedVirus(item.TopRight) && !DeadActiveBtn.Contains(item.TopRight))
                {
                    activateButton(item.TopRight, color);
                    DeadActiveBtn.Add(item.TopRight);

                }
            }

        }
        private void button55_Click(object sender, EventArgs e)
        {
            checkPlayer(Button55);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            checkPlayer(Button61);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            checkPlayer(Button31);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkPlayer(Button15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            checkPlayer(Button14);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkPlayer(Button11);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            checkPlayer(Button71);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            checkPlayer(Button20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkPlayer(Button3);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            checkPlayer(Button81);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            checkPlayer(Button41);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkPlayer(Button12);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkPlayer(Button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkPlayer(Button8);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            checkPlayer(Button16);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkPlayer(Button4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkPlayer(Button6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkPlayer(Button9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkPlayer(Button5);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkPlayer(Button13);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            checkPlayer(Button92);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            checkPlayer(Button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            checkPlayer(Button19);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkPlayer(Button2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkPlayer(Button1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            checkPlayer(Button21);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            checkPlayer(Button51);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            checkPlayer(Button17);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            checkPlayer(Button93);
        }

        private void button83_Click(object sender, EventArgs e)
        {
            checkPlayer(Button83);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            checkPlayer(Button73);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            checkPlayer(Button63);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            checkPlayer(Button23);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            checkPlayer(Button33);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            checkPlayer(Button43);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            checkPlayer(Button53);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            checkPlayer(Button22);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            checkPlayer(Button32);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            checkPlayer(Button42);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            checkPlayer(Button52);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            checkPlayer(Button62);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            checkPlayer(Button72);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            checkPlayer(Button82);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            checkPlayer(Button95);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            checkPlayer(Button96);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            checkPlayer(Button97);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            checkPlayer(Button98);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            checkPlayer(Button99);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            checkPlayer(Button100);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            checkPlayer(Button90);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            checkPlayer(Button80);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            checkPlayer(Button70);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            checkPlayer(Button60);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            checkPlayer(Button50);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            checkPlayer(Button40);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            checkPlayer(Button30);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            checkPlayer(Button29);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            checkPlayer(Button39);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            checkPlayer(Button49);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            checkPlayer(Button59);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            checkPlayer(Button69);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            checkPlayer(Button79);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            checkPlayer(Button89);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            checkPlayer(Button88);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            checkPlayer(Button87);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            checkPlayer(Button86);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            checkPlayer(Button85);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            checkPlayer(Button94);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            checkPlayer(Button74);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            checkPlayer(Button75);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            checkPlayer(Button76);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            checkPlayer(Button77);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            checkPlayer(Button78);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            checkPlayer(Button68);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            checkPlayer(Button67);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            checkPlayer(Button66);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            checkPlayer(Button65);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            checkPlayer(Button64);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            checkPlayer(Button54);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            checkPlayer(Button44);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            checkPlayer(Button34);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            checkPlayer(Button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            checkPlayer(Button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            checkPlayer(Button26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            checkPlayer(Button27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            checkPlayer(Button28);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            checkPlayer(Button38);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            checkPlayer(Button48);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            checkPlayer(Button58);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            checkPlayer(Button57);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            checkPlayer(Button47);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            checkPlayer(Button37);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            checkPlayer(Button36);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            checkPlayer(Button46);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            checkPlayer(Button56);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            checkPlayer(Button84);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            checkPlayer(Button45);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            checkPlayer(Button35);
        }

    }
}
