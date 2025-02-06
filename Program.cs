﻿public class Program
{
    static int SeqSearch(int[] arr, int value){
        int i = 0;
        while(arr[i]!=value)
            i++;
        return i;
    }
    static int RecuSearch(int[] arr, int from, int value){
        if(arr==null)
            return -1;
        if(arr[from]==value)
            return from;
        else
            return RecuSearch(arr, from+1, value);
    }

    //Cài đặt SenSearch bằng đệ quy
    static int SenSearch(int[] arr, int value){
        int x = arr[arr.Length-1];
        arr[arr.Length-1] = value; //Thêm phần tử cần tìm vào cuối mang - sentinel
        int i = SeqSearch(arr, value);
        arr[arr.Length-1] = x;
        if(i<arr.Length-1)
            return i;
        else if(x==value)
            return arr.Length-1;
        else
            return -1;
    }

    //Cài đặt BinSearch bằng đệ quy
    static int BinSearch(int[] sarr, int value){
        int L = 0, R = sarr.Length-1;
        while(L<=R){
            int m = (L+R)/2;
            if(sarr[m]==value)
                return m;
            else if(sarr[m]<value)
                L = m+1;
            else
                R = m-1;
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        //int[] arr = {3, 9, 2, 5, 6};
        //int value = 6;
        //int index = SeqSearch(arr, value);
        //int index = RecuSearch(arr, 0, value);
        //int index = SenSearch(arr, value);
        //Console.WriteLine($"Phần tử có giá trị {value} ở vị trí {index}");

        int[] sarr = {2, 3, 5, 6, 9};
        int value = 6;
        int index = BinSearch(sarr, value);
        Console.WriteLine($"Phần tử có giá trị {value} ở vị trí {index}");
    }
}