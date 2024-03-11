// Write a function `stayPositive` that accepts an array of numbers as an argument. The function should
// return an array containing only the positive numbers.
// const stayPositive = (arr) =>
// {
//     let positive =[];
//     for(let x of arr)
//     {
//         if(x>0)
//         {
//         positive.push(x)
//         }
//     }
//     return positive;
// }
// console.log(stayPositive([10, -4, 3, 6])); // [10, 3, 6]
// console.log(stayPositive([-5, 11, -40, 30.3, -2])); // [11, 30.3]
// console.log(stayPositive([-11, -30])); // []

// Write a function `bleepVowels` that accepts a string as an argument. The function should return
// a new string where all vowels are replaced with `*`s. Vowels are the letters a, e, i, o, u.
//  const bleepVowels = (str) => 
//  {
//     const strToLower = str.toLowerCase();
//      let newString ="";
//      let vowels = ["a", "e", "i", "o", "u"];

//     for(let c of strToLower)
//     {
//         if(vowels.indexOf(c) >-1)
//         {
//             newString+='*' 
//         }
//         else
//         {
//             newString+=c;  
//         }
//         // switch(c)
//         // {
//         //     case 'a':
//         //     case 'e': 
//         //     case 'i':
//         //     case 'o':
//         //     case 'u':  
//         //     newString+='*' 
//         //     break;
//         //     default:
//         //         newString+=c;  
//         // }
//     }
//     return newString;
//  }
// console.log(bleepVowels("skateboard")); // 'sk*t*b**rd'
// console.log(bleepVowels("slipper")); // 'sl*pp*r'
// console.log(bleepVowels("range")); // 'r*ng*'
// console.log(bleepVowels("brisk morning")); // 'br*sk m*rn*ng'

// Write a function `filterLongWords` that accepts an array of strings as an argument. The function
// should return a new array containing only the strings that are less than 5 characters long.
// const filterLongWords =(arr) =>
// {
//     const newArr= []
//     for(let a of arr)
//     {
//         if(a.length <5)
//         {
//             newArr.push(a)
//         }
//     }
//     return newArr;
// }
// console.log(filterLongWords(["kale", "cat", "retro", "axe", "heirloom"]));
// // ['kale', 'cat', 'axe']

// console.log(filterLongWords(["disrupt", "pour", "trade", "pic"]));
// // ['pour', 'pic']

// Write a function `numOdds` that accepts an array of numbers as an argument. The function should
// return a number representing the count of odd elements in the array.
//   const numOdds = (arr) =>
//   {
//     let count =0;
//     for(let n of arr)
//     {
//         if(n%2===1)
//         {
//           count++  
//         }
//     }
//     return count;
//   }
// console.log(numOdds([4, 7, 2, 5, 9])); // 3
// console.log(numOdds([11, 31, 58, 99, 21, 60])); // 4
// console.log(numOdds([100, 40, 4])); // 0

// Write a function `stringsToLengths` that accepts an array of strings as an argument. The function
// should return a new array containing the lengths of the elements of the original array.
// const stringsToLengths = (arr) => 
// {
//     const result =[]
//     for(let a of arr)
//     {
//        result.push(a.length)
//     }
//     return result;
// }
// console.log(stringsToLengths(["belly", "echo", "irony", "pickled"]));
// // [5, 4, 5, 7]

// console.log(stringsToLengths(["on", "off", "handmade"]));
// // [2, 3, 8]
// Write a function `divisors` that accepts a number as an argument. The function should return an
// array containing all positive numbers that can divide into the argument.
// const divisors = (n) => 
// {
//     const result =[];
//     for(let i=1; i<=n; i++)
//     {
//         if(n%i===0)
//         {
//             result.push(i)
//         }
//     }
//     return result;
// }
// console.log(divisors(15)); // [1, 3, 5, 15]
// console.log(divisors(7)); // [1, 7]
// console.log(divisors(24)); // [1, 2, 3, 4, 6, 8, 12, 24]

// Write a function `makeAcronym` that accepts a sentence string as an argument. The function should
// return a string containing the first character of each word in the sentence.
//  const makeAcronym = (str) => {
//     let acronomy ="";
//     for(let c of str.toUpperCase().split(" "))
//     {
//         acronomy += c.slice(0,1);
//     }
//   return acronomy;
//  }
// console.log(makeAcronym("New York")); // NY
// console.log(makeAcronym("same stuff different day")); // SSDD
// console.log(makeAcronym("Laugh out loud")); // LOL
// console.log(makeAcronym("don't over think stuff")); // DOTS

// Write a function `wordCount(sentence, targetWords)` that accepts a sentence string and an array of
// `targetWords`. The function should return a count of the number of words of the sentence that are
// in `targetWords`.
//  const wordCount =(str, arr) =>
//  {
//     const words = str.split(" ");
//     let count =0;
//     for(let x of words)
//     {
//         let index = arr.indexOf(x);
//         if(index >-1)count++;
//     }
//     return count;
//  }
// console.log(wordCount("open the window please", ["please", "open", "sorry"])); // 2
// console.log(wordCount("drive to the cinema", ["the", "driver"])); // 1
// console.log(wordCount("can I have that can", ["can", "I"])); // 3

// Write a function `yourAverageFunction` that accepts an array of numbers as an argument. The
// function should return the average of all elements of the array. If the input array is empty,
// then the function should return null.
// const yourAverageFunction = (nums) =>
// {
//     if(nums.length==0) return null;
//     let sum =0;
//      for(let n of nums)
//      {
//         sum+=n;
//      }
//      return sum/nums.length;
// }
// console.log(yourAverageFunction([5, 2, 7, 24])); // 9.5
// console.log(yourAverageFunction([100, 6])); // 53
// console.log(yourAverageFunction([31, 32, 40, 12, 33])); // 29.6
// console.log(yourAverageFunction([])); // null

// Write a function `chooseDivisibles(numbers, target)` that accepts an array of numbers and a
// target number as arguments. The function should return an array containing elements of the original
// array that are divisible by the target.
// const chooseDivisibles =(nums, target)=>
// {
//      const result =[];
//      for(let num of nums)
//      {
//         if(num%target===0)
//         {
//             result.push(num)
//         }
//      }
//    return result;
// }
// console.log(chooseDivisibles([40, 7, 22, 20, 24], 4)); // [40, 20, 24]
// console.log(chooseDivisibles([9, 33, 8, 17], 3)); // [9, 33]
// console.log(chooseDivisibles([4, 25, 1000], 10)); // [1000]


// Write a function `maximum` that accepts an array of numbers as an argument. The function should 
// return the largest number of the array. If the array is empty, then the function should return null.
// const maximum = (nums)=> 
// {
//     if(nums.length==0) return null;
//     let largest = nums[0];
//     for(let n =1; n<nums.length; n++)
//     {
//         if(nums[n]>largest)
//         {
//             largest = nums[n];
//         }

//     }
// return largest;
// }
// console.log(maximum([5, 6, 3, 7])); // 7
// console.log(maximum([17, 15, 19, 11, 2])); // 19
// console.log(maximum([])); // null

// Write a function `lengthiestWord` that accepts a sentence string as an argument. The function should
// return the longest word of the sentence. If there is a tie, return the word that appears later 
// in the sentence.
// const lengthiestWord = (str) => 
// {
//     let longestWord = "";
//     const words = str.split(" ");
//     for(let word of words)
//     {
//         if(word.length > longestWord.length)
//         {
//             longestWord = word;
//         }
//     }
//     return longestWord;
// }
// console.log(lengthiestWord("I am pretty hungry")); // 'pretty'
// console.log(lengthiestWord("we should think outside of the box")); // 'outside'
// console.log(lengthiestWord("down the rabbit hole")); // 'rabbit'
// console.log(lengthiestWord("simmer down")); // 'simmer'

// Write a function `alternatingCaps` that accepts a sentence string as an argument. The function should
// return the sentence where words alternate between lowercase and uppercase.
// const alternatingCaps =(str) => 
// {
//     const words = str.split(" ");
//     let isLower = true;
//     let result =[];
//     for(let word of words)
//     {
//         if(isLower)
//         {
//             isLower = false;
//            result.push(word.toLowerCase())
//         } 
//         else
//         {
//             result.push(word.toUpperCase());
//             isLower=true;
//         }
//     }
//     return result.join(" ");
// }
// console.log(alternatingCaps("take them to school")); // 'take THEM to SCHOOL'
// console.log(alternatingCaps("What did ThEy EAT before?")); // 'what DID they EAT before?'

// Write a function `numberRange(min, max, step)` that accepts three numbers as arguments, `min`,
// `max`, and `step`. The function should return all numbers between `min` and `max` at `step` intervals.
// `min` and `max` are inclusive.
// const numberRange = (min, max, step)=>
// {
//     const result = [];
//     for(let n=min; n<=max; n+=step)
//     {
//             result.push(n);
//     }
//     return result;
// }

// console.log(numberRange(10, 40, 5)); // [10, 15, 20, 25, 30, 35, 40]
// console.log(numberRange(14, 24, 3)); // [14, 17, 20, 23]
// console.log(numberRange(8, 35, 6)); // [8, 14, 20, 26, 32]

// Write a function `removeShortWords` that accepts a sentence string as an argument. The function
// should return a new sentence where all of the words shorter than 4 characters are removed.
// const removeShortWords = (str) => 
// {
//     const words = str.split(" ");
//     const result = [];
//     for(let word of words )
//     {
//         if(word.length >=4)
//         {
//             result.push(word)
//         }
//     }
//    return result.join(" ");
// }
// console.log(removeShortWords("knock on the door will you")); // 'knock door will'
// console.log(removeShortWords("a terrible plan")); // 'terrible plan'
// console.log(removeShortWords("run faster that way")); // 'faster that'


// Write a function `commonElements` that accepts two arrays as arguments. The function should return
// a new array containing the elements that are found in both of the input arrays. The order of
// the elements in the output array doesn't matter as long as the function returns the correct elements.
const commonElements = (arr1, arr2) =>
{
    const result =[];
    for(let arr of arr1)
    {
        if(!result.includes(arr) && arr2.includes(arr))
        {
            result.push(arr)
        }
    }
    return result;
}
let arr1 = ["a", "c", "d", "b"];
let arr2 = ["b", "a", "y"];
console.log(commonElements(arr1, arr2)); // ['a', 'b']

let arr3 = [4, 7];
let arr4 = [32, 7, 1, 4];
console.log(commonElements(arr3, arr4)); // [4, 7]