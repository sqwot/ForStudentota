using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms {

    enum FillType {
        Increment,
        Decrement,
        random
    }

    abstract class Sort {
        protected int[] array;
        protected int arrayLength;

        public Sort(int arrayLength) {
            this.arrayLength = arrayLength;
        }

        public int Transactions { get; protected set; }
        public int Comparisions { get; protected set; }

        public void Fill(FillType type) {
            array = new int[arrayLength];
            switch (type) {
                case FillType.Increment:
                    FillIncrement();
                    break;
                case FillType.Decrement:
                    FillDecrement();
                    break;
                case FillType.random:
                    FillRandom();
                    break;
                default:
                    break;
            }
        }

        public abstract void Sorting();

        public int GetChecksum() {
            int summ = 0;
            for (int i = 0; i < arrayLength; i++) {
                summ += array[i];
            }
            return summ;
        }
        public int GetSeriesCount() {
            int series = 1;
            for (int i = 1; i < arrayLength; i++) {
                if(array[i-1]>array[i]) {
                    series++;
                }
            }
            return series;
        }
        public void Print() {
            for (int i = 0; i < arrayLength; i++) {
                Console.Write($"|{array[i]}");
            }
            Console.WriteLine("|");
        }

        public void FillIncrement() {
            for (int i = 0; i < arrayLength; i++) {
                array[i] = i;
            }
        }
        public void FillDecrement() {
            int j = arrayLength - 1;
            for (int i = 0; i < arrayLength; i++, j--) {
                array[i] = j;
            }
        }
        public void FillRandom() {
            Random R = new Random();
            for (int i = 0; i < arrayLength; i++) {
                array[i] = R.Next(-100, 100);
            }
        }
    }
}
