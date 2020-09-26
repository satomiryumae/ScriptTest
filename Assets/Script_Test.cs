using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int mp = 53;
        int sum = 0;

        for (int i = 1; i < 10; i++)    
        {
            sum += 5;
            if (mp >= 0)
            {
                Debug.Log("魔法攻撃をした。残りMPは" + sum);
                mp -= sum;
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
