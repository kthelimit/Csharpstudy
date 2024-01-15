using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalendarTest3
{
    // 달력 작업에 필요한 메서드를 모아놓은 클래스
    internal class Calendar
    {
        public static bool IsLeapYear(int year)
        {
            //   bool result = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
            //  return result;
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
        //각 월의 마지막 날짜 구하기
        public static int LastDay(int year, int month)
        {
            //2월, 짧은 달(4,6,9,11), 긴달(1,3,5,7,8,10,12)

            /*switch (month)
            {
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
            */

            // 각 달의 마지막 날짜를 기억하는 배열을 선언한다.
            int[] m = { 31, 0, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            m[1] = IsLeapYear(year) ? 29 : 28;
            return m[month - 1];
        }
        public static int TotalDay(int year, int month, int day)
        {
            int sum = (year - 1) * 365 + (year - 1) / 4 - (year - 1) / 100 + (year - 1) / 400;
            //int sum = (year - 1) * 365;
            /*
            for(int i=1;i<year;i++)
            {
                if (IsLeapYear(i))
                {
                    sum++;
                }
            }*/
            for (int i = 1; i < month; i++)
            {
                sum += LastDay(year, i);
            }
            return sum + day;
        }

        public static int WeekDay(int year, int month, int day)
        {
            return TotalDay(year, month, day) % 7;
        }
    }
}
