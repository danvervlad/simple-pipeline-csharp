# Simple Pipeline

Simple pipeline pattern in Csharp

## Usage examples

Pass integer through pipe and convert it to string at result.

```c#
var result = await Task.FromResult(3)
                       .Step(new MultiplyStep(multiplier))
                       .Step(new OptionalStep<int, int>(i => i > 10, new MultiplyStep(multiplier)))
                       .Step(new ConvertToStringStep());
```