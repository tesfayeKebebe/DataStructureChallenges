// // snippet 0-2
// let howMany = function () {
//     return 42;
//   };
  
//   console.log(howMany);//[Function: howMany]
//   console.log(howMany());//42
  
//   const theAnswer = howMany();
//   console.log(theAnswer);//42
  
//   let howMuch = function () {
//     5;
//   };
//   console.log(howMuch());// undefined

// snippet 0-3
// let average = function (num1, num2) {
//     console.log("calculating...");
//     return (num1 + num2) / 2;
//   };
  
//   console.log(average(5, 10));//7.5
//   console.log(average(20, 26));//23
//   console.log(average(50, 100) + 2);//77
  
//   let a = 21 + 3;//23
//   let b = 20;
//   let n = average(a, b);//23+20=43/2=21.5
//   console.log(average(n, 18));//21.5+18=39.5/2=19.75=20

// // snippet 0-4
// let exclaim = function (str) {
//     let capitalized = str.toUpperCase();
//     return capitalized + "!!";
//   };
  
//   let result = exclaim("potato");//POTATO!!
//   console.log(result);//POTATO!!
//   console.log(result.length);//8
//   console.log(result[0]);//P
//   console.log(result[result.length - 1]);//!


// Write a function `isDivBy4` that accepts a number as an argument. The function should return a
// boolean indicating whether or not the number is divisible by 4.
// const isDivBy4 = function(n)
// {
//     if(n%4===0)
//     return true
//      else
//      return false;
// }
// console.log(isDivBy4(8)); // true
// console.log(isDivBy4(12)); // true
// console.log(isDivBy4(24)); // true
// console.log(isDivBy4(9)); // false
// console.log(isDivBy4(10)); // false

// Write a function `keepItQuiet` that accepts a string as an argument. The function should return the
// lowercase version of the string with 3 periods added to the end of it.
// const keepItQuiet = function(str)
// {
//     return str.toLowerCase() + "..."
// }
// console.log(keepItQuiet("HOORAY")); // 'hooray...'
// console.log(keepItQuiet("Doggo")); // 'doggo...'
// console.log(keepItQuiet("WHAT?!?!")); // 'what?!?!...'

// Write a function `isLong` that accepts a string as an argument. The function should return a boolean
// // indicating whether or not the string is longer than 5 characters
// const isLong = function(str)
// {
//     if(str.length > 5)
//     return true
//     else
//     return false;
// }
// console.log(isLong("pie")); // false
// console.log(isLong("kite")); // false
// console.log(isLong("kitty")); // false
// console.log(isLong("telescope")); // true
// console.log(isLong("thermometer")); // true
// console.log(isLong("restaurant")); // true


// Write a function `half` that accepts a number as an argument. The function should return half of the
// number.
// const half = function(n)
// {
//     return n/2;
// }
// console.log(half(8)); // 4
// console.log(half(15)); // 7.5
// console.log(half(90)); // 45


// Write a function `endsWithT` that accepts a string as an argument. The function should return a
// boolean indicating whether or not the string ends with the character 't'.
// const endsWithT= function(str)
// {

//     if(str[str.length-1]==='t')
//     return true;
//     else
//     return false;
// }
// console.log(endsWithT("smart")); // true
// console.log(endsWithT("racket")); // true
// console.log(endsWithT("taco")); // false
// console.log(endsWithT("boomerang")); // false


// Write a function `average` that accepts three numbers as arguments. The function should return the
// average of the three numbers.
// const average = function(n1,n2, n3)
// {
//     return (n1+n2+n3)/3
// }
// console.log(average(3, 10, 8)); // 7
// console.log(average(10, 5, 12)); // 9
// console.log(average(6, 20, 40)); // 22

// Write a function `startsWithR` that accepts a string as an argument and returns a boolean indicating
// whether or not the string starts with 'r' or 'R'.
// const startsWithR = function(str)
// {
//    return str[0].toLowerCase()==='r';
// }
// console.log(startsWithR("roger that")); // true
// console.log(startsWithR("Row, row, row your boat")); // true
// console.log(startsWithR("slip")); // false
// console.log(startsWithR("Taxicab")); // false


// Write a function `parity` that accepts a number as an argument. The function should return the
// string 'even' if the number is even. It should return the string 'odd' if the number is odd.
//  const parity = function(n)
//  {
//     return n%2===0?"'even'": "'odd'"
//  }
// console.log(parity(5)); // 'odd'
// console.log(parity(7)); // 'odd'
// console.log(parity(13)); // 'odd'
// console.log(parity(32)); // 'even'
// console.log(parity(10)); // 'even'
// console.log(parity(602348)); // 'even'

// Write a function `longer` that accepts two strings as arguments. The function should return the
// string that is longer. If the strings have the same length, then return the first string.
// const longer= function(str, str1)
// {
// if(str.length >=str1.length) return str;
// else 
// return str1;

// }
// console.log(longer("drum", "piranha")); // 'piranha'
// console.log(longer("basket", "fork")); // 'basket'
// console.log(longer("flannel", "sustainable")); // 'sustainable'
// console.log(longer("disrupt", "ability")); // 'disrupt'
// console.log(longer("bird", "shoe")); // 'bird'

// Write a function `oneOrNone` that accepts two booleans as arguments. The function should return true
// if exactly one of the arguments is true. If BOTH arguments are true, then it should return false.
// const oneOrNone = function(b, b1)
// {
//     if(b===b1) return false;
//     else return true;
// }
// console.log(oneOrNone(false, false)); // false
// console.log(oneOrNone(true, false)); // true
// console.log(oneOrNone(false, true)); // true
// console.log(oneOrNone(true, true)); // false

// Write a function `endsInLy` that accepts a string as an argument and returns a boolean indicating
// whether or not the string ends in the substring 'ly'.
const endsInLy = function(str)
{

    if(str.slice(str.length - 2)==="ly") return true;
    else return false;
}
console.log(endsInLy("pretty")); // false
console.log(endsInLy("instant")); // false
console.log(endsInLy("analytic")); // false
console.log(endsInLy("timidly")); // true
console.log(endsInLy("fly")); // true
console.log(endsInLy("gallantly")); // true