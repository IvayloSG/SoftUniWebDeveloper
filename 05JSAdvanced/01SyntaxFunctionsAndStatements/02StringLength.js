function stringLength(arrOne, arrTwo, arrThree){
    let length = arrOne.length + arrTwo.length + arrThree.length;
    let avg = Math.round(length/3);

    console.log(length);
    console.log(avg);
}

stringLength('chocolate', 'ice cream', 'cake');
stringLength('pasta', '5', '22.3');