﻿using KillerSudokuSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KillerSudokuSolver.Helpers
{
    public class Helper
    {
        public static SortedSet<int> PossibleValues(KillerSudoku killerSudoku)
        {
            int count = killerSudoku.Board.board.Count;
            SortedSet<int> result = new SortedSet<int>();

            for(var i = 1; i <= count; i++)
            {
                result.Add(i);
            }

            return result;
        }

        public static List<List<Field>> GetAllRowColKubes(KillerSudoku killerSudoku)
        {
            List<List<Field>> rowColKubes = new List<List<Field>>();
            Board board = killerSudoku.Board;
            board.board.ForEach(row => rowColKubes.Add(row));

            for (var i = 0; i < board.board.Count; i++) { rowColKubes.Add(board.getColumn(i)); };

            int kubeCount = Convert.ToInt32(Math.Sqrt(board.board.Count));

            for (var i = 0; i < board.board.Count; i++)
            {
                Tuple<int, int> kubenumber = new Tuple<int, int>(i / kubeCount, i % kubeCount);

                rowColKubes.Add(board.getKube(killerSudoku, kubenumber));
            };

            return rowColKubes;
        }

        public static List<List<Field>> GetAllColumns(KillerSudoku killerSudoku)
        {
            List<List<Field>> rowColKubes = new List<List<Field>>();
            Board board = killerSudoku.Board;

            for (var i = 0; i < board.board.Count; i++) { rowColKubes.Add(board.getColumn(i)); };
            return rowColKubes;
        }

        public static List<List<Field>> GetAllKubes(KillerSudoku killerSudoku)
        {
            List<List<Field>> rowColKubes = new List<List<Field>>();
            Board board = killerSudoku.Board;

            int kubeCount = Convert.ToInt32(Math.Sqrt(board.board.Count));

            for (var i = 0; i < board.board.Count; i++)
            {
                Tuple<int, int> kubenumber = new Tuple<int, int>(i / kubeCount, i % kubeCount);

                rowColKubes.Add(board.getKube(killerSudoku, kubenumber));
            };
            return rowColKubes;
        }

        public static List<Field> ConcatBoard(Board board)
        {
            List<Field> fields = new List<Field>();
            board.board.ForEach(row => fields = fields.Concat(row).ToList());
            return fields;
        }

        public static void HashBoard(Board board)
        {
            board.allFields().Select(x => x.Value)
                .Where(x => x != 0)
                .ToList()
                .ForEach(x => Console.Write(x));
        }



        public static List<Tuple<int, int>> ToTupleList(List<Field> fields)
        {
            List<Tuple<int, int>> res = new List<Tuple<int, int>>();
            fields.ForEach(field => res.Add(field.Coordinates));
            return res;
        }

        public static int TotalRowValue(KillerSudoku killerSudoku)
        {
            return PossibleValues(killerSudoku)
                .Aggregate((a, b) => a + b);
        }

        public static string GetRowType(List<Field> row)
        {
            Field basicField = row.FirstOrDefault();
            if (row.All(field => basicField.Coordinates.Item1 == field.Coordinates.Item1)) return "column";
            if (row.All(field => basicField.Coordinates.Item2 == field.Coordinates.Item2)) return "row";
            else return "kube";
        }
    }
}
