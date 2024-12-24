using UnityEngine;
using System.Collections.Generic;

public class CanvasSequence : MonoBehaviour
{
    public List<GameObject> canvasList;

    private int canvasIndex = 0;

    private void Start()
    {
        canvasList[0].SetActive(true);
    }
    
    public void NextCanvas()
    {
        canvasList[canvasIndex++].SetActive(false);

        if (canvasIndex >= canvasList.Count) return;

        canvasList[canvasIndex].SetActive(true);
    }
}
