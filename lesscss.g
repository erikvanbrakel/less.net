grammar lesscss;
options {
	output=AST;
	ASTLabelType=CommonTree;
	language=CSharp;
	}


tokens {
	VAR;
	RULE;
	PROPERTY;
	SELECTORGROUP;
	SELECTOR;
	FONTDEFINITION;
	CLASS;
	TAG;
	ID;
	WILDCARD;
	EXPR;
	CONSTANT;
	LITERAL;
	MIXIN;
}

lessCss
	: (lessLine)+
	;
	

fragment variable
	: '@' IDENT ':' (literal -> IDENT ^(LITERAL literal) | additiveExpression -> IDENT ^(EXPR additiveExpression)) ';'
	;
fragment lessLine
	: ruleset | mediadefinition | (variable -> ^(VAR variable))
	;


	
fragment literal
	: (STRING | IDENT) (',' (STRING | IDENT))*
	;

fragment varname 
	: '@' IDENT -> IDENT
	;


fragment expression
	: 	additiveExpression -> ^(EXPR additiveExpression)
	;

fragment additiveExpression
	:	multiplicativeExpression ( ('+'|'-')^ multiplicativeExpression )*
	;

fragment multiplicativeExpression 
	:	primaryExpression ( ('*'|'/')^ primaryExpression)*
	;

fragment primaryExpression
	:	'('! additiveExpression ')'!
	|	value 
	;

fragment value	
	: 	varname -> ^(VAR varname)
	|	numeric -> ^(CONSTANT numeric)
	;
	
fragment numeric
	:	(NUM UNIT?) | COLOR
	;
	
fragment mediadefinition
	: ('@media' media '{' lessCss '}') 
	;
fragment ruleset 
	: selectors '{' ruleContents* '}' -> ^(RULE selectors ruleContents*)
	;
	
fragment ruleContents
	: property -> ^(PROPERTY property) | ((selectors ';') -> ^(MIXIN selectors)) | ruleset;

fragment media 	: 'all'|'braille'|'embossed'|'handheld'|'print'|'projection'|'screen'|'speech'|'tty'|'tv';

fragment selectors
	: selectorGrouping (',' selectorGrouping)* -> ^(SELECTORGROUP selectorGrouping+)
	;
	
fragment selectorGrouping
	: (selectorOps? selector)+ -> ^(SELECTOR selector+)
	;
	

fragment property
	: IDENT ':' propval+ ';' -> IDENT propval+
	;

fragment propval
	: literal | additiveExpression -> ^(EXPR additiveExpression);
fragment selector
	: IDENT | SelectorClass | SelectorID
	;

	
fragment selectorOps 
	: '>' | '+'
	;

			
val 
	:	IDENT '(' (STRING | (NUM UNIT?) | COLOR) (',' (STRING|(NUM UNIT?)|COLOR))* ')'
	|	IDENT
	|	STRING
	|	(NUM UNIT?)
	|	COLOR
	;

SelectorClass 
	: '.' IDENT
	;

SelectorID
	: '#' IDENT
	;

// string literals
STRING
	:	'"' (~('"'|'\n'|'\r'))* '"'
	|	'\'' (~('\''|'\n'|'\r'))* '\''
	;

UNIT
	: ('%'|'px'|'cm'|'mm'|'in'|'pt'|'pc'|'em'|'ex'|'deg'|'rad'|'grad'|'ms'|'s'|'hz'|'khz')
	;
	
NUM
	:	('-' (('0'..'9')* '.')? ('0'..'9')+
	|	(('0'..'9')* '.')? ('0'..'9')+)
	;

COLOR
	:	'#' ('0'..'9'|'a'..'f'|'A'..'F')+
	;

		
IDENT
	:	('_' | 'a'..'z'| 'A'..'Z' ) 
		('_' | '-' | 'a'..'z'| 'A'..'Z' | '0'..'9')*
	|	'-' ('_' | 'a'..'z'| 'A'..'Z' ) 
		('_' | '-' | 'a'..'z'| 'A'..'Z' | '0'..'9')*
	;

// Ignore whitespace and comments

SL_COMMENT
	:	'//'
		(~('\n'|'\r'))* ('\n'|'\r'('\n')?)
		{$channel=HIDDEN;}
	;
	
COMMENT
	:	'/*' .* '*/' { $channel=HIDDEN; }
	;

WS	: ( ' ' | '\t' | '\r' | '\n' | '\f' )+ { $channel=HIDDEN; }
	;
