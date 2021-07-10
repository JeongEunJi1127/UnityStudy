using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스를 클릭하면
        {
            // 마우스를 클릭한 좌료
            this.startPos = Input.mousePosition;
            //this.speed = 0.2f; //처음 속도 설정
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //마우스 버튼에서 손 떼었을 때
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //스와이프 길이를 처음 속도로 변경한다
            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0); //이동 메서드 translate 사용.
        this.speed *= 0.98f; //감속
    }
}
