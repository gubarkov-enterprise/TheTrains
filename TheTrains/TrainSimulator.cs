using System.Collections.Generic;
using System.Linq;

namespace TheTrains
{
    public class TrainSimulator
    {
        private LinkedListNode<Carriage> _currentCarriage;

        public Carriage CurrentCarriage => _currentCarriage.Value;


        public TrainSimulator(int carriageCount)
        {
            _currentCarriage = new LinkedList<Carriage>(
                    Enumerable.Range(0, carriageCount)
                        .Select(_ => new Carriage()))
                .First;
        }

        public void GoNextCarriage() => _currentCarriage = _currentCarriage.Next ?? _currentCarriage.List?.First;

        public void GoPreviousCarriage() => _currentCarriage = _currentCarriage.Previous ?? _currentCarriage.List?.Last;
    }
}