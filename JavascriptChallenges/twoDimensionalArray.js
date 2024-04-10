// Write a function `print2d` that accepts a two-dimensional array as an argument. The function
// should print all inner elements of the array.
// const print2d = (arr) =>
// {
//   for(let i =0; i<arr.length; i++)
//   {
//     let subArray = arr[i];
//      for(let j =0; j<subArray.length; j++)
//      {
//       console.log(subArray[j])
//      }
//   }
// }
// let array1 = [
//     ["a", "b", "c", "d"],
//     ["e", "f"],
//     ["g", "h", "i"],
//   ];
//   print2d(array1);
//   // prints
//   //  a
//   //  b
//   //  c
//   //  d
//   //  e
//   //  f
//   //  g
//   //  h
//   //  i
  
//   let array2 = [[9, 3, 4], [11], [42, 100]];
//   print2d(array2);
//   // prints
//   //  9
//   //  3
//   //  4
//   //  11
//   //  42
//   //  100

// Write a function `makeMatrix(m, n, value)` that accepts three arguments. The function should return
// a 2-dimensional array of height `m` and width `n` that contains the `value` as every element.

// const makeMatrix =(m, n, value)=>
// {
//   const twoDimensional= [];
//   for(let i = 0; i<m; i++)
//   {
//     const subArray =[];
//      for(let j=0; j< n; j++)
//      {
//       subArray.push(value);
//      }
//      twoDimensional.push(subArray);
//   }
//   return twoDimensional;
// }

// console.log(makeMatrix(3, 5, null));
// // [
// //   [ null, null, null, null, null ],
// //   [ null, null, null, null, null ],
// //   [ null, null, null, null, null ]
// // ]

// console.log(makeMatrix(4, 2, "x"));
// // [
// //   [ 'x', 'x' ],
// //   [ 'x', 'x' ],
// //   [ 'x', 'x' ],
// //   [ 'x', 'x' ]
// // ]

// console.log(makeMatrix(2, 2, 0));
// // [
// //   [ 0, 0 ],
// //   [ 0, 0 ]
// // ]

// Write a function `totalProduct(array)` that accepts a 2D array of numbers. The function should return
// the total product of all numbers in the array.
// const totalProduct = (arr) => 
// {
//   let product =1;
//   for(let i= 0; i<arr.length; i++)
//   {
//      let subArray = arr[i];
//       for(let j= 0; j<subArray.length; j++)
//       {
//         product*=subArray[j];
//       }
//   }
//   return product;
// }
// let array1 = [
//   [3, 5, 2],
//   [6, 2],
// ];
// console.log(totalProduct(array1)); // 360

// let array2 = [
//   [4, 6],
//   [2, 3],
//   [1, 2],
// ];
// console.log(totalProduct(array2)); // 288

// Write a function `twoSumPairs(numbers, target)` that accepts an array of numbers and a target number
// as arguments. The function should return a 2D array containing all unique pairs of elements that
// sum to the target.
// const twoSumPairs =(arr, target) => 
// {
//     const twoDim =[];
//     for(let i=0; i<arr.length; i++)
//     {
//       const subArray = [];
//        for(let j=i+1; j<arr.length; j++)
//        {
//         if(arr[i] + arr[j]===target)
//         {
//           subArray.push(arr[i])
//           subArray.push(arr[j])
//         }
//        }
//       if(subArray.length>0) twoDim.push(subArray);
//     }
//     return twoDim;
// }
// console.log(twoSumPairs([2, 3, 4, 6, 5], 8)); // [ [2, 6], [3, 5] ]
// console.log(twoSumPairs([10, 7, 4, 5, 2], 12)); // [ [10, 2], [7, 5] ]
// console.log(twoSumPairs([3, 9, 8], 11)); // [ [3, 8] ]
// console.log(twoSumPairs([3, 9, 8], 10)); // [ ]

// Write a function `zipper` that accepts two arrays as arguments. The function should return a 2D
// array containing pairs of elements at the same indices. You can assume that the arrays have the 
// same length.
const zipper = (arr1, arr2)=> 
{
  const twoDim =[];
    for(let a =0; a < arr1.length; a++)
    {
       const subArr =[];
      subArr.push(arr1[a]);
      subArr.push(arr2[a]);

      twoDim.push(subArr);
    }
  return twoDim;

}
let array1 = ["a", "b", "c", "d"];
let array2 = [-1, -2, -3, -4];
console.log(zipper(array1, array2));
// [
//   ['a', -1],
//   ['b', -2],
//   ['c', -3],
//   ['d', -4],
// ]

let array3 = ["whisper", "talk", "shout"];
let array4 = ["quiet", "normal", "loud"];
console.log(zipper(array3, array4));
// [
//   ['whisper', 'quiet'],
//   ['talk', 'normal'],
//   ['shout', 'loud'],
// ]