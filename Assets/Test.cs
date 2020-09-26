using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{

    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    

    public void Magic(int mp)
    {
        if (mp % 5 >= 0)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        
    }


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];

        array[0] = 50;
        array[1] = 20;
        array[2] = 30;
        array[3] = 90;
        array[4] = 70;

        //順番
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //逆順
        for (int j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

        Boss lastboss = new Boss();

        
        for(int i = 0; i <= 10; i++)
        {
            lastboss.Magic(53);
        }

        lastboss.Attack();
        lastboss.Defence(3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
