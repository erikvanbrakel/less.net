// $ANTLR 3.1.2 d:\\lesscss.g 2009-07-28 14:55:21


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class lesscssLexer : Lexer {
    public const int CLASS = 13;
    public const int ATTRIB = 7;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int HASVALUE = 15;
    public const int PSEUDO = 14;
    public const int ID = 12;
    public const int ATTRIBEQUAL = 8;
    public const int EOF = -1;
    public const int COLOR = 22;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int SELECTOR = 4;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__59 = 59;
    public const int LESS = 18;
    public const int IDENT = 19;
    public const int VAR = 5;
    public const int COMMENT = 24;
    public const int T__50 = 50;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int RULE = 9;
    public const int BEGINSWITH = 16;
    public const int PARENTOF = 10;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int PRECEDEDS = 11;
    public const int NUM = 21;
    public const int TAG = 6;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int WS = 25;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int PROPERTY = 17;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int SL_COMMENT = 23;
    public const int STRING = 20;

    // delegates
    // delegators

    public lesscssLexer() 
    {
		InitializeCyclicDFAs();
    }
    public lesscssLexer(ICharStream input)
		: this(input, null) {
    }
    public lesscssLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "d:\\lesscss.g";} 
    }

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:7:7: ( '@' )
            // d:\\lesscss.g:7:9: '@'
            {
            	Match('@'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:8:7: ( ':' )
            // d:\\lesscss.g:8:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:9:7: ( ';' )
            // d:\\lesscss.g:9:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:10:7: ( '{' )
            // d:\\lesscss.g:10:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:11:7: ( '}' )
            // d:\\lesscss.g:11:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:12:7: ( ',' )
            // d:\\lesscss.g:12:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:13:7: ( '>' )
            // d:\\lesscss.g:13:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:14:7: ( '+' )
            // d:\\lesscss.g:14:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:15:7: ( '#' )
            // d:\\lesscss.g:15:9: '#'
            {
            	Match('#'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:16:7: ( '.' )
            // d:\\lesscss.g:16:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:17:7: ( '::' )
            // d:\\lesscss.g:17:9: '::'
            {
            	Match("::"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:18:7: ( '[' )
            // d:\\lesscss.g:18:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:19:7: ( ']' )
            // d:\\lesscss.g:19:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:20:7: ( '=' )
            // d:\\lesscss.g:20:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:21:7: ( '~=' )
            // d:\\lesscss.g:21:9: '~='
            {
            	Match("~="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:22:7: ( '|=' )
            // d:\\lesscss.g:22:9: '|='
            {
            	Match("|="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:23:7: ( '%' )
            // d:\\lesscss.g:23:9: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:24:7: ( 'px' )
            // d:\\lesscss.g:24:9: 'px'
            {
            	Match("px"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:25:7: ( 'cm' )
            // d:\\lesscss.g:25:9: 'cm'
            {
            	Match("cm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:26:7: ( 'mm' )
            // d:\\lesscss.g:26:9: 'mm'
            {
            	Match("mm"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:27:7: ( 'in' )
            // d:\\lesscss.g:27:9: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:28:7: ( 'pt' )
            // d:\\lesscss.g:28:9: 'pt'
            {
            	Match("pt"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:29:7: ( 'pc' )
            // d:\\lesscss.g:29:9: 'pc'
            {
            	Match("pc"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:30:7: ( 'em' )
            // d:\\lesscss.g:30:9: 'em'
            {
            	Match("em"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:31:7: ( 'ex' )
            // d:\\lesscss.g:31:9: 'ex'
            {
            	Match("ex"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:32:7: ( 'deg' )
            // d:\\lesscss.g:32:9: 'deg'
            {
            	Match("deg"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:33:7: ( 'rad' )
            // d:\\lesscss.g:33:9: 'rad'
            {
            	Match("rad"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:34:7: ( 'grad' )
            // d:\\lesscss.g:34:9: 'grad'
            {
            	Match("grad"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:35:7: ( 'ms' )
            // d:\\lesscss.g:35:9: 'ms'
            {
            	Match("ms"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:36:7: ( 's' )
            // d:\\lesscss.g:36:9: 's'
            {
            	Match('s'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:37:7: ( 'hz' )
            // d:\\lesscss.g:37:9: 'hz'
            {
            	Match("hz"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:38:7: ( 'khz' )
            // d:\\lesscss.g:38:9: 'khz'
            {
            	Match("khz"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:39:7: ( '(' )
            // d:\\lesscss.g:39:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:40:7: ( ')' )
            // d:\\lesscss.g:40:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:110:2: ( ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )* | '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )* )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= 'A' && LA3_0 <= 'Z') || LA3_0 == '_' || (LA3_0 >= 'a' && LA3_0 <= 'z') || (LA3_0 >= '\u0100' && LA3_0 <= '\uFFFE')) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == '-') )
            {
                alt3 = 2;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // d:\\lesscss.g:110:4: ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    {
                    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// d:\\lesscss.g:111:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt1 = 2;
                    	    int LA1_0 = input.LA(1);

                    	    if ( (LA1_0 == '-' || (LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z') || (LA1_0 >= '\u0100' && LA1_0 <= '\uFFFE')) )
                    	    {
                    	        alt1 = 1;
                    	    }


                    	    switch (alt1) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:
                    			    {
                    			    	if ( input.LA(1) == '-' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop1;
                    	    }
                    	} while (true);

                    	loop1:
                    		;	// Stops C# compiler whining that label 'loop1' has no statements


                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:112:4: '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    {
                    	Match('-'); 
                    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// d:\\lesscss.g:113:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( (LA2_0 == '-' || (LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z') || (LA2_0 >= '\u0100' && LA2_0 <= '\uFFFE')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:
                    			    {
                    			    	if ( input.LA(1) == '-' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0100' && input.LA(1) <= '\uFFFE') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:118:2: ( '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"' | '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\'' )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == '\"') )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == '\'') )
            {
                alt6 = 2;
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // d:\\lesscss.g:118:4: '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"'
                    {
                    	Match('\"'); 
                    	// d:\\lesscss.g:118:8: (~ ( '\"' | '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '\u0000' && LA4_0 <= '\t') || (LA4_0 >= '\u000B' && LA4_0 <= '\f') || (LA4_0 >= '\u000E' && LA4_0 <= '!') || (LA4_0 >= '#' && LA4_0 <= '\uFFFF')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:118:9: ~ ( '\"' | '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop4;
                    	    }
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	Match('\"'); 

                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:119:4: '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\''
                    {
                    	Match('\''); 
                    	// d:\\lesscss.g:119:9: (~ ( '\\'' | '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '\u0000' && LA5_0 <= '\t') || (LA5_0 >= '\u000B' && LA5_0 <= '\f') || (LA5_0 >= '\u000E' && LA5_0 <= '&') || (LA5_0 >= '(' && LA5_0 <= '\uFFFF')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:119:10: ~ ( '\\'' | '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop5;
                    	    }
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	Match('\''); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "NUM"
    public void mNUM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:123:2: ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ | ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == '-') )
            {
                alt13 = 1;
            }
            else if ( (LA13_0 == '.' || (LA13_0 >= '0' && LA13_0 <= '9')) )
            {
                alt13 = 2;
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // d:\\lesscss.g:123:4: '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
                    {
                    	Match('-'); 
                    	// d:\\lesscss.g:123:8: ( ( '0' .. '9' )* '.' )?
                    	int alt8 = 2;
                    	alt8 = dfa8.Predict(input);
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // d:\\lesscss.g:123:9: ( '0' .. '9' )* '.'
                    	        {
                    	        	// d:\\lesscss.g:123:9: ( '0' .. '9' )*
                    	        	do 
                    	        	{
                    	        	    int alt7 = 2;
                    	        	    int LA7_0 = input.LA(1);

                    	        	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
                    	        	    {
                    	        	        alt7 = 1;
                    	        	    }


                    	        	    switch (alt7) 
                    	        		{
                    	        			case 1 :
                    	        			    // d:\\lesscss.g:123:10: '0' .. '9'
                    	        			    {
                    	        			    	MatchRange('0','9'); 

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop7;
                    	        	    }
                    	        	} while (true);

                    	        	loop7:
                    	        		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	        	Match('.'); 

                    	        }
                    	        break;

                    	}

                    	// d:\\lesscss.g:123:27: ( '0' .. '9' )+
                    	int cnt9 = 0;
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:123:28: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt9 >= 1 ) goto loop9;
                    		            EarlyExitException eee9 =
                    		                new EarlyExitException(9, input);
                    		            throw eee9;
                    	    }
                    	    cnt9++;
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whinging that label 'loop9' has no statements


                    }
                    break;
                case 2 :
                    // d:\\lesscss.g:124:4: ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
                    {
                    	// d:\\lesscss.g:124:4: ( ( '0' .. '9' )* '.' )?
                    	int alt11 = 2;
                    	alt11 = dfa11.Predict(input);
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // d:\\lesscss.g:124:5: ( '0' .. '9' )* '.'
                    	        {
                    	        	// d:\\lesscss.g:124:5: ( '0' .. '9' )*
                    	        	do 
                    	        	{
                    	        	    int alt10 = 2;
                    	        	    int LA10_0 = input.LA(1);

                    	        	    if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
                    	        	    {
                    	        	        alt10 = 1;
                    	        	    }


                    	        	    switch (alt10) 
                    	        		{
                    	        			case 1 :
                    	        			    // d:\\lesscss.g:124:6: '0' .. '9'
                    	        			    {
                    	        			    	MatchRange('0','9'); 

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    goto loop10;
                    	        	    }
                    	        	} while (true);

                    	        	loop10:
                    	        		;	// Stops C# compiler whining that label 'loop10' has no statements

                    	        	Match('.'); 

                    	        }
                    	        break;

                    	}

                    	// d:\\lesscss.g:124:23: ( '0' .. '9' )+
                    	int cnt12 = 0;
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( ((LA12_0 >= '0' && LA12_0 <= '9')) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // d:\\lesscss.g:124:24: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt12 >= 1 ) goto loop12;
                    		            EarlyExitException eee12 =
                    		                new EarlyExitException(12, input);
                    		            throw eee12;
                    	    }
                    	    cnt12++;
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whinging that label 'loop12' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUM"

    // $ANTLR start "COLOR"
    public void mCOLOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:128:2: ( '#' ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+ )
            // d:\\lesscss.g:128:4: '#' ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+
            {
            	Match('#'); 
            	// d:\\lesscss.g:128:8: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= '0' && LA14_0 <= '9') || (LA14_0 >= 'A' && LA14_0 <= 'F') || (LA14_0 >= 'a' && LA14_0 <= 'f')) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt14 >= 1 ) goto loop14;
            		            EarlyExitException eee14 =
            		                new EarlyExitException(14, input);
            		            throw eee14;
            	    }
            	    cnt14++;
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whinging that label 'loop14' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLOR"

    // $ANTLR start "SL_COMMENT"
    public void mSL_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SL_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:133:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? ) )
            // d:\\lesscss.g:133:4: '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? )
            {
            	Match("//"); 

            	// d:\\lesscss.g:134:3: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= '\u0000' && LA15_0 <= '\t') || (LA15_0 >= '\u000B' && LA15_0 <= '\f') || (LA15_0 >= '\u000E' && LA15_0 <= '\uFFFF')) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:134:4: ~ ( '\\n' | '\\r' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	// d:\\lesscss.g:134:19: ( '\\n' | '\\r' ( '\\n' )? )
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == '\n') )
            	{
            	    alt17 = 1;
            	}
            	else if ( (LA17_0 == '\r') )
            	{
            	    alt17 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // d:\\lesscss.g:134:20: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 2 :
            	        // d:\\lesscss.g:134:25: '\\r' ( '\\n' )?
            	        {
            	        	Match('\r'); 
            	        	// d:\\lesscss.g:134:29: ( '\\n' )?
            	        	int alt16 = 2;
            	        	int LA16_0 = input.LA(1);

            	        	if ( (LA16_0 == '\n') )
            	        	{
            	        	    alt16 = 1;
            	        	}
            	        	switch (alt16) 
            	        	{
            	        	    case 1 :
            	        	        // d:\\lesscss.g:134:30: '\\n'
            	        	        {
            	        	        	Match('\n'); 

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SL_COMMENT"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:140:2: ( '/*' ( . )* '*/' )
            // d:\\lesscss.g:140:4: '/*' ( . )* '*/'
            {
            	Match("/*"); 

            	// d:\\lesscss.g:140:9: ( . )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == '*') )
            	    {
            	        int LA18_1 = input.LA(2);

            	        if ( (LA18_1 == '/') )
            	        {
            	            alt18 = 2;
            	        }
            	        else if ( ((LA18_1 >= '\u0000' && LA18_1 <= '.') || (LA18_1 >= '0' && LA18_1 <= '\uFFFF')) )
            	        {
            	            alt18 = 1;
            	        }


            	    }
            	    else if ( ((LA18_0 >= '\u0000' && LA18_0 <= ')') || (LA18_0 >= '+' && LA18_0 <= '\uFFFF')) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:140:9: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements

            	Match("*/"); 

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // d:\\lesscss.g:144:4: ( ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+ )
            // d:\\lesscss.g:144:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            {
            	// d:\\lesscss.g:144:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            	int cnt19 = 0;
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( ((LA19_0 >= '\t' && LA19_0 <= '\n') || (LA19_0 >= '\f' && LA19_0 <= '\r') || LA19_0 == ' ') )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // d:\\lesscss.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt19 >= 1 ) goto loop19;
            		            EarlyExitException eee19 =
            		                new EarlyExitException(19, input);
            		            throw eee19;
            	    }
            	    cnt19++;
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whinging that label 'loop19' has no statements

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // d:\\lesscss.g:1:8: ( T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | IDENT | STRING | NUM | COLOR | SL_COMMENT | COMMENT | WS )
        int alt20 = 41;
        alt20 = dfa20.Predict(input);
        switch (alt20) 
        {
            case 1 :
                // d:\\lesscss.g:1:10: T__26
                {
                	mT__26(); 

                }
                break;
            case 2 :
                // d:\\lesscss.g:1:16: T__27
                {
                	mT__27(); 

                }
                break;
            case 3 :
                // d:\\lesscss.g:1:22: T__28
                {
                	mT__28(); 

                }
                break;
            case 4 :
                // d:\\lesscss.g:1:28: T__29
                {
                	mT__29(); 

                }
                break;
            case 5 :
                // d:\\lesscss.g:1:34: T__30
                {
                	mT__30(); 

                }
                break;
            case 6 :
                // d:\\lesscss.g:1:40: T__31
                {
                	mT__31(); 

                }
                break;
            case 7 :
                // d:\\lesscss.g:1:46: T__32
                {
                	mT__32(); 

                }
                break;
            case 8 :
                // d:\\lesscss.g:1:52: T__33
                {
                	mT__33(); 

                }
                break;
            case 9 :
                // d:\\lesscss.g:1:58: T__34
                {
                	mT__34(); 

                }
                break;
            case 10 :
                // d:\\lesscss.g:1:64: T__35
                {
                	mT__35(); 

                }
                break;
            case 11 :
                // d:\\lesscss.g:1:70: T__36
                {
                	mT__36(); 

                }
                break;
            case 12 :
                // d:\\lesscss.g:1:76: T__37
                {
                	mT__37(); 

                }
                break;
            case 13 :
                // d:\\lesscss.g:1:82: T__38
                {
                	mT__38(); 

                }
                break;
            case 14 :
                // d:\\lesscss.g:1:88: T__39
                {
                	mT__39(); 

                }
                break;
            case 15 :
                // d:\\lesscss.g:1:94: T__40
                {
                	mT__40(); 

                }
                break;
            case 16 :
                // d:\\lesscss.g:1:100: T__41
                {
                	mT__41(); 

                }
                break;
            case 17 :
                // d:\\lesscss.g:1:106: T__42
                {
                	mT__42(); 

                }
                break;
            case 18 :
                // d:\\lesscss.g:1:112: T__43
                {
                	mT__43(); 

                }
                break;
            case 19 :
                // d:\\lesscss.g:1:118: T__44
                {
                	mT__44(); 

                }
                break;
            case 20 :
                // d:\\lesscss.g:1:124: T__45
                {
                	mT__45(); 

                }
                break;
            case 21 :
                // d:\\lesscss.g:1:130: T__46
                {
                	mT__46(); 

                }
                break;
            case 22 :
                // d:\\lesscss.g:1:136: T__47
                {
                	mT__47(); 

                }
                break;
            case 23 :
                // d:\\lesscss.g:1:142: T__48
                {
                	mT__48(); 

                }
                break;
            case 24 :
                // d:\\lesscss.g:1:148: T__49
                {
                	mT__49(); 

                }
                break;
            case 25 :
                // d:\\lesscss.g:1:154: T__50
                {
                	mT__50(); 

                }
                break;
            case 26 :
                // d:\\lesscss.g:1:160: T__51
                {
                	mT__51(); 

                }
                break;
            case 27 :
                // d:\\lesscss.g:1:166: T__52
                {
                	mT__52(); 

                }
                break;
            case 28 :
                // d:\\lesscss.g:1:172: T__53
                {
                	mT__53(); 

                }
                break;
            case 29 :
                // d:\\lesscss.g:1:178: T__54
                {
                	mT__54(); 

                }
                break;
            case 30 :
                // d:\\lesscss.g:1:184: T__55
                {
                	mT__55(); 

                }
                break;
            case 31 :
                // d:\\lesscss.g:1:190: T__56
                {
                	mT__56(); 

                }
                break;
            case 32 :
                // d:\\lesscss.g:1:196: T__57
                {
                	mT__57(); 

                }
                break;
            case 33 :
                // d:\\lesscss.g:1:202: T__58
                {
                	mT__58(); 

                }
                break;
            case 34 :
                // d:\\lesscss.g:1:208: T__59
                {
                	mT__59(); 

                }
                break;
            case 35 :
                // d:\\lesscss.g:1:214: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 36 :
                // d:\\lesscss.g:1:220: STRING
                {
                	mSTRING(); 

                }
                break;
            case 37 :
                // d:\\lesscss.g:1:227: NUM
                {
                	mNUM(); 

                }
                break;
            case 38 :
                // d:\\lesscss.g:1:231: COLOR
                {
                	mCOLOR(); 

                }
                break;
            case 39 :
                // d:\\lesscss.g:1:237: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;
            case 40 :
                // d:\\lesscss.g:1:248: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 41 :
                // d:\\lesscss.g:1:256: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA8 dfa8;
    protected DFA11 dfa11;
    protected DFA20 dfa20;
	private void InitializeCyclicDFAs()
	{
	    this.dfa8 = new DFA8(this);
	    this.dfa11 = new DFA11(this);
	    this.dfa20 = new DFA20(this);



	}

    const string DFA8_eotS =
        "\x01\uffff\x01\x03\x02\uffff";
    const string DFA8_eofS =
        "\x04\uffff";
    const string DFA8_minS =
        "\x02\x2e\x02\uffff";
    const string DFA8_maxS =
        "\x02\x39\x02\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA8_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x02\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "123:8: ( ( '0' .. '9' )* '.' )?"; }
        }

    }

    const string DFA11_eotS =
        "\x01\uffff\x01\x03\x02\uffff";
    const string DFA11_eofS =
        "\x04\uffff";
    const string DFA11_minS =
        "\x02\x2e\x02\uffff";
    const string DFA11_maxS =
        "\x02\x39\x02\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA11_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x02\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "124:4: ( ( '0' .. '9' )* '.' )?"; }
        }

    }

    const string DFA20_eotS =
        "\x02\uffff\x01\x25\x06\uffff\x01\x26\x01\x28\x06\uffff\x08\x1e"+
        "\x01\x35\x02\x1e\x0d\uffff\x01\x3a\x01\x3b\x01\x3c\x01\x3d\x01\x3e"+
        "\x01\x3f\x01\x40\x01\x41\x01\x42\x03\x1e\x01\uffff\x01\x46\x01\x1e"+
        "\x0b\uffff\x01\x48\x01\x49\x01\x1e\x01\uffff\x01\x4b\x02\uffff\x01"+
        "\x4c\x02\uffff";
    const string DFA20_eofS =
        "\x4d\uffff";
    const string DFA20_minS =
        "\x01\x09\x01\uffff\x01\x3a\x06\uffff\x02\x30\x06\uffff\x01\x63"+
        "\x02\x6d\x01\x6e\x01\x6d\x01\x65\x01\x61\x01\x72\x01\x2d\x01\x7a"+
        "\x01\x68\x03\uffff\x01\x2e\x02\uffff\x01\x2a\x06\uffff\x09\x2d\x01"+
        "\x67\x01\x64\x01\x61\x01\uffff\x01\x2d\x01\x7a\x0b\uffff\x02\x2d"+
        "\x01\x64\x01\uffff\x01\x2d\x02\uffff\x01\x2d\x02\uffff";
    const string DFA20_maxS =
        "\x01\ufffe\x01\uffff\x01\x3a\x06\uffff\x01\x66\x01\x39\x06\uffff"+
        "\x01\x78\x01\x6d\x01\x73\x01\x6e\x01\x78\x01\x65\x01\x61\x01\x72"+
        "\x01\ufffe\x01\x7a\x01\x68\x03\uffff\x01\ufffe\x02\uffff\x01\x2f"+
        "\x06\uffff\x09\ufffe\x01\x67\x01\x64\x01\x61\x01\uffff\x01\ufffe"+
        "\x01\x7a\x0b\uffff\x02\ufffe\x01\x64\x01\uffff\x01\ufffe\x02\uffff"+
        "\x01\ufffe\x02\uffff";
    const string DFA20_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x02\uffff\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01"+
        "\x11\x0b\uffff\x01\x21\x01\x22\x01\x23\x01\uffff\x01\x24\x01\x25"+
        "\x01\uffff\x01\x29\x01\x0b\x01\x02\x01\x09\x01\x26\x01\x0a\x0c\uffff"+
        "\x01\x1e\x02\uffff\x01\x27\x01\x28\x01\x12\x01\x16\x01\x17\x01\x13"+
        "\x01\x14\x01\x1d\x01\x15\x01\x18\x01\x19\x03\uffff\x01\x1f\x01\uffff"+
        "\x01\x1a\x01\x1b\x01\uffff\x01\x20\x01\x1c";
    const string DFA20_specialS =
        "\x4d\uffff}>";
    static readonly string[] DFA20_transitionS = {
            "\x02\x23\x01\uffff\x02\x23\x12\uffff\x01\x23\x01\uffff\x01"+
            "\x20\x01\x09\x01\uffff\x01\x10\x01\uffff\x01\x20\x01\x1c\x01"+
            "\x1d\x01\uffff\x01\x08\x01\x06\x01\x1f\x01\x0a\x01\x22\x0a\x21"+
            "\x01\x02\x01\x03\x01\uffff\x01\x0d\x01\x07\x01\uffff\x01\x01"+
            "\x1a\x1e\x01\x0b\x01\uffff\x01\x0c\x01\uffff\x01\x1e\x01\uffff"+
            "\x02\x1e\x01\x12\x01\x16\x01\x15\x01\x1e\x01\x18\x01\x1a\x01"+
            "\x14\x01\x1e\x01\x1b\x01\x1e\x01\x13\x02\x1e\x01\x11\x01\x1e"+
            "\x01\x17\x01\x19\x07\x1e\x01\x04\x01\x0f\x01\x05\x01\x0e\u0081"+
            "\uffff\ufeff\x1e",
            "",
            "\x01\x24",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x27\x07\uffff\x06\x27\x1a\uffff\x06\x27",
            "\x0a\x21",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2b\x10\uffff\x01\x2a\x03\uffff\x01\x29",
            "\x01\x2c",
            "\x01\x2d\x05\uffff\x01\x2e",
            "\x01\x2f",
            "\x01\x30\x0a\uffff\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x36",
            "\x01\x37",
            "",
            "",
            "",
            "\x01\x21\x01\uffff\x0a\x21\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "",
            "",
            "\x01\x39\x04\uffff\x01\x38",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x43",
            "\x01\x44",
            "\x01\x45",
            "",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x47",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "\x01\x4a",
            "",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "",
            "",
            "\x01\x1e\x02\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\u0085\uffff\ufeff\x1e",
            "",
            ""
    };

    static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
    static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
    static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
    static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
    static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
    static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
    static readonly short[][] DFA20_transition = DFA.UnpackEncodedStringArray(DFA20_transitionS);

    protected class DFA20 : DFA
    {
        public DFA20(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 20;
            this.eot = DFA20_eot;
            this.eof = DFA20_eof;
            this.min = DFA20_min;
            this.max = DFA20_max;
            this.accept = DFA20_accept;
            this.special = DFA20_special;
            this.transition = DFA20_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | IDENT | STRING | NUM | COLOR | SL_COMMENT | COMMENT | WS );"; }
        }

    }

 
    
}
