function equal(input) {
    let pairs = 0;
    for (let i = 0; i < input.length; i++) {
        for (let j = 0; j < input[i].length; j++) {
            let element = input[i][j];

            if (i == 0) {
                if (element == input[i][j - 1]) {
                    pairs++;
                } if (element == input[i][j + 1]) {
                    pairs++;
                } if (element == input[i + 1][j]) {
                    pairs++;;
                }
            } else if (i == input.length - 1) {
                if (element == input[i][j - 1]) {
                    pairs++;
                } if (element == input[i][j + 1]) {
                    pairs++;
                } if (element == input[i - 1][j]) {
                    pairs++;;
                }
            } else {
                if (element == input[i][j - 1]) {
                    pairs++;
                } if (element == input[i][j + 1]) {
                    pairs++;
                } if (element == input[i - 1][j]) {
                    pairs++;;
                } if (element == input[i - 1][j]) {
                    pairs++;
                }
            }
        }
    }

    return Math.floor(pairs / 2);
}

console.log(equal(
    [['2', '2', '5', '7', '4'],
    ['4', '0', '5', '3', '4'],
    ['2', '5', '5', '4', '2']]
));

console.log(equal(
    [['2', '2', '5', '7', '4'],
    ['4', '0', '5', '3', '4'],
    ['2', '3', '5', '4', '2'],
    ['9', '8', '7', '5', '4']]
));

console.log(equal(
 [['test', 'yes', 'yo', 'ho'],
 ['well', 'done', 'yo', '6'],
 ['not', 'done', 'yet', '5']]
));