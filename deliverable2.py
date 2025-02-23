import random

# Ask the user for their name
name = input("What is your name? ")

# Ask if they want to do the COIN FLIP CHALLENGE
challenge_response = input(f"Hi {name}, do you want to do the COIN FLIP CHALLENGE? (Yes/No): ").lower()

# If the user says "No", call them a coward and exit
if challenge_response == "no":
    print(f"You're a coward, {name}!")
else:
    # Start the challenge if the user agrees
    score = 0
    print(f"Alright, {name}, let's get started! You have 5 rounds to go.")
    
    # Loop for 5 rounds
    for round in range(1, 6):
        # Randomly pick 0 or 1 for heads or tails
        coin_flip = random.randint(0, 1)
        
        # Ask the user to guess "heads" or "tails"
        user_guess = input("Guess 'heads' or 'tails': ").lower()
        
        # Compare the user's guess with the random number
        if (coin_flip == 0 and user_guess == "heads") or (coin_flip == 1 and user_guess == "tails"):
            score += 1
            print("Correct guess!")
        else:
            print("Wrong guess. Better luck next time!")
    
    # After 5 rounds, tell the user their score
    print(f"{name}, the challenge is over. Your score is: {score} out of 5.")

