function biggest(input) {
    return input.reduce((acc, c) => acc.concat(c)).sort((a, b) => a - b).pop();
}

console.log(biggest([[20, 50, 10],
    [8, 33, 145]]));