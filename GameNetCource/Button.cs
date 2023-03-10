using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNetCource
{
    public class Button
    {
        public string Name { get; set; } = "";
        public bool IsActive { get; set; } = false;
        public Button Top { get; set; } = null;
        public Button Right { get; set; } = null;
        public Button Left { get; set; } = null;
        public Button Bottom { get; set; } = null;
        public Button TopRight { get; set; } = null;
        public Button TopLeft { get; set; } = null;
        public Button BottomRight { get; set; } = null;
        public Button BottomLeft { get; set; } = null;
        public Player Player { get; set; } = null;
        public Button(string name) 
        {
            Name = name;
        }
        public Button(bool isActive)
        {
            IsActive = isActive;
        }
        public Button(Player player)
        {
            Player = player;
        }
        public Button(Button top)
        {
            Top =top;
        } 
        public Button(Button top, Button bottom)
        {
            Top =top;
            Bottom = bottom;
        } 
        public Button(Button top, Button bottom, Button right)
        {
            Top =top;
            Bottom = bottom;
            Right = right;
        }
        public Button(Button top, Button bottom, Button right, Button left)
        {
            Top = top;
            Bottom = bottom;
            Right = right;
            Left = left;
        }
        public Button(Button top, Button bottom, Button right, Button left, Button topRight)
        {
            Top = top;
            Bottom = bottom;
            Right = right;
            Left = left;
            TopRight = topRight;
        }
        public Button(Button top, Button bottom, Button right, Button left, Button topRight, Button topLeft)
        {
            Top = top;
            Bottom = bottom;
            Right = right;
            Left = left;
            TopRight = topRight;
            TopLeft = topLeft;
        }
        public Button(Button top, Button bottom, Button right, Button left, Button topRight, Button topLeft, Button bottomRight)
        {
            Top = top;
            Bottom = bottom;
            Right = right;
            Left = left;
            TopRight = topRight;
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public Button(Button top, Button bottom, Button right, Button left, Button topRight, Button topLeft, Button bottomRight, Button bottomLeft)
        {
            Top = top;
            Bottom = bottom;
            Right = right;
            Left = left;
            TopRight = topRight;
            TopLeft = topLeft;
            BottomRight = bottomRight;
            BottomLeft = bottomLeft;
        }
    }
}
