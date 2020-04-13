#panos30fyllou
def palindrome(s, l):
    for i in range (0, l):
        if (not s[i] == s[l - i - 1]):                   
            return False   
    return True

s = list(input("Enter a string: "))
size = len(s)
i = 0
while not palindrome(s, len(s)):
        s.insert(size, s[i])
        i += 1
print(i)