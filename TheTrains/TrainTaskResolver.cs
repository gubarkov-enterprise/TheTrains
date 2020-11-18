using System;
using System.Collections.Generic;

namespace TheTrains
{
    public class TrainTaskResolver
    {
        private TrainSimulator _trainSimulator;


        public int Resolve(TrainSimulator simulator)
        {
            _trainSimulator = simulator;

            var targetCarriageState = _trainSimulator.CurrentCarriage.LightIsOn;
            var iterationsCount = 0;

            while (true)
            {
                do
                {
                    _trainSimulator.GoNextCarriage();
                    iterationsCount++;
                } while (targetCarriageState != _trainSimulator.CurrentCarriage.LightIsOn);

                Iterate(iterationsCount, () => _trainSimulator.GoPreviousCarriage());

                _trainSimulator.CurrentCarriage.ToggleLight();
                targetCarriageState = !targetCarriageState;

                Iterate(iterationsCount, () => _trainSimulator.GoNextCarriage());


                if (_trainSimulator.CurrentCarriage.LightIsOn == targetCarriageState)
                    break;
            }

            return iterationsCount;
        }


        private void Iterate(int count, Action callback)
        {
            for (int step = 0; step < count; step++)
            {
                callback();
            }
        }
    }
}