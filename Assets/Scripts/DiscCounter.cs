using System.Collections.Generic;
using Seville;
using UnityEngine;

public class DiscCounter : MonoBehaviour
{    
    [SerializeField] private int dValue = 0;
    [SerializeField] private int iValue = 0;
    [SerializeField] private int sValue = 0;
    [SerializeField] private int cValue = 0;

    public List<GameObject> finalPopupList;

    private int currentSelection = 0;

    public void ChangeSelection(int value)
    {
        currentSelection = value;
    }

    public void SubmitResponse()
    {
        switch (currentSelection)
        {
            case 1:
                dValue++;
                break;
            case 2:
                iValue++;
                break;
            case 3:
                sValue++;
                break;
            case 4:
                cValue++;
                break;
        }
    }

    public void ShowResult()
    {
        if (dValue >= iValue && dValue >= sValue && dValue >= cValue)
        {
            finalPopupList[0].SetActive(true);
        }
        else if (iValue >= sValue && iValue >= cValue)
        {
            finalPopupList[1].SetActive(true);
        }
        else if (sValue >= cValue)
        {
            finalPopupList[2].SetActive(true);
        }
        else
        {
            finalPopupList[3].SetActive(true);
        }
    }
}
