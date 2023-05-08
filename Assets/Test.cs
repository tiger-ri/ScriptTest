using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列を初期化する
        int[] array = { 23, 27, 70, 74, 16 };

        //配列の各要素を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log (array [i]);
        }
        //配列の各要素を逆順に表示
        for (int i = 4; i >=0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
        {

        }


}
