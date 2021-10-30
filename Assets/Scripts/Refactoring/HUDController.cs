using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUDController : MonoBehaviour
{
    public Text countText;
    public Text bombasText;
    PickUps pickUps;

    void Start()
    {
        pickUps = GetComponent<PickUps>();
    }

    void Update()
    {
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Materiales: " + pickUps.Count.ToString();
        bombasText.text = "" + pickUps.Bombas.ToString();
    }
}
