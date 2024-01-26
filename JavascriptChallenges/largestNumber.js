const largestNumber = (arr)=>
{
    let largestNum = 0;
    for(let i=0; i<arr.length; i++)
    {
        if(arr[i]>largestNum)
        {
            largestNum = arr[i];
        }
    }
    return largestNum;
}
console.log(largestNumber([2,5,8]))
console.log(largestNumber([2,10,8]))
console.log(largestNumber([2,1,1]))