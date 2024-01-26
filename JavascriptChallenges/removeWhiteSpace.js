const removeWhiteSpace =(s) =>{
    //\s matches white space characters including tab and line brake
    // the g flag is used to perform a global search and replace, 
    // replacing all occurrences
 const replaceStr = s.replace(/\s/g, "");
 return replaceStr;
// return s.split(" ").join("")
}
console.log(removeWhiteSpace("You are     good person"))
