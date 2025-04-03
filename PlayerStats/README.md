## Diagrama UML de Classes

```mermaid
classDiagram
    class Color {
        - const byte DEFAULT_ALPHA
        - byte red
        - byte green
        - byte blue
        - byte alpha
        + byte Red
        + byte Green
        + byte Blue
        + byte Alpha
        + Color(byte red, byte green, byte blue, byte alpha)
        + Color(byte red, byte green, byte blue)
        + byte GetGrey
    }
    class Sphere {
        - Color color
        - float radius
        - int timesThrown
        + Color Color
        + float Radius
        + int TimesThrown
        + Sphere(Color color, float radius)
        + void Pop()
        + void Throw()
        + string ToString()
    }
    Sphere --> Color