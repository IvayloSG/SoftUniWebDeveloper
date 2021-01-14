function largest(arrOne, arrTwo, arrThree){
    let bigger = Math.max(arrOne, arrTwo);
    let biggest = Math.max(bigger, arrThree);

    console.log(`The largest number is ${biggest}.`);
}

largest(5, -3, 16);
largest(-3, -5, -22.5);