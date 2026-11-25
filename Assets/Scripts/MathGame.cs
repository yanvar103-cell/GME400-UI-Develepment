using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MathGame : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private TMP_Text[] _textField;
    [SerializeField] private TMP_Text _operatorText;  // the text that used to show the static "+"
    [SerializeField] private bool _allowDivision = true; //to check the logical variable nummer1 for divisibility
    private int _number1;
    private int _number2;
    private char _operator;
    private int _correctAnswer;

    private readonly char[] _operatorsWithDivision = { '+', '-', '*', '/' };
    private readonly char[] _operatorsNoDivision = { '+', '-', '*' };

    void Start()
    {
        GenerateProblem();
    }

    public void GenerateProblem()
    {
        char[] operators = _allowDivision ? _operatorsWithDivision : _operatorsNoDivision;
        _operator = operators[Random.Range(0, operators.Length)]; // max is exclusive for int

        _number1 = Random.Range(2, 40);
        _number2 = Random.Range(2, 40);

        switch (_operator)
        {
            case '-':
                // Keep the answer non-negative: put the bigger number first
                if (_number2 > _number1)
                    (_number1, _number2) = (_number2, _number1);
                break;

            case '*':
                // Smaller numbers so multiplication stays reasonable
                _number1 = Random.Range(2, 13);
                _number2 = Random.Range(2, 13);
                break;

            case '/':
                // Build the problem backwards so the answer is always a whole number
                _number2 = Random.Range(2, 13);       // divisor
                int quotient = Random.Range(2, 13);  // the answer
                _number1 = _number2 * quotient;       // dividend
                break;
        }

        CalculateAnswer();

        _textField[0].text = _number1.ToString();
        _textField[1].text = _number2.ToString();
        _operatorText.text = _operator == '*' ? "×" : _operator == '/' ? "÷" : _operator.ToString();
        _textField[2].text = "Solve this!";
        _inputField.text = "";
    }
    
    public void CalculateAnswer()
    {
        switch (_operator)
        {
            case '+': _correctAnswer = _number1 + _number2; break;
            case '-': _correctAnswer = _number1 - _number2; break;
            case '*': _correctAnswer = _number1 * _number2; break;
            case '/': _correctAnswer = _number1 / _number2; break;
        }
    }

    public void InputAnswer()
    {
        // TryParse instead of Parse, so empty or non-number input doesn't crash the game
        if (!int.TryParse(_inputField.text, out int playerAnswer))
        {
            _textField[2].text = "Please enter a number!";
            return;
        }

        if (playerAnswer == _correctAnswer)
            _textField[2].text = "Correct!";
        else
            _textField[2].text = $"Wrong, true answer is {_correctAnswer}!";
    }
}
