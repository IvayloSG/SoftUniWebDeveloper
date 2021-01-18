function square(number) {
    let str = '* ';

    for (let i = 0; i < number; i++) {
        console.log(str.repeat(number));
    }
}

square(5);