using Models;


//Listas
List<string> listaString = new List<string>();

listaString.Add("Eric");
listaString.Add("Fernandez");
listaString.Remove("Fernandez");
Console.WriteLine($"Capacidade: {listaString.Capacity}");
Console.WriteLine($"Count: {listaString.Count}");
for(int contador = 0; contador < listaString.Count; contador++){
    Console.WriteLine($"{contador} - {listaString[contador]}");
}

// ARRAYS
int[] arrayInteiros = new int[3];
arrayInteiros[0] = 33;
arrayInteiros[1] = 66;
arrayInteiros[2] = 99;


int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


Console.WriteLine(arrayInteiros[0]);

//Modificar o tamanho do array:
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

for (int contador = 0; contador < arrayInteiros.Length; contador++){
    Console.WriteLine($"Posição {contador}: {arrayInteiros[contador]}");
}

foreach(int valor in arrayInteiros){
    Console.WriteLine(valor);
}

Pessoa p = new Pessoa();
p.Name = "Eric";
p.Age = 28;
p.Hello();