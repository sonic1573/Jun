using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 주석, 컴퓨터가 처리하지 않는 라인

        /*
         여러줄을 걸친
         주석을
         남길 수 있다
         */

        // 콘솔 출력
        Debug.Log("Hello World!");

        // 숫자형 변수
        int age = 22;
        int money = -1000;

        Debug.Log(age);
        Debug.Log(money);

        // floating point - float: 소숫점을 가지는 실수
        // 소수점 아래 7자리까지만 정확
        float height = 169.12345f;

        // float의 두배의 메모리 사용 64비트
        // 소숫점 아래 15자리까지만 정확
        double pi = 3.14159265359;

        // bool은 참 혹은 거짓
        bool isBoy = true;
        bool isGirl = false;

        // char character는 한 문자
        char grade = 'A';

        // string은 문장
        string movieTitle = "러브라이브!";

        Debug.Log("내 나이는!: " + age);
        Debug.Log("내가 가진 돈은!: " + money);
        Debug.Log("내 몸무게는! " + height);
        Debug.Log("내 원주율은! " + pi);
        Debug.Log("내 성적은!" + grade);
        Debug.Log("명작 영화!" + movieTitle);
        Debug.Log("나는 남자인가?" + isBoy);


        // var는 할당하는 값을 기준으로 타입을 결정
        var myName = "I_Jun";
        // string myName = "I_Jun";
        var myAge = 22;
        //int myAge = 22;

        Debug.Log("준혁의 닉네임" + myName);
    }
}
