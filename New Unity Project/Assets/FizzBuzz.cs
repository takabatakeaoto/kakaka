using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("デバッグ");
        FizzBuzzOut();
	}
	
	// Update is called once per frame
	void Update () {

        }

    void FizzBuzzOut(){
        for (int i = 1; i <= 20; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) { Debug.Log("FizzBuzz"); }
            //15の倍数ならFizzBuｚｚ
            else if (i % 3 == 0) { Debug.Log("Fizz"); }
            //三の倍数ならFIZZ
            else if (i % 5 == 0) { Debug.Log("Buzz"); }
            //5の倍数ならBuzz
            else  { Debug.Log(i); }
         }
    }
}
