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

- 오브젝트 풀링을 활용하여 발판 재사용
  - 발판이 화면 밖으로 나가면 풀에 저장

</div>
</details>

<details>
<summary>플레이어 오브젝트</summary>
<div markdown="1">

- 화면을 터치하면 플레이어가 점프, 최대 2단 점프
- 길게 누르고 있을수록 플레이어가 더 높이 점프
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
  - 장애물 없음: 1점, 1개: 2점, 2개: 3점, 3개: 4점

</div>
</details>

<details>
<summary>데이터 저장</summary>
<div markdown="1">

- PlayerPrefs로 최고점수 갱신 및 저장
- 시작화면에 보이도록 구성
- bgm, sfx 설정 현황 또한 PlayerPrefs.SetInt()로 저장 및 불러오기
  - 0으로 저장 시 off, 1로 저장 시 on

</div>
</details>

</br>

## 6. 스크린샷
<details>
<summary>메인화면</summary>
<div markdown="1">

![UniRun_Main1](https://user-images.githubusercontent.com/76508241/213147680-21f231ff-9f6a-4adf-a2e9-43c7122ce730.jpg)
- 화면을 터치 시 시작
- Bgm, Sfx 버튼으로 배경음악 및 효과음 활성화/비활성화
- Quit 버튼으로 어플리케이션 종료

</div>
</details>

<details>
<summary>인게임</summary>
<div markdown="1">

![UniRun_Ingame1](https://user-images.githubusercontent.com/76508241/213147699-9fdcec8c-7c30-401f-ba94-9ca89ac9fe6b.jpg)
![UniRun_Ingame2](https://user-images.githubusercontent.com/76508241/213147698-f9653da2-5687-475e-aa33-96c2a1c85c90.jpg)
- 붉은 가시는 장애물이며 닿으면 게임오버 처리

</div>
</details>

<details>
<summary>게임오버</summary>
<div markdown="1">

![UniRun_End1](https://user-images.githubusercontent.com/76508241/213147695-be68e872-a651-4f91-962d-eff29ae60bcb.jpg)
- 화면 아무 곳이나 터치하여 메인화면으로 돌아감

</div>
</details>

</br>

## 7. 링크
- [플레이 영상 및 다운로드](https://drive.google.com/drive/folders/1poffdYBI0S9SJSnPl8fXw4HGA0aJ_FdA)
