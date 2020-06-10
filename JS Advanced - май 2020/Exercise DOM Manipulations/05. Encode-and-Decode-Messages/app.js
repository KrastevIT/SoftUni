function encodeAndDecodeMessages() {
    const [encodeBtn, decodeBtn] = document.querySelectorAll('button');
    encodeBtn.addEventListener('click', encode);
    decodeBtn.addEventListener('click', decode);

    const [inputEncode, inputDecode] = document.querySelectorAll('textarea');

    function encode(e) {
        if (inputEncode !== '') {
            let textEncode = '';
            for (let i = 0; i < inputEncode.value.length; i++) {

                const ascii = inputEncode.value[i].charCodeAt(0) + 1;

                textEncode += String.fromCharCode(ascii);
            }
            inputDecode.value = textEncode;
            inputEncode.value = '';
        }
    }

    function decode(e) {
        if (inputDecode !== '') {
            inputEncode.removeAttribute('disabled');
            let textEncode = '';
            for (let i = 0; i < inputDecode.value.length; i++) {

                const ascii = inputDecode.value[i].charCodeAt(0) - 1;

                textEncode += String.fromCharCode(ascii);
            }
            inputDecode.value = textEncode;
        }
    }
}