function solve() {
    const input = document.querySelector('input');
    const select = document.querySelector('#selectMenuTo');
    document.querySelector('button').addEventListener('click', convert);

    const optionBinary = document.createElement('option');
    const optionHexadecimal = document.createElement('option');
    optionBinary.value = 'binary';
    optionBinary.textContent = 'Binary';
    optionHexadecimal.value = 'hexadecimal';
    optionHexadecimal.textContent = 'Hexadecimal';

    select.appendChild(optionBinary);
    select.appendChild(optionHexadecimal);

    const mathObj = {
        binary: (x) => x.toString(2),
        hexadecimal: (x) => x.toString(16).toUpperCase()
    };

    const resultOutput = document.querySelector('#result');

    function convert() {
        const result = mathObj[select.value](Number(input.value));

        resultOutput.value = result;
    }
}