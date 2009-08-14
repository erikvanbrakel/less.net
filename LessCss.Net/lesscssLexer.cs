// $ANTLR 3.1.2 D:\\lesscss.g 2009-08-14 02:31:20


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class lesscssLexer : Lexer {
    public const int SELECTORGROUP = 7;
    public const int CLASS = 10;
    public const int ID = 12;
    public const int EOF = -1;
    public const int COLOR = 23;
    public const int EXPR = 14;
    public const int SELECTOR = 8;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int WILDCARD = 13;
    public const int IDENT = 18;
    public const int VAR = 4;
    public const int COMMENT = 28;
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
    public const int MINUS = 20;
    public const int NUM = 21;
    public const int TAG = 11;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int UNIT = 22;
    public const int T__32 = 32;
    public const int MIXIN = 17;
    public const int WS = 29;
    public const int T__33 = 33;
    public const int FONTDEFINITION = 9;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int PROPERTY = 6;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int SelectorID = 25;
    public const int SL_COMMENT = 27;
    public const int CONSTANT = 15;
    public const int SelectorClass = 24;
    public const int STRING = 19;
    public const int HEXDIGIT = 26;

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
    	get { return "D:\\lesscss.g";} 
    }

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:7:7: ( '@' )
            // D:\\lesscss.g:7:9: '@'
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
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:8:7: ( ':' )
            // D:\\lesscss.g:8:9: ':'
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
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:9:7: ( ';' )
            // D:\\lesscss.g:9:9: ';'
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
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:10:7: ( ',' )
            // D:\\lesscss.g:10:9: ','
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
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:11:7: ( '+' )
            // D:\\lesscss.g:11:9: '+'
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
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:12:7: ( '*' )
            // D:\\lesscss.g:12:9: '*'
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
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:13:7: ( '/' )
            // D:\\lesscss.g:13:9: '/'
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
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:14:7: ( '(' )
            // D:\\lesscss.g:14:9: '('
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
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:15:7: ( ')' )
            // D:\\lesscss.g:15:9: ')'
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
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:16:7: ( '@media' )
            // D:\\lesscss.g:16:9: '@media'
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
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:17:7: ( '{' )
            // D:\\lesscss.g:17:9: '{'
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
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:18:7: ( '}' )
            // D:\\lesscss.g:18:9: '}'
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
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:19:7: ( 'all' )
            // D:\\lesscss.g:19:9: 'all'
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
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:20:7: ( 'braille' )
            // D:\\lesscss.g:20:9: 'braille'
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
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:21:7: ( 'embossed' )
            // D:\\lesscss.g:21:9: 'embossed'
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
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:22:7: ( 'handheld' )
            // D:\\lesscss.g:22:9: 'handheld'
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
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:23:7: ( 'print' )
            // D:\\lesscss.g:23:9: 'print'
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
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:24:7: ( 'projection' )
            // D:\\lesscss.g:24:9: 'projection'
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
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:25:7: ( 'screen' )
            // D:\\lesscss.g:25:9: 'screen'
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
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:26:7: ( 'speech' )
            // D:\\lesscss.g:26:9: 'speech'
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
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:27:7: ( 'tty' )
            // D:\\lesscss.g:27:9: 'tty'
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
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:28:7: ( 'tv' )
            // D:\\lesscss.g:28:9: 'tv'
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
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:29:7: ( '>' )
            // D:\\lesscss.g:29:9: '>'
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
    // $ANTLR end "T__52"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:57:8: ( '-' )
            // D:\\lesscss.g:57:10: '-'
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
    // $ANTLR end "MINUS"

    // $ANTLR start "SelectorClass"
    public void mSelectorClass() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SelectorClass;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:124:2: ( '.' IDENT )
            // D:\\lesscss.g:124:4: '.' IDENT
            {
            	Match('.'); 
            	mIDENT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SelectorClass"

    // $ANTLR start "SelectorID"
    public void mSelectorID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SelectorID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:128:2: ( '#' IDENT )
            // D:\\lesscss.g:128:4: '#' IDENT
            {
            	Match('#'); 
            	mIDENT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SelectorID"

    // $ANTLR start "COLOR"
    public void mCOLOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:132:2: ( '#' ( HEXDIGIT )+ )
            // D:\\lesscss.g:132:4: '#' ( HEXDIGIT )+
            {
            	Match('#'); 
            	// D:\\lesscss.g:132:8: ( HEXDIGIT )+
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
            			    // D:\\lesscss.g:132:8: HEXDIGIT
            			    {
            			    	mHEXDIGIT(); 

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
            // D:\\lesscss.g:137:2: ( '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"' | '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\'' )
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
                    // D:\\lesscss.g:137:4: '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"'
                    {
                    	Match('\"'); 
                    	// D:\\lesscss.g:137:8: (~ ( '\"' | '\\n' | '\\r' ) )*
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
                    			    // D:\\lesscss.g:137:9: ~ ( '\"' | '\\n' | '\\r' )
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
                    // D:\\lesscss.g:138:4: '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\''
                    {
                    	Match('\''); 
                    	// D:\\lesscss.g:138:9: (~ ( '\\'' | '\\n' | '\\r' ) )*
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
                    			    // D:\\lesscss.g:138:10: ~ ( '\\'' | '\\n' | '\\r' )
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
            // D:\\lesscss.g:142:2: ( ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' ) )
            // D:\\lesscss.g:142:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )
            {
            	// D:\\lesscss.g:142:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )
            	int alt5 = 16;
            	alt5 = dfa5.Predict(input);
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:142:5: '%'
            	        {
            	        	Match('%'); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\lesscss.g:142:9: 'px'
            	        {
            	        	Match("px"); 


            	        }
            	        break;
            	    case 3 :
            	        // D:\\lesscss.g:142:14: 'cm'
            	        {
            	        	Match("cm"); 


            	        }
            	        break;
            	    case 4 :
            	        // D:\\lesscss.g:142:19: 'mm'
            	        {
            	        	Match("mm"); 


            	        }
            	        break;
            	    case 5 :
            	        // D:\\lesscss.g:142:24: 'in'
            	        {
            	        	Match("in"); 


            	        }
            	        break;
            	    case 6 :
            	        // D:\\lesscss.g:142:29: 'pt'
            	        {
            	        	Match("pt"); 


            	        }
            	        break;
            	    case 7 :
            	        // D:\\lesscss.g:142:34: 'pc'
            	        {
            	        	Match("pc"); 


            	        }
            	        break;
            	    case 8 :
            	        // D:\\lesscss.g:142:39: 'em'
            	        {
            	        	Match("em"); 


            	        }
            	        break;
            	    case 9 :
            	        // D:\\lesscss.g:142:44: 'ex'
            	        {
            	        	Match("ex"); 


            	        }
            	        break;
            	    case 10 :
            	        // D:\\lesscss.g:142:49: 'deg'
            	        {
            	        	Match("deg"); 


            	        }
            	        break;
            	    case 11 :
            	        // D:\\lesscss.g:142:55: 'rad'
            	        {
            	        	Match("rad"); 


            	        }
            	        break;
            	    case 12 :
            	        // D:\\lesscss.g:142:61: 'grad'
            	        {
            	        	Match("grad"); 


            	        }
            	        break;
            	    case 13 :
            	        // D:\\lesscss.g:142:68: 'ms'
            	        {
            	        	Match("ms"); 


            	        }
            	        break;
            	    case 14 :
            	        // D:\\lesscss.g:142:73: 's'
            	        {
            	        	Match('s'); 

            	        }
            	        break;
            	    case 15 :
            	        // D:\\lesscss.g:142:77: 'hz'
            	        {
            	        	Match("hz"); 


            	        }
            	        break;
            	    case 16 :
            	        // D:\\lesscss.g:142:82: 'khz'
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
            // D:\\lesscss.g:146:2: ( ( ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ ) | ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ ) )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == '.' || (LA12_0 >= '0' && LA12_0 <= '9')) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == '-') )
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
                    // D:\\lesscss.g:146:4: ( ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
                    {
                    	// D:\\lesscss.g:146:4: ( ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
                    	// D:\\lesscss.g:146:5: ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
                    	{
                    		// D:\\lesscss.g:146:5: ( ( '0' .. '9' )* '.' )?
                    		int alt7 = 2;
                    		alt7 = dfa7.Predict(input);
                    		switch (alt7) 
                    		{
                    		    case 1 :
                    		        // D:\\lesscss.g:146:6: ( '0' .. '9' )* '.'
                    		        {
                    		        	// D:\\lesscss.g:146:6: ( '0' .. '9' )*
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
                    		        			    // D:\\lesscss.g:146:7: '0' .. '9'
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

                    		// D:\\lesscss.g:146:24: ( '0' .. '9' )+
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
                    				    // D:\\lesscss.g:146:25: '0' .. '9'
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


                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:147:4: ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
                    {
                    	// D:\\lesscss.g:147:4: ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
                    	// D:\\lesscss.g:147:5: '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
                    	{
                    		Match('-'); 
                    		// D:\\lesscss.g:147:9: ( ( '0' .. '9' )* '.' )?
                    		int alt10 = 2;
                    		alt10 = dfa10.Predict(input);
                    		switch (alt10) 
                    		{
                    		    case 1 :
                    		        // D:\\lesscss.g:147:10: ( '0' .. '9' )* '.'
                    		        {
                    		        	// D:\\lesscss.g:147:10: ( '0' .. '9' )*
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
                    		        			    // D:\\lesscss.g:147:11: '0' .. '9'
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

                    		// D:\\lesscss.g:147:28: ( '0' .. '9' )+
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
                    				    // D:\\lesscss.g:147:29: '0' .. '9'
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

    // $ANTLR start "HEXDIGIT"
    public void mHEXDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\lesscss.g:152:18: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            // D:\\lesscss.g:
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

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEXDIGIT"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:156:2: ( ( '_' | 'a' .. 'z' | 'A' .. 'Z' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            // D:\\lesscss.g:156:4: ( '_' | 'a' .. 'z' | 'A' .. 'Z' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
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

            	// D:\\lesscss.g:157:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
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
            			    // D:\\lesscss.g:
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
            // D:\\lesscss.g:165:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? ) )
            // D:\\lesscss.g:165:4: '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? )
            {
            	Match("//"); 

            	// D:\\lesscss.g:166:3: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= '\u0000' && LA14_0 <= '\t') || (LA14_0 >= '\u000B' && LA14_0 <= '\f') || (LA14_0 >= '\u000E' && LA14_0 <= '\uFFFF')) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:166:4: ~ ( '\\n' | '\\r' )
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
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	// D:\\lesscss.g:166:19: ( '\\n' | '\\r' ( '\\n' )? )
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == '\n') )
            	{
            	    alt16 = 1;
            	}
            	else if ( (LA16_0 == '\r') )
            	{
            	    alt16 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:166:20: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\lesscss.g:166:25: '\\r' ( '\\n' )?
            	        {
            	        	Match('\r'); 
            	        	// D:\\lesscss.g:166:29: ( '\\n' )?
            	        	int alt15 = 2;
            	        	int LA15_0 = input.LA(1);

            	        	if ( (LA15_0 == '\n') )
            	        	{
            	        	    alt15 = 1;
            	        	}
            	        	switch (alt15) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\lesscss.g:166:30: '\\n'
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
            // D:\\lesscss.g:171:2: ( '/*' ( . )* '*/' )
            // D:\\lesscss.g:171:4: '/*' ( . )* '*/'
            {
            	Match("/*"); 

            	// D:\\lesscss.g:171:9: ( . )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == '*') )
            	    {
            	        int LA17_1 = input.LA(2);

            	        if ( (LA17_1 == '/') )
            	        {
            	            alt17 = 2;
            	        }
            	        else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '.') || (LA17_1 >= '0' && LA17_1 <= '\uFFFF')) )
            	        {
            	            alt17 = 1;
            	        }


            	    }
            	    else if ( ((LA17_0 >= '\u0000' && LA17_0 <= ')') || (LA17_0 >= '+' && LA17_0 <= '\uFFFF')) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:171:9: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

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
            // D:\\lesscss.g:174:4: ( ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+ )
            // D:\\lesscss.g:174:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            {
            	// D:\\lesscss.g:174:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            	int cnt18 = 0;
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= '\t' && LA18_0 <= '\n') || (LA18_0 >= '\f' && LA18_0 <= '\r') || LA18_0 == ' ') )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:
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
            			    if ( cnt18 >= 1 ) goto loop18;
            		            EarlyExitException eee18 =
            		                new EarlyExitException(18, input);
            		            throw eee18;
            	    }
            	    cnt18++;
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whinging that label 'loop18' has no statements

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
        // D:\\lesscss.g:1:8: ( T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | MINUS | SelectorClass | SelectorID | COLOR | STRING | UNIT | NUM | IDENT | SL_COMMENT | COMMENT | WS )
        int alt19 = 34;
        alt19 = dfa19.Predict(input);
        switch (alt19) 
        {
            case 1 :
                // D:\\lesscss.g:1:10: T__30
                {
                	mT__30(); 

                }
                break;
            case 2 :
                // D:\\lesscss.g:1:16: T__31
                {
                	mT__31(); 

                }
                break;
            case 3 :
                // D:\\lesscss.g:1:22: T__32
                {
                	mT__32(); 

                }
                break;
            case 4 :
                // D:\\lesscss.g:1:28: T__33
                {
                	mT__33(); 

                }
                break;
            case 5 :
                // D:\\lesscss.g:1:34: T__34
                {
                	mT__34(); 

                }
                break;
            case 6 :
                // D:\\lesscss.g:1:40: T__35
                {
                	mT__35(); 

                }
                break;
            case 7 :
                // D:\\lesscss.g:1:46: T__36
                {
                	mT__36(); 

                }
                break;
            case 8 :
                // D:\\lesscss.g:1:52: T__37
                {
                	mT__37(); 

                }
                break;
            case 9 :
                // D:\\lesscss.g:1:58: T__38
                {
                	mT__38(); 

                }
                break;
            case 10 :
                // D:\\lesscss.g:1:64: T__39
                {
                	mT__39(); 

                }
                break;
            case 11 :
                // D:\\lesscss.g:1:70: T__40
                {
                	mT__40(); 

                }
                break;
            case 12 :
                // D:\\lesscss.g:1:76: T__41
                {
                	mT__41(); 

                }
                break;
            case 13 :
                // D:\\lesscss.g:1:82: T__42
                {
                	mT__42(); 

                }
                break;
            case 14 :
                // D:\\lesscss.g:1:88: T__43
                {
                	mT__43(); 

                }
                break;
            case 15 :
                // D:\\lesscss.g:1:94: T__44
                {
                	mT__44(); 

                }
                break;
            case 16 :
                // D:\\lesscss.g:1:100: T__45
                {
                	mT__45(); 

                }
                break;
            case 17 :
                // D:\\lesscss.g:1:106: T__46
                {
                	mT__46(); 

                }
                break;
            case 18 :
                // D:\\lesscss.g:1:112: T__47
                {
                	mT__47(); 

                }
                break;
            case 19 :
                // D:\\lesscss.g:1:118: T__48
                {
                	mT__48(); 

                }
                break;
            case 20 :
                // D:\\lesscss.g:1:124: T__49
                {
                	mT__49(); 

                }
                break;
            case 21 :
                // D:\\lesscss.g:1:130: T__50
                {
                	mT__50(); 

                }
                break;
            case 22 :
                // D:\\lesscss.g:1:136: T__51
                {
                	mT__51(); 

                }
                break;
            case 23 :
                // D:\\lesscss.g:1:142: T__52
                {
                	mT__52(); 

                }
                break;
            case 24 :
                // D:\\lesscss.g:1:148: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 25 :
                // D:\\lesscss.g:1:154: SelectorClass
                {
                	mSelectorClass(); 

                }
                break;
            case 26 :
                // D:\\lesscss.g:1:168: SelectorID
                {
                	mSelectorID(); 

                }
                break;
            case 27 :
                // D:\\lesscss.g:1:179: COLOR
                {
                	mCOLOR(); 

                }
                break;
            case 28 :
                // D:\\lesscss.g:1:185: STRING
                {
                	mSTRING(); 

                }
                break;
            case 29 :
                // D:\\lesscss.g:1:192: UNIT
                {
                	mUNIT(); 

                }
                break;
            case 30 :
                // D:\\lesscss.g:1:197: NUM
                {
                	mNUM(); 

                }
                break;
            case 31 :
                // D:\\lesscss.g:1:201: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 32 :
                // D:\\lesscss.g:1:207: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;
            case 33 :
                // D:\\lesscss.g:1:218: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 34 :
                // D:\\lesscss.g:1:226: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA5 dfa5;
    protected DFA7 dfa7;
    protected DFA10 dfa10;
    protected DFA19 dfa19;
	private void InitializeCyclicDFAs()
	{
	    this.dfa5 = new DFA5(this);
	    this.dfa7 = new DFA7(this);
	    this.dfa10 = new DFA10(this);
	    this.dfa19 = new DFA19(this);




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
            get { return "142:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )"; }
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
            get { return "146:5: ( ( '0' .. '9' )* '.' )?"; }
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
            get { return "147:9: ( ( '0' .. '9' )* '.' )?"; }
        }

    }

    const string DFA19_eotS =
        "\x01\uffff\x01\x24\x05\uffff\x01\x27\x04\uffff\x05\x21\x01\x18"+
        "\x01\x21\x01\uffff\x01\x36\x04\uffff\x07\x21\x08\uffff\x02\x21\x02"+
        "\x18\x01\x21\x01\x18\x01\x21\x03\x18\x03\x21\x01\x4c\x02\uffff\x01"+
        "\x3a\x02\uffff\x04\x18\x04\x21\x01\x52\x07\x21\x01\x5a\x01\uffff"+
        "\x01\x3a\x02\x18\x01\x21\x01\x18\x01\uffff\x07\x21\x01\uffff\x01"+
        "\x18\x03\x21\x01\x66\x06\x21\x01\uffff\x01\x21\x01\x6e\x01\x6f\x01"+
        "\x70\x03\x21\x03\uffff\x01\x74\x01\x75\x01\x21\x02\uffff\x01\x21"+
        "\x01\x78\x01\uffff";
    const string DFA19_eofS =
        "\x79\uffff";
    const string DFA19_minS =
        "\x01\x09\x01\x6d\x05\uffff\x01\x2a\x04\uffff\x01\x6c\x01\x72\x01"+
        "\x6d\x01\x61\x01\x63\x01\x2d\x01\x74\x01\uffff\x01\x2e\x02\x30\x02"+
        "\uffff\x02\x6d\x01\x6e\x01\x65\x01\x61\x01\x72\x01\x68\x08\uffff"+
        "\x01\x6c\x01\x61\x02\x2d\x01\x6e\x01\x2d\x01\x69\x03\x2d\x01\x72"+
        "\x01\x65\x01\x79\x01\x2d\x02\uffff\x01\x30\x02\uffff\x04\x2d\x01"+
        "\x67\x01\x64\x01\x61\x01\x7a\x01\x2d\x01\x69\x01\x6f\x01\x64\x01"+
        "\x6e\x01\x6a\x02\x65\x01\x2d\x01\uffff\x01\x30\x02\x2d\x01\x64\x01"+
        "\x2d\x01\uffff\x01\x6c\x01\x73\x01\x68\x01\x74\x02\x65\x01\x63\x01"+
        "\uffff\x01\x2d\x01\x6c\x01\x73\x01\x65\x01\x2d\x01\x63\x01\x6e\x01"+
        "\x68\x02\x65\x01\x6c\x01\uffff\x01\x74\x03\x2d\x02\x64\x01\x69\x03"+
        "\uffff\x02\x2d\x01\x6f\x02\uffff\x01\x6e\x01\x2d\x01\uffff";
    const string DFA19_maxS =
        "\x01\x7d\x01\x6d\x05\uffff\x01\x2f\x04\uffff\x01\x6c\x01\x72\x01"+
        "\x78\x01\x7a\x01\x78\x01\x7a\x01\x76\x01\uffff\x01\x39\x02\x7a\x02"+
        "\uffff\x01\x6d\x01\x73\x01\x6e\x01\x65\x01\x61\x01\x72\x01\x68\x08"+
        "\uffff\x01\x6c\x01\x61\x02\x7a\x01\x6e\x01\x7a\x01\x6f\x03\x7a\x01"+
        "\x72\x01\x65\x01\x79\x01\x7a\x02\uffff\x01\x66\x02\uffff\x04\x7a"+
        "\x01\x67\x01\x64\x01\x61\x02\x7a\x01\x69\x01\x6f\x01\x64\x01\x6e"+
        "\x01\x6a\x02\x65\x01\x7a\x01\uffff\x01\x66\x02\x7a\x01\x64\x01\x7a"+
        "\x01\uffff\x01\x6c\x01\x73\x01\x68\x01\x74\x02\x65\x01\x63\x01\uffff"+
        "\x01\x7a\x01\x6c\x01\x73\x01\x65\x01\x7a\x01\x63\x01\x6e\x01\x68"+
        "\x02\x65\x01\x6c\x01\uffff\x01\x74\x03\x7a\x02\x64\x01\x69\x03\uffff"+
        "\x02\x7a\x01\x6f\x02\uffff\x01\x6e\x01\x7a\x01\uffff";
    const string DFA19_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\uffff\x01"+
        "\x08\x01\x09\x01\x0b\x01\x0c\x07\uffff\x01\x17\x03\uffff\x01\x1c"+
        "\x01\x1d\x07\uffff\x01\x1e\x01\x1f\x01\x22\x01\x0a\x01\x01\x01\x20"+
        "\x01\x21\x01\x07\x0e\uffff\x01\x18\x01\x19\x01\uffff\x01\x1b\x01"+
        "\x1a\x11\uffff\x01\x16\x05\uffff\x01\x0d\x07\uffff\x01\x15\x0b\uffff"+
        "\x01\x11\x07\uffff\x01\x13\x01\x14\x01\x0e\x03\uffff\x01\x0f\x01"+
        "\x10\x02\uffff\x01\x12";
    const string DFA19_specialS =
        "\x79\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x02\x22\x01\uffff\x02\x22\x12\uffff\x01\x22\x01\uffff\x01"+
            "\x17\x01\x16\x01\uffff\x01\x18\x01\uffff\x01\x17\x01\x08\x01"+
            "\x09\x01\x06\x01\x05\x01\x04\x01\x14\x01\x15\x01\x07\x0a\x20"+
            "\x01\x02\x01\x03\x02\uffff\x01\x13\x01\uffff\x01\x01\x1a\x21"+
            "\x04\uffff\x01\x21\x01\uffff\x01\x0c\x01\x0d\x01\x19\x01\x1c"+
            "\x01\x0e\x01\x21\x01\x1e\x01\x0f\x01\x1b\x01\x21\x01\x1f\x01"+
            "\x21\x01\x1a\x02\x21\x01\x10\x01\x21\x01\x1d\x01\x11\x01\x12"+
            "\x06\x21\x01\x0a\x01\uffff\x01\x0b",
            "\x01\x23",
            "",
            "",
            "",
            "",
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
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x02\x21\x01\x32\x0c\x21\x01\x33\x0a\x21",
            "\x01\x34\x01\uffff\x01\x35",
            "",
            "\x01\x20\x01\uffff\x0a\x20",
            "\x0a\x20\x07\uffff\x1a\x37\x04\uffff\x01\x37\x01\uffff\x1a"+
            "\x37",
            "\x0a\x39\x07\uffff\x06\x38\x14\x3a\x04\uffff\x01\x3a\x01\uffff"+
            "\x06\x38\x14\x3a",
            "",
            "",
            "\x01\x3b",
            "\x01\x3c\x05\uffff\x01\x3d",
            "\x01\x3e",
            "\x01\x3f",
            "\x01\x40",
            "\x01\x41",
            "\x01\x42",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x43",
            "\x01\x44",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x01\x21\x01\x45\x18\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x46",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x47\x05\uffff\x01\x48",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x49",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "",
            "",
            "\x0a\x4d\x07\uffff\x06\x4d\x1a\uffff\x06\x4d",
            "",
            "",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "\x01\x51",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "",
            "\x0a\x4d\x07\uffff\x06\x4d\x1a\uffff\x06\x4d",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x5b",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "",
            "\x01\x5c",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "",
            "\x01\x6d",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "",
            "",
            "",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            "\x01\x76",
            "",
            "",
            "\x01\x77",
            "\x01\x21\x02\uffff\x0a\x21\x07\uffff\x1a\x21\x04\uffff\x01"+
            "\x21\x01\uffff\x1a\x21",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | MINUS | SelectorClass | SelectorID | COLOR | STRING | UNIT | NUM | IDENT | SL_COMMENT | COMMENT | WS );"; }
        }

    }

 
    
}
