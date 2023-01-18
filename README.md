# Project: UniRun

</br>

## 1. 개요
장애물을 피해 최고점수를 획득하는 간단한 모바일 게임

</br>

## 2. 제작기간 & 참여인원
- 약 10일
- 개인 프로젝트

</br>

## 3. 사용언어 & 도구
- C#
- Visual Studio
- Unity 2D(에디터 버전: 2021.3.12f1)

</br>

## 4. 구동 플랫폼
- Android

</br>

## 5. 주요 구현 이슈
<details>
<summary>무한 스크롤</summary>
<div markdown="1">

- 하나의 배경 이미지로 무한 스크롤링하여 플레이어가 앞으로 달려나가는 듯한 효과를 주도록 구현

</div>
</details>

<details>
<summary>오브젝트 풀링</summary>
<div markdown="1">

- 오브젝트 풀링을 활용하여 발판 재사용(발판이 화면 밖으로 나가면 풀에 저장)

</div>
</details>

<details>
<summary>플레이어 오브젝트</summary>
<div markdown="1">

- 화면을 터치하면 플레이어가 점프, 최대 2단 점프까지 가능
- OnCollisionEnter2D() 함수 내 collision.contacts[0].normal.y > 0.7f 조건을 활용하여 발판 위에 안착했을 때만 점수를 획득하도록 함
- FixPosition() 함수로 플레이어가 지정된 자리를 이탈하는 경우 자리를 되찾아오도록 함

</div>
</details>

<details>
<summary>발판 오브젝트</summary>
<div markdown="1">

- 발판이 OnEnable() 될 때 위치를 랜덤으로 지정
- 발판 위 장애물은 총 세개, 25% 확률로 각 장애물 활성화
- 확률 구현에는 Random.Range() 사용
- 장애물이 많은 발판일수록 추가되는 점수량 증가

</div>
</details>

<details>
<summary>데이터 저장</summary>
<div markdown="1">

- PlayerPrefs로 최고점수 갱신 및 저장
- 시작화면에 보이도록 구성
- bgm, sfx 설정 현황 또한 PlayerPrefs.SetInt()로 저장 및 불러오기(0으로 저장 시 off, 1로 저장 시 on)

</div>
</details>

</br>

## 6. 스크린샷
<details>
<summary>메인화면</summary>
<div markdown="1">

![Dodge_Main1](https://user-images.githubusercontent.com/76508241/212594242-ed09df1d-4881-4529-8974-8e40e25641fb.png)
- 게임 시작, 세팅, 종료 버튼으로 구성

![Dodge_Main2](https://user-images.githubusercontent.com/76508241/212594416-6f129ff0-b642-4496-a796-7ad6288bc020.png)
- Dropdown으로 구성
- 난이도는 쉬움, 보통, 어려움으로 구성
- 난이도별 점수 차등 지급

</div>
</details>

<details>
<summary>인게임</summary>
<div markdown="1">

![Dodge_Ingame1](https://user-images.githubusercontent.com/76508241/212594410-7dfcafab-09c4-4a78-af65-82c796ffa312.png)
![Dodge_Ingame2](https://user-images.githubusercontent.com/76508241/212594413-0cf150ed-4edf-428a-89c2-ceeece5cba36.png)
![Dodge_Ingame3](https://user-images.githubusercontent.com/76508241/212594415-702bf1e2-a350-4e9f-a113-4aba46285e15.png)
- 빨간색 기둥 오브젝트는 BulletSpawner로써 총알 생성 및 발사
- 파란색 구슬 오브젝트는 쉴드로써 총알 1회 방어 할 수 있으며, 중첩 획득 가능.

</div>
</details>

<details>
<summary>게임오버</summary>
<div markdown="1">

![Dodge_End1](https://user-images.githubusercontent.com/76508241/212594419-b5c9a2a7-7374-451b-88ea-d5db146be037.png)
- R키 입력을 통해 재시작(메인화면으로 넘어감)
- PlayerPrefs를 통해 점수 저장 및 최고 기록 조회

</div>
</details>

</br>

## 7. 링크
- [플레이 영상 및 다운로드](https://drive.google.com/drive/folders/1BQRBXwcbqKP7jxQQLEF5ONfYi_rkeJyO)
