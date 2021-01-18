function area(radius) {
    
    let type = typeof(radius);
    let a = Number(radius);

    if (type != 'number') {
        return `We can not calculate the circle area, because we receive a ${type}.`;
    }

    let area = Math.PI * a ** 2;
    return area.toFixed(2);
}

console.log(area(5));
console.log(area('name'));