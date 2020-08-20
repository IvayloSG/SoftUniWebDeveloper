function aggregateElements (inputArray) {
    let sumOfElements = inputArray.reduce((a, b)=> a + b, 0);

    let inverseSumOfElements = inputArray.reduce((a, b) => a + 1/b, 0);

    let concatenateElementsResult = inputArray.reduce((a, b) => a + b, "");

    console.log(sumOfElements);
    console.log(inverseSumOfElements.toFixed(4));
    console.log(concatenateElementsResult);
}