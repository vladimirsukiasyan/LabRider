using System;
using System.Collections.Generic;
using System.Text;
using Lab3;

namespace FigureCollections
{
    public class Matrix<T>
    {
        private readonly Dictionary<string, T> _matrix = new Dictionary<string, T>();

        private int _maxX;
        private int _maxY;
        private int _maxZ;


        IMatrixCheckEmpty<T> _сheckEmpty;


        public Matrix(int maxX, int maxY, int maxZ,
            IMatrixCheckEmpty<T> сheckEmptyParam)
        {
            _maxX = maxX;
            _maxY = maxY;
            _maxZ = maxZ;
            _сheckEmpty = сheckEmptyParam;
        }


        public T this[int x, int y, int z]
        {
            set
            {
                checkBounds(x, y, z);
                string key = getDictKey(x, y, z);
                _matrix.Add(key, value);
            }
            get
            {
                checkBounds(x, y, z);
                var key = getDictKey(x, y, z);
                if (_matrix.ContainsKey(key))
                {
                    return _matrix[key];
                }

                return _сheckEmpty.getEmptyElement();
            }
        }


        void checkBounds(int x, int y, int z)
        {
            if (x < 0 || x >= _maxX)
            {
                throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
            }

            if (y < 0 || y >= _maxY)
            {
                throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
            }

            if (z < 0 || z >= _maxZ)
            {
                throw new ArgumentOutOfRangeException("z", "z=" + z + " выходит за границы");
            }
        }

        string getDictKey(int x, int y, int z)
        {
            return x + "_" + y + "_" + z;
        }

        public override string ToString()
        {
            var b = new StringBuilder();
            for (int k = 0; k < _maxZ; k++)
            {
                b.Append("K = " + k + "\n");
                for (int j = 0; j < _maxY; j++)
                {
                    for (int i = 0; i < _maxX; i++)
                    {
                        if (i > 0)
                        {
                            b.Append("\t");
                        }

                        if (!_сheckEmpty.checkEmptyElement(this[i, j, k]))
                        {
                            b.Append(this[i, j, k]);
                        }
                        else
                        {
                            b.Append(" - ");
                        }
                    }

                    b.Append("\n");
                }

                b.Append("\n");
            }

            return b.ToString();
        }
    }
}