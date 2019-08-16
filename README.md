# Csharp
## Relational 
| Relational operators  | C# relational operator| Sample C# |
| :--------------------:|:---------------------:| :--------:|
| >                     | >                     |  x > y    |
| <                     | <                     |  x < y    |
| ≥                     | >=                    |  X >= y   |
| ≤                     | <=                    |  x <= y   |
|                       |                       |           |
| Equality operators    | C# Equality operators |           | 
|=                      | ==                    |  x == y   |
|≠                      | =!                    |  x =! y   |

```csharp
using System; 
 
public class RelationalEquality  
{ 
    public static void Main( string[] args ) 
    {
        int integer1; 
        int integer2; 

        Console.Write( "Enter first integer: " ); 
        integer1 = Convert.ToInt32( Console.ReadLine() );

        Console.Write( "Enter second integer: " ); 
        integer2 = Convert.ToInt32( Console.ReadLine() );

        if ( integer1 == integer2 ) 
            Console.WriteLine( "{0} == {1}", integer1, integer2 );

        if ( integer1 != integer2 ) 
            Console.WriteLine( "{0} != {1}", integer1, integer2 );

        if ( integer1 < integer2 ) 
            Console.WriteLine( "{0} < {1}", integer1, integer2 );

        if ( integer1 > integer2 ) 
            Console.WriteLine( "{0} > {1}", integer1, integer2 );

        if ( integer1 <= integer2 ) 
            Console.WriteLine( "{0} <= {1}", integer1, integer2 );

        if ( integer1 >= integer2 ) 
        Console.WriteLine( "{0} >= {1}", integer1, integer2 );
    } 
} 

```