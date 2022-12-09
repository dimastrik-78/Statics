using UnityEngine;

namespace _Source
{
    public static class Formulas
    {
        public static double CalculatingSpeedABody(string stringSpeed, string stringTime) 
        {
            if (double.TryParse(stringSpeed, out double speed)
                && double.TryParse(stringTime, out double time))
                return speed / time;
            return 0;
        }

        public static double BodyImpulse(string stringMass, string stringSpeed)
        {
            if (double.TryParse(stringMass, out double mass)
                && double.TryParse(stringSpeed, out double speed))
                return mass * speed;
            return 0;
        }

        public static double MechanicalWork(string stringForce, string stringDistanceTraveled)
        {
            if (double.TryParse(stringForce, out double force)
                && double.TryParse(stringDistanceTraveled, out double distanceTraveled))
                return force * distanceTraveled;
            return 0;
        }

        public static double Gravity(string stringMass1, string stringMass2, string stringDistance)
        {
            if (double.TryParse(stringMass1, out double mass1)
                && double.TryParse(stringMass2, out double mass2)
                && double.TryParse(stringDistance, out double distance))
                return Resources.Load<DataSO>("CONSTANTData").AccelerationofGravityConstant * mass1 * mass2 / (distance * distance);
            return 0;
        }
        
        public static double CalculatingHeightFromWhichBodyFalls(string stringTime)
        {
            if (double.TryParse(stringTime, out double time))
                return Resources.Load<DataSO>("CONSTANTData").GravitationalConstant * (time * time) / 2;
            return 0;
        }
    }
}
