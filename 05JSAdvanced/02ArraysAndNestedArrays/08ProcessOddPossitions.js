function odd(input) {
    return input.filter((x, i) => i % 2 != 0).map(x => x * 2).reverse();
}

console.log(odd([3, 0, 10, 4, 7, 3]));