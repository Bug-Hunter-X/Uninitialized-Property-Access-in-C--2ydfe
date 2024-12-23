public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property that hasn't been initialized
        int value = MyProperty; // This will cause an error if MyProperty is not assigned a value before this line. 
    }
}