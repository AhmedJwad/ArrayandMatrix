using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppConcepts.Logic
{
    public class MyArray
    {
        private int _top;//logic size
        private int[] _array;

        public MyArray(int n)
        {
            N = n;
            _array = new int[n];
           _top = 0;
        }
        public bool IsFull => _top == N;
        public bool IsEmpty => _top == 0;
        public int N { get; } // physical size

        public void Add(int number)
        {
            if(IsFull)
            {
                throw new Exception("the array is full");
            }
           
            _array[_top] = number;
            _top++;
        }

        public void Insert(int number, int postitin)
        {
            if (IsFull)
            {
                throw new Exception("the array is full");
            }
            if(postitin<0)
            {
                postitin = 0;
            }
            if(postitin > _top)
            {
                postitin = _top;
            }
            for (int i = _top; i > postitin; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[postitin] = number;
            _top++;
        }
        public void Remove(int position)
        {
            if(IsEmpty)
            {
                throw new Exception("the array is empty");
            }
            if(position < 0)
            {
                position = 0;
            }
            if(position > _top)
            {
                position = _top;
            }
            for(int i = position;i<_top -1 ;i++)
            {
                _array[i] = _array[i + 1];
            }
            _top--;
        }
        public MyArray GetPrimes()
        {
            int PrimeCount = 0;
            for (int i = 0; i < _top; i++)
            {
                if (ISPrime(_array[i]))
                {
                    PrimeCount++;
                }
            }
            var primeArray =new MyArray(PrimeCount);
            for (int i = 0; i < _top; i++)
            {
                if (ISPrime(_array[i]))
                {
                    primeArray.Add(_array[i]);
                }
            }
            return primeArray;
        }
        public MyArray GetMosterepeated()
        {
            int[,] matrixCount = new int[_top, 2];
            int topMatrix = FillMatrixCount(matrixCount);
            OrderMatrixCount(matrixCount, topMatrix);
            int repeatedCounter = GetRepeatedCounter(matrixCount, topMatrix);
            return FillMostRepeated(repeatedCounter, matrixCount);
           

        }

        public MyArray GetNonRepeated()
        {
            int NonRepeatedCount = 0;
           
            for (int i = 0; i <_top; i++)
            {
                bool IsRepeated = false;
                for (int j = 0; j < _top; j++)
                {
                    if (i != j && _array[i] == _array[j])
                    {
                        IsRepeated = true;
                        break;
                    }
                }
                    if (!IsRepeated)
                    {
                        NonRepeatedCount++;
                    }
                }
               
           
            var nonRepeates=new MyArray(NonRepeatedCount);

            for (int i = 0; i < _top; i++)
            {
                bool IsRepeated = false;
                for (int j = 0; j < _top; j++)
                {
                    if(i!=j && _array[i] == _array[j])
                    {
                        IsRepeated = true;
                        break;
                    }
                }
                if(!IsRepeated)
                {
                    nonRepeates.Add(_array[i]);
                }

            }
            return nonRepeates;
        }
        public MyArray GetOdds()
        {
            int oddscount = 0;
            for (int i = 0; i <_top; i++)
            {
                if (IsOdd(_array[i]))
                {
                    oddscount++;
                }
            }
            var oddsArray = new MyArray(oddscount);
            for (int i = 0; i < _top; i++)
            {
                if (IsOdd(_array[i]))
                {
                    oddsArray.Add(_array[i]);
                }
            }
            return oddsArray;
        }
        public void Fill()
        {
            fill(1, 100);
        }
        public void fill(int minimum, int maximum)
        {
            Random random = new();
            for (int i = 0; i < N; i++)
            {
                _array[i] = random.Next(minimum, maximum);

            }
            _top = N;
        }

        public override string ToString()
        {
            if (IsEmpty)
            {
                return "there is no item in array";
            }
            string output = string.Empty;
            int count = 0;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
                if(count <20)
                {
                    count = 0;
                    output += "\t";
                }
            }
            return output;
        }
        public void sort()
        {
            sort(descending: false);
        }
        public void sort(bool descending )
        {
            for (int i = 0; i < _top-1 ; i++)
            {
                for (int j = i+1; j< _top; j++)
                {
                    if(descending)
                    {
                        if (_array[i] >_array[j])
                        {
                            Change(ref _array[i],ref _array[j]);
                        }
                    }else
                    {
                        if (_array[i]< _array[j])
                        {
                            Change(ref _array[i],ref _array[j]);
                        }
                    }
                   
                }
            }
        }
        private bool ISPrime(int n)
        {
            if (n == 1) return false;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if(n % i ==0)
                {
                    return false;
                }
            }
            return true;
        }
        private void Change(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b=aux;
        }
        private bool IsOdd(int n)
        {
            return n % 2 == 0;
        }
        private int FillMatrixCount(int[,] matrixCount)
        {
            int TopMatrix = 0;
            for (int i = 0; i < _top; i++)
            {
                int j = 0;
              for  (; j<TopMatrix; j++)
                {
                    if (_array[i] == matrixCount[j,0])
                    {
                        matrixCount[j, 1]++;
                        break;
                    }
                }
              if(j == TopMatrix)
                {
                    matrixCount[TopMatrix, 0] = _array[i];
                    matrixCount[TopMatrix, 1] = 1;
                    TopMatrix++;
                }

            }
            return TopMatrix;
        }
        private void OrderMatrixCount(int[,] matrixCount, int topMatrix)
        {
            for (int i = 0; i < topMatrix - 1; i++)
            {
                for (int j = i+1; j < topMatrix; j++)
                {
                    if (matrixCount[i, 1] < matrixCount[j,1])
                    {
                        Change(ref matrixCount[i, 0], ref matrixCount[j, 0]);
                        Change(ref matrixCount[i, 1], ref matrixCount[j, 1]);

                    }
                }
            }
        }
        private int GetRepeatedCounter(int[,] matrixCount, int topMatrix)
        {
            int repeatedCounter = 1;
            for (; repeatedCounter < topMatrix; repeatedCounter++)
            {
                if (matrixCount[0, 1] != matrixCount[repeatedCounter,1])
                {
                    break;
                }
            }
            return repeatedCounter;
        }
        private MyArray FillMostRepeated(int repeatedCounter, int[,] matrixCount)
        {
            var mostRepeater = new MyArray(repeatedCounter);
            for (int i = 0; i < repeatedCounter; i++)
            {
                mostRepeater.Add(matrixCount[i, 0]);
            }
            return mostRepeater;
        }
    }
}
