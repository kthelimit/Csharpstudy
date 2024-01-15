# 240115
* 메서드와 Class에 대해서 학습했다.
* CalendarTest3에서는 지난번에 작성한 CalendarTest의 코드를 기반으로 일부 기능들을 메서드로 바꾸는 것을 연습했다.
* CarTest에서는 Class의 개념과 멤버 변수, 그리고 메서드에 대해 학습했다.
* CardPicker에서는 랜덤으로 카드를 뽑아 그 숫자와 무늬를 결정해주는 각각의 메서드를 작성해보았다.

## CalendarTest3
* 지난 시간(240112)에 작성한 CalendarTest2의 코드를 기반으로 하는 스크립트이다.
* 대부분의 메서드를 Calendar라는 클래스에 몰아서 작성했고 Program(Main이 위치하고 있는 cs파일)에서 그것을 불러와 활용하는 형태이다.
* 메서드는 윤년여부를 체크하는 IsLeapYear, 이전에는 DateTime.DaysInMonth로 가져왔던 달의 마지막 날짜를 알려줄 LastDay, 그리고 입력받은 날짜까지의 날 수를 계산해주는 TotalDay, 이전에도 작성했던 WeekDay를 작성했다.
* 각각의 기능을 메서드로 작성하자 각 메서드에서도 다른 메서드를 불러와 사용하는 구간이 많았기 때문에 생각보다 더 코드가 짧아져 편리해졌다고 느꼈다.

## CarTest
* 여기서는 Car라는 클래스와 그 멤버변수인 name, 그리고 메서드인 MoveForward를 작성해보고 MainApp에서 그것들을 불러와 car와 car2라는 객체를 생성해 이것저것 테스트해보았다.
* car와 car2는 같은 Car라는 클래스로부터 생성되었지만 서로 독립적이라는 것을 알 수 있었다.

## CardPicker
* 이전에 했던 카드셔플과는 달리 각각의 카드를 뽑을 때마다 랜덤하게 돌리는 것이라 중복이 나온다.
* CardPicker의 객체를 생성해서 쓰는 경우 CardPicker 내부의 메서드들에 static이 붙지않아도 되었지만 CardPicker를 직접 불러와 사용하려면 static이 필요했다.
