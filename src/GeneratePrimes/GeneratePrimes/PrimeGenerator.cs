﻿namespace GeneratePrimes;

/// <remarks>
/// This class Generates primes numbers up to a user specified
/// maximum. The algorithm used is the Sieve of Eratosthenes.
/// Given an array of integers starting at 2:
/// Find the first uncrossed integer, and cross out all its
/// multiples. Repeat until there are no more multiples
/// in the array.
/// </remark>
using System;

public class PrimeGenerator
{
    private static bool[] f;
    private static int[] result;

    public static int[] GeneratePrimeNumbers(int maxValue)
    {
        if (maxValue < 2)
            return new int[0];
        else
        {
            InitializeArrayOfIntegers(maxValue);
            CrossOutMultiples();
            PutUncrossedIntegersIntoResult();
            return result;
        }
    }

    private static void PutUncrossedIntegersIntoResult()
    {
        int i;
        int j;
        // how many primes are there?
        int count = 0;
        for (i = 0; i < f.Length; i++)
        {
            if (f[i])
                count++;    // bump count
        }

        result = new int[count];

        // move the primes into the result
        for (i = 0, j = 0; i < f.Length; i++)
        {
            if (f[i])               // if prime
                result [j++] = i;
        }
    }

    private static void CrossOutMultiples()
    {
        int i;
        int j;
        for (i = 2; i < Math.Sqrt(f.Length) + 1; i++)
        {
            if (f[i])   // if i is uncrossed, cross out its multiples.
            {
                for (j = 2 * i; j < f.Length; j += i)
                    f[j] = false;   // multiple is not prime
            }
        }
    }

    private static void InitializeArrayOfIntegers(int maxValue)
    {
        // declarations
        f = new bool[maxValue + 1];
        f[0] = f[1] = false;    // neither primes nor multiples.
        for (int i = 2; i < f.Length; i++)
            f[i] = true;
    }
}