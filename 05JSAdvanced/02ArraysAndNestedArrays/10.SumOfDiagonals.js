function diagonals(input) {
    let main = 0;
    let secondary = 0;

    for (let i = 0; i < input.length; i++) {
         for (let j = 0; j < input[i].length; j++) {
             if (i == j) {
                 main += input[i][j];
             } if (i + j == input.length - 1) {
                 secondary += input[i][j];
             }
         }
    }

    return `${main} ${secondary}`;
}

console.log(diagonals(
    [[20, 40],
    [10, 60]]
   ));