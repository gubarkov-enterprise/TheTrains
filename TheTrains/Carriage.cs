using System;

namespace TheTrains
{
    public class Carriage
    {
        public bool LightIsOn { get; private set; }

        public Carriage()
        {
            LightIsOn = new Random().Next(100) < 50;
        }

        public void ToggleLight() => LightIsOn = !LightIsOn;
    }
}