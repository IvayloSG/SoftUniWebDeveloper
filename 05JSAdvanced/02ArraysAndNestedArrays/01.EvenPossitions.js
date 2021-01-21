function evenPossitions (arr) {
    let result = [];

    for (let i = 0; i < arr.length; i++) {
        if (i % 2 === 0) {
            const element = arr[i];
            result[result.length] = element;
        }
    }

    console.log(result.join(' '));
}

evenPossitions([20, 30, 40, 50]);