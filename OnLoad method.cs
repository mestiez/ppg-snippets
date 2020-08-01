using UnityEngine;

namespace Mod
{
    public class Mod
    {
        //Optionally, you may want to do some stuff right after every mod is loaded
        public static void OnLoad()
        {
            UnityEngine.Debug.Log("Haha");
        }

        //Mods require one of these
        public static void Main()
        {
            
        }
    }
}
