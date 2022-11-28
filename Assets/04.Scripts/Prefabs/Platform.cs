using UnityEngine;

// 발판으로서 필요한 동작을 담은 스크립트
public class Platform : MonoBehaviour
{
    void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // 컴포넌트가 활성화될때 마다 매번 실행되는 메서드
    void OnEnable()
    {
        #region Reset Variables
        // 발판을 리셋하는 처리
        isStepped = false;
        score = 1;
        #endregion

        #region Valid Check
        if (spwanPosMinX > spwanPosMaxX)
            Algorithm.Swap(ref spwanPosMinX, ref spwanPosMaxX);
        if (spwanPosMinY > spwanPosMaxY)
            Algorithm.Swap(ref spwanPosMinY, ref spwanPosMaxY);
        #endregion

        for (int i = 0; i < obstacles.Length; i++)
        {
            // 25%의 확률로 장애물 활성화
            if (Random.Range(0, 4) == 0)
            {
                obstacles[i].SetActive(true);
                score++;
            }
            else
                obstacles[i].SetActive(false);
        }

        transform.position = new Vector2(Random.Range(spwanPosMinX, spwanPosMaxX), Random.Range(spwanPosMinY, spwanPosMaxY));
    }

    void Update()
    {
        if (transform.position.x <= -MainCamera.halfWidth - boxCollider.size.x)
            ObjectPool.instance.ReturnPlatform(this);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 플레이어 캐릭터가 자신을 밟았을때 점수를 추가하는 처리
        if (collision.gameObject.CompareTag(Tag.PLAYER) && !isStepped)
        {
            isStepped = true;
            GameManager.instance.AddScore(score);
        }
    }

    public GameObject[] obstacles; // 장애물 오브젝트들
    public float spwanPosMinX;
    public float spwanPosMaxX;
    public float spwanPosMinY;
    public float spwanPosMaxY;

    BoxCollider2D boxCollider;
    bool isStepped; // 플레이어 캐릭터가 밟았었는가
    int score;
}