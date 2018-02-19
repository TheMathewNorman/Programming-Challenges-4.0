var previousPasswords = "";
function generatePassword() {
    var length = document.getElementById("length").value;
    var validCharacters = ['A', 'B', 'C', 'D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7','8','9','!','@','#','$','%','^','*','(',')','?','~'];

    var generatedPass = "";

    var punctuationPattern = RegExp('[!@#$%^*()?~]');
    var numberPattern = RegExp('\\d');
    var upperPattern = RegExp('[A-Z]');
    var lowerPattern = RegExp('[a-z]');

    for (var i = 0; i < length; i++) {
        var generatedCharacter = validCharacters[Math.floor(Math.random() * Math.floor(validCharacters.length))];
        if (upperPattern.test(generatedCharacter)) {
            generatedCharacter = '<span style="color:red">' + generatedCharacter + '</span>';
        } else if (lowerPattern.test(generatedCharacter)) {
            generatedCharacter = '<span style="color:green">' + generatedCharacter + '</span>';
        } else if (punctuationPattern.test(generatedCharacter)) {
            generatedCharacter = '<span style="color:blue">' + generatedCharacter + '</span>';
        } else if (numberPattern.test(generatedCharacter)) {
            generatedCharacter = '<span style="color:black">' + generatedCharacter + '</span>';
        }

        generatedPass += generatedCharacter;
    }

    previousPasswords = generatedPass + "<br>" + previousPasswords;

    document.getElementById("password").style.display = 'block';
    document.getElementById("password").innerHTML = generatedPass;
    document.getElementById("previous").innerHTML = previousPasswords;
}