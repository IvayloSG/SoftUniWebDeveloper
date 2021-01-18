function cooking(number, argOne, argTwo, argThree, argFour, argFive) {
    const array = [argOne, argTwo, argThree, argFour, argFive];
    number = Number(number);

    for (let i = 0; i < array.length; i++) {
        let element = array[i];
        
        if (element == 'chop') {
            number /= 2;
        } else if (element == 'dice'){
            number = Math.sqrt(number)
        } else if (element == 'spice'){
            number += 1;
        } else if (element == 'bake'){
            number *= 3;
        } else if (element == 'fillet'){
            number *= 0.8;
        }

        console.log(number);
    }
}

cooking('9', 'dice', 'spice', 'chop', 'bake', 'fillet');
cooking('32', 'chop', 'chop', 'chop', 'chop', 'chop');
