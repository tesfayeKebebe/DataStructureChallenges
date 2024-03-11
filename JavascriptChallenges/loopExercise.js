// Write a function `divisibleRange(min, max, num)` that accepts three numbers as arguments. The
// function should print all numbers between `min` and `max` (exclusive) that are also divisible by
// num.
// const divisibleRange = function(min, max, num)
// {
//     for(let x=min+1; x<max; x++ )
//     {
//         if(x%num===0)
//         {
//             console.log(x)
//         }
//     }
// }
// divisibleRange(17, 40, 9);
// // prints
// //  18
// //  27
// //  36

// divisibleRange(10, 24, 4);
// // prints
// //  12
// //  16
// //  20


// Write a function `reverseIterate` that accepts a string as an argument. The function should print
// the characters of the string one by one, in reverse order. The function doesn't need to return any
// value. It should just print to the terminal.
// const reverseIterate =(str)=>
// {
//      for(let c =str.length-1; c>=0; c--)
//      {
//         console.log(str[c])
//      }
// }
// reverseIterate("carrot");
// // prints
// //  t
// //  o
// //  r
// //  r
// //  a
// //  c

// reverseIterate("box");
// // prints
// //  x
// //  o
// //  b


// Write a function `removeCapitals` that accepts a string as an argument. The function should return a
// new version of the string with all capital letters removed.
// const removeCapitals =(str) =>
// {
//     let newStr = "";
//     for(let c of str)
//     {
//         if(c!==c.toUpperCase())
//         {
//           newStr+=c;
//         }

//     }
//     return newStr
// }
// console.log(removeCapitals("fOrEver")); // 'frver'
// console.log(removeCapitals("raiNCoat")); // 'raioat'
// console.log(removeCapitals("cElLAr Door")); // 'clr oor'

// Write a function `raisePower(base, exponent)` that accepts two numbers, `base` and `exponent`. The
// function should return `base` raised to the `exponent` power.
//
// For example, raisePower(2, 5) should return 32 because 2 * 2 * 2 * 2 * 2 = 32 
// For example, raisePower(4, 3) should return 64 because 4 * 4 * 4 = 64
//   const raisePower =(base, exponent) =>
// {
//     // let num =1;
//     // for(let x=1; x<=exponent; x++)
//     // {
//     //     num*=base;
//     // }
//     //return num;
//     return Math.pow(base, exponent);
// }
// console.log(raisePower(2, 5)); // 32
// console.log(raisePower(4, 3)); // 64
// console.log(raisePower(10, 4)); // 10000
// console.log(raisePower(7, 2)); // 49

// Write a function `censorE` that accepts a string as an argument. The function should return the a new
// version of string where all characters that are 'e's are replaced with '*'s.
// const censorE = (str) =>
// {
//     let newStr = "";
//     for(let c of str)
//     {
//       if(c==='e')
//       {
//         newStr+='*';
//       }
//       else{
//         newStr+=c;
//       }
//     }
//     return newStr;
// }
// console.log(censorE("speedy")); // 'sp**dy'
// console.log(censorE("pending")); // 'p*nding'
// console.log(censorE("scene")); // 'sc*n*'
// console.log(censorE("heat")); // 'h*at'

// Write a function `fizzBuzz` that accepts a max number as an argument. The function should
// print all numbers less than or equal to max that are divisible by either 3 or 5 but not both 3
// and 5. The function doesn't need to return any value. It should just print to the terminal.
// const fizzBuzz =(max)=> 
// {
//     for(let x =3; x<=max; x++)
//     {
//         if((x % 3 === 0 || x % 5 === 0) && !(x % 3 === 0 && x % 5 === 0))
//         {
//             console.log(x)
//         }
//     }


// }
// fizzBuzz(18);
// // prints
// //  3
// //  5
// //  6
// //  9
// //  10
// //  12
// //  18

// fizzBuzz(33);
// // prints
// //  3
// //  5
// //  6
// //  9
// //  10
// //  12
// //  18
// //  20
// //  21
// //  24
// //  25
// //  27
// //  33