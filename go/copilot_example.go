// This function works, but could be improved for readability and long-term maintenance.
// Your challenge: reduce technical debt without changing the output.

package main

import "fmt"
import "strings"

func main() {
    arr := []string{"one", "two", "three", "four"}
    val := "o"
    var r []string
    for i := 0; i < len(arr); i++ {
        if strings.Contains(arr[i], val) {
            r = append(r, arr[i]+fmt.Sprintf("%d", i))
        }
    }
    fmt.Println("Result:")
    for _, v := range r {
        fmt.Println(v)
    }
}
