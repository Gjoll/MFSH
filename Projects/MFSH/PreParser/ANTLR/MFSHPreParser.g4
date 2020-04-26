parser grammar MFSHPreParser;

options { tokenVocab=MFSHPreLexer; }

text: (fsh | mfsh | profile)* EOF;

profile: PROFILE WS? (TEXT (WS | TEXT | LB)*) EOL ;
fsh:
	WS? ( (TEXT | COLON) (WS | TEXT | LB | COLON)*)? EOL
  |	WS? EOL
	;

mfsh: WS? LB (WS | TEXT | LB)* EOL
    ;

