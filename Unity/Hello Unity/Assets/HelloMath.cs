﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloMath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        int a = 5;

        int b = 7;

        int sum = a + b;

        Debug.Log(sum);

        sum = a - b;

        Debug.Log(sum);

        Debug.Log(a * b);

        Debug.Log(a / b);

        Debug.Log(b / a);

        Debug.Log(a % b);

        Debug.Log(b % a);
        */

        int i = 0;

        // 0
        Debug.Log(i++);
        // 1
        Debug.Log(i);
        // 2
        Debug.Log(++i);
        // 2
        Debug.Log(i);


        int j = 10;

        j += 5;
        //j = j + 5;

        j -= 5;
        //j = j - 5;

        j *= 5;
        // j = j * 5;

        j /= 5;
        // j = j / 5;

        j %= 5;
        // j = j % 5;

        Debug.Log(j);

    }
}

