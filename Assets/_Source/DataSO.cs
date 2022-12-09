using UnityEngine;

namespace _Source
{
    [CreateAssetMenu(fileName = "CONSTANTData", menuName = "Data/CONSTANTData")]
    public class DataSO : ScriptableObject
    {
        private const double GRAVITATIONALCONSTANT = 6.67;
        private const double ACCELERATIONOFGRAVITYCONSTANT = 9.81;
        
        public double GravitationalConstant { get => GRAVITATIONALCONSTANT;  }
        public double AccelerationofGravityConstant { get => ACCELERATIONOFGRAVITYCONSTANT;  }
    }
}
