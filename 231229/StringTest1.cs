using System;

namespace StringTest1
{
    internal class StringTest1
    {
        static void Main(string[] args)
        {
            string str = "SeoulIt_academy";

            // IndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾음.=> 첫번째 글자는 0부터 시작.
            // => 대소문자를 구분하고 문자열이 없는 경우 -1을 반환한다. 중복되는 값이 있으면 먼저 나온 값을 나타냄.
            Console.WriteLine(str.IndexOf("S"));
            Console.WriteLine(str.IndexOf("s"));
            Console.WriteLine(str.IndexOf("a"));

            // LastIndexOf() : 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾음.
            Console.WriteLine(str.LastIndexOf("a"));

            // StartsWith() : 현재 문자열이 지정된 문자열로 시작하는지 평가
            Console.WriteLine(str.StartsWith("S"));
            Console.WriteLine(str.StartsWith("s"));

            // EndsWith() : 현재 문자열리 지정된 문자열로 끝나는지 평가
            Console.WriteLine(str.EndsWith("my"));
            Console.WriteLine(str.EndsWith("m"));

            // Contains() : 현재 문자열이 지정된 문자열을 포함하는지를 평가
            Console.WriteLine(str.Contains("academy"));

            // Replace() : 현재 문자열에서 지정된 문자열을 다른 문자열로 바꾼다
            Console.WriteLine(str.Replace("It","it"));

            // ToLower() : 대문자 -> 소문자
            // ToUpper() : 소문자 -> 대문자
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());

            //Insert() : 현재 문자열에서 지정된 위치에 지정된 문자열을 삽입
            Console.WriteLine(str.Insert(15, "홍대"));
            Console.WriteLine(str.Insert(10, "홍대"));

            //Remove() : 현재 문자열에서 지정된 위치로부터 지정된 수만큼의 문자 삭제. 뒤쪽 숫자를 안 적으면 싹 다 지움
            Console.WriteLine(str.Remove(7,1));
            Console.WriteLine(str.Remove(7));

            str = "             SeoulIT_academy       ";
            //Trim() : 현재 문자열의 앞/뒤 공백 제거
            Console.WriteLine(str);
            Console.WriteLine(str.Trim());

            //TrimStart() : 현재 문자열의 앞에 있는 공백 제거
            Console.WriteLine(str.TrimStart()+"앞 공백 제거");

            //TrimEnd() : 현재 문자열의 뒤에 있는 공백 제거
            Console.WriteLine(str.TrimEnd()+"뒷 공백 제거");

            //Split("구분자") : 현재 문자열을 지정된 문자를 기준으로 분리. => 분리된 문자열은 배열로 저장됨.
            str = "Seoul_IT_Acedemy";
            Console.WriteLine(str.Split("_"));
            Console.WriteLine(str.Split("_")[0]);
            Console.WriteLine(str.Split("_")[1]);
            Console.WriteLine(str.Split("_")[2]);

            // SubString() : 현재 무자열의 지정된 위치로부터 지정된 수만큼 문자열 추출. 뒤에 수를 안 적으면 뒤를 전부 추출
            Console.WriteLine(str.Substring(8));
            Console.WriteLine(str.Substring(9,7));

            // CompareTo() : 문자열 비교 => 같으면 0 / 다르면 1 또는 -1
            // Equals() : 문자열 비교 => 같으면 True / 다르면 False
            str = "토마토";
            Console.WriteLine(str.CompareTo("바나나"));
            Console.WriteLine(str.CompareTo("토마토"));
            Console.WriteLine(str.Equals("바나나"));
            Console.WriteLine(str.Equals("토마토"));

            // Length : 문자열의 길이(개수)
            str = "SeoulIT_academy";
            Console.WriteLine("str의 글자 개수 "+str.Length);
        }
    }
}
