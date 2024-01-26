const checkAnagram = (s1,s2)=>
{
    // if(s1.length!==s2.length)
    // {
    //   return "Not anagram"
    // }
    // const s1Split = s1.split("");
    // for(let i=0; i<s1.length; i++)
    // {
    //     if(!s2.includes(s1Split[i]))
    //     {
    //         return  "Not anagram";
    //     }
    // }
    // return  "They are anagram";
   const s1Arr = s1.split('').sort().join('')
   const s2Arr = s2.split('').sort().join('')
    if(s1Arr!==s2Arr)
    {
      return "Not anagram"
    }
    else
    {
        return  "They are anagram";  
    }
}
console.log(checkAnagram("silent3", "listen2"));
console.log(checkAnagram("silent", "listen"));