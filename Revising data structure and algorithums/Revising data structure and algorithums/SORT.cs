using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revising_data_structure_and_algorithums
{
    class SORT
    {
        public void Insertion_Sort(int[]data)
        { int j;
            for(int i=0;i<data.Length;i++)
            { j = i;
                int temp = data[i];
                while(j>0&&data[j-1]>temp)
                {
                    data[j] = data[j - 1];
                    j -= 1;
                }
                data[j] = temp;
            }
        }
        public void Selection_Sort(int[]data)
        {
            int min = 0;
            for(int i=0;i<data.Length;i++)
            {
                min = i;
                for(int j=i+1;j<data.Length;j++)
                {
                    if (data[min] > data[j])
                        min = j;

                }
                int temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
        }
        public void BubbleSort(int[] data)
        { bool check = false;
           for(int i=0;i<data.Length;i++)
            {
                for(int j=0;j<data.Length-1;j++)
                {
                    if(data[j]>data[j+1])
                    {
                        int temp = data[j+1];
                        data[j+1] = data[j];
                        data[j] = temp;
                        check = true;
                    }
                }
                if (!check)
                    break;
            }
        }
    }
}
