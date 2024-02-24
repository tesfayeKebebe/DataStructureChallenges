
const depthFirstPrint= (data, source) =>
{
    if(data.length===0 || data===null) return [];
    const result =[]
    const stack =[source];
    while(stack.length >0)
    {
        const current = stack.pop();
        result.push(current);
        for(let neighbor of data[current])
        {
           stack.push(neighbor)
        }
    }
    return result;
     
}
const breathFirstTransvers =(data, src)=>
{
    const result = []
    const queue = [src]
    while(queue.length >0)
    {
        const current = queue.shift();
        result.push(current)
       for(let neighbor of data[current]) 
       {
        queue.push(neighbor)
       }
    }
    return result;
}


const data = {
    a:['b','c'],
    b:['d'],
    c:['e'],
    d:['f'],
    e:[],
    f:[]
}
console.log(depthFirstPrint(data, 'a'))
// [ 'a', 'c', 'e', 'b', 'd', 'f' ]
console.log(breathFirstTransvers(data, 'a'))
// [ 'a', 'b', 'c', 'd', 'e', 'f' ]
