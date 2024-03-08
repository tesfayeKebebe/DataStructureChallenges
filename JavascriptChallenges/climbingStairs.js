const climbingStairs = (n)=>
{
    if(n<3)
    {
        return 1;
    }
    const memo = [0,1,2];
    for(let i=3; i<=n; i++)
    {
        memo[i]= memo[i-1]+ memo[i-2]
    }
    return memo[n];
}
console.log(climbingStairs(8))
console.log(climbingStairs(5))