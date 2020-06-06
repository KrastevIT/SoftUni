function toggle() {
    const extra = document.getElementById('extra');
    const btn = document.getElementsByClassName('button')[0];

    if (extra.style.display === 'block') {
        extra.style.display = 'none';
        btn.textContent = 'More';
    }
    else {
        extra.style.display = 'block';
        btn.textContent = 'Less';
    }
}