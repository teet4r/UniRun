using UnityEngine;

// PlayerController는 플레이어 캐릭터로서 Player 게임 오브젝트를 제어한다.
public class Player : MonoBehaviour
{
    void Awake()
    {
        instance = this;

        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void OnEnable()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isDead && other.CompareTag(Tag.DEAD))
            Die();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 바닥에 닿았음을 감지하는 처리
        if (collision.gameObject.CompareTag(Tag.PLATFORM))
            // 충돌한 지점이 절벽이나 천장을 바닥으로 인식하는 문제 해결
            if (collision.contacts[0].normal.y > 0.7f) // 충돌 지점의 경사가 대략 45도보다 작은지 검사
            {
                isGrounded = true;
                jumpCount = 0;
                animator.SetBool(AnimatorID.GROUNDED, isGrounded);
            }
    }

    public void Jump()
    {
        if (isDead) return;
        if (jumpCount < 2)
        {
            isGrounded = false;
            jumpCount++;
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * jumpForce);
            SoundManager.instance.sfxAudio.Play(Sfx.JUMP);
        }

        animator.SetBool(AnimatorID.GROUNDED, isGrounded);
    }

    public void JumpDecelerate()
    {
        if (isDead) return;
        if (rigidbody.velocity.y > 0f)
            rigidbody.velocity *= 0.5f;
    }

    void Die()
    {
        isDead = true;
        animator.SetTrigger(AnimatorID.DIE);
        SoundManager.instance.sfxAudio.Play(Sfx.DIE);
        rigidbody.velocity = Vector2.zero;
        GameManager.instance.OnPlayerDead();
    }

    public static Player instance = null;
    public float jumpForce = 700f; // 점프 힘

    int jumpCount = 0; // 누적 점프 횟수
    bool isGrounded = false; // 바닥에 닿았는지 나타냄
    bool isDead = false; // 사망 상태

    Rigidbody2D rigidbody; // 사용할 리지드바디 컴포넌트
    Animator animator; // 사용할 애니메이터 컴포넌트
}