# MFSH

FSH (FHIR) prepropcessor

## Installation

Open Visual Studio Package Manager Console, and type the following.

dotnet tool install --global Eir.MFSH

to upgrade,

dotnet tool uninstall --global Eir.MFSH

dotnet tool install --global Eir.MFSH

## Command Line Option

MFSH has only one optional command line option. This option is the name of the 
json configuration file that configures the watches.
If no name is passed on the command line, then the config file defaults to

MFSH.json

## Options file

MFSH is controlled from a user defined json file. 

```json
{
	"baseInputDir": "{path}",
	"baseOutputDir": "{path}",
	"baseUrl": "{url}",
	"mfshPaths": [
		"MFSH"
	],
	"defines": [
		{
			"name": "%GraphDir%",
			"value": "..\\GraphFiles"
		}
	],
	"cleanDirs": [
		{
			"path": "..\\build\\input\\pagecontent",
			"filter": "StructureDefinition-*-intro.xml"
		}
	]
}
```

The format of this file is json.
| name | meaning |
| ---- | -------------- |
| {baseInputDir} | Base Input Dir. The output path is computed by taking the input path minus its base dir and adding the output dir |
| {baseOutputDir} | Base dir of all output files |
| {baseUrl} | Fhir base url for all profiles being generated by this project.  |
| {working dir} | Sets the working dir used when a command is executed. |
| {mfshPaths} | Array of input files/directories to process. All *.minc and *.mfsh files referenced here will be processed |
| {defines} | Define variable values. When processing mfsh content, these variables can be referenced |
| {cleanDirs} | Optional array of directories to clean. At startup all files in the path matching the file filter will be scanned. If they are not updated during the running of the program they will be deleted at program conclusion |

## MFSH Grammar

MFSH reads two kinds of files
| name | meaning |
| ---- | -------------- |
| *.minc | These files include macro and variable definitions, but do not generate directly any fsh |
| *.mfsh | These files can include macro and variable definitions like .minc files, but they will generate a corresponding .fsh file |

### MFSH Commands

All mfsh commands are formatted as a line that starts with a '#'. White space can proceed the '#' character.

#### macro

Define a mfsh macro.
The syntax of the command is

```text
\#macro {name} [once] ([{parameters}]) [> {output path}]
macro value (i.e. fsh text)
\#end
```
 
| name | meaning |
| ---- | -------------- |
| {name}| name of the macro. The name must be unique in the project |
| {profile} | optional flag indicating that the macro should only be referenced once in any profile.
All references after the initial reference will be ignored. 
If once is included, then the macro must have no macros |
| {global} | Similar to profile, except that the macro should only be referenced a single time,
even if called from multiple profiles |
| {parameter names} | A comma separated list of parameter names that define paraneters to expand when the macro is invoked.
Each parameter will be treated like a variable, and can have the format name or %name%. |
| {output path} | An optional path. If not included then the value of the invoked macro will be copied to the current output fsh file.
If included, then text from a macro can be redirected to any alternate file. All text to an alternate file from multiple macro applications
will be concatenated together. Text in a file from a previous mfsh run will not be retained |
| macro value | whatever text and/or mfsh commands the macro should expand. |

Example

```text
#macro SetComponent(SliceName, Cardinality, ValueSet)
  #apply GraphLink("focus")
  * component[SliceName].value[x] Cardinality
  * component[SliceName].value[x] only CodeableConcept
  * component[SliceName].value[x] from ValueSet
#end
```

Example Redirect

This macro assumes that the '%PageContent%' variable was defined in the options file.

```text
//
// Write out an intro doc.
//
#macro IntroDoc(%Description%) > "%PageContent%\\StructureDefinition-%Id%-intro.xml"
  ` <div xmlns="http://www.w3.org/1999/xhtml"
  `     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  `     xsi:schemaLocation="http://hl7.org/fhir ../../src-generated/schemas/fhir-single.xsd">
  `   <p>
  `     <u style="font-size:large;">Description</u>
  `   </p>
  `   %Description%
  ` </div>
#end
```
#### apply

Apply a mfsh macro.

The syntax of the command is

```text
\#apply {name} ([{parameters}])
```
| name | meaning |
| ---- | -------------- |
| {name}| name of the macro to expand|
| {parameter values} | A comma separated list of parameter values.
Each value is enclosed in quotes or multi line quotes ('"""').
The number of parameter values must match the number of parameters defined for the macro.
The parameter value can contains variales/parameters that will be expanded when called. |

Example

```text
#apply SetComponent("mySlice", "0..1", "MyValueSet")
#end
```

Example Multi line

```text
#apply SetComponent(
#  """
#  mySlice
#  """,
# "0..1",
# "MyValueSet")
```

#### incompatible

This will indicate that the current profile or macro is incompatible with a macro.
Attempts to call that macro will cause a run time error.


The syntax of the command is

```text
\#incompatible {name}

| name | meaning |
| ---- | -------------- |
| {name}| name of the macro that is being declatred as incompatible |

#### use

The use macro defines a name that will be used in searching for macros (i.e. when calling using \#apply).

A macro name can be defines with periods in the name delimiting the name int seperate pseudo namespaces.

#macro Alpha.Beta.Delta()

The macro can be referenced by its full name

#apply Alpha.Beta.Delta()

or you can use the short cut.

#use Alpha
#apply Beta.Delta()

#use Alpha.Beta
#apply Delta()

A use statement is valid for the whole file.

### FSH Text

Lines that do not start with a '#' are processed as fsh (or json/text if in a macro redirect).
MFSH will replace any variables references in these lines with the variable value.

### Variable Expansion
Variables can be defined which can be referenced in redirect paths, mfsh commands, and fsh text. When a string matching the variable is detected,
the value of the variable will replace the actual variable name.

There are two types of variables.

%{name}%

variables that start and end with '%' will be expanded whereever they are found

{name}

variables that do not start and end with '%' will be expanded only if they are seperate words.

i.e. if a variable xxyyz is defined, then the string

ABCxxyyzDEF

will not have xxyyz relaced,

ABC xxyyz DEF

will have its variable replaced.

### Variables
The following variables are automatically defined.

| name | meaning |
| ---- | -------------- |

| %ApplySourceFile% | The source file that contained the last #apply command executed. Used for debug tracing.
  ApplySourceFile uses unix forward slash directory seperators, not windows backwards slash. |
| %ApplyLineNumber% | The line number in the file that contained the last #apply command executed. Used for debug tracing |
| %ApplyStackFrame% | Apply stack trace (all the apply's command leading up to current context) |
| %BasePath% | The current input file path (relative to the base input directory) |
| %BaseDir% |  The current input file directory (relative to the base input directory)|
| %BaseName% |  The current input file name (no directory) |
| %BaseNameNoExtension% |  The current input file name (no directory, no extension) |

| %MacroName% | The name of the current macro |
| %MacroPath% | The path to the file containing the current macro |
| %MacroDir% | The name of the directory containing the current macro file |
| %MacroFileName% | The file name of the current macro file |
| %MacroFileNameNoExtension% | The file name of the current macro file |

| %SavePath% | The output file path, relative to the base output directory |
| %Id% | Fsh Id header value. This is the name of the current Profile or Extension|
| %Title% | Fsh Title header value. This is the title of the current Profile or Extension|
| %Url% | The name of the current Extension's or Profile's FHIR url. |










#### #if

Con ditionally include element.
The syntax of the command is

```text
\#if {condition}
Fsh/Mfsh lines
\#else if {condition}
Fsh/Mfsh lines
...
\#else
Fsh/Mfsh lines
\#end

```

'else' amd ;else if' are not required and the commadn may consist of just the 'if'...'end' commands.
'
| name | meaning |
| ---- | -------------- |
| {condition}| a condition that evaluates to true.|

Conditions can be one of the following
| condition | meaning |
| {string} == {string} | compare one string to another. True if both strings are the same. The string can be a simple string (enclosd in quotes)
or a multi line string. The contents of the string can be variables which get expanded. |
| {number} == {number} | compare one number to another. True if both numbers are the same. The {number} can be a variable which get expanded. |
| {number} >  {number} | compare one number to another. True if lhs > rhs. |
| {number} >=  {number} | compare one number to another. True if lhs >= rhs. |
| {number} <  {number} | compare one number to another. True if lhs < rhs. |
| {number} >=  {number} | compare one number to another. True if lhs >= rhs. |

Example

```text
#if "mySlice" == "MyValueSet"
...
#end
```

```text
#if Counter == 10
...
#end
```
