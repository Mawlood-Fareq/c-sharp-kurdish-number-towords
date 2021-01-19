# Kurdish number to words

## Introduction
Converts Numbers (including decimal points) into words for Central Kurdish Language. It also converts the numbers into words for currency.


## Usage
### Importing
```c#
using KurdishNumberToWords;
```

### To convert Number to words
```c#
KurdishNumber num = new KurdishNumber();
Console.WriteLine(num.Convert(123)) // سەد و بیست و سێ
```

### To convert Currency to words
```c#
Console.WriteLine(num.ConvertCurrency(123)) // سەد و بیست و سێ دینار
```
Use Currency with including decimal points :
```c#
Console.WriteLine(num.ConvertCurrency(123.25)) // سەد و بیست و سێ دینار و بیست و پێنج فلس
```

_Note. By default Currency unit is __Dinar__ and decimal unit is __Flis__, you can change to any Currency and decimal unit :_
```c#
Console.WriteLine(num.ConvertCurrency(123, 'دۆلار')) // سەد و بیست و سێ دۆلار

Console.WriteLine(num.ConvertCurrency(123.25, 'دۆلار', 'سەنت')) // سەد و بیست و سێ دۆلار و بیست و پێنج سەنت
```


## Change Log

__Version 1.0.1__
* Converts Currency into words.
* Use Special Currency and decimal units.

__Version 1.0.0__
* Converts Numbers into words for Central Kurdish Language.