using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    [SerializeField] private GameObject resetBtn;
    private int termA, termB;

    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;

        result = summandA + summandB;

        txtResult.text = string.Format("{0}", result);
        return result;
    }

    public void GetValues()
    {
        string termA, termB;
        termA = inputFieldTermA.text;
        termB = inputFieldTermB.text;

        Debug.Log("Methode GetValues wird ausgeführt: " + CheckAddition(int.Parse(termA), int.Parse(termB)));
    }

    public void ResetBtn()
    {
        inputFieldTermA.text = string.Empty;
        inputFieldTermB.text = string.Empty;
        txtResult.text = "";

        termA = 0;
        termB = 0;
    }

}