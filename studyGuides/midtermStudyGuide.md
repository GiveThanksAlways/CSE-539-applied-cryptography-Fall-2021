# Midterm Study Guide

## Week 1
### Introduction to Cryptography
### Basic Concepts
* Number Theory - (primes and prime factorization) `p x q = N`
* Number Theory - (one-way function concept)
* Number Theory - (know how to use mod N ---> 5 mod 4 = 1)
* random numbers concepts
* hash functions concepts
* encryptions (symmetric and asymmetric)
* Kerckhoff's Principle (many eyes, public algorithm, private key, mathmatically indecipherable, ciphertext doesn't have to be secret, etc.)
* types of ciphers (vegnere, Cesear, basics on how to describe them)
* Describe each of these on a basic level (steganography, cryptoanalysis, encryption, hashing)
* stream cipher basics and block cipher basics
* Cryptographic goals (confidentiality, data integrity, authentication, non-repudiation)

### Encryption Basics
* symmetric and asymmetric categories/ basic concepts
* DES concepts
* AES basics
* Sbox/Pbox basic concepts
* feistel cipher (DES) basic structure/concept and how to XOR
* key strength in relation to number of bits 

## Week 2
### Random Numbers
* Be familiar with the term nonce being used as a random number
* how the size of a random number effects encryption strength
* statistical tests for randomness
* basic differences between PRNG and CSPRNG
* CSPRNG basic concepts. How can a CSPRNG be made?
* how seeds help you build a PRNG or CSPRNG
### Hash Functions
* basic properties of hash functions (deterministic, many-to-one, types)
* collisions
* over the phone coin toss example (hashing and salting)
* usage of hash functions (digital signatures, data integrity)
* Basics on how a hash function can be made / other ways to make one
### Encryption Algorithms
* symmetric encryption basics
* asymmetric encryption basics
* one time pad concepts
* practice the bitwise XOR computation by hand 
* DES basic concepts/ basic structure
* AES basic concepts/ basic structure
* RSA basic concepts
* RSA basic calculations of plaintext and ciphertext
### Birthday Attacks on Hash Functions
* basic concept of birthday attack
* how to defend against birthday attacks
* basic statistical idea behind birthday paradox.

## Week 3
### Password Insecurity
* what are common attacks on passwords?
* salting concepts
* birthday paradox concept
* what are efficient attacks on passwords?
* can we reverse hashes? (dictionary attacks, rainbow tables, commenly used passwords)
* How hard is it to brute force a password?
* Unix password history basics
### Password Storage
* know how passwords are stored
* password storage with salting
* what hashing algorithms/ bit size are good to use
### Rainbow Tables
* Rainbow Tables (basic concepts)
* How does salting help prevent rainbow attacks?

## Week 4
### Authentication
* Forms of authentication for passwords
* basic concepts about attacks on pre-shared keys/ defense against attacks (multifactor authentication, challenge-response, replay attack, man-in-the-middle, etc.)
### Key Exchange
* Merkle's puzzles (basic concepts)
* be familiar with basics of why key exchange is used
* be familiar with Diffie-Hellman and RSA concepts
* basic calculations used for Diffie-Hellman and RSA concepts
### Diffie-Hellman Key Exchange
* Basic concepts
* usage
* basic calculations used for Diffie-Hellman (small numbers that can be done without calculator)
* Man in the Middle Attack on Diffie-Hellman
### Public Keys and Applications
* elliptic curve cryptography basic concepts/ basic usage
* key exchange with elliptic curve diffie hellman basic steps
* Why is RSA so hard to break?
* Basic RSA calculations
* Why is Diffie-Hellman so hard to break?
* Review basic concepts on ElGamal and elliptic curves
* digital signatures (basics of how they work)
* digital certificates basics

