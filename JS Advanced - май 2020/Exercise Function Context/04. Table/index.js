function solve() {
   const tbody = document.querySelector('tbody');
   const items = tbody.querySelectorAll('tr');
   tbody.addEventListener('click', parseTabe);

   function parseTabe(e) {
      const row = e.target.parentNode;
      if (row.nodeName === 'TR') {
         if (row.style.backgroundColor !== '') {
            row.style.backgroundColor = '';
         } else {
            Array.from(items).forEach(i => i.style.backgroundColor = '');
            row.style.backgroundColor = '#413f5e';
         }
      }
   }
}
