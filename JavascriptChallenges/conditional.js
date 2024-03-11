// snippet 0-1
// if (true) {
//     console.log("foo");
//   }
  
//   if (false) {
//     console.log("bar");
//   }
//   // snippet 0-2
// if (false || false) {
//     console.log("boop");
//   }
  
//   if (true || false) {
//     console.log("beep");
//   }

// snippet 0-3
// let num = 40;

// if (num > 0) {
//   console.log("zip");
// }

// if (num % 2 === 0) {
//   console.log("zoop");
// }

// snippet 0-4
// let word = "jeep";

// if (word[0] === "d") {
//   console.log("yer");
// } else {
//   console.log("nah");
// }
// snippet 0-5
// let sentence = "roger that";

// if (sentence[sentence.length - 1] === "t") {
//   console.log("ends in t");
// } else {
//   console.log("does not end in t");
// }

// if (sentence.length <= 4) {
//   console.log("short");
// } else {
//   console.log("long");
// }

// snippet 1-0
// let qty = 38;

// if (qty > 30 && qty % 5 === 4) {
//   console.log("swish");
// } else {
//   console.log("swoosh");
// }

// if (qty > 0) {
//   console.log("pos");
// }


// snippet 1-1
// let a = "celery";
// let b = "SQUASH";

// if (a === a.toUpperCase()) {
//   console.log("alpha");
// }

// if (b === b.toUpperCase()) {
//   console.log("beta");
// }

// snippet 1-2
// let number = 9;

// if (number > 4) {
//   console.log("ding");
// } else if (number % 3 === 0) {
//   console.log("dong");
// }

// snippet 1-3
// let z = 12;

// if (z > 10) {
//   console.log("vroom");
// }

// if (z % 3 === 0) {
//   console.log("skrrt");
// }


// // snippet 2-1
// let nonsense = "blog trust fund tattooed williamsburg poke roof party";
// let hasOk = nonsense.indexOf("ok") > -1;

// if (hasOk) {
//   console.log("yeet");
// } else if (nonsense.length > 10) {
//   console.log("yo");
// } else {
//   console.log("no");
// }


// let hasZoo = nonsense.indexOf("zoo") > -1;
// let hasFun = nonsense.indexOf("fun") > -1;

// if (hasZoo && hasOk) {
//   console.log("cool");
// } else if (hasOk) {
//   console.log("rad");
// } else if (hasFun) {
//   console.log("dope");
// } else {
//   console.log("nope");
// }

// snippet 2-2

// let q = 25;
// if (q % 3 === 0 && q % 5 === 0) {
//   console.log("both");
// } else if (q % 3 === 0 || q % 5 == 0) {
//   console.log("either");
// } else {
//   console.log("neither");
// }
// //either

// let r = 9;
// if (r % 3 === 0 && r % 5 === 0) {
//   console.log("both");
// } else if (r % 3 === 0 || r % 5 == 0) {
//   console.log("either");
// } else {
//   console.log("neither");
// }
// //either
// let s = 15;
// if (s % 3 === 0 && s % 5 === 0) {
//   console.log("both");
// } else if (s % 3 === 0 || s % 5 == 0) {
//   console.log("either");
// } else {
//   console.log("neither");
// }
// //both

let str="AIICXAIBAAKBgQCuw0YyucjI9bf7yRhIkyg4Ru6kYU7O6fIn2JoFDzCZNkzDdsuXFGh6BXNvbu8uZUT289ERzYP1QjryMEKWzcbtsioyQApL7AgOZyFc3JJ7wvupHhIj2sqxJNtpAh7HQFG08rYh2Pb3HwOm83rbTomM6LnnjooGcoDeuWkuPqXsRlwIDAQABAoGAeQkbPBR5n9y2QLaEjcDGv7dVpFiMGHMaZZVDX34rZPy1EkZNZqlQU0jopLVvLyLESMh9A7gKhqoyMAbgZPpdb0CvniTJPpKYk24mLBeym8rBMW3XBmKk1xIOcJPGXMxeJW61jxPg6doah0aCIjf8n0Z8t8B81kLFojpECQQDzlCp0Nzka3AVZVPdBuuPg0fzeV8ugpiPEp6wQLjIMDFqYtGoAOEy4JpkmkK7zwsQsHZ8jbOtqIFdRLPrvAkEAruU321Ie1CnYCHX4Q79vLcDeWOUpdzEHp2uzDIfzP1gv7RIktGgSZWKhrnNWdeH4Y0CFb9lu6TQYJwNJvug2QJBANX0m3Uds9P9pLbQlI9WWmAtYqIZrsBElcAjOgAik0uOfawholNiw5B3ADvIYqPkLW4dGk1dO6zxW8ZF83MdMCQHGfhxLuFgsOBSfF7Bj4UX6T9FGhUGSXiqUsd06E2mMRLAjWUUUw82DLwucxMrSsV4z1aN57asC8YuQ9FkCQGirlVCt4ccXeGLCHcCsI8AYQJFRzbMs381M16jEpnaKUGrtdbMW018gWJ0EoD4tS2YZpr1hEbtiOkPJaaTKQ"
if(str.indexOf("coDe") >-1)
{
console.log("Found")
}
else {
    console.log("not found")
}