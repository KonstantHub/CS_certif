int M = 5;
int N = 23;
void outputNumbers(int num1, int num2)
{
    if(num2 == num1-1)
    {
        return;
    }
    outputNumbers(num1, num2 - 1);
    Console.Write(num2 + " ");
}
outputNumbers(M, N);