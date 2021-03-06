﻿using KillerSudokuSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillerSudokuSolver.Helpers
{
    public class CageCombinationFinder
    {
        public static List<SortedSet<int>> CagePossibilities(int cageValue, int tiles, SortedSet<int> possibleValues, KillerSudoku killerSudoku)
        {
            return CalculatePosibilitiesNotAdd(cageValue, new SortedSet<int>(), 0, killerSudoku.Board.board.Count)
                .Where(x => x.Count == tiles)
                .Where(x => x.All(y => possibleValues.Contains(y)))
                .ToList();
        }

        private static List<SortedSet<int>> CalculatePosibilitiesAdd(int remainingvalue, SortedSet<int> currentset, int nextValue, int size)
        {
            SortedSet<int> newPosibility = new SortedSet<int>();
            currentset.ToList().ForEach(x => newPosibility.Add(x));
            remainingvalue -= nextValue;
            newPosibility.Add(nextValue);
            if (remainingvalue == 0)
            {
                List<SortedSet<int>> result = new List<SortedSet<int>>();
                result.Add(newPosibility);
                return result;
            }
            if (remainingvalue < 0)
            {
                return new List<SortedSet<int>>();
            }
            if (nextValue >= size)
            {
                return new List<SortedSet<int>>();
            }
            else
            {
                List<SortedSet<int>> res = CalculatePosibilitiesAdd(remainingvalue, newPosibility, nextValue + 1, size);
                List<SortedSet<int>> res2 = CalculatePosibilitiesNotAdd(remainingvalue, newPosibility, nextValue + 1, size);
                res2.ToList().ForEach(x => res.Add(x));
                return res;
            }
        }

        private static List<SortedSet<int>> CalculatePosibilitiesNotAdd(int remainingvalue, SortedSet<int> currentset, int nextValue, int size)
        {
            if(nextValue >= size)
            {
                return new List<SortedSet<int>>();
            }

            List<SortedSet<int>> res = CalculatePosibilitiesAdd(remainingvalue, currentset, nextValue + 1, size);
            List<SortedSet<int>> res2 = CalculatePosibilitiesNotAdd(remainingvalue, currentset, nextValue + 1, size);
            res2.ToList().ForEach(x => res.Add(x));
            return res;
        }
    } 
}
