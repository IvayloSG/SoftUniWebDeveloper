function fruit(type, quantity, price) {
    let kilos = quantity / 1000;

    let totalPrice = kilos * Number(price);

    return `I need $${totalPrice.toFixed(2)} to buy ${kilos.toFixed(2)} kilograms ${type}.`;
}

console.log(fruit('orange', 2500, 1.80));