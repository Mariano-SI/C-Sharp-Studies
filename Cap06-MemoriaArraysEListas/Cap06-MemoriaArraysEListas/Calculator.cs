﻿using System;


namespace Cap06_MemoriaArraysEListas {
    internal class Calculator {

        public static int Sum(params int[] numbers) {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static int Triple(ref int x) {
            return x *= 3;
        }
    }
}
