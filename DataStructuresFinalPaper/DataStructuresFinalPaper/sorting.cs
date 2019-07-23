using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalPaper
{
    class sorting
    {
        public int partition(int[]data,int stat,int end)
        {
            int pivot = end;
            int pinindex = stat;
            for(int i=stat;i<end;i++)
            {
                if(data[i]<=data[pivot])
                {
                    int temp = data[pinindex];
                    data[pinindex] = data[i];
                    data[i] = temp;
                    pinindex++;
                }
            }
            int x = data[pivot];
            data[pivot] = data[pinindex];
            data[pinindex] = x;
            return pinindex;
        }
        public void QuickSort(int[] data,int start,int end)
        {
            if(start<end)
            {
                int pinindex = partition(data, start, end);
                QuickSort(data, start, pinindex - 1);
                QuickSort(data, pinindex + 1, end);

            }
        }
    }
}
