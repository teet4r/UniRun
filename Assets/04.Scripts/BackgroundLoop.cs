using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour
{
    void Awake()
    {
        // 가로 길이를 측정하는 처리
        boxCollider = GetComponent<BoxCollider2D>();

        width = boxCollider.size.x;
    }

    void Update()
    {
        // 현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때 위치를 리셋
        if (transform.position.x <= -MainCamera.instance.halfWidth * 2)
            Reposition();
    }

    // 위치를 리셋하는 메서드
    void Reposition()
    {
        transform.position = Vector2.right * (MainCamera.instance.halfWidth + width / 2);
    }

    BoxCollider2D boxCollider;
    float width; // 배경의 가로 길이
}