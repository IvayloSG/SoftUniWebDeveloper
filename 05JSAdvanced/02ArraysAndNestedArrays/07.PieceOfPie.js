function piece(input, start, stop) {
    return input.slice(input.indexOf(start), input.indexOf(stop) + 1);
}

console.log(piece(
['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
))