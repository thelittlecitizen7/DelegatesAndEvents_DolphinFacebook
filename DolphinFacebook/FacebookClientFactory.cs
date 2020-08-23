using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    public class FacebookClientFactory : IFacebookClientFactory
    {
        
        public IFacebookClient CreateClient(IDisplay display)
        {
            return new DolphinsFacebookClient(display);
            /*if (display.GetType() == typeof(DisplayWallPost)) {
                return new DolphinsFacebookClient(display);
            }
            return null;*/
        }
    }
}
