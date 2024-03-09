// // snippet 2
// console.log("hi");

// for (let i = 3; i <= 7; i++) {
//   console.log("program");
//   console.log(i);
// }

// // console.log("bye");
// // snippet 3
// let foo = function () {
//     for (let num = 10; num > 0; num -= 2) {
//       console.log(num);
//     }
//   };
  
//   console.log("begin");
//   foo();
//   console.log("end");
//   foo();

// // snippet 5
// let total = 0;
// for (let i = 1; i < 5; i++) {
//   total += i;
//   console.log(total);
// }

// console.log("grand total: " + total);

// Write a function `minToMax(min, max)` that accepts two numbers as arguments. The function should
// print all numbers from min to max inclusive. The function doesn't need to return any value. It
// should just print to the terminal.
// const minToMax = function(min, max)
//  {
//     for(let x = min; x <= max; x++)
//         {
//             console.log(x)
//         }
//  }
// minToMax(5, 9);
// // prints
// //  5
// //  6
// //  7
// //  8
// //  9

// minToMax(11, 13);
// // prints
// //  11
// //  12
// //  13

// minToMax(20, 11);

// Write a function `stringIterate` that accepts a string as an argument. The function should print out
// each character of the string, one by one. The function doesn't need to return any value. It should
// just print to the terminal.
// const stringIterate = function(str)
// {
//     for(let x of str)
//     {
//         console.log(x)
//     }
// }
// stringIterate("celery");
// // prints
// //  c
// //  e
// //  l
// //  e
// //  r
// //  y

// stringIterate("hat");
// // prints
// //  h
// //  a
// //  t

// Write a function named `fiveMultiplesOf` that accepts a number as an argument. The function should
// print out the first five multiples of the given number. The function doesn't need to return any
// value. It should just print to the terminal.
// const fiveMultiplesOf = function(n)
// {
//     for(let i =1; i<=5; i++)
//     {
//         console.log(i*n);
//     }
// }
// fiveMultiplesOf(7);
// // prints
// //  7
// //  14
// //  21
// //  28
// //  35

// fiveMultiplesOf(3);
// // prints
// //  3
// //  6
// //  9
// //  12
// //  15

// Write a function named `sumUpTo(max)` that accepts a max number as an argument. The function should
// return the total sum of all whole numbers from 1 to the max, inclusive.
//
// For example, sumUpTo(4) should return 10 because 1 + 2 + 3 + 4 = 10.
// const sumUpTo = function(n)
// {
//     let sum = 0;
//     for(let i=1; i<=n; i++)
//     {
//      sum+=i;
//     }
//     return sum;
// }
// console.log(sumUpTo(4)); // 10
// console.log(sumUpTo(5)); // 15
// console.log(sumUpTo(2)); // 3

// Write a function named `noOhs` that accepts a string as an argument. The functions should print the
// characters of the string one by one except the character 'o'. The function doesn't need to return
// any value. It should just print to the terminal.
// const noOhs = function(str)
// {
//     for(let i of str)
//     {
//         if(i!=='o')
//         {
//             console.log(i)
//         }
//     }
// }
// noOhs("code");
// // prints
// //  c
// //  d
// //  e

// noOhs("school");
// // prints
// //  s
// //  c
// //  h
// //  l

// Write a function named `oddSum(max)` that accepts a max number as an argument. The function should
// return the total sum of all odd numbers from 1 to the max, inclusive.
//
// For example, oddSum(10) should return 25 because 1 + 3 + 5 + 7 + 9 = 25
// const oddSum = function(n)
// {
//     let sum = 0;
//     for(let i = 1; i<=n; i++)
//     {
//         if(i%2!==0)
//         {
//             sum+=i
//         }

//     }
//     return sum;
// }
// console.log(oddSum(10)); // 25
// console.log(oddSum(5)); // 9

// Write a function named `stringRepeater(str, num)` that accepts a string and a number as arguments.
// The function should return a new string consisting of the `str` repeated `num` number of times.
// const stringRepeater = function(str, n)
// {
//     let newStr ="";
//     for(let i=0; i<n; i++)
//     {
//         newStr+=str;
//     }
//     return newStr
// }
// console.log(stringRepeater("q", 4)); // 'qqqq'
// console.log(stringRepeater("go", 2)); // 'gogo'
// console.log(stringRepeater("tac", 3)); // 'tactactac'

// Write a function named `divByEither(num1, num2, max)` that accepts three numbers as arguments. 
// The function should print out all positive numbers less than max that are divisible by num1 or num2. 
// The function doesn't need to return any value. It should just print to the terminal.
 const divByEither= function(num1, num2, max)
 {
    for(let i=1; i<max; i++)
    {
        if(i%num1===0 || i%num2===0)
        {
            console.log(i)
        }
    }
 }
divByEither(4, 3, 16);
// prints
//  3
//  4
//  6
//  8
//  9
//  12
//  15

divByEither(7, 5, 20);
// prints
//  5
//  7
//  10
//  14
//  15