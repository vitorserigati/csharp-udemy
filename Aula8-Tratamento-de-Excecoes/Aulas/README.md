# Estrutura try-catch

- Bloco try:
    - Contém o código que representa a execução normal do trecho de código que pode acarretar em uma exceção.

- Bloco catch:
    - Contém o código a ser executado caso uma exceção ocorra.
    - Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido).

## Bloco finally

- É um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção.

- Exemplo clássico: Fechar um arquivo ou conexão de banco de dados ao final do processamento.

sintaxe:

```csharp

try{
}catch(){
}
finally {
}
```
exemplo de uso:

```csharp
using System;
using System.IO/

public class ProcessFile{

    public static void Main(){
        FileStram fs = null;

        try{
            fs = new FileStram(@"C:\temp\data.txt", FileMode.Open);
            StramReader sr = new StramReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e){
            Console.WriteLine(e.Message);
        }
        finally{
            if(fs != null){
                fs.Close();
            }
        }
    }
}
```
