// This method works, but could be improved for readability and long-term maintenance.
// Your challenge: reduce technical debt without changing the output.

public class MessyExample {
    public static void main(String[] args) {
        String[] arr = {"apple", "banana", "cherry", "date"};
        String v = "a";
        for (int i=0;i<arr.length;i++) {
            if (arr[i].contains(v)) {
                System.out.println(arr[i]+i);
            }
        }
    }
}
