function solve(fruit, kg, price) {
  kg /= 1000;
  const sum = (kg * price).toFixed(2);
  console.log(`I need $${sum} to buy ${kg.toFixed(2)} kilograms ${fruit}.`);
}
solve('orange', 1000, 2);
