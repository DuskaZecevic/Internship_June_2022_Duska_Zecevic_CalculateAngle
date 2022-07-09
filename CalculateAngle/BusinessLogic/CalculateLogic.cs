using System;

namespace CalculateAngle.BusinessLogic
{
    public class CalculateLogic
    {
        public static int CalculateAngle(double hour, double minute)
        {
            if (hour > 12)
                hour -= 12;
            
            int hoursInDegrees = (int)(0.5 * (hour * 60 + minute));
            int minutesInDegrees = (int)(6 * minute);
            int angle = Math.Abs(hoursInDegrees - minutesInDegrees);
            return angle = Math.Min(360 - angle, angle);
        }
    }
}
