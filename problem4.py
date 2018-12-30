#The purpose of this program is to find largest 3-digit palindrome product

print("Palindrome problem starting...")

n1 = 100
n2 = 100

ans = 0;

def reverse(num):
    rev = 0
    while num > 0:
        rev = (10 * rev) + num % 10
        num //= 10
    return rev

def isPalindroms(input):
    if(input == reverse(input)):
        return True
    else:
        return False

for i1 in range(100, 1000):
    # print("i1 is " + str(i1))
    for i2 in range(100, 1000):
        # print ("i2 is " + str(i2))
        temp = i1*i2
        if(isPalindroms(temp) and (temp > ans)):
            ans = temp
            print("program finished. Largest palindrome: " + str(ans))

# This program can be modified to give a general solution for n digits.
# n can be defined by used input.
# We can change the ranges of i1 and i2 and then define them in terms of 10^n.
