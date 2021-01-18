function sum(n, m) {
    let firstNumber = Number(n);
    let secondNumber = Number(m);

    let sum = 0;

    for (let i = firstNumber; i <= secondNumber; i++) {
        sum += i;
    }

    return sum;
}

console.log(sum(1, 5));
console.log(sum(1, 3));
