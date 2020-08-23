using DolphinFacebook.Displayes;
using MamaFacebook.Abstract;
using System;

namespace DolphinFacebook
{
    class Program
    {
        static void Main(string[] args)
        {
            IFacebookClientFactory facebookClientFactory = new FacebookClientFactory();
            IDisplay consoleDispaler = new DisplayWallPost();
            IDisplay consoleDispaler2 = new DisplayWallPost2();
            IDisplay consoleDispaler3 = new DisplayWallPost3();
            IFacebookClient dolphinsFacebookClient = facebookClientFactory.CreateClient(consoleDispaler);

            IFacebookClient dolphinsFacebookClient2 = facebookClientFactory.CreateClient(consoleDispaler2);
            IFacebookClient dolphinsFacebookClient3 = facebookClientFactory.CreateClient(consoleDispaler3);

            dolphinsFacebookClient2.Subscribe(dolphinsFacebookClient);
            dolphinsFacebookClient3.Subscribe(dolphinsFacebookClient);

            dolphinsFacebookClient.WriteNewWallPost("Hey from here");
            Console.WriteLine("-----------------------------------------------");

            dolphinsFacebookClient2.Unsubscribe(dolphinsFacebookClient);
            dolphinsFacebookClient3.Unsubscribe(dolphinsFacebookClient);
            dolphinsFacebookClient.WriteNewWallPost("aftre change");
            
        }
    }
}
