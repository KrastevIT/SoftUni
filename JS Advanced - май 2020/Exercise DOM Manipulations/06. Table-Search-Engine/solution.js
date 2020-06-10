function solve() {
   document.querySelector('#searchBtn').addEventListener('click', search);

   function search(e) {
      const input = document.querySelector('#searchField');
      const query = input.value.trim().toLocaleLowerCase();
      if (query.length > 0) {
         const tbody = document.querySelector('tbody');

         Array.from(tbody.querySelectorAll('tr')).forEach(tr => {
            tr.classList.remove('select');
         });

         Array.from(tbody.querySelectorAll('td')).forEach(td => {
            if (td.textContent.trim().toLocaleLowerCase().includes(query)) {
               td.parentNode.classList.add('select');
            }
         });

         input.value = '';
      }
   }
}