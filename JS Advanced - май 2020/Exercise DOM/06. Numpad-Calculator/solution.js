function solve() {
    const screen = document.querySelector('#expressionOutput');
    const output = document.querySelector('#resultOutput');

    document.querySelector('.clear').addEventListener('click', () => {
        memory.first = '';
        memory.secound = '';
        memory.operator = '';
        screen.textContent = '';
        output.textContent = '';
    });

    Array.from(document.querySelector('div.keys').querySelectorAll('button')).forEach(b => {
        b.addEventListener('click', OnClick);
    });

    const memory = {
        first: '',
        secound: '',
        operator: ''
    };

    const operators = {
        '+': () => Number(memory.first) + Number(memory.secound),
        '-': () => Number(memory.first) - Number(memory.secound),
        '*': () => Number(memory.first) * Number(memory.secound),
        '/': () => Number(memory.first) / Number(memory.secound),
        '=': () => true
    };

    function OnClick(e) {
        const value = e.target.value;
        if (operators.hasOwnProperty(value)) {
            if (value === '=') {
                output.textContent = operators[memory.operator]();
                return;
            }
            memory.operator = value;
        } else if (memory.operator === '') {
            memory.first += value;
        } else {
            memory.secound += value;
        }

        screen.textContent = `${memory.first} ${memory.operator} ${memory.secound}`;
    }
}