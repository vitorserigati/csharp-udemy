# File, FileInfo

- Namespace System.IO

- Realiza Operações com arquivos (create, copy, delete, move, open, etc.) e ajuda na crianção de objetos FileStream.

- File:
    - static members (simples, mas realiza verificação de segurança para cada operação)

- FileInfo:
    - instance members

## IOException

- Namespace System.UI

- IOException
    - DirectoryNotFoundException
    - DriveNotFoundException
    - EdOfStremException
    - FileLoadException
    - FileNotFoundException
    - PathTooLongException
    - PipeException

## FileStream

Disponibiliza uma stream associada a um arquivo, permitindo operações de leitura e escrita.

Suporte a dados binários.

- Instanciação:

    - Vários Construtores
    - File / FileInfo

## StreamReader

É uma stream capaz de ler caracteres a partir de uma stream binária (ex: FileStream).

Suporte a dados no formato de texto.

- Instanciação:

    - Vários construtores.
    - File/FileInfo

### Stream

Stream em programação/informática significa uma sequência de dados. Comum quando queremos transmitir dados em sequência.

## Block Using

Sintaxe simplificada que garante que os objetos IDisposable serão fechados.

Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser manualmente fechados.

Exemplos: Font, FileStream, StreamReader, StreamWriter...

## StreamWriter

É uma stream capaz de escrever caracteres a partir de uma stream binária (ex: FileStream).
Suporte a dados no formato de texto.

- Instanciação:

    - Vários Construtores.
    - File/FileInfo
        - CreateText(path)
        - AppendText(string)


## Directory, DirectoryInfo

- Namespace System.IO
- Operações com pastas (create, enumerate, get files, etc.).
- Directory
    - static members (simples, mas realiza verificação de segurança para cada operação)
- DirectoryInfo
    - Instance Members
## Path 

- Namespace System.IO

- Realiza Operações com strings que contém informações de arquivos ou pastas.
