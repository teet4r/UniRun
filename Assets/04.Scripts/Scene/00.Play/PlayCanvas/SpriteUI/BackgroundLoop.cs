using System.Collections;
using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치 & 반복하는 스크립트
public class BackgroundLoop : MonoBehaviour
{
    void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public void StartLoop()
    {
        loopRoutine = StartCoroutine(_Loop());
    }

    public void StopLoop()
    {
        if (isActive)
        {
            StopCoroutine(loopRoutine);
            loopRoutine = null;
            isActive = false;
        }
    }

    IEnumerator _Loop()
    {
        if (isActive) yield break;
        isActive = true;
        width = boxCollider.size.x; // 가로 길이 측정

        while (!GameManager.instance.isGameover)
        {
            // 게임 오브젝트를 왼쪽으로 일정 속도로 평행 이동하는 처리
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            // 배경이 화면 밖을 완전히 벗어나면 위치 리셋
            if (transform.position.x <= -MainCamera.halfWidth * 2)
            {
                if (loop)
                    Reposition();
                else
                    Destroy(gameObject);
            }
            yield return null;
        }
    }

    // 위치를 리셋하는 메서드
    void Reposition()
    {
        // 화면 오른쪽 밖으로 위치 초기화
        transform.position = Vector2.right * (MainCamera.halfWidth + width / 2);
    }

    public float speed = 10f; // 이동 속도
    public bool isActive { get; private set; } = false; // 루프가 활성화 되어있는지

    [SerializeField]
    [Tooltip("재사용 할지말지 여부, 재사용 하지않으면 바로 폐기")]
    bool loop = true;

    BoxCollider2D boxCollider;
    float width; // 배경의 가로 길이
    Coroutine loopRoutine = null;
}