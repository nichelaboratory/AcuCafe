I have refactored the code to use the Decorator design pattern. This pattern seemed a good fit for the code in question as it:

1. Easily allows new drinks to be added.
2. Makes it easy to prevent certain orders, e.g. stop milk being added to iced tea.

The design pattern is explained in the O'Reilly Head First Design Patterns book.

I've added several unit tests - more can be added but these show the general principals of TDD.

One likely future requirement is for a double espresso to be added. This would essentially need two instances of the Espresso class
but there would have to be some sort of discounting functionality (e.g. 2nd espresso shot an extra 30p). This could be added as a
condiment, or a method within Espresso, or maybe as a separate DoubleEspresso class.

If I had more time I'd also add a class based on the Factory design pattern which would further automate the ordering of drinks,
e.g. espresso, double espresso. The factory should show error messages (e.g. attempt to add milk to iced tea).