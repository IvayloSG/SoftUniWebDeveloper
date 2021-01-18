function sum(arr) {
    let sum = 0;
    let inverted = 0;
    let concat = '';

    for (let i = 0; i < arr.length; i++) {
        let element = arr[i];

        sum += element;
        inverted += 1 / element;
        concat += element
    }

    console.log(sum);
    console.log(inverted);
    console.log(concat);
}

sum ([2, 4, 8, 16])