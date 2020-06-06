function solve() {
   const line = document.getElementById('chat_input');
   const button = document.getElementById('send').addEventListener('click', send);
   const chat = document.getElementById('chat_messages');

   function send() {
      if (line.value === '') {
         return;
      }

      const div = document.createElement('div');
      div.setAttribute('class', 'message my-message');

      div.textContent = line.value;
      chat.appendChild(div);
      line.value = '';
   }
}