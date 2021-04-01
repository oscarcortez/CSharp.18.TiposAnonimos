# CSharp.18.TiposAnonimos

Tipos anonimos son clases sin nombre, no existe el codigo de dicha clase

aqui se puede ver un ejemplo usando el resultado de linq:
```csharp
var resultado = personas.Where(a => a.Edad == 30)
.Select(a => new { NombreCompleto = $"{a.Nombre} {a.Apellido}" });
```

este es el tipo anonimo, esto evita que se tenga que crear modelos auxiliares
```csharp
new { NombreCompleto = $"{a.Nombre} {a.Apellido}" }
```
