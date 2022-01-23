def calculate_highest_prime_factor(ival):
    highest_prime_factor = 0;

    isPrime = True
    currentFactor = 0;

    for i in range(1, ival):
        if (ival % i == 0):
            currentFactor = i
            for j in range(2, currentFactor/2):
                if (currentFactor % j == 0):
                    isPrime = False
            if (isPrime == True):
                highest_prime_factor = currentFactor

        isPrime = True

    print("The highest prime factor is: " + str(highest_prime_factor))


# User input
userInput = ""
validInput = False
while validInput == False:
    userInput = raw_input("Enter a number: ")
    
    if (userInput == "q"):
        quit()
    
    try:
        userInput = int(userInput)
    except:
        print("Please enter an integer or type 'q' to exit")
    else:
        validInput = True
        calculate_highest_prime_factor(userInput)