using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinValueController : MonoBehaviour
{
    private GameManager gm;
    private Text textComp;

    void Start()
    {
        gm = GameManager.Instance;
        textComp = GetComponent<Text>();
        textComp.text = gm.pointsCounter.ToString();
        gm.CollectableChanged.AddListener(UpdatePointValue);
    }

    public void UpdatePointValue(int pointsCount)
    {
        textComp.text = pointsCount.ToString();
    }
}
