function same(input) {
    let text = String(input);

    let isSame = true;
    let sum = 0;

    for (let i = 0; i < text.length; i++) {
        let element = text[i];
        if (i != text.length - 1) {
            if (element != (text[i + 1])) {
                isSame = false;
            }
        }

        sum += Number(element);
    }

    console.log(isSame);
    console.log(sum);
}

same(2222222);
same(1234);
