using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonclickscript : MonoBehaviour
{

    public GameObject gameObject;

    void Awake () {
        DontDestroyOnLoad(this.gameObject);
    }
}
