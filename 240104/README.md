# 240104
* switch 문 / switch 식 / For 문에 대해서 배웠다.
* FuzzyBuzzy는 3의 배수에 Fuzzy, 5의 배수에 Buzzy, 3과 5의 공배수에 FuzzyBuzzy를 출력하는 예제다.
* StarTest는 for문 안에 for문을 넣어 별을 출력하는 예제다.

## SwitchTest
```
    string grade = score switch
            {
                9 => "A",
                8 => "B",
                7 => "C",
                6 => "D",
                _=> "F" //무시 패턴, switch 문의 default. 언더스코어가 들어가는 것이다.
            };
```
switch 식의 사용법.
