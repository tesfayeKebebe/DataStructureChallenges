const longest =(str)=> {
    var longStr ="";
    let len = 0;
    var splitString = str.split(" ");
    for(let i=0; i<splitString.length; i++)
    {
        if(splitString[i].length>longStr.length)
        {
            longStr =  splitString[i];
        }
    }
    return longStr;
}
console.log(longest("My name is Tesfaye"))