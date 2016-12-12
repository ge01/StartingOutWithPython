# Get the user's name, age, and income.
name = raw_input('Enter your name?')
age = int(raw_input('Enter your age?'))
income = float(input('Enter your income?'))

# Display the data.
print('Here is the data you entered:')
print('Name: ' + name)
print('Age: {}'.format(age))
print('Income: {}'.format(income))
