using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RandomPartExplosion
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class RPExplode : MonoBehaviour
    {
        public void Startup()
        {
            Debug.Log("[RPE] Start!");
        }
        public void Update()
        {
            bool keyPressed = Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Alpha4);
            if (keyPressed)
            {
                List<Part> parts = FlightGlobals.ActiveVessel.Parts;
                int index;
                System.Random rnd = new System.Random();
                Debug.Log($"[RPE] Kaboom, part count: {parts.Count}");
                index = rnd.Next(1, parts.Count);
                parts[index].explode();
            }
            
            keyPressed = Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Alpha5);
            if (keyPressed)
            {
                Debug.Log("[RPE] SelfDestruct");
                List<Part> parts = FlightGlobals.ActiveVessel.Parts;
                for (int x = parts.Count - 1; x >= 0; x--) // This actually looks like a single explosion
                {
                    parts[x].explode();
                }
            }
        }
    }
}
