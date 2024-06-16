namespace HomeWork3_17_5;

public class Calculator {
    
    private void CheckForOperand(dynamic op) {
        if (!(op is int) && !(op is long) && !(op is float) && !(op is double)) {
            throw new ArgumentException("Непідтримуваний тип операнда");
        }
    }

    public dynamic Add(dynamic x, dynamic y) {
        CheckForOperand(x);
        CheckForOperand(y);
        return x + y;
    }
    public dynamic Subtract(dynamic x, dynamic y) {
        CheckForOperand(y);
        CheckForOperand(x);
        return x - y;
    }
    public dynamic Multiply(dynamic x, dynamic y) {
        CheckForOperand(y);
        CheckForOperand(x);
        return x * y;
    }
    public dynamic Divide(dynamic x, dynamic y) {
        CheckForOperand(y);
        CheckForOperand(x);
        return x / y;
    }



}
