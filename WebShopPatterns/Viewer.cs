using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopPatterns
{
    class Viewer : User
    {
        private static readonly Lazy<Viewer> viewer = new Lazy<Viewer>(() => new Viewer());

        public static Viewer Instance { get { return viewer.Value; } }

        private Viewer() : base("Viewer")
        {

        }

        // Null Object does nothing
        public override void Order()
        {

        }
    }
}
