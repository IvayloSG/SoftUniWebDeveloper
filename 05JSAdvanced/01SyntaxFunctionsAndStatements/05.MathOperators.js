function calculator(firstNumber, secondNumber, sign) {
    firstNumber = Number(firstNumber);
    secondNumber = Number(secondNumber);

    let result = 0;

    switch (sign) {
        case '+':
            result = firstNumber + secondNumber;
            break;
        case '-':
            result = firstNumber - secondNumber;
            break;
        case '*':
            result = firstNumber * secondNumber;
            break;
        case '/':
            result = firstNumber / secondNumber;
            break;
        case '%':
            result = firstNumber % secondNumber;
            break;
        case '**':
            result = firstNumber ** secondNumber;
            break;
        default:
            break;
    }

    return result;
}

console.log(calculator(2, 3, '/'));