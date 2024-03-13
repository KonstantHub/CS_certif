int[]myArray = {1, 2, 7, 0, 10, 34, 11, 27};
int myArrayLength = myArray.Length;
void outputElemtntsBackwards(int[]array, int length)
{
    if(length == 0)
    {
        return;
    }
    int i = length - 1;
    Console.Write(array[i] + " ");
    outputElemtntsBackwards(array, length - 1);
}
outputElemtntsBackwards(myArray, myArrayLength);
