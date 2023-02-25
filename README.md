# Gilded Rose Refactoring Kata

This Kata was originally created by Terry Hughes (http://twitter.com/TerryHughes). It is already on GitHub [here](https://github.com/NotMyself/GildedRose). See also [Bobby Johnson's description of the kata](https://iamnotmyself.com/refactor-this-the-gilded-rose-kata/).

[Emily Bache](https://github.com/emilybache) translated the original C# into a few other languages, (with a little help from her friends!), and slightly changed the starting position. This means she's actually done a small amount of refactoring already compared with the original form of the kata, and made it easier to get going with writing tests by giving you one failing unit test to start with. She also added test fixtures for Text-Based approval testing with TextTest (see [the TextTests](https://github.com/emilybache/GildedRose-Refactoring-Kata/tree/master/texttests))

As Bobby Johnson points out in his article ["Why Most Solutions to Gilded Rose Miss The Bigger Picture"](https://iamnotmyself.com/why-most-solutions-to-gilded-rose-miss-the-bigger-picture/), it'll actually give you better practice at handling a legacy code situation if you do this Kata in the original C#. In the format of Emily however, this kata is also really useful for practicing writing good tests using different frameworks and approaches, and the small changes she's made help with that. It's also interesting to compare what the refactored code and tests look like in different programming languages.

She uses this kata as part of her work as a [technical coach](https://leanpub.com/techagilecoach). A while back she wrote this article ["Writing Good Tests for the Gilded Rose Kata"](http://coding-is-like-cooking.info/2013/03/writing-good-tests-for-the-gilded-rose-kata/) about how you could use this kata in a [coding dojo](https://leanpub.com/codingdojohandbook).

## How to use this Kata

The simplest way is to just clone the code and start hacking away improving the design. You'll want to look at the ["Gilded Rose Requirements"](https://github.com/costa-amore/Gilded_Rose_kata/blob/master/Gilded_Rose_behavior/Gilded_Rose_requirements.txt) which explains what the code is for. It's strongly recommended that you'll write some tests if you want to make sure you don't break the code while you refactor.

You could write some unit tests yourself, using the requirements to identify suitable test cases. You can start with the provided failing unit test as a starting point.

Alternatively, use the "Text-Based" tests provided in this repository. (Read more about that in the next section)

Whichever testing approach you choose, the idea of the exercise is to do some deliberate practice, and improve your skills at designing test cases and refactoring. The idea is not to re-write the code from scratch, but rather to practice designing tests, taking small steps, running the tests often, and incrementally improving the design. 

### Gilded Rose Requirements in other languages 

- [English](GildedRoseRequirements.txt)
- [Español](GildedRoseRequirements_es.md)

## Text-Based Approval Testing

This code has a [TextTest](https://texttest.org) fixture for Approval testing. For information about this, see the [TextTests README](https://github.com/emilybache/GildedRose-Refactoring-Kata/tree/master/texttests)

