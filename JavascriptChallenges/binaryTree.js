class Node {
  constructor(val) {
    this.val = val;
    this.left = null;
    this.right = null;
  }
}
// const depthFirstValues = (root) => {
//     if(root===null) return [];
//     const result =[];
//     const stack = [root];
//     while(stack.length>0)
//       {
//         const current=stack.pop();
//          result.push(current.val);
        
//         if(current.right) stack.push(current.right);
//         if(current.left) stack.push(current.left);
       
//       }
//     return result;
//   };

const depthFirstValuesRecursion = (root) =>
{
    if(root===null) return [];
    const leftValues= depthFirstValuesRecursion(root.left);
   const rightValues= depthFirstValuesRecursion(root.right);
   return [root.val, ...leftValues, ...rightValues]
}
const a = new Node('a');
const b = new Node('b');
const c = new Node('c');
const d = new Node('d');
const e = new Node('e');
const f = new Node('f');

a.left = b;
a.right = c;
b.left = d;
b.right = e;
c.right = f;

//      a
//    /   \
//   b     c
//  / \     \
// d   e     f

// const result = depthFirstValues(a); 
const result =depthFirstValuesRecursion(a)
const expect= ['a', 'b', 'd', 'e', 'c', 'f']
console.log(result)

// find target values K
const  depthTargetValue =(root, k) =>
{
  if(root===null) return false;
  const stack = [root];
  while(stack.length >0)
  {
    const current = stack.pop();
    if(current.val===k)
    {
      return true;
    }
    if(current.left!==null) stack.push(current.left)
    if(current.right!==null) stack.push(current.right)
  }
return false;
}
const target =depthTargetValue(a,'e')
const notTarget =depthTargetValue(a,'j')
console.log(target)
console.log(notTarget)



///Minimum values of binary tree
const treeMinValue =(root) =>
{
  if(root===null) return 0;
  const stack = [root]
  let min = root.val;
  while(stack.length>0)
  {
    const current = stack.pop();
    if(current.val<min)
    {
      min = current.val;
    }
    if(current.left!==null) stack.push(current.left)
    if(current.right!==null) stack.push(current.right)
  }
return min;
}

const a1 = new Node(3);
const b1 = new Node(11);
const c1 = new Node(4);
const d1 = new Node(4);
const e1 = new Node(-2);
const f1 = new Node(1);

a1.left = b1;
a1.right = c1;
b1.left = d1;
b1.right = e1;
c1.right = f1;

//       3
//    /    \
//   11     4
//  / \      \
// 4   -2     1
 const min =treeMinValue(a1); // -> -2
 console.log(min)