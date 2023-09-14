# simple-console-cpf-validator
The CPF (Cadastro de Pessoas Físicas) is a unique identification number issued to individuals in Brazil. It serves as a tax identification number and is used for various purposes, including financial transactions, government services, and employment. 
The CPF is similar to a social security number in the United States or a national insurance number in the United Kingdom.

1. Length: A valid CPF consists of 11 digits.

2. Digits: All digits must be numeric (0-9).

3. CPF Algorithm: The last two digits of the CPF are verification digits, and they are calculated based on the preceding nine digits using a specific algorithm.

Here's how the calculation works:

    a. Multiply each of the first nine digits of the CPF by a specific weight factor, which starts with 10 and decreases by 1 for each digit. For example, if the CPF is 123.456.789-09, the calculation would look like this:
    
    (1 * 10) + (2 * 9) + (3 * 8) + (4 * 7) + (5 * 6) + (6 * 5) + (7 * 4) + (8 * 3) + (9 * 2) = 293
    B. Calculate the first verification digit:
    
    Divide the result from step a (293) by 11.
    The remainder is calculated as 293 % 11, which is 9.
    If the remainder is less than 2, the first verification digit is 0. Otherwise, it's 11 minus the remainder, which is 11 - 9 = 2.
    
    C. Calculate the second verification digit:
    
    Multiply each of the first nine digits by a different set of weight factors, starting with 11 and decreasing by 1 for each digit.
    Add the results together.
    Add the first verification digit (2, calculated in step b) multiplied by 2 to the sum.
    Using the example CPF 123.456.789-09:
    
    (1 * 11) + (2 * 10) + (3 * 9) + (4 * 8) + (5 * 7) + (6 * 6) + (7 * 5) + (8 * 4) + (9 * 3) + (2 * 2) = 334
    
    D. Divide the result from step c (334) by 11.
    
    E. The remainder is calculated as 334 % 11, which is 9.

4. Combining the Verification Digits: After calculating both verification digits (in this case, 2 and 2), they are combined to form the last two digits of the CPF.

So, a valid Brazilian CPF is 11 digits long, contains only numeric digits, and the last two digits are calculated according to the rules mentioned above. If the calculated verification digits match the ones in the CPF, it is considered valid.

If the remainder is less than 2, the second verification digit is 0. Otherwise, it's 11 minus the remainder, which is 11 - 9 = 2.

Combining the Verification Digits: After calculating both verification digits (in this case, 2 and 2), they are combined to form the last two digits of the CPF.

So, a valid Brazilian CPF is 11 digits long, contains only numeric digits, and the last two digits are calculated according to the rules mentioned above. If the calculated verification digits match the ones in the CPF, it is considered valid.
