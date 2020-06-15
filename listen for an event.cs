using UnityEngine;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            // listen for the event that is fired when wires are created
            ModAPI.OnWireCreated += (sender, wire) => {
                // check if it is a spring cable
                if (wire is SpringCableBehaviour)
                {
                    // make it red
                    wire.SetColor(Color.red);
                    // make it thinner
                    wire.SetThickness(0.5f);
                }
            };
        }
    }
}
