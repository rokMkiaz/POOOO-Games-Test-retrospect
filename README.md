## P사에서 진행한 과제형 테스트 반성겸 개선 프로젝트
제작 기간 : 19시간(테스트 시간 : 12.09 3시~ 12.11 3시 24시간)\
문제: 내용: 눈키 모작
  - 소스: 눈키의 그래픽 및 사운드 리소스 사용
  - 엔진: Unity 사용
  - 해상도: 가변해상도 대응 필수
 
 반성 : 제한시간내에 너무 많은 것을 구현하려고 한 것이 문제였던 것 같다.\
 중요점은 게임성 이었지만, UI와 레벨 까지 구현하려고 너무 욕심을 내어 Apk빌드 후 테스트하며\
 탈락을 예상하였다. 필수인 가변해상도에 대해 지식이 너무 부족하여 레터박스조작으로만 퉁치려 하였지만,\
 잘 되지 못 하였다. 이러한 문제들에 대해 개선을 하고 고치는 프로젝트를 수행하려 한다.
 
 내가 만든 프로젝트와 P사에서 출시한 작품과 비교해 보며 개선을 하는 것이 이 프로젝트의 목표 이다.\
 시간에 쪼들려 쓰레기 코드도 많이 사용하였고, 욕심에 눈이 멀어 쓰지 말아야 할짓도 하여 수정할 것이다.

### 게임에서 살려야 했던 것
#### 주제 분석
기본적으로 눈물이 나오는 방법을 더 살려야 했다고 생각한다. 클릭을 하며 관찰을 많이 하였으나\
버그인지 살린건지 끝까지 고민하였던 부분들이다.\
![뎁스](https://user-images.githubusercontent.com/93506849/207499642-12471466-6e1c-49b2-a633-2bf529f90798.JPG)
- 기본적으로 눈물에 깊이가 들어가 있는 것으로 보인다.
- 깊이에 따라 눈물의 크기와 바닥에 접촉 시 생기는 파장의 위치와 크기가 달라지게 설정이 되어있다는 것을 알았다.(그러나 UI 더 살릴 생각을 해서 안넣었다..)

#### 반성 부분
주제에 대한 접근성\
![모작눈물](https://user-images.githubusercontent.com/93506849/207500089-90cecb4f-d132-4572-8ed8-e8dda870c5f3.JPG)
- 중요 부분을 너무 간단하게 구현을 해버린 것이 아닌가 하였다. 그냥 눈물만 나오면 되는거 아닌가란 생각을 가지고 만든 것이 가장 큰 실수 였던 것 같다.

![업데이트 실수](https://user-images.githubusercontent.com/93506849/207500303-750d8a72-89ff-436c-89e7-7dd4e5aaeead.JPG)

- 그리고 클릭시 누른 만큼 눈물이 펑펑 나왔어야 했던 부분을 Update()로 처리를 해버렸다..(Fixed Update로 바꿔야 했는데..)
- 60fps제한을 걸어두니 터치를 아무리 하여도 내 생각만큼 눈물이 나오지 않았다..

 ![gafgd](https://user-images.githubusercontent.com/93506849/207501237-771abf1a-b198-4ad9-9b79-843c2c0560be.JPG)
 
- 마지막으로 UI를 정해진 위치에 올라오게 하는 것에 대해 FixedUpdate를 쓸데없이 사용하였다.
- 정해진 위치로만 올라가게 위치지정만 했으면 되었던 문제를 너무 편하게 처리할려다가 하지 말아야할 짓을 하였다.
전체적으로 살려야할 부분은 못 살리고, 하지 말아야 하는 부분을 손댄 것이 해당 프로젝트 실패의 원인이 되었던 것 같다.

### 개선 작업
![뎁스추가](https://user-images.githubusercontent.com/93506849/207812270-2cbb40a6-e4a8-4b12-9435-076014e55ad9.JPG)
- 눈물 나오는 부분을 FixedUpdate()로 바꿔 주었다.
- Depth를 추가하여 위치에 따라 눈물크기도 변경 시켜주었다.

![KakaoTalk_20221215_174232085](https://user-images.githubusercontent.com/93506849/207813156-ef48dd14-0508-4691-8de8-601eba7a967e.gif)

(Z에 따라 크기, 충돌 지점이 다른 것을 확인할 수 있다.)
![페어리](https://user-images.githubusercontent.com/93506849/208022339-87aeac73-c4bc-41d9-beb3-2d068d477432.JPG)
- Strategy Pattern(전략패턴)을 적용하여 페어리를 구현해보려 한다.
- 구조적으로 특정위치에서 랜덤하게 배치되는 페어리를 하나씩 관리하는 것 보다 괜찮을 것으로 보이며 공통되는 장비를 착용하기에 해당 패턴을 적용하였다.

![level1](https://user-images.githubusercontent.com/93506849/208022467-33b5e746-dc73-4bde-bc99-dcaff629e6cd.JPG)
- level1에 해당하는 페어리를 스크립트로 만들어 보았고 작동을 테스트 해보았다.
 \ ![정상작동](https://user-images.githubusercontent.com/93506849/208022545-155d44de-a6de-40b0-8972-9af8e86e9ee8.JPG)

