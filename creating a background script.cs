using UnityEngine;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            //tell the game that a component of this type should be created in the background
            ModAPI.Register<CoolBackgroundScriptTime>();
        }
    }

    //define a behaviour that will run in the background
    //it will be attached to an otherwise empty gameobject floating in the scene, created when the catalog is first populated
    public class CoolBackgroundScriptTime : MonoBehaviour
    {
        //treat it like any other component
        void Update()
        {
            if (Input.GetKey(KeyCode.P))
                ModAPI.Notify("gamer is holding the P key");
        }
    }
}
