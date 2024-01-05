# 240105
* 이번 시간에는 배열과 for문을 이용한 반복문에 대해서 배웠다.
* ArrayTest에서는 배열을 생성하는 방법, 그리고 foreach에 대해서 배웠다.
* DiceTest, DiceTest2, DiceTest3은 Random을 사용해 1~6 사이의 무작위의 수(주사위의 눈)를 10개 생성하고 각 눈이 몇번 나왔는지 세어보는 코드를 작성했다.
* PerfectNum과 PerfectNum2는 완전수(자기자신을 제외한 약수들의 합이 자기 자신이 되는 수. 6,28, 496 등)를 구하는 코드를 작성했다.

## ArrayTest
* 배열은 선언과 함께 초기화가 된다.
  *    int : 0 / double : 0 / char : 공백 / bool : false / 참조형식(string, object)의 배열은 null로 초기화된다.
```
데이터타입[] 배열이름 = new 자료형[크기];
데이터타입[] 배열이름 = new 자료형[] {값1, 값2, ...};
데이터타입[] 배열이름 = {값1, 값2, .....};
```
## DiceTest
DiceTest, DiceTest2, DiceTest3은 같은 결과물(주사위의 각 눈이 몇번 나왔는가)을 내는 코드로 뒤쪽으로 갈수록 배열과 for문을 사용해 점점 코드의 줄 수를 줄여나갔다.
