function addItem() {
    const text = document.getElementById('newItemText');
    const value = document.getElementById('newItemValue');

    const menu = document.getElementById('menu');
    const option = document.createElement('option');

    option.value = value.value;
    option.textContent = text.value;
    menu.appendChild(option);

    text.value = '';
    value.value = '';
}