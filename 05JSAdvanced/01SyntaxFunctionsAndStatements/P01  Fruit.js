function fruit(fruit, weight, price) {
    let kilograms = weight/1000;
    let sum = kilograms * price;
    
    let result = `I need $${sum.toFixed(2)} to buy ${(kilograms).toFixed(2)} kilograms ${fruit}.`;
    
    return result;
}