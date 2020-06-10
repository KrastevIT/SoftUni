function create(words) {
   const parentDiv = document.querySelector('#content');

   for (let i = 0; i < words.length; i++) {
      const div = document.createElement('div');
      const p = document.createElement('p');
      p.style.display = 'none';
      p.textContent = words[i];
      div.appendChild(p);
      parentDiv.appendChild(div);
   }

   parentDiv.addEventListener('click', onClick);

   function onClick(e) {
      const div = e.target;
      const p = div.querySelector('div > p');
      p.style.display = 'block';
   }
}