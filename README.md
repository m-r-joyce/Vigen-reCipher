# Vigenère Engineer
#### C# Vigenère Cipher Encryptor and Decryptor with ROT0/ROT1 Options
By **Michael Joyce** for **COMP3026 _Application Security Programming_**, Instructor **Randy Baker**

29 May 2017

This simple C# desktop application allows a user to encrypt and decrypt messages using a Vigenère cipher. The option to use ROT0 (a = a) as well as ROT1 (a = b) are available.

The plaintext must be between 20 and 60 characters. The key must contain between 5 and 10 characters. Punctuation is not permitted, though spaces are permitted in the plaintext input (and will be reflected in the output).

#### Resources Used
- Microsoft. (n.d.). *Regex class*. Retrieved from https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex(v=vs.110).aspx
- Vigenère cipher. (2013). By user "Timur". Retrieved from https://planetcalc.com/2468/
> *Used to verify results of encryption/decryption function*