function numbers(input) {
    let result = []; 

    for (let i = 0; i < input.length; i++) {
        let element = input[i];
        
        if (element >= 0) {
            result.push(element);
        } else{
            result.unshift(element);
        }
    }

    return result.join('\n');
}

console.log(numbers([7, -2, 8, 9]))