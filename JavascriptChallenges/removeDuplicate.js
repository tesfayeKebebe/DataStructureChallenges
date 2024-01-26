const removeDuplicate =(arr)=>
{
    let setList = new Set();
    for(let i=0; i<arr.length;i++)
    {
        setList.add(arr[i])
    }
    return setList;

    
}
console.log(removeDuplicate([1,2,3,4,4,7,8,8]))