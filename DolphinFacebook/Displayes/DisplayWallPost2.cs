using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook.Displayes
{
    public class DisplayWallPost2 : IDisplay
    {
        void IDisplay.DisplayWallPost(string wallPost)
        {
            Console.WriteLine($"Post 2 : {wallPost}");
        }
    }
}
