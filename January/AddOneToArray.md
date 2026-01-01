# Intuition
The number is represented as an array of digits, so adding one is similar to manual addition. Starting from the last digit, we add 1. If the digit becomes 10, we set it to 0 and carry 1 to the next digit on the left. This carry may continue through the entire array.

# Approach
- Initialize a carry with value 1 to represent adding one to the number.
- Traverse the digits array from right to left.
- For each digit, add the carry:
    - Update the digit with sum % 10.
    - Update the carry with sum / 10.
- After processing all digits:
    - If a carry still exists (e.g., input was [9,9,9]), create a new array with the carry at the front followed by the updated digits.
    - Otherwise, return the modified digits array directly.

# Complexity
- Time complexity:
O(n) — where n is the number of digits, since we traverse the array once.

- Space complexity:
O(1) extra space — no additional data structures are used except for the output array when an extra digit is required

# Code
```csharp []
public class Solution {
    public int[] PlusOne(int[] digits) 
    {
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int n = digits[i] + carry;
            digits[i] = n % 10;
            carry = n / 10;
        }
        if (carry > 0)
        {
            var newDigits = new int[digits.Length + 1];
            newDigits[0] = carry;
            for (int i = 0; i < digits.Length; i++)
            {
                newDigits[i + 1] = digits[i];
            }
            digits = newDigits; 
        }
        return digits;
    }
}
```
