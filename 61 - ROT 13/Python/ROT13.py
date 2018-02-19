userText = input('Enter you text: ')

cipherText = ""

for c in userText:
    if c.isupper():
        newCharCode = ord(c)-65
        newCharCode = ((newCharCode + 13) % 26) + 65
        cipherText += chr(newCharCode)
    elif c.islower():
        newCharCode = ord(c)-97
        newCharCode = ((newCharCode + 13) % 26) + 97
        cipherText += chr(newCharCode)
    else:
        cipherText += c

print(cipherText)
input();
