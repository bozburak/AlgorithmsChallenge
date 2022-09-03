using System;
using System.Collections.Generic;
using Abstracts;

namespace Concretes
{
    public class OverlappingHours : IAlgorithm
    {
        /*
            if there are overlapping hours, return false

            Default Duration List

            First Item: { StartHour= 2 StartMinute= 6 EndHour= 4 EndMinute= 10}
            Second Item: { StartHour= 5 Minute= 0 EndHour= 7 EndMinute= 0 }

            Hour Duration = {
                private int Hour { get; set; } Max 24
                private int Minute { get; set; } Max 60
            }
        */

        void IAlgorithm.Algroithm()
        {
            Console.WriteLine("Overlapping Hours!");

            var newDuration = new Duration() { StartHour = 13, StartMinute = 0, EndHour = 2, EndMinute = 7 };

            bool result = Solution(newDuration);
            Console.ReadKey();
        }

        private static bool Solution(Duration newDuration)
        {
            var defaultDurationList = new List<Duration>()
            {
                new Duration() { StartHour = 2, StartMinute = 6, EndHour = 4, EndMinute = 10 },
                new Duration() { StartHour = 5, StartMinute = 0, EndHour = 7, EndMinute = 0 }
            };

            foreach (var detail in defaultDurationList)
            {
                if (!((newDuration.StartHour < newDuration.EndHour || (newDuration.StartHour == newDuration.EndHour && newDuration.StartMinute < newDuration.EndMinute))
                    && (detail.StartHour < detail.EndHour || (detail.StartHour == detail.EndHour && detail.StartMinute < detail.EndMinute))))
                {
                    if (!((detail.StartHour > newDuration.EndHour || (detail.StartHour == newDuration.EndHour && detail.StartMinute > newDuration.EndMinute)) &&
                        (newDuration.StartHour > detail.EndHour || (newDuration.StartHour == detail.EndHour && newDuration.StartMinute > detail.EndMinute))))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!((detail.StartHour > newDuration.EndHour || (detail.StartHour == newDuration.EndHour && detail.StartMinute > newDuration.EndMinute)) ||
                        (newDuration.StartHour > detail.EndHour || (newDuration.StartHour == detail.EndHour && newDuration.StartMinute > detail.EndMinute))))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    public class Duration
    {
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public int EndHour { get; set; }
        public int EndMinute { get; set; }
    }
}