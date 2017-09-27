# MakeLink
Command line tool to create Windows shortcuts.

Created primarly to be used with configuration or set up scripts.

## Usage
    make-link.exe [parameters]
        -target:<path>
        -icon:<path>
        -arguments:<arguments>
        -working-directory:<path>
        -description:<Description>

## Example
    make-link -target:"C:\Program Files (x86)\MyProgram\MyProgram.exe" -output:StartMyProgram.lnk -arguments:"/b /r etc"
