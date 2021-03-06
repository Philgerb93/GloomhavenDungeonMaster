﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioPanel : MonoBehaviour {

    public ScalarController scalarController;
    GameController gameController;

    private void Start()
    {
        gameController = GameObject.Find("Game Controller").GetComponent<GameController>();
    }

    public void PushRoundLevel(int i)
    {
        scalarController.currentValue = i;
    }


    // Update is called once per frame
    void Update()
    {
        gameController.scenarioLevel = scalarController.GetCurrentValue();
    }
}
