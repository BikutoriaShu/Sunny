using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public int gems=0;
    void Update()
    {
        text.text=gems.ToString()+" Gems";
    }
}
