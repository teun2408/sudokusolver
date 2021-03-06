﻿using System;
using System.Collections.Generic;
using System.Text;
using KillerSudokuSolver.Models;

namespace SudokuTestProject.Sudokus.Killer
{
    public class EvilKiller : ISudoku
    {
        public KillerSudoku CreateSudoku(bool logging)
        {
            //http://www.sudokuwiki.org/killersudoku.htm?bd=111212111322212223333444333121141121123141321443333344441121144311121113333222333,080000171222150000270000000000000020000000200000000000051713000010001314000041000000000000150000000000001800000025003319000000220000000000000019000000000000000000
            List<Cage> cages = new List<Cage>
            {
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(0, 0), new Tuple<int, int>(1, 0), new Tuple<int, int>(2, 0) }, 8),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(3, 0), new Tuple<int, int>(3, 1), new Tuple<int, int>(1, 1), new Tuple<int, int>(2, 1) }, 17),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(4, 0), new Tuple<int, int>(4, 1) }, 12),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(5, 0), new Tuple<int, int>(5, 1), new Tuple<int, int>(6, 1), new Tuple<int, int>(7, 1) }, 22),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(6, 0), new Tuple<int, int>(7, 0), new Tuple<int, int>(8, 0) }, 15),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(0, 1), new Tuple<int, int>(0, 2), new Tuple<int, int>(1, 2), new Tuple<int, int>(2, 2) }, 27),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(3, 2), new Tuple<int, int>(4, 2), new Tuple<int, int>(5, 2), new Tuple<int, int>(4, 3), new Tuple<int, int>(4, 4) }, 20),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(8, 1), new Tuple<int, int>(8, 2), new Tuple<int, int>(7, 2), new Tuple<int, int>(6, 2) }, 20),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(0, 3), new Tuple<int, int>(0, 4) }, 5),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(1, 3), new Tuple<int, int>(1, 4) }, 17),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(2, 3), new Tuple<int, int>(3, 3), new Tuple<int, int>(3, 4) }, 13),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(5, 3), new Tuple<int, int>(5, 4), new Tuple<int, int>(6, 3) }, 10),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(7, 3), new Tuple<int, int>(7, 4) }, 13),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(8, 3), new Tuple<int, int>(8, 4) }, 14),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(0, 5), new Tuple<int, int>(0, 6), new Tuple<int, int>(1, 5), new Tuple<int, int>(1, 6) }, 15),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(2, 4), new Tuple<int, int>(2, 5), new Tuple<int, int>(3, 5), new Tuple<int, int>(4, 5), new Tuple<int, int>(5, 5), new Tuple<int, int>(6, 5), new Tuple<int, int>(6, 4) }, 41),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(7, 5), new Tuple<int, int>(7, 6), new Tuple<int, int>(8, 5), new Tuple<int, int>(8, 6) }, 18),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(0, 7), new Tuple<int, int>(0, 8), new Tuple<int, int>(1, 8), new Tuple<int, int>(2, 8) }, 22),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(1, 7), new Tuple<int, int>(2, 6), new Tuple<int, int>(3, 6), new Tuple<int, int>(2, 7), new Tuple<int, int>(3, 7) }, 25),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(8, 7), new Tuple<int, int>(8, 8), new Tuple<int, int>(7, 8), new Tuple<int, int>(6, 8) }, 19),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(5, 6), new Tuple<int, int>(5, 7), new Tuple<int, int>(6, 6), new Tuple<int, int>(6, 7), new Tuple<int, int>(7, 7) }, 19),
                new Cage(new List<Tuple<int, int>>() { new Tuple<int, int>(4, 6), new Tuple<int, int>(4, 7), new Tuple<int, int>(4, 8), new Tuple<int, int>(3, 8), new Tuple<int, int>(5, 8) }, 33)
            };

            return new KillerSudoku(cages, new Board(null, new Logger(logging)), "evil killer");
        }
    }
}
