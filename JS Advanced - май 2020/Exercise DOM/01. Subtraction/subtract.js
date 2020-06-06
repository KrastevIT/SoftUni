function subtract() {
    const firstNumber = Number(document.getElementById('firstNumber').value);
    const secoundNumber = Number(document.getElementById('secondNumber').value);

    const getDiv = document.getElementById('result');
    getDiv.innerText = firstNumber - secoundNumber;
}