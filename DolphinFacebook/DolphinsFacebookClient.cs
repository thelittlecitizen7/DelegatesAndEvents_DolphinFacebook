using MamaFacebook.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DolphinFacebook
{
    public class DolphinsFacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;
        public string Name = "lior";

        private IDisplay _displayer { get; set; }

        public DolphinsFacebookClient(IDisplay displayer)
        {
            _displayer = displayer;
        }

        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += _displayer.DisplayWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= _displayer.DisplayWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            _displayer.DisplayWallPost(wallPost);
            NewWallPost?.Invoke(wallPost);
        }
    }
}
