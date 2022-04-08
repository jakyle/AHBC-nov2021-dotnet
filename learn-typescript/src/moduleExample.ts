// A module, is simple a javascript or typescript file.  
// literally a {insert name}.js / {insert name}.ts file is a module.
// A module is a file that contains code that you want to reuse.


// we are exporting this function from this module, which means a different module
// will be able to import it in.
export function printMessage(message: string) {
	console.log(message)
}

// export keyword does NOT restrict the member to ONLY be used externally,
// you can still use this member inside the module