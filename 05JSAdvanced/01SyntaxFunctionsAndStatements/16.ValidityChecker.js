function valid(x1, y1, x2, y2) {
    var distanceOne = Math.sqrt(x1 ** 2 + y1 ** 2);
    var distanceTwo = Math.sqrt(x2 ** 2 + y2 ** 2);
    var distanceThree = Math.sqrt(Math.abs(x1 - x2) ** 2 + Math.abs(y1 - y2) ** 2);

    console.log(`{${x1}, ${y1}} to {0, 0} is ${Number.isInteger(distanceOne) ? 'valid' : 'invalid'}`);
    console.log(`{${x2}, ${y2}} to {0, 0} is ${Number.isInteger(distanceTwo) ? 'valid' : 'invalid'}`);
    console.log(`{${x1}, ${y1}} to {${x1}, ${y1}} is ${Number.isInteger(distanceThree) ? 'valid' : 'invalid'}`);
}
valid (2, 1, 1, 1);
valid (3, 0, 0, 4);