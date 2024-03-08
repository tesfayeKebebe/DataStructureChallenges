const isPalindrome =(str)=>
{
    let splitStr = str.split('');
    let start =0;
    let end = splitStr.length-1;
    while(start<=end)
    {
        if(splitStr[start]!==splitStr[end])
        {
            return false
        }
        start++;
        end--;
    }
    return true;
}
console.log(isPalindrome("carrac"))
console.log(isPalindrome("carrad"))