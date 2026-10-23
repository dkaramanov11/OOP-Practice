# Shapes — Area and Perimeter

Create a system for working with geometric shapes.

## Requirements

- Create an abstract class Shape with a read-only Name property.
- Initialize the name through a constructor.
- Declare two abstract methods:
  - double CalculateArea()
  - double CalculatePerimeter()
- Add a PrintInfo() method that displays the shape's name,
  area, and perimeter to two decimal places.

- Create a Rectangle class that inherits from Shape.
- It has read-only Width and Height properties.
- Area = width * height.
- Perimeter = 2 * (width + height).

- Create a Circle class that inherits from Shape.
- It has a read-only Radius property.
- Area = PI * radius * radius.
- Perimeter = 2 * PI * radius.
- Use Math.PI for PI.

- All dimensions must be greater than 0.
- If a dimension is 0 or negative, display a message
  and set that dimension to 1.

## Testing

In Main:
1. Create a rectangle with width 4 and height 3.
2. Create a circle with radius 2.
3. Create a rectangle with an invalid width.
4. Store all shapes in a single List<Shape>.
5. Loop through the list and call PrintInfo() for each shape.