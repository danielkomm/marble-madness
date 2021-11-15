using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeValueController : MonoBehaviour
{
    private GameManager gm;
    private Text textComp;

    void Start()
    {
        gm = GameManager.Instance;
        textComp = GetComponent<Text>();
        textComp.text = gm.lifeCounter.ToString();
        gm.lifeCounterChanged.AddListener(UpdateLiveValue);
    }

    public void UpdateLiveValue(int lifeCount)
    {
        textComp.text = lifeCount.ToString();
    }
}
