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
            bool key = Input.GetKey(KeyCode.RightAlt) && Input.GetKey(KeyCode.Alpha0);
            if (!key) return;

            List<Part> parts = FlightGlobals.ActiveVessel.Parts;
            int index;
            System.Random rnd = new System.Random();
            index = rnd.Next(1, parts.Count);
            parts[index].explode();
        }
    }
}
