
var MORSE_CODE =
{
    ".-": "A",
    "-...": "B",
    "-.-.": "C",
    "-..": "D",
    ".": "E",
    "..-.": "F",
    "--.": "G",
    "....": "H",
    "..": "I",
    ".---": "J",
    "-.-": "K",
    ".-..": "L",
    "--": "M",
    "-.": "N",
    "-- -": "O",
    ".--.": "P",
    "--.-": "Q",
    ".-.": "R",
    "...": "S",
    "-": "T",
    "..-": "U",
    "...-": "V",
    ".--": "W",
    "-..-": "X",
    "-.--": "Y",
    "--..": "Z",
};

var decodeBits = function (bits) {
    // ToDo: Accept 0's and 1's, return dots, dashes and spaces
    return bits
        .replace(/11/g, '1')
        .replace(/111/g, '-')
        .replace(/1/g, '.')
        .replace(/000000000000/g, '   ')
        .replace(/000000/g, ' ')
        .replace(/00/g, '');
}

var decodeMorse = function (morseCode) {
    // ToDo: Accept dots, dashes and spaces, return human-readable message
    

    var word = morseCode.split('   ');
    var result = [];
    console.log("摩斯密碼：" + word);
    for (var w = 0; w < word.length; w++) {
        var ary = word[w].split(" ");
        console.log("一個單字：" + ary);
        for (var i = 0; i < ary.length; i++) {
            ary[i] = MORSE_CODE[ary[i]];
        }
        console.log("一個單字：" + ary);
        result.push(ary.join(''));
    }
    return result.join(' ');
}
var source =
    '1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011';
console.log(source);
var morse = decodeBits(source);
console.log(morse);
var result = decodeMorse(morse);
console.log(result);
var answer = "HEY JUDE";
