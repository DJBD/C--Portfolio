using System;
using System.Collections.Generic;

namespace Flyweight
{
    public static class PlatformFactory
    {
        
        private static Dictionary<String, IPlatform> Platforms = new Dictionary<String,IPlatform>();
        
        public static IPlatform PlatformInstance(string name)
        {
            if (Platforms.ContainsKey(name))
                return Platforms[name];

            switch (name)
            {
                case "C" :
                    IPlatform C = new CPlatform();
                    Platforms.Add(name, C);
                    return C;
                case "SCALA" :
                    IPlatform S = new ScalaPlatform();
                    Platforms.Add(name, S);
                    return S;
                case "JAVA" :
                    IPlatform J = new JavaPlatform();
                    Platforms.Add(name, J);
                    return J;
                case "RUBY" :
                    IPlatform R = new RubyPlatform();
                    Platforms.Add(name, R);
                    return R;
            }

            return null;

        }
    }


}