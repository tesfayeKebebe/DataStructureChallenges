const primeNumber =(n)=>
{
    if(n<2)
    {
        return n + " is not prime number"
    }
    for(let i=2; i<= n/2; i++)
    {
        if(n%i===0)
        {
            return n + " is not prime number";
        }
    }
    return   n + " is prime number";
}
console.log(primeNumber(13))
console.log(primeNumber(8))
console.log(primeNumber(1))