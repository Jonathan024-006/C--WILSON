using System;

public class Employee
{
    // Campo privado para guardar el documento
    private string _document;

    // Propiedad de solo lectura: se inicializa en el constructor
    public int Id { get; }

    // Nombre completo del empleado
    public string FullName { get; set; } = "";

    // Salario base (solo modificable dentro de la clase)
    public decimal BaseSalary { get; private set; }

    // Documento con validación
    public string Document
    {
        get => _document;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Documento requerido");
            _document = value.Trim();
        }
    }

    // Constructor con validaciones
    public Employee(int id, string fullName, decimal baseSalary, string document)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
        Id = id;
        FullName = fullName;
        SetBaseSalary(baseSalary);
        Document = document;
    }

    // Método para validar salario
    public void SetBaseSalary(decimal amount)
    {
        if (amount < 1_000_000m) throw new ArgumentException("Salario mínimo no válido");
        BaseSalary = amount;
    }
}

/* Ejercicio 1
   Crea Product con: Id (solo lectura), Name (valida no vacío), Price (>= 0), Stock (>= 0).
   Agrega dos constructores: uno completo y otro con precio 0 por defecto.
   Crea 2 instancias en Main y muéstralas por consola.
*/

// Clase Product con validaciones
public class Product
{
    public int Id { get; }
    private string _name; 
    private decimal _price;
    private int _stock;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío");
            _name = value.Trim();
        }
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0) throw new ArgumentException("El precio no puede ser negativo");
            _price = value;
        }
    }

    public int Stock
    {
        get => _stock;
        set
        {
            if (value < 0) throw new ArgumentException("El stock no puede ser negativo");
            _stock = value;
        }
    }

    // Constructor completo
    public Product(int id, string name, decimal price, int stock)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id));
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }

    // Constructor con precio 0 por defecto
    public Product(int id, string name, int stock) : this(id, name, 0m, stock) { }

    public override string ToString() => $"[{Id}] {Name} - Precio: {Price:C0}, Stock: {Stock}";
}
