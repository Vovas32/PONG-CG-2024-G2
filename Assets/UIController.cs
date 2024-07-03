using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{

    public TextMeshProUGUI LeftPlayerScore;
    public TextMeshProUGUI RightPlayerScore;

    // Start is called before the first frame update
    public void SetLeftPlayerScore(string text)
    {
        LeftPlayerScore.SetText(text);
    }

    // Update is called once per frame
    public void SetRightPlayerScore(string text)
    {
        RightPlayerScore.SetText(text);
    }
}
