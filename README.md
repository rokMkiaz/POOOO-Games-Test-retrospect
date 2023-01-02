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
#### 눈물
> ![뎁스추가](https://user-images.githubusercontent.com/93506849/207812270-2cbb40a6-e4a8-4b12-9435-076014e55ad9.JPG)
> - 눈물 나오는 부분을 FixedUpdate()로 바꿔 주었다.
> - Depth를 추가하여 위치에 따라 눈물크기도 변경 시켜주었다.
> 
> ![KakaoTalk_20221215_174232085](https://user-images.githubusercontent.com/93506849/207813156-ef48dd14-0508-4691-8de8-601eba7a967e.gif)
> 
> (Z에 따라 크기, 충돌 지점이 다른 것을 확인할 수 있다.)
#### 요정
> ![페어리](https://user-images.githubusercontent.com/93506849/208022339-87aeac73-c4bc-41d9-beb3-2d068d477432.JPG)
> - Strategy Pattern(전략패턴)을 적용하여 페어리를 구현해보려 한다.
> - 구조적으로 특정위치에서 랜덤하게 배치되는 페어리를 하나씩 관리하는 것 보다 괜찮을 것으로 보이며 공통되는 장비를 착용하기에 해당 패턴을 적용하였다.
> 
> ![level1](https://user-images.githubusercontent.com/93506849/208022467-33b5e746-dc73-4bde-bc99-dcaff629e6cd.JPG)
> ![정상작동](https://user-images.githubusercontent.com/93506849/208023776-9bba09f8-0e76-4be5-8dec-f0ac3152d910.JPG)
> - level1에 해당하는 페어리를 스크립트로 만들어 보았고 작동을 테스트 해보았다.
>
>![1번](https://user-images.githubusercontent.com/93506849/208283936-0b8d8eda-e961-47c4-8106-a478662a5621.JPG)
> - 작동이 정상적으로 확인되었으니 모델링을 시작하기전에 이전 스트레티지 패턴에 내용들을 추가해 준다.
>
> ![1](https://user-images.githubusercontent.com/93506849/208283968-3daa4cd3-6b21-4e6d-89d2-f63bb49ebfa8.JPG)
> - 리스트들을 이용에 스폰지점에 다 넣어주었다. 완드,모자,날개는 모든 요정들이 공용으로 쓰기에 스포너에 달아주었다.
>
> ![변환완료](https://user-images.githubusercontent.com/93506849/208283989-f0ae41ab-3d80-47e2-aebf-3b174d5cc3b2.JPG)
> - 런타임시 변경 확인
> 
> ![장비추가](https://user-images.githubusercontent.com/93506849/209457208-524138fe-e47d-4aa6-b215-35bdb5c746b3.JPG)
> 
> ![바꿈](https://user-images.githubusercontent.com/93506849/209457218-c9f7504c-5058-42e4-8ffd-4fcbfa6c8a3d.JPG)
> - 장비도 스트레티지 패턴을 사용하여 작성하였다.
>
>![invoke](https://user-images.githubusercontent.com/93506849/209608575-093c836a-0605-45d9-8736-617307a6dfb9.JPG)
> - Invoke를 사용하여 코드 재활용을 해보았다. int, "_Hat" 부분을 바꾸면 여러 함수를 호출할 수 있을 것 같아서 만들었는데, 괜찮은 방법인지 모르겠다.
>![0](https://user-images.githubusercontent.com/93506849/209608673-e23a4f18-2288-4cad-9ece-7832efef41a3.JPG)
>
#### 기타
>![풀1](https://user-images.githubusercontent.com/93506849/210203290-b9b0514a-ec54-4c83-946e-7ff8d36e4d52.JPG)
>![object풀](https://user-images.githubusercontent.com/93506849/210203300-87efd2b5-e607-4416-8262-bb886371aeeb.JPG)
> - Object Pooling을 적용해 보았다. GameObject를 생성,삭제 하는데는 많은 리소스를 잡아먹으므로 미리 만들어 두고 재사용 하는 방식으로 쓸데 없는 동적할당을 사용하지 않아 메모리 성능을 개선한다. 물론 너무 크게 사용하면 낭비가 되고, 적게 사용하면 제대로된 생성이 안된다.
>
>![KakaoTalk_20230102_163151224](https://user-images.githubusercontent.com/93506849/210204203-c9956331-f119-4871-b5f5-80fda4dd6624.gif)
>이전과는 눈물 나오는 속도가 차원이 다르다...@_@;;
>
>![장전완료](https://user-images.githubusercontent.com/93506849/210203739-b1c9160f-90c0-4ffb-be15-c3c359a9dfaf.JPG)
>![변경](https://user-images.githubusercontent.com/93506849/210203751-f50585a9-0385-4871-a3dd-11470e662739.JPG)
> -  Object Pooling을 사용하였으므로 기존 코드들을 수정하였다.(주석처리) 새로 생성,삭제 하는 것 보다 메모리 소비가 적어졌고, 반응속도도 개선 되었다.
>
> ![기존](https://user-images.githubusercontent.com/93506849/209037132-fe1e9249-a959-4875-a6f6-bddb2004c444.jpg)
> - Delegate를 사용하여 함수 참조를 적용해 보았다.
> - C# 델리게이트는 한 번 콜백이 추가 또는 제거될 때마다 해당 콜백 리스트 전체를 깊게 복사 합니다. 콜백 리스트가 많거나, 하나의 프레임당 콜백의 참조/해제 수가 많을 경우 내부 Delegate.Combine 메서드의 성능이 순간적으로 크게 나빠지므로, 주의하며 사용한다.
>
>![1](https://user-images.githubusercontent.com/93506849/210197290-174674a2-b3fd-41ba-accc-f7350fcd9c16.JPG)
>![2](https://user-images.githubusercontent.com/93506849/210197296-28da5a99-1cb3-4e4a-b395-dc1f9ecabf56.JPG)
>![3](https://user-images.githubusercontent.com/93506849/210197301-19f43601-9404-433c-ab24-d52d9ded45a2.JPG)
> - Loading Scene을 추가해 보았다. 
> - https://wergia.tistory.com/194 해당 글을 참고하여 작성해 보았다.


