# My_RPG-trial_version-
## 정현우
 개인과제 - '내가 만들고 싶은 게임' 구현하기


마음 속에 '만들고 싶은 게임'은 분명히 있지만, 4일 만에 구현하기에는 그 스케일이 너무 크고 복잡하기 때문에  
4일만으로는 확실하게 시간이 불충분하다고 판단했습니다.  
따라서 이번 과제에서는 필수 구현 기능만 간략하게 구현하고  
남은 시간에는 이번 주차 강의를 학습하고, 이제껏 들은 강의와 강의 자료들을 전체적으로 복습하는 시간을 가졌습니다.  
구현한 기능 목록은 다음과 같습니다.  

![image](https://github.com/jhwoo944/My_RPG-trial_version-/assets/128718414/a5c398a2-b6c0-4f67-aa61-3acaeaf6effb)  

### 타이틀 화면
 - 새로 하기, 이어하기, 게임 종료 메뉴  
버튼이 아닌 이미지와 스크립트를 활용하여 구현하였습니다.  
키보드 방향키와 마우스로 선택중인 메뉴를 전환할 수 있고, 엔터키와 좌클릭으로 메뉴 동작을 실행할 수 있습니다.  
＊이어하기 기능은 미구현입니다.  

### 플레이어 및 카메라, 룸 이동
![image](https://github.com/jhwoo944/My_RPG-trial_version-/assets/128718414/1f9f3b45-20e7-417d-8d02-fb194f53d8d2)  
![image](https://github.com/jhwoo944/My_RPG-trial_version-/assets/128718414/1cd52469-077a-4843-9abd-34f56d17f038)

- 플레이어를 W A S D로 움직일 수 있습니다.
- 카메라는 플레이어를 부드럽게 따라갑니다.
- 우측 상단의 계단에 진입 시 다른 씬으로 이동할 수 있습니다.
이 때 카메라와 플레이어는 씬 이동 시에도 삭제되지 않습니다.  
플레이어는 Potal 오브젝트 인스펙터에 저장된 값에 따라 씬을 이동하고,  
씬 로드가 완료 될 시에도 Potal 오브젝트 인스펙터에 저장된 값을 받아와 적절한 좌표로 이동합니다.
 - 타일맵으로 맵을 꾸미고 솔리드를 적용했습니다.
 - 플레이어 조작은 InputAction을 활용했습니다.

### 스크립트 파일 구성
게임의 구현 기능과는 관계 없지만, 스탠다드 세션의 '설계' 항목 강의를 참조하여  
추후 개발 작업 시에 도움이 될 수 있는 스크립트 구조 설계의 기틀을 마련해 보았습니다.  



 - BaseMonoBehaviour.cs  
모노 비헤이비어를 래핑한 클래스로,  
지금은 아무 기능도 없지만 추후에 필요한 프로퍼티 또는 메서드 등을  
이것 저것 추가하여 자식 클래스들에게 상속하는 용도로 작성하였습니다.  
모든 스크립트 클래스는 BaseMonoBehaviour 클래스를 상속합니다.  

 - OverallManager.cs  
모든 Manager와 Public_Data 스크립트들을 유기적으로 잇는 총괄 매니저 스크립트입니다.  
각각의 스크립트들은 OverallManager를 참조 및 역참조하도록 구성되어 있습니다.  

 - Public_Enum.cs , Public_Structer.cs , Public_Utility.cs, Public_Variable.cs  
공용으로 쓸 수 있는, 데이터들을 한데 모아놓은 스크립트들 입니다.  
Public_Variable.cs에서 OvarallMAnager를 중개자로 플레이어가 씬 이동 시 다음 맵에서 어떤 좌표에 나타날 지를 저장하고 씬 로드 완료 시에 리턴합니다.  
Public_Utility.cs는 스크립트 작성 시 유용한 메서드들을 저장합니다.  

 - UiManager.cs , SoundManager.cs , TestManager.cs  
UiManager 와 SoundManager은 차후 사용 될 수 있지만 현재는 빈 스크립트이며,  
TestManager 는 게임 테스트 시에 유용한 기능들을 키보드 숫자 1~0번을 눌러 사용할 수 있도록 작성했습니다.
