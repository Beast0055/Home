string CalculateSum(int n, string res = "") {
    if(n == 1) {
        return res += n.ToString();
    }
    res+= n.ToString() + " ";
    return CalculateSum(n - 1, res);
}

Console.WriteLine(CalculateSum(5));



