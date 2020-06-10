function lockedProfile() {
    document.querySelector('main').addEventListener('click', onClick);

    function onClick(e) {
        const parent = e.target.parentNode;
        const checkBtn = parent.querySelector('input[type="radio"][value="lock"]');

        const btn = e.target;
        if (btn.nodeName !== 'BUTTON' || checkBtn.checked) {
            return;
        }
        const div = Array.from(parent.querySelectorAll('div')).filter(x => x.id.includes('HiddenFields'))[0];

        if (div.style.display !== 'block') {
            div.style.display = 'block';
            btn.textContent = 'Hide it';
        } else {
            div.style.display = 'none';
            btn.textContent = 'Show more';
        }
    }
}