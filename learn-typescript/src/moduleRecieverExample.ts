// this syntax is pretty literal, we use the import key word,
// then curly brackets, then inside the curly brackets, you put in the
// name of the variable or function or class, then after the brackets
// you use the from key word, followed by a string that contains the
// relative path to the module you are importing from (a module is literally 
// just a javascript or typescript file).
import { printMessage } from "./moduleExample";

printMessage("Hello World");