using System.Collections;

public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack myStack = new Stack();
        foreach(string item in tokens)
        {
            bool isNum = Int32.TryParse(item, out int itemInt);
            if (isNum)
            {
                myStack.Push(itemInt);
            } else
            {
                int operand2 = (int)myStack.Pop();
                int operand1 = (int)myStack.Pop();
                switch (item)
                {
                    case "+":
                        myStack.Push(operand1 + operand2);
                        break;
                    case "-":
                        myStack.Push(operand1 - operand2);
                        break;
                    case "*":
                        myStack.Push(operand1 * operand2);
                        break;
                    case "/":
                        myStack.Push(operand1 / operand2);
                        break;
                }
            }
            
        }
        return (int)myStack.Pop();
    }
}