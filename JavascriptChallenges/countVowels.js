const countVowels= (s)=>
{
    const vowel = "aeiou"
    let count =0;
    const sSplit = s.toLowerCase().split('');
    for(let i=0; i<s.length; i++)
    {
        if(vowel.includes(sSplit[i]))
        {
            count++;
        }
    }
    return count;
}
console.log(countVowels("TEsfaye"))