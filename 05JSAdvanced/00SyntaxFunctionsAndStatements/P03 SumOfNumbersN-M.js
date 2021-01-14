function sumNumbers(n, m) {
    let firstNumber = Number(n);
    let lastNumber = Number(m);
    let result = 0;

    for (let i = firstNumber; i <= lastNumber; i++) {
        result += i;
    } 

    return result;
}
