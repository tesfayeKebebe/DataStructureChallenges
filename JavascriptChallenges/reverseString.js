console.log("do this challenges");
const reverse = (str) => {
    let strReverse = str.split('');
  let first = 0;
  let end = strReverse.length - 1;
  while (first <= end) {
    let temp = strReverse[first];
    strReverse[first] = strReverse[end];
    strReverse[end] = temp;
    first++;
    end--;
  }
  return strReverse.join('');
  //str.reverse().join('')
};
console.log(reverse("tesfaye"));


