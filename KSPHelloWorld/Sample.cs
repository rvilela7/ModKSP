using System;
using UnityEngine;

namespace HelloWorld
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    public class Hello : MonoBehaviour
    {
        public void Update()
        {
            Debug.Log("Hello world! " + Time.realtimeSinceStartup);
        }
    }

    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class MyKSPAddon : MonoBehaviour
    {
        public void Start()
        {
            GameEvents.onPartDie.Add(PartDead);
        }

        public void PartDead(Part p)
        {

        }
        public void OnDisable()
        {
            GameEvents.onPartDie.Remove(PartDead);
        }


    }
}
