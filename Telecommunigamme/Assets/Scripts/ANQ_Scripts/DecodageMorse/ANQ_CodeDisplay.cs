﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANQ_CodeDisplay : MonoBehaviour
{
    void Start()
    {
        Text CodeMorse = GetComponent<Text>();
        CodeMorse.text = ANQ_MorseWords.code + " : " + ANQ_MorseWords.codeInMorse;
    }


}
