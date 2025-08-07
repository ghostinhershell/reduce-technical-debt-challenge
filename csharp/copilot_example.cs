// This function works, but could be improved for readability and long-term maintenance.
// Your challenge: reduce technical debt without changing the output.

using System;
using System.Collections.Generic;

class Messy {
    static void Main(string[] args) {
        List<string> arr = new List<string> { "dog", "cat", "bird", "fish" };
        string val = "i";
        List<string> res = new List<string>();
        for(int i=0;i<arr.Count;i++){
            if(arr[i].IndexOf(val)!=-1){
                res.Add(arr[i]+i);
            }
        }
        Console.WriteLine("Summary:");
        foreach(string s in res){
            Console.WriteLine(s);
        }
    }
}
