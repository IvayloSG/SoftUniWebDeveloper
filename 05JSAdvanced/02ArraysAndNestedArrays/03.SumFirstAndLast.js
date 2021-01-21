function sum(arr) {
    let firstElement = Number(arr.shift());
    let lastElement = Number(arr.pop());

    let result = firstElement + lastElement;

    return result; 
}

console.log(sum(['1', '2', '3']))