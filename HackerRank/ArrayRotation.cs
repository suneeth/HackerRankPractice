using System;

namespace HackerRank
{
    public class ArrayRotation
    {   
        private string  _array="";
        public ArrayRotation(string array)
        {
            _array=array;
        }

        public int[] RotateRight(int arraylength,int rotations)
        {
           

                int n = arraylength;

                int k = rotations;

                string[] a_temp = _array.Split(' ');

                int[] a = Array.ConvertAll(a_temp,Int32.Parse);
                 

                int[] ta=new int[n];
                if(k==0){
                    return a;
                }

                for(int i=0; i< n;i++)
                {
                    if(i >= n-k) // 3
                        {
                            ta[i-(n-k)]= a[i]; 
                        }
                    else
                        {
                            ta[i+k]= a[i]; 
                        }
                }
                return ta;
        }

        public int[] RotateLeft(int arraylength, int rotations)
        {
               int n = arraylength;

                int k = rotations;

                string[] a_temp = _array.Split(' ');

                int[] a = Array.ConvertAll(a_temp,Int32.Parse);
                 

                int[] ta=new int[n];
                if(k==0){
                    return a;
                }

                for(int i=n-1; i >= 0; i--)
                {
                    if(i >=n-k)  //>= 4
                    {
                       ta[i]=a[i-(n-k)];
                    }
                    else
                    {
                       ta[i]= a[i+k];     
                    }
                }

                return ta;
        }
    }
     
}
