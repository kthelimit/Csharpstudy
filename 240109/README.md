# 240109
* 이번 시간에는 정렬과 while 반복문에 대해서 배웠다.
* SelectionSort에서는 선택정렬에 대해 배웠다.
* RankingTest, RankingTest2에서는 주어진 점수에 따른 등수를 매기는 방법에 대해 배웠다.
* BubbleSortTest에서는 버블정렬에 대해 배웠다.
* WhileTest, WhileTest2에서는 while 반복문에 대해 학습했다.

## SelectionSort
### 선택정렬 
* 중첩for문을 사용한다.
* i번째 데이터를 선택해서 j번째 데이터와 비교한 후, 앞의 데이터가 크면 두 기억장소에 저장된 값을 교환한다. 오름차순.
* 하나를 잡고 뒤쪽의 데이터들 하나하나씩과 비교해가며 진행하는 것이라 앞쪽부터 작은 순서대로 정렬이 진행된다.

## RankingTest
* RankingTest에서는 점수가 적힌 배열과 별개로 등수 관리용 배열을 만들어 1로 초기화하고 각 점수들을 비교해 뒤쪽의 점수가 더 높은 경우 해당 위치의 등수에 1을 추가했다.
* RankingTest2에서는 두 점수를 비교하고 둘 중 적은 점수쪽의 등수를 1 올리는 대신, 비교하는 횟수를 줄였다. 결과적으로 선택정렬과 비슷한 형태가 되었다.

## BubbleSortTest
### 버블정렬
* 중첩for문을 사용한다.
* j번째 인덱스의 데이터를 선택해서 j+1번째 인덱스의 데이터와 비교하며 앞의 값이 크면 데이터를 교환한다. 오름차순
* 연이어 놓인 데이터들을 비교해서 더 큰 값을 뒤로 보내며 뒤쪽으로 진행하는 것이라 뒤쪽부터 큰 순서대로 정렬이 진행된다.

## WhileTest
* WhileTest에서는 for반복문을 이용한 1에서 10까지의 합계를 구하는 코드를 while문과 do while문을 활용해 다시 작성해보았다.
* WhileTest2에서는 무한루프 상태로 while문을 작성하고 무한루프를 빠져나가는 방법에 대해 배웠다.