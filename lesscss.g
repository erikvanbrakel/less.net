grammar lesscss;
options {
	output=AST;
	ASTLabelType=CommonTree;
	language=CSharp;
	k=4;}


tokens {
	SELECTOR;
	VAR;
	TAG;
	ATTRIB;
	ATTRIBEQUAL;
	RULE;
	PARENTOF;
	PRECEDEDS;
	ID;
	CLASS;
	PSEUDO;
	HASVALUE;
	BEGINSWITH;
	PROPERTY;
	LESS;
}
lessCss 
	: cssRule* -> ^(LESS cssRule*)
	;

fragment cssRule
	:	 variable | ruleset;
variable
	: '@' IDENT ':' expr ';' -> ^( VAR IDENT expr)
	;
ruleset
 	: selectors '{' rulesetLine* '}' -> ^( RULE selectors rulesetLine* )
	;
	
fragment rulesetLine 
	:	ruleset | property;
	
selectors
	: selector (',' selector)* -> ^(SELECTOR selector+)
	;
	
selector 
	: elem selectorOperation* attrib* ->  elem selectorOperation* attrib*
	;

selectorOperation
	: selectop? elem -> selectop* elem
	;

fragment selectop
	: '>' -> PARENTOF
        | '+'  -> PRECEDEDS
	;

fragment property
	: declaration ';' ->  declaration
	;
	
fragment elem
	: IDENT -> ^( TAG IDENT )
	| '#' IDENT -> ^( ID IDENT )
	| '.' IDENT -> ^( CLASS IDENT )
	;

pseudo
	: (':'|'::') IDENT -> ^( PSEUDO IDENT )
	| (':'|'::') function -> ^( PSEUDO function )
	;

attrib
	: '[' IDENT (attribRelate (STRING | IDENT))? ']' -> ^( ATTRIB IDENT (attribRelate STRING* IDENT*)? )
	;
	
attribRelate
	: '='  -> ATTRIBEQUAL
	| '~=' -> HASVALUE
	| '|=' -> BEGINSWITH
	;	
  
declaration
	: IDENT ':' args -> ^( PROPERTY IDENT args )
	;


expr
	: (NUM unit?)
	| IDENT
	| COLOR
	| STRING
	| function
	;

unit
	: ('%'|'px'|'cm'|'mm'|'in'|'pt'|'pc'|'em'|'ex'|'deg'|'rad'|'grad'|'ms'|'s'|'hz'|'khz')
	;
	
args
	: expr (','? expr)* -> expr*
	;

function
	: IDENT '(' args? ')' -> IDENT '(' args* ')'
	;

IDENT
	:	('_' | 'a'..'z'| 'A'..'Z' | '\u0100'..'\ufffe' ) 
		('_' | '-' | 'a'..'z'| 'A'..'Z' | '\u0100'..'\ufffe' | '0'..'9')*
	|	'-' ('_' | 'a'..'z'| 'A'..'Z' | '\u0100'..'\ufffe' ) 
		('_' | '-' | 'a'..'z'| 'A'..'Z' | '\u0100'..'\ufffe' | '0'..'9')*
	;

// string literals
STRING
	:	'"' (~('"'|'\n'|'\r'))* '"'
	|	'\'' (~('\''|'\n'|'\r'))* '\''
	;

NUM
	:	'-' (('0'..'9')* '.')? ('0'..'9')+
	|	(('0'..'9')* '.')? ('0'..'9')+
	;

COLOR
	:	'#' ('0'..'9'|'a'..'f'|'A'..'F')+
	;

// Single-line comments
SL_COMMENT
	:	'//'
		(~('\n'|'\r'))* ('\n'|'\r'('\n')?)
		{$channel=HIDDEN;}
	;
	
// multiple-line comments
COMMENT
	:	'/*' .* '*/' { $channel = HIDDEN; }
	;

// Whitespace -- ignored
WS	: ( ' ' | '\t' | '\r' | '\n' | '\f' )+ { $channel = HIDDEN; }
	;

