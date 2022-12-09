using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace _Source
{
    public class Logic : MonoBehaviour
    {
        // я посчитал использование List более эффективным вариантом, чем делать несколько переменных.
        // я понимаю, что в таком случае легко сломать код, добавивь лишний элемент, поменять порядок или удалить элемент
        // но лучше так, чем очень много полей SerializeField
        [SerializeField] private List<Text> textFormulas;
        [SerializeField] private List<InputField> inputNumbers;
        [SerializeField] private List<Text> textResults;
        
        private ViewDataSO _viewDataSO;
        // private DataSO _dataSO;

        private void Start()
        {
            _viewDataSO = Resources.Load<ViewDataSO>("Formulas");

            textFormulas[0].text = _viewDataSO.FormulaCalculatingSpeedABody;
            textResults[0].text = "";
            
            textFormulas[1].text = _viewDataSO.FormulaBodyImpulse;
            textResults[1].text = "";
            
            textFormulas[2].text = _viewDataSO.FormulaMechanicalWork;
            textResults[2].text = "";
            
            textFormulas[3].text = _viewDataSO.FormulaGravity;
            textResults[3].text = "";
            
            textFormulas[4].text = _viewDataSO.FormulacalCalculatingHeightFromWhichBodyFalls;
            textResults[4].text = "";
        }

        public void CalculatingSpeedABody()
        {
            textResults[0].text = Formulas.CalculatingSpeedABody(inputNumbers[0].text, inputNumbers[1].text).ToString();
        }
        
        public void BodyImpulse()
        {
            textResults[1].text = Formulas.BodyImpulse(inputNumbers[2].text, inputNumbers[3].text).ToString();
        }
        
        public void MechanicalWork()
        {
            textResults[2].text = Formulas.MechanicalWork(inputNumbers[4].text, inputNumbers[5].text).ToString();
        }
        
        public void ChargeCalculation()
        {
            textResults[3].text = Formulas.Gravity(inputNumbers[6].text, inputNumbers[7].text, inputNumbers[8].text).ToString();
        }
        
        public void CalculatingHeightFromWhichBodyFalls()
        {
            textResults[4].text = Formulas.CalculatingHeightFromWhichBodyFalls(inputNumbers[9].text).ToString();
        }
    }
}
