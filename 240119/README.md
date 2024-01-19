# 240119
* abstract클래스와 예외처리, 그리고 property와 상속클래스의 upcasting과 downcasting에 대해 학습했다.
* MemoTest(17~18일에 작성한 내용 참고)에서는 try catch로 예외처리하는 법에 대해 학습했다.
* AbstractTest에서는 abstract 클래스와 메서드에 대해 학습했다.
* Starcraft에서는 AbstractTest에서 배운 것을 기반으로 예제를 작성했다.
* UpcastingDownCastingTest에서는 지난 시간에 배우던 upcasting과 downcasting에 대해 학습했다.
* PropertyTest에서는 Property로 반환값을 가져오거나 새 값을 할당하는 것에 대해 학습했다.

## MemoTest
* 지난번에 수정하고자 하는 글을 불러올때 해당하는 글번호의 글이 없을 경우 예외처리를 통해 처리하도록 코드를 수정하였다.
### 예외 처리 : 예외 상황이 생겼을 때 프로그램이 멈추지않고 실행될 수 있게 하는 것.
```
try{
     실행코드;
         ...;
}
catch(예외상황 e)
{
          예외발생시 실행할 코드;
          ....;
	}
	[finally]
```
* Exception : 모든 예외처리.
* ArgumentOutOfRangeException : 범위를 넘어가버렸을때의 예외처리.

## AbstractTest
### 추상 클래스 : 여러 파생 클래스에서 공유할 수 있는 기본 클래스의 공통적인 정의를 제공
* 미완성된 클래스 => 추상 메서드(미완성된 메서드)를 포함하고 있기 때문에....
* 추상메서드 : 추상 클래스에서만 선언할 수 있고, 메서드의 본문이 없다. abstract 사용 / 가상메서드
* 추상클래스의 파생클래스에서 추상 메서드를 모두 구현해야한다.=> override해야한다
* 추상메서드를 선언할 때 static 또는 virtual 키워드를 사용할 수 없다.
* 직접 인스턴스화 할 수 없다(객체 생성 불가..) => new 사용못함
* 추상클래스에서 선언되는 모든 멤버는 접근 제한자를 지정하지 않으면 모두 private이다.
```
abstract class 클래스명 {
}
```
* 추상 클래스도 일반 클래스를 상속할 수 있다.

## PropertyTest
