function solve() {
  const tbody = document.querySelector('tbody');
  const [generate, buy] = [...document.querySelectorAll('button')];
  const [input, output] = [...document.querySelectorAll('textarea')];
  generate.addEventListener('click', OnGenerate);
  buy.addEventListener('click', OnBuy);

  const tableSet = {
    'img': (a, b) => a.src = b,
    'p': (a, b) => a.textContent = b,
    'input': (a, b) => a.type = b
  };

  function createTableData(atribute, value) {
    const td = document.createElement('td');
    const atr = document.createElement(atribute);
    tableSet[atribute](atr, value);
    td.appendChild(atr);
    return td;
  }

  function OnGenerate(e) {
    const data = JSON.parse(input.value);

    for (let item of data) {

      const tr = document.createElement('tr');

      tr.appendChild(createTableData('img', item.img));
      tr.appendChild(createTableData('p', item.name));
      tr.appendChild(createTableData('p', item.price));
      tr.appendChild(createTableData('p', item.decFactor));
      tr.appendChild(createTableData('input', 'checkbox'));

      tbody.appendChild(tr);

    }
  }

  function OnBuy(e) {
    const checkedElements = Array.from(tbody.querySelectorAll('input'))
      .filter(x => x.checked)
      .map(x => x.parentNode.parentNode);

    const result = {
      'name': '',
      'price': 0,
      'average': 0
    };

    for (const tr of checkedElements) {

      result['name'] += `${tr.childNodes[1].textContent}, `;
      result['price'] += Number(tr.childNodes[2].textContent);
      result['average'] += Number(tr.childNodes[3].textContent);
    }

    result['average'] = result['average'] / checkedElements.length;

    result['name'] = result['name'].substring(0, result['name'].length - 2);

    output.textContent = `Bought furniture: ${result['name'].trim()} \nTotal Price: ${result['price'].toFixed(2)} \nAverage decoration factor: ${result['average']}`;
  }
}