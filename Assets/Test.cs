using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�z�������������
        int[] array = { 23, 27, 70, 74, 16 };

        //�z��̊e�v�f�����Ԃɕ\��
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log (array [i]);
        }
        //�z��̊e�v�f���t���ɕ\��
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
