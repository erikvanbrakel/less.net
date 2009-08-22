// $ANTLR 3.1.2 D:\\development\\Less.Net\\lesscss.g 2009-08-22 06:00:27

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class lesscssLexer : Lexer {
    public const int SELECTORGROUP = 7;
    public const int CLASS = 10;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int ID = 12;
    public const int EOF = -1;
    public const int COLOR = 18;
    public const int EXPR = 14;
    public const int SELECTOR = 8;
    public const int WILDCARD = 13;
    public const int IDENT = 19;
    public const int VAR = 4;
    public const int COMMENT = 24;
    public const int T__50 = 50;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int RULE = 5;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int LITERAL = 16;
    public const int NUM = 21;
    public const int TAG = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int UNIT = 22;
    public const int T__32 = 32;
    public const int MIXIN = 17;
    public const int WS = 25;
    public const int T__33 = 33;
    public const int FONTDEFINITION = 9;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int PROPERTY = 6;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int SL_COMMENT = 23;
    public const int CONSTANT = 15;
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
    	get { return "D:\\development\\Less.Net\\lesscss.g";} 
    }

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:7:7: ( '@' )
            // D:\\development\\Less.Net\\lesscss.g:7:9: '@'
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
            // D:\\development\\Less.Net\\lesscss.g:8:7: ( ':' )
            // D:\\development\\Less.Net\\lesscss.g:8:9: ':'
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
            // D:\\development\\Less.Net\\lesscss.g:9:7: ( ';' )
            // D:\\development\\Less.Net\\lesscss.g:9:9: ';'
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
            // D:\\development\\Less.Net\\lesscss.g:10:7: ( ',' )
            // D:\\development\\Less.Net\\lesscss.g:10:9: ','
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
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:11:7: ( '+' )
            // D:\\development\\Less.Net\\lesscss.g:11:9: '+'
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
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:12:7: ( '-' )
            // D:\\development\\Less.Net\\lesscss.g:12:9: '-'
            {
            	Match('-'); 

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
            // D:\\development\\Less.Net\\lesscss.g:13:7: ( '*' )
            // D:\\development\\Less.Net\\lesscss.g:13:9: '*'
            {
            	Match('*'); 

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
            // D:\\development\\Less.Net\\lesscss.g:14:7: ( '/' )
            // D:\\development\\Less.Net\\lesscss.g:14:9: '/'
            {
            	Match('/'); 

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
            // D:\\development\\Less.Net\\lesscss.g:15:7: ( '(' )
            // D:\\development\\Less.Net\\lesscss.g:15:9: '('
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
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:16:7: ( ')' )
            // D:\\development\\Less.Net\\lesscss.g:16:9: ')'
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
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:17:7: ( '@media' )
            // D:\\development\\Less.Net\\lesscss.g:17:9: '@media'
            {
            	Match("@media"); 


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
            // D:\\development\\Less.Net\\lesscss.g:18:7: ( '{' )
            // D:\\development\\Less.Net\\lesscss.g:18:9: '{'
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
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:19:7: ( '}' )
            // D:\\development\\Less.Net\\lesscss.g:19:9: '}'
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
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:20:7: ( 'all' )
            // D:\\development\\Less.Net\\lesscss.g:20:9: 'all'
            {
            	Match("all"); 


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
            // D:\\development\\Less.Net\\lesscss.g:21:7: ( 'braille' )
            // D:\\development\\Less.Net\\lesscss.g:21:9: 'braille'
            {
            	Match("braille"); 


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
            // D:\\development\\Less.Net\\lesscss.g:22:7: ( 'embossed' )
            // D:\\development\\Less.Net\\lesscss.g:22:9: 'embossed'
            {
            	Match("embossed"); 


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
            // D:\\development\\Less.Net\\lesscss.g:23:7: ( 'handheld' )
            // D:\\development\\Less.Net\\lesscss.g:23:9: 'handheld'
            {
            	Match("handheld"); 


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
            // D:\\development\\Less.Net\\lesscss.g:24:7: ( 'print' )
            // D:\\development\\Less.Net\\lesscss.g:24:9: 'print'
            {
            	Match("print"); 


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
            // D:\\development\\Less.Net\\lesscss.g:25:7: ( 'projection' )
            // D:\\development\\Less.Net\\lesscss.g:25:9: 'projection'
            {
            	Match("projection"); 


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
            // D:\\development\\Less.Net\\lesscss.g:26:7: ( 'screen' )
            // D:\\development\\Less.Net\\lesscss.g:26:9: 'screen'
            {
            	Match("screen"); 


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
            // D:\\development\\Less.Net\\lesscss.g:27:7: ( 'speech' )
            // D:\\development\\Less.Net\\lesscss.g:27:9: 'speech'
            {
            	Match("speech"); 


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
            // D:\\development\\Less.Net\\lesscss.g:28:7: ( 'tty' )
            // D:\\development\\Less.Net\\lesscss.g:28:9: 'tty'
            {
            	Match("tty"); 


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
            // D:\\development\\Less.Net\\lesscss.g:29:7: ( 'tv' )
            // D:\\development\\Less.Net\\lesscss.g:29:9: 'tv'
            {
            	Match("tv"); 


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
            // D:\\development\\Less.Net\\lesscss.g:30:7: ( '#' )
            // D:\\development\\Less.Net\\lesscss.g:30:9: '#'
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
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:31:7: ( '.' )
            // D:\\development\\Less.Net\\lesscss.g:31:9: '.'
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
    // $ANTLR end "T__50"

    // $ANTLR start "COLOR"
    public void mCOLOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:122:2: ( '#' ( '0' .. '9' | 'A' .. 'F' | 'a' .. 'f' )+ )
            // D:\\development\\Less.Net\\lesscss.g:122:4: '#' ( '0' .. '9' | 'A' .. 'F' | 'a' .. 'f' )+
            {
            	Match('#'); 
            	// D:\\development\\Less.Net\\lesscss.g:122:8: ( '0' .. '9' | 'A' .. 'F' | 'a' .. 'f' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'F') || (LA1_0 >= 'a' && LA1_0 <= 'f')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:
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
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLOR"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:127:2: ( '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"' | '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\'' )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == '\"') )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == '\'') )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // D:\\development\\Less.Net\\lesscss.g:127:4: '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"'
                    {
                    	Match('\"'); 
                    	// D:\\development\\Less.Net\\lesscss.g:127:8: (~ ( '\"' | '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\t') || (LA2_0 >= '\u000B' && LA2_0 <= '\f') || (LA2_0 >= '\u000E' && LA2_0 <= '!') || (LA2_0 >= '#' && LA2_0 <= '\uFFFF')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // D:\\development\\Less.Net\\lesscss.g:127:9: ~ ( '\"' | '\\n' | '\\r' )
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
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	Match('\"'); 

                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:128:4: '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\''
                    {
                    	Match('\''); 
                    	// D:\\development\\Less.Net\\lesscss.g:128:9: (~ ( '\\'' | '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '\u0000' && LA3_0 <= '\t') || (LA3_0 >= '\u000B' && LA3_0 <= '\f') || (LA3_0 >= '\u000E' && LA3_0 <= '&') || (LA3_0 >= '(' && LA3_0 <= '\uFFFF')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // D:\\development\\Less.Net\\lesscss.g:128:10: ~ ( '\\'' | '\\n' | '\\r' )
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
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements

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

    // $ANTLR start "UNIT"
    public void mUNIT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNIT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:132:2: ( ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' ) )
            // D:\\development\\Less.Net\\lesscss.g:132:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )
            {
            	// D:\\development\\Less.Net\\lesscss.g:132:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )
            	int alt5 = 16;
            	alt5 = dfa5.Predict(input);
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:5: '%'
            	        {
            	        	Match('%'); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:9: 'px'
            	        {
            	        	Match("px"); 


            	        }
            	        break;
            	    case 3 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:14: 'cm'
            	        {
            	        	Match("cm"); 


            	        }
            	        break;
            	    case 4 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:19: 'mm'
            	        {
            	        	Match("mm"); 


            	        }
            	        break;
            	    case 5 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:24: 'in'
            	        {
            	        	Match("in"); 


            	        }
            	        break;
            	    case 6 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:29: 'pt'
            	        {
            	        	Match("pt"); 


            	        }
            	        break;
            	    case 7 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:34: 'pc'
            	        {
            	        	Match("pc"); 


            	        }
            	        break;
            	    case 8 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:39: 'em'
            	        {
            	        	Match("em"); 


            	        }
            	        break;
            	    case 9 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:44: 'ex'
            	        {
            	        	Match("ex"); 


            	        }
            	        break;
            	    case 10 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:49: 'deg'
            	        {
            	        	Match("deg"); 


            	        }
            	        break;
            	    case 11 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:55: 'rad'
            	        {
            	        	Match("rad"); 


            	        }
            	        break;
            	    case 12 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:61: 'grad'
            	        {
            	        	Match("grad"); 


            	        }
            	        break;
            	    case 13 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:68: 'ms'
            	        {
            	        	Match("ms"); 


            	        }
            	        break;
            	    case 14 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:73: 's'
            	        {
            	        	Match('s'); 

            	        }
            	        break;
            	    case 15 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:77: 'hz'
            	        {
            	        	Match("hz"); 


            	        }
            	        break;
            	    case 16 :
            	        // D:\\development\\Less.Net\\lesscss.g:132:82: 'khz'
            	        {
            	        	Match("khz"); 


            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNIT"

    // $ANTLR start "NUM"
    public void mNUM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:136:2: ( ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ | ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ ) )
            // D:\\development\\Less.Net\\lesscss.g:136:4: ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ | ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
            {
            	// D:\\development\\Less.Net\\lesscss.g:136:4: ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ | ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == '-') )
            	{
            	    alt12 = 1;
            	}
            	else if ( (LA12_0 == '.' || (LA12_0 >= '0' && LA12_0 <= '9')) )
            	{
            	    alt12 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("", 12, 0, input);

            	    throw nvae_d12s0;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // D:\\development\\Less.Net\\lesscss.g:136:5: '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
            	        {
            	        	Match('-'); 
            	        	// D:\\development\\Less.Net\\lesscss.g:136:9: ( ( '0' .. '9' )* '.' )?
            	        	int alt7 = 2;
            	        	alt7 = dfa7.Predict(input);
            	        	switch (alt7) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\development\\Less.Net\\lesscss.g:136:10: ( '0' .. '9' )* '.'
            	        	        {
            	        	        	// D:\\development\\Less.Net\\lesscss.g:136:10: ( '0' .. '9' )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt6 = 2;
            	        	        	    int LA6_0 = input.LA(1);

            	        	        	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	        	        	    {
            	        	        	        alt6 = 1;
            	        	        	    }


            	        	        	    switch (alt6) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // D:\\development\\Less.Net\\lesscss.g:136:11: '0' .. '9'
            	        	        			    {
            	        	        			    	MatchRange('0','9'); 

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop6;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop6:
            	        	        		;	// Stops C# compiler whining that label 'loop6' has no statements

            	        	        	Match('.'); 

            	        	        }
            	        	        break;

            	        	}

            	        	// D:\\development\\Less.Net\\lesscss.g:136:28: ( '0' .. '9' )+
            	        	int cnt8 = 0;
            	        	do 
            	        	{
            	        	    int alt8 = 2;
            	        	    int LA8_0 = input.LA(1);

            	        	    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
            	        	    {
            	        	        alt8 = 1;
            	        	    }


            	        	    switch (alt8) 
            	        		{
            	        			case 1 :
            	        			    // D:\\development\\Less.Net\\lesscss.g:136:29: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt8 >= 1 ) goto loop8;
            	        		            EarlyExitException eee8 =
            	        		                new EarlyExitException(8, input);
            	        		            throw eee8;
            	        	    }
            	        	    cnt8++;
            	        	} while (true);

            	        	loop8:
            	        		;	// Stops C# compiler whinging that label 'loop8' has no statements


            	        }
            	        break;
            	    case 2 :
            	        // D:\\development\\Less.Net\\lesscss.g:137:4: ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
            	        {
            	        	// D:\\development\\Less.Net\\lesscss.g:137:4: ( ( '0' .. '9' )* '.' )?
            	        	int alt10 = 2;
            	        	alt10 = dfa10.Predict(input);
            	        	switch (alt10) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\development\\Less.Net\\lesscss.g:137:5: ( '0' .. '9' )* '.'
            	        	        {
            	        	        	// D:\\development\\Less.Net\\lesscss.g:137:5: ( '0' .. '9' )*
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
            	        	        			    // D:\\development\\Less.Net\\lesscss.g:137:6: '0' .. '9'
            	        	        			    {
            	        	        			    	MatchRange('0','9'); 

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop9;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop9:
            	        	        		;	// Stops C# compiler whining that label 'loop9' has no statements

            	        	        	Match('.'); 

            	        	        }
            	        	        break;

            	        	}

            	        	// D:\\development\\Less.Net\\lesscss.g:137:23: ( '0' .. '9' )+
            	        	int cnt11 = 0;
            	        	do 
            	        	{
            	        	    int alt11 = 2;
            	        	    int LA11_0 = input.LA(1);

            	        	    if ( ((LA11_0 >= '0' && LA11_0 <= '9')) )
            	        	    {
            	        	        alt11 = 1;
            	        	    }


            	        	    switch (alt11) 
            	        		{
            	        			case 1 :
            	        			    // D:\\development\\Less.Net\\lesscss.g:137:24: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt11 >= 1 ) goto loop11;
            	        		            EarlyExitException eee11 =
            	        		                new EarlyExitException(11, input);
            	        		            throw eee11;
            	        	    }
            	        	    cnt11++;
            	        	} while (true);

            	        	loop11:
            	        		;	// Stops C# compiler whinging that label 'loop11' has no statements


            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUM"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:141:2: ( ( '_' | 'a' .. 'z' | 'A' .. 'Z' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* | '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            int alt15 = 2;
            int LA15_0 = input.LA(1);

            if ( ((LA15_0 >= 'A' && LA15_0 <= 'Z') || LA15_0 == '_' || (LA15_0 >= 'a' && LA15_0 <= 'z')) )
            {
                alt15 = 1;
            }
            else if ( (LA15_0 == '-') )
            {
                alt15 = 2;
            }
            else 
            {
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("", 15, 0, input);

                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // D:\\development\\Less.Net\\lesscss.g:141:4: ( '_' | 'a' .. 'z' | 'A' .. 'Z' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
                    {
                    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// D:\\development\\Less.Net\\lesscss.g:142:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == '-' || (LA13_0 >= '0' && LA13_0 <= '9') || (LA13_0 >= 'A' && LA13_0 <= 'Z') || LA13_0 == '_' || (LA13_0 >= 'a' && LA13_0 <= 'z')) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // D:\\development\\Less.Net\\lesscss.g:
                    			    {
                    			    	if ( input.LA(1) == '-' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
                    			    goto loop13;
                    	    }
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements


                    }
                    break;
                case 2 :
                    // D:\\development\\Less.Net\\lesscss.g:143:4: '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
                    {
                    	Match('-'); 
                    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}

                    	// D:\\development\\Less.Net\\lesscss.g:144:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( (LA14_0 == '-' || (LA14_0 >= '0' && LA14_0 <= '9') || (LA14_0 >= 'A' && LA14_0 <= 'Z') || LA14_0 == '_' || (LA14_0 >= 'a' && LA14_0 <= 'z')) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // D:\\development\\Less.Net\\lesscss.g:
                    			    {
                    			    	if ( input.LA(1) == '-' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements


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

    // $ANTLR start "SL_COMMENT"
    public void mSL_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SL_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\development\\Less.Net\\lesscss.g:150:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? ) )
            // D:\\development\\Less.Net\\lesscss.g:150:4: '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? )
            {
            	Match("//"); 

            	// D:\\development\\Less.Net\\lesscss.g:151:3: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= '\u0000' && LA16_0 <= '\t') || (LA16_0 >= '\u000B' && LA16_0 <= '\f') || (LA16_0 >= '\u000E' && LA16_0 <= '\uFFFF')) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:151:4: ~ ( '\\n' | '\\r' )
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
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements

            	// D:\\development\\Less.Net\\lesscss.g:151:19: ( '\\n' | '\\r' ( '\\n' )? )
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == '\n') )
            	{
            	    alt18 = 1;
            	}
            	else if ( (LA18_0 == '\r') )
            	{
            	    alt18 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d18s0 =
            	        new NoViableAltException("", 18, 0, input);

            	    throw nvae_d18s0;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // D:\\development\\Less.Net\\lesscss.g:151:20: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\development\\Less.Net\\lesscss.g:151:25: '\\r' ( '\\n' )?
            	        {
            	        	Match('\r'); 
            	        	// D:\\development\\Less.Net\\lesscss.g:151:29: ( '\\n' )?
            	        	int alt17 = 2;
            	        	int LA17_0 = input.LA(1);

            	        	if ( (LA17_0 == '\n') )
            	        	{
            	        	    alt17 = 1;
            	        	}
            	        	switch (alt17) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\development\\Less.Net\\lesscss.g:151:30: '\\n'
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
            // D:\\development\\Less.Net\\lesscss.g:156:2: ( '/*' ( . )* '*/' )
            // D:\\development\\Less.Net\\lesscss.g:156:4: '/*' ( . )* '*/'
            {
            	Match("/*"); 

            	// D:\\development\\Less.Net\\lesscss.g:156:9: ( . )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == '*') )
            	    {
            	        int LA19_1 = input.LA(2);

            	        if ( (LA19_1 == '/') )
            	        {
            	            alt19 = 2;
            	        }
            	        else if ( ((LA19_1 >= '\u0000' && LA19_1 <= '.') || (LA19_1 >= '0' && LA19_1 <= '\uFFFF')) )
            	        {
            	            alt19 = 1;
            	        }


            	    }
            	    else if ( ((LA19_0 >= '\u0000' && LA19_0 <= ')') || (LA19_0 >= '+' && LA19_0 <= '\uFFFF')) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:156:9: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements

            	Match("*/"); 

            	 _channel=HIDDEN; 

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
            // D:\\development\\Less.Net\\lesscss.g:159:4: ( ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+ )
            // D:\\development\\Less.Net\\lesscss.g:159:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            {
            	// D:\\development\\Less.Net\\lesscss.g:159:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            	int cnt20 = 0;
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= '\t' && LA20_0 <= '\n') || (LA20_0 >= '\f' && LA20_0 <= '\r') || LA20_0 == ' ') )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // D:\\development\\Less.Net\\lesscss.g:
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
            			    if ( cnt20 >= 1 ) goto loop20;
            		            EarlyExitException eee20 =
            		                new EarlyExitException(20, input);
            		            throw eee20;
            	    }
            	    cnt20++;
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whinging that label 'loop20' has no statements

            	 _channel=HIDDEN; 

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
        // D:\\development\\Less.Net\\lesscss.g:1:8: ( T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | COLOR | STRING | UNIT | NUM | IDENT | SL_COMMENT | COMMENT | WS )
        int alt21 = 33;
        alt21 = dfa21.Predict(input);
        switch (alt21) 
        {
            case 1 :
                // D:\\development\\Less.Net\\lesscss.g:1:10: T__26
                {
                	mT__26(); 

                }
                break;
            case 2 :
                // D:\\development\\Less.Net\\lesscss.g:1:16: T__27
                {
                	mT__27(); 

                }
                break;
            case 3 :
                // D:\\development\\Less.Net\\lesscss.g:1:22: T__28
                {
                	mT__28(); 

                }
                break;
            case 4 :
                // D:\\development\\Less.Net\\lesscss.g:1:28: T__29
                {
                	mT__29(); 

                }
                break;
            case 5 :
                // D:\\development\\Less.Net\\lesscss.g:1:34: T__30
                {
                	mT__30(); 

                }
                break;
            case 6 :
                // D:\\development\\Less.Net\\lesscss.g:1:40: T__31
                {
                	mT__31(); 

                }
                break;
            case 7 :
                // D:\\development\\Less.Net\\lesscss.g:1:46: T__32
                {
                	mT__32(); 

                }
                break;
            case 8 :
                // D:\\development\\Less.Net\\lesscss.g:1:52: T__33
                {
                	mT__33(); 

                }
                break;
            case 9 :
                // D:\\development\\Less.Net\\lesscss.g:1:58: T__34
                {
                	mT__34(); 

                }
                break;
            case 10 :
                // D:\\development\\Less.Net\\lesscss.g:1:64: T__35
                {
                	mT__35(); 

                }
                break;
            case 11 :
                // D:\\development\\Less.Net\\lesscss.g:1:70: T__36
                {
                	mT__36(); 

                }
                break;
            case 12 :
                // D:\\development\\Less.Net\\lesscss.g:1:76: T__37
                {
                	mT__37(); 

                }
                break;
            case 13 :
                // D:\\development\\Less.Net\\lesscss.g:1:82: T__38
                {
                	mT__38(); 

                }
                break;
            case 14 :
                // D:\\development\\Less.Net\\lesscss.g:1:88: T__39
                {
                	mT__39(); 

                }
                break;
            case 15 :
                // D:\\development\\Less.Net\\lesscss.g:1:94: T__40
                {
                	mT__40(); 

                }
                break;
            case 16 :
                // D:\\development\\Less.Net\\lesscss.g:1:100: T__41
                {
                	mT__41(); 

                }
                break;
            case 17 :
                // D:\\development\\Less.Net\\lesscss.g:1:106: T__42
                {
                	mT__42(); 

                }
                break;
            case 18 :
                // D:\\development\\Less.Net\\lesscss.g:1:112: T__43
                {
                	mT__43(); 

                }
                break;
            case 19 :
                // D:\\development\\Less.Net\\lesscss.g:1:118: T__44
                {
                	mT__44(); 

                }
                break;
            case 20 :
                // D:\\development\\Less.Net\\lesscss.g:1:124: T__45
                {
                	mT__45(); 

                }
                break;
            case 21 :
                // D:\\development\\Less.Net\\lesscss.g:1:130: T__46
                {
                	mT__46(); 

                }
                break;
            case 22 :
                // D:\\development\\Less.Net\\lesscss.g:1:136: T__47
                {
                	mT__47(); 

                }
                break;
            case 23 :
                // D:\\development\\Less.Net\\lesscss.g:1:142: T__48
                {
                	mT__48(); 

                }
                break;
            case 24 :
                // D:\\development\\Less.Net\\lesscss.g:1:148: T__49
                {
                	mT__49(); 

                }
                break;
            case 25 :
                // D:\\development\\Less.Net\\lesscss.g:1:154: T__50
                {
                	mT__50(); 

                }
                break;
            case 26 :
                // D:\\development\\Less.Net\\lesscss.g:1:160: COLOR
                {
                	mCOLOR(); 

                }
                break;
            case 27 :
                // D:\\development\\Less.Net\\lesscss.g:1:166: STRING
                {
                	mSTRING(); 

                }
                break;
            case 28 :
                // D:\\development\\Less.Net\\lesscss.g:1:173: UNIT
                {
                	mUNIT(); 

                }
                break;
            case 29 :
                // D:\\development\\Less.Net\\lesscss.g:1:178: NUM
                {
                	mNUM(); 

                }
                break;
            case 30 :
                // D:\\development\\Less.Net\\lesscss.g:1:182: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 31 :
                // D:\\development\\Less.Net\\lesscss.g:1:188: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;
            case 32 :
                // D:\\development\\Less.Net\\lesscss.g:1:199: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 33 :
                // D:\\development\\Less.Net\\lesscss.g:1:207: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA5 dfa5;
    protected DFA7 dfa7;
    protected DFA10 dfa10;
    protected DFA21 dfa21;
	private void InitializeCyclicDFAs()
	{
	    this.dfa5 = new DFA5(this);
	    this.dfa7 = new DFA7(this);
	    this.dfa10 = new DFA10(this);
	    this.dfa21 = new DFA21(this);




	}

    const string DFA5_eotS =
        "\x14\uffff";
    const string DFA5_eofS =
        "\x14\uffff";
    const string DFA5_minS =
        "\x01\x25\x01\uffff\x01\x63\x01\uffff\x01\x6d\x01\uffff\x01\x6d"+
        "\x0d\uffff";
    const string DFA5_maxS =
        "\x01\x73\x01\uffff\x01\x78\x01\uffff\x01\x73\x01\uffff\x01\x78"+
        "\x0d\uffff";
    const string DFA5_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\uffff\x01\x05\x01\uffff"+
        "\x01\x0a\x01\x0b\x01\x0c\x01\x0e\x01\x0f\x01\x10\x01\x02\x01\x06"+
        "\x01\x07\x01\x04\x01\x0d\x01\x08\x01\x09";
    const string DFA5_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x01\x3d\uffff\x01\x03\x01\x07\x01\x06\x01\uffff\x01\x09"+
            "\x01\x0b\x01\x05\x01\uffff\x01\x0c\x01\uffff\x01\x04\x02\uffff"+
            "\x01\x02\x01\uffff\x01\x08\x01\x0a",
            "",
            "\x01\x0f\x10\uffff\x01\x0e\x03\uffff\x01\x0d",
            "",
            "\x01\x10\x05\uffff\x01\x11",
            "",
            "\x01\x12\x0a\uffff\x01\x13",
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
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "132:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )"; }
        }

    }

    const string DFA7_eotS =
        "\x01\uffff\x01\x03\x02\uffff";
    const string DFA7_eofS =
        "\x04\uffff";
    const string DFA7_minS =
        "\x02\x2e\x02\uffff";
    const string DFA7_maxS =
        "\x02\x39\x02\uffff";
    const string DFA7_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA7_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x02\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "136:9: ( ( '0' .. '9' )* '.' )?"; }
        }

    }

    const string DFA10_eotS =
        "\x01\uffff\x01\x03\x02\uffff";
    const string DFA10_eofS =
        "\x04\uffff";
    const string DFA10_minS =
        "\x02\x2e\x02\uffff";
    const string DFA10_maxS =
        "\x02\x39\x02\uffff";
    const string DFA10_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA10_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x02\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "137:4: ( ( '0' .. '9' )* '.' )?"; }
        }

    }

    const string DFA21_eotS =
        "\x01\uffff\x01\x23\x04\uffff\x01\x24\x01\uffff\x01\x27\x04\uffff"+
        "\x05\x20\x01\x17\x01\x20\x01\x36\x01\x38\x02\uffff\x07\x20\x09\uffff"+
        "\x02\x20\x02\x17\x01\x20\x01\x17\x01\x20\x03\x17\x03\x20\x01\x4a"+
        "\x03\uffff\x04\x17\x04\x20\x01\x4f\x07\x20\x01\x57\x01\uffff\x02"+
        "\x17\x01\x20\x01\x17\x01\uffff\x07\x20\x01\uffff\x01\x17\x03\x20"+
        "\x01\x63\x06\x20\x01\uffff\x01\x20\x01\x6b\x01\x6c\x01\x6d\x03\x20"+
        "\x03\uffff\x01\x71\x01\x72\x01\x20\x02\uffff\x01\x20\x01\x75\x01"+
        "\uffff";
    const string DFA21_eofS =
        "\x76\uffff";
    const string DFA21_minS =
        "\x01\x09\x01\x6d\x04\uffff\x01\x2e\x01\uffff\x01\x2a\x04\uffff"+
        "\x01\x6c\x01\x72\x01\x6d\x01\x61\x01\x63\x01\x2d\x01\x74\x02\x30"+
        "\x02\uffff\x02\x6d\x01\x6e\x01\x65\x01\x61\x01\x72\x01\x68\x09\uffff"+
        "\x01\x6c\x01\x61\x02\x2d\x01\x6e\x01\x2d\x01\x69\x03\x2d\x01\x72"+
        "\x01\x65\x01\x79\x01\x2d\x03\uffff\x04\x2d\x01\x67\x01\x64\x01\x61"+
        "\x01\x7a\x01\x2d\x01\x69\x01\x6f\x01\x64\x01\x6e\x01\x6a\x02\x65"+
        "\x01\x2d\x01\uffff\x02\x2d\x01\x64\x01\x2d\x01\uffff\x01\x6c\x01"+
        "\x73\x01\x68\x01\x74\x02\x65\x01\x63\x01\uffff\x01\x2d\x01\x6c\x01"+
        "\x73\x01\x65\x01\x2d\x01\x63\x01\x6e\x01\x68\x02\x65\x01\x6c\x01"+
        "\uffff\x01\x74\x03\x2d\x02\x64\x01\x69\x03\uffff\x02\x2d\x01\x6f"+
        "\x02\uffff\x01\x6e\x01\x2d\x01\uffff";
    const string DFA21_maxS =
        "\x01\x7d\x01\x6d\x04\uffff\x01\x7a\x01\uffff\x01\x2f\x04\uffff"+
        "\x01\x6c\x01\x72\x01\x78\x01\x7a\x01\x78\x01\x7a\x01\x76\x01\x66"+
        "\x01\x39\x02\uffff\x01\x6d\x01\x73\x01\x6e\x01\x65\x01\x61\x01\x72"+
        "\x01\x68\x09\uffff\x01\x6c\x01\x61\x02\x7a\x01\x6e\x01\x7a\x01\x6f"+
        "\x03\x7a\x01\x72\x01\x65\x01\x79\x01\x7a\x03\uffff\x04\x7a\x01\x67"+
        "\x01\x64\x01\x61\x02\x7a\x01\x69\x01\x6f\x01\x64\x01\x6e\x01\x6a"+
        "\x02\x65\x01\x7a\x01\uffff\x02\x7a\x01\x64\x01\x7a\x01\uffff\x01"+
        "\x6c\x01\x73\x01\x68\x01\x74\x02\x65\x01\x63\x01\uffff\x01\x7a\x01"+
        "\x6c\x01\x73\x01\x65\x01\x7a\x01\x63\x01\x6e\x01\x68\x02\x65\x01"+
        "\x6c\x01\uffff\x01\x74\x03\x7a\x02\x64\x01\x69\x03\uffff\x02\x7a"+
        "\x01\x6f\x02\uffff\x01\x6e\x01\x7a\x01\uffff";
    const string DFA21_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01\x07\x01"+
        "\uffff\x01\x09\x01\x0a\x01\x0c\x01\x0d\x09\uffff\x01\x1b\x01\x1c"+
        "\x07\uffff\x01\x1d\x01\x1e\x01\x21\x01\x0b\x01\x01\x01\x06\x01\x1f"+
        "\x01\x20\x01\x08\x0e\uffff\x01\x18\x01\x1a\x01\x19\x11\uffff\x01"+
        "\x17\x04\uffff\x01\x0e\x07\uffff\x01\x16\x0b\uffff\x01\x12\x07\uffff"+
        "\x01\x14\x01\x15\x01\x0f\x03\uffff\x01\x10\x01\x11\x02\uffff\x01"+
        "\x13";
    const string DFA21_specialS =
        "\x76\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x02\x21\x01\uffff\x02\x21\x12\uffff\x01\x21\x01\uffff\x01"+
            "\x16\x01\x14\x01\uffff\x01\x17\x01\uffff\x01\x16\x01\x09\x01"+
            "\x0a\x01\x07\x01\x05\x01\x04\x01\x06\x01\x15\x01\x08\x0a\x1f"+
            "\x01\x02\x01\x03\x04\uffff\x01\x01\x1a\x20\x04\uffff\x01\x20"+
            "\x01\uffff\x01\x0d\x01\x0e\x01\x18\x01\x1b\x01\x0f\x01\x20\x01"+
            "\x1d\x01\x10\x01\x1a\x01\x20\x01\x1e\x01\x20\x01\x19\x02\x20"+
            "\x01\x11\x01\x20\x01\x1c\x01\x12\x01\x13\x06\x20\x01\x0b\x01"+
            "\uffff\x01\x0c",
            "\x01\x22",
            "",
            "",
            "",
            "",
            "\x01\x1f\x01\uffff\x0a\x1f\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "",
            "\x01\x26\x04\uffff\x01\x25",
            "",
            "",
            "",
            "",
            "\x01\x28",
            "\x01\x29",
            "\x01\x2a\x0a\uffff\x01\x2b",
            "\x01\x2c\x18\uffff\x01\x2d",
            "\x01\x31\x0e\uffff\x01\x2e\x01\uffff\x01\x30\x03\uffff\x01"+
            "\x2f",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x02\x20\x01\x32\x0c\x20\x01\x33\x0a\x20",
            "\x01\x34\x01\uffff\x01\x35",
            "\x0a\x37\x07\uffff\x06\x37\x1a\uffff\x06\x37",
            "\x0a\x1f",
            "",
            "",
            "\x01\x39",
            "\x01\x3a\x05\uffff\x01\x3b",
            "\x01\x3c",
            "\x01\x3d",
            "\x01\x3e",
            "\x01\x3f",
            "\x01\x40",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x41",
            "\x01\x42",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x01\x20\x01\x43\x18\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x44",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x45\x05\uffff\x01\x46",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x47",
            "\x01\x48",
            "\x01\x49",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "",
            "",
            "",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "\x01\x56",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x58",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "",
            "\x01\x6a",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "",
            "",
            "",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            "\x01\x73",
            "",
            "",
            "\x01\x74",
            "\x01\x20\x02\uffff\x0a\x20\x07\uffff\x1a\x20\x04\uffff\x01"+
            "\x20\x01\uffff\x1a\x20",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | COLOR | STRING | UNIT | NUM | IDENT | SL_COMMENT | COMMENT | WS );"; }
        }

    }

 
    
}
