function stringCalculator(stringOne, stringTwo, stringThree) {
    let stringOneLength = stringOne.length;
    let stringTwoLength = stringTwo.length;
    let stringThreeLength = stringThree.length;

    let totalStringLength = stringOneLength + stringTwoLength + stringThreeLength;
    let averageLength = Math.floor(totalStringLength/3);

    console.log(totalStringLength);
    console.log(averageLength);
}
