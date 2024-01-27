const fibonacci = (n)=> {
    const arr=[0,1];
    for(let i =2; i<n; i++)
    {
        let sum = arr[i-1] + arr[i-2];
        arr.push(sum);
    }
    return arr;
}
console.log(fibonacci(8))