function circleArea(input) {
    let result;
    let typeOfInput = typeof(input);

    if (typeOfInput == "number") {
        let radius = Number(input);

        result = Math.PI * input ** 2;
        
        console.log(result.toFixed(2));
    }
    else {
        console.log(`We can not calculate the circle area, because we receive a ${typeOfInput}.`);
    }
}