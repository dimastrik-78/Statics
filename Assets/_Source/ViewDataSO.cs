using System.Collections.Generic;
using UnityEngine;

namespace _Source
{
    [CreateAssetMenu(fileName = "Formulas", menuName = "Data/Formulas")]
    public class ViewDataSO : ScriptableObject
    {
        public string FormulaCalculatingSpeedABody;
        public string FormulaBodyImpulse;
        public string FormulaMechanicalWork;
        public string FormulaGravity;
        public string FormulacalCalculatingHeightFromWhichBodyFalls;
    }
}
