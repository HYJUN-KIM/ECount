﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_Array_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            //수학과 학생들의 기말고사 시험점수
            int[] score = new int[] { 79, 88, 97, 54, 56, 95 };
            int max = score[0];  //max 변수 >> 79
            int min = score[0];  //min  변수 >> 79

			/*
		        제어문을 사용해서  max  라는 변수에 시험점수 최대값을
		         min  라는 변수에 시험점수 최소값을 담으세요
		        출력결과 : max > 97 , min > 54
		        단 for 문을 한번만 사용하세요 (max , min 하나의  for문)
		    */
			for (int i = 1; i < score.Length; i++)
			{
				
				//if(score[i] > max) { max = score[i];}
				//if(score[i] < min) { min = score[i];}
				max = (score[i] > max) ? score[i] : max;
				min = (score[i] < min) ? score[i] : min;
			}
            Console.WriteLine($"max : {max} , min : {min}");


			//어느 학생의 기말고사 시험점수 (5과목)
			int sum = 0;
			float average = 0f;
			int[] jumsu = { 100, 55, 90, 60, 78 };

			//1. 총과목의 수
			//2. 과목의 합
			//3. 과목의 평균
			//단 2,3  문제는 하나의  for  으로 해결하세요

			for (int i = 0; i < jumsu.Length; i++)
			{
				sum += jumsu[i]; //sum = sum + i
				if (i == jumsu.Length - 1)
				{ //마직막 방 번호와  ....
					average = sum / (float)jumsu.Length;
				}

			}

			Console.WriteLine($"총과목수 : {jumsu.Length} , 합 : {sum}  , 평균 :{average}");

		}
	}
}
