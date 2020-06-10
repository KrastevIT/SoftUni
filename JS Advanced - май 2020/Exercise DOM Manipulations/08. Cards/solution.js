function solve() {
   const firstPlayerCard = document.querySelectorAll('#player1Div > img');
   const secoundPlayerCard = document.querySelectorAll('#player2Div > img');
   document.querySelector('.cards').addEventListener('click', OnClick);

   const result = document.querySelectorAll('#result > span');

   const game = {
      'player1Div': -1,
      'player2Div': -1
   };

   function OnClick(e) {
      if (e.target.nodeName === 'IMG') {
         const card = e.target;
         const point = e.target.name;
         if (game[e.target.parentNode.id] === -1) {
            e.target.setAttribute('src', 'images/whiteCard.jpg');
            game[e.target.parentNode.id] = point;

            const span = e.target.parentNode.id === 'player1Div' ?
               result[0] : result[2];
            span.textContent = point;

            const cardOne = Array.from(firstPlayerCard).find(x => x.name === game['player1Div']);
            const cardTwo = Array.from(secoundPlayerCard).find(x => x.name === game['player2Div']);

            if (game['player1Div'] !== -1 && game['player2Div'] !== -1) {
               if (Number(game['player1Div']) > Number(game['player2Div'])) {
                  cardOne.style.border = '2px solid green';
                  cardTwo.style.border = '2px solid red';
               } else {
                  cardOne.style.border = '2px solid red';
                  cardTwo.style.border = '2px solid green';
               }
            }
         }
      }
   }
}