# Get the user's name, age, and income.
name = raw_input('What is your name? ')
age = int(raw_input('What is your age? '))
income = float(input('What is your income? '))

# Display the data.
print('Here is the data you entered:')
print ('Name: ' + name)
#print ('Age: ', age)
print ('Age: {}'.format(age))
print('Income: {}'.format(income))
