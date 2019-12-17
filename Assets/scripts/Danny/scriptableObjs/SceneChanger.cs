﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string goToScene;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(goToScene);
        }
    }
}