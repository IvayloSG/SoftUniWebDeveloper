function half(input) {
    input.sort((a, b) => a- b);

    let index = Math.floor(input.length / 2);
    return input.slice(index);
}

console.log(half([4, 7, 2, 5]));
console.log(half([3, 19, 14, 7, 2, 19, 6]));