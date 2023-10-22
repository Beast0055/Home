int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int Sum(int n1 ,int n2, int sum = 0) {
    if(n2 == n1) {
        return sum += n2;
    }
    sum += n2;
    return Sum(n1, n2 - 1, sum);
}
Console.WriteLine(Sum(M, N));
