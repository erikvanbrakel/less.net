// $ANTLR 3.1.2 D:\\lesscss.g 2009-08-02 22:25:16


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class lesscssLexer : Lexer {
    public const int SELECTORGROUP = 7;
    public const int RULE = 5;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int PSEUDO = 12;
    public const int T__20 = 20;
    public const int EOF = -1;
    public const int COLOR = 15;
    public const int NUM = 14;
    public const int UNIT = 16;
    public const int WS = 19;
    public const int SELECTOR = 8;
    public const int PROPERTY = 6;
    public const int SelectorID = 11;
    public const int SL_COMMENT = 17;
    public const int IDENT = 10;
    public const int SelectorClass = 9;
    public const int VAR = 4;
    public const int COMMENT = 18;
    public const int STRING = 13;

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

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:7:7: ( '{' )
            // D:\\lesscss.g:7:9: '{'
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
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:8:7: ( '}' )
            // D:\\lesscss.g:8:9: '}'
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
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:9:7: ( ',' )
            // D:\\lesscss.g:9:9: ','
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
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:10:7: ( '>' )
            // D:\\lesscss.g:10:9: '>'
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
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
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
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:12:7: ( ':' )
            // D:\\lesscss.g:12:9: ':'
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
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:13:7: ( ';' )
            // D:\\lesscss.g:13:9: ';'
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
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:14:7: ( '@' )
            // D:\\lesscss.g:14:9: '@'
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
    // $ANTLR end "T__27"

    // $ANTLR start "PSEUDO"
    public void mPSEUDO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PSEUDO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:47:2: ( ':' IDENT )
            // D:\\lesscss.g:47:4: ':' IDENT
            {
            	Match(':'); 
            	mIDENT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PSEUDO"

    // $ANTLR start "SelectorClass"
    public void mSelectorClass() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SelectorClass;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:70:2: ( '.' IDENT )
            // D:\\lesscss.g:70:4: '.' IDENT
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
            // D:\\lesscss.g:74:2: ( '#' IDENT )
            // D:\\lesscss.g:74:4: '#' IDENT
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

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:79:2: ( '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"' | '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\'' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == '\"') )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == '\'') )
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
                    // D:\\lesscss.g:79:4: '\"' (~ ( '\"' | '\\n' | '\\r' ) )* '\"'
                    {
                    	Match('\"'); 
                    	// D:\\lesscss.g:79:8: (~ ( '\"' | '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt1 = 2;
                    	    int LA1_0 = input.LA(1);

                    	    if ( ((LA1_0 >= '\u0000' && LA1_0 <= '\t') || (LA1_0 >= '\u000B' && LA1_0 <= '\f') || (LA1_0 >= '\u000E' && LA1_0 <= '!') || (LA1_0 >= '#' && LA1_0 <= '\uFFFF')) )
                    	    {
                    	        alt1 = 1;
                    	    }


                    	    switch (alt1) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:79:9: ~ ( '\"' | '\\n' | '\\r' )
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
                    			    goto loop1;
                    	    }
                    	} while (true);

                    	loop1:
                    		;	// Stops C# compiler whining that label 'loop1' has no statements

                    	Match('\"'); 

                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:80:4: '\\'' (~ ( '\\'' | '\\n' | '\\r' ) )* '\\''
                    {
                    	Match('\''); 
                    	// D:\\lesscss.g:80:9: (~ ( '\\'' | '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\t') || (LA2_0 >= '\u000B' && LA2_0 <= '\f') || (LA2_0 >= '\u000E' && LA2_0 <= '&') || (LA2_0 >= '(' && LA2_0 <= '\uFFFF')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:80:10: ~ ( '\\'' | '\\n' | '\\r' )
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
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

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
            // D:\\lesscss.g:84:2: ( ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' ) )
            // D:\\lesscss.g:84:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )
            {
            	// D:\\lesscss.g:84:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )
            	int alt4 = 16;
            	alt4 = dfa4.Predict(input);
            	switch (alt4) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:84:5: '%'
            	        {
            	        	Match('%'); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\lesscss.g:84:9: 'px'
            	        {
            	        	Match("px"); 


            	        }
            	        break;
            	    case 3 :
            	        // D:\\lesscss.g:84:14: 'cm'
            	        {
            	        	Match("cm"); 


            	        }
            	        break;
            	    case 4 :
            	        // D:\\lesscss.g:84:19: 'mm'
            	        {
            	        	Match("mm"); 


            	        }
            	        break;
            	    case 5 :
            	        // D:\\lesscss.g:84:24: 'in'
            	        {
            	        	Match("in"); 


            	        }
            	        break;
            	    case 6 :
            	        // D:\\lesscss.g:84:29: 'pt'
            	        {
            	        	Match("pt"); 


            	        }
            	        break;
            	    case 7 :
            	        // D:\\lesscss.g:84:34: 'pc'
            	        {
            	        	Match("pc"); 


            	        }
            	        break;
            	    case 8 :
            	        // D:\\lesscss.g:84:39: 'em'
            	        {
            	        	Match("em"); 


            	        }
            	        break;
            	    case 9 :
            	        // D:\\lesscss.g:84:44: 'ex'
            	        {
            	        	Match("ex"); 


            	        }
            	        break;
            	    case 10 :
            	        // D:\\lesscss.g:84:49: 'deg'
            	        {
            	        	Match("deg"); 


            	        }
            	        break;
            	    case 11 :
            	        // D:\\lesscss.g:84:55: 'rad'
            	        {
            	        	Match("rad"); 


            	        }
            	        break;
            	    case 12 :
            	        // D:\\lesscss.g:84:61: 'grad'
            	        {
            	        	Match("grad"); 


            	        }
            	        break;
            	    case 13 :
            	        // D:\\lesscss.g:84:68: 'ms'
            	        {
            	        	Match("ms"); 


            	        }
            	        break;
            	    case 14 :
            	        // D:\\lesscss.g:84:73: 's'
            	        {
            	        	Match('s'); 

            	        }
            	        break;
            	    case 15 :
            	        // D:\\lesscss.g:84:77: 'hz'
            	        {
            	        	Match("hz"); 


            	        }
            	        break;
            	    case 16 :
            	        // D:\\lesscss.g:84:82: 'khz'
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
            // D:\\lesscss.g:88:2: ( ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ | ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ ) ( UNIT )? )
            // D:\\lesscss.g:88:4: ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ | ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ ) ( UNIT )?
            {
            	// D:\\lesscss.g:88:4: ( '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ | ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+ )
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == '-') )
            	{
            	    alt11 = 1;
            	}
            	else if ( (LA11_0 == '.' || (LA11_0 >= '0' && LA11_0 <= '9')) )
            	{
            	    alt11 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d11s0 =
            	        new NoViableAltException("", 11, 0, input);

            	    throw nvae_d11s0;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:88:5: '-' ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
            	        {
            	        	Match('-'); 
            	        	// D:\\lesscss.g:88:9: ( ( '0' .. '9' )* '.' )?
            	        	int alt6 = 2;
            	        	alt6 = dfa6.Predict(input);
            	        	switch (alt6) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\lesscss.g:88:10: ( '0' .. '9' )* '.'
            	        	        {
            	        	        	// D:\\lesscss.g:88:10: ( '0' .. '9' )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt5 = 2;
            	        	        	    int LA5_0 = input.LA(1);

            	        	        	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
            	        	        	    {
            	        	        	        alt5 = 1;
            	        	        	    }


            	        	        	    switch (alt5) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // D:\\lesscss.g:88:11: '0' .. '9'
            	        	        			    {
            	        	        			    	MatchRange('0','9'); 

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop5;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop5:
            	        	        		;	// Stops C# compiler whining that label 'loop5' has no statements

            	        	        	Match('.'); 

            	        	        }
            	        	        break;

            	        	}

            	        	// D:\\lesscss.g:88:28: ( '0' .. '9' )+
            	        	int cnt7 = 0;
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
            	        			    // D:\\lesscss.g:88:29: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt7 >= 1 ) goto loop7;
            	        		            EarlyExitException eee7 =
            	        		                new EarlyExitException(7, input);
            	        		            throw eee7;
            	        	    }
            	        	    cnt7++;
            	        	} while (true);

            	        	loop7:
            	        		;	// Stops C# compiler whinging that label 'loop7' has no statements


            	        }
            	        break;
            	    case 2 :
            	        // D:\\lesscss.g:89:4: ( ( '0' .. '9' )* '.' )? ( '0' .. '9' )+
            	        {
            	        	// D:\\lesscss.g:89:4: ( ( '0' .. '9' )* '.' )?
            	        	int alt9 = 2;
            	        	alt9 = dfa9.Predict(input);
            	        	switch (alt9) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\lesscss.g:89:5: ( '0' .. '9' )* '.'
            	        	        {
            	        	        	// D:\\lesscss.g:89:5: ( '0' .. '9' )*
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
            	        	        			    // D:\\lesscss.g:89:6: '0' .. '9'
            	        	        			    {
            	        	        			    	MatchRange('0','9'); 

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop8;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop8:
            	        	        		;	// Stops C# compiler whining that label 'loop8' has no statements

            	        	        	Match('.'); 

            	        	        }
            	        	        break;

            	        	}

            	        	// D:\\lesscss.g:89:23: ( '0' .. '9' )+
            	        	int cnt10 = 0;
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
            	        			    // D:\\lesscss.g:89:24: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt10 >= 1 ) goto loop10;
            	        		            EarlyExitException eee10 =
            	        		                new EarlyExitException(10, input);
            	        		            throw eee10;
            	        	    }
            	        	    cnt10++;
            	        	} while (true);

            	        	loop10:
            	        		;	// Stops C# compiler whinging that label 'loop10' has no statements


            	        }
            	        break;

            	}

            	// D:\\lesscss.g:89:36: ( UNIT )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == '%' || (LA12_0 >= 'c' && LA12_0 <= 'e') || (LA12_0 >= 'g' && LA12_0 <= 'i') || LA12_0 == 'k' || LA12_0 == 'm' || LA12_0 == 'p' || (LA12_0 >= 'r' && LA12_0 <= 's')) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:89:36: UNIT
            	        {
            	        	mUNIT(); 

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

    // $ANTLR start "COLOR"
    public void mCOLOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COLOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:93:2: ( '#' ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+ )
            // D:\\lesscss.g:93:4: '#' ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+
            {
            	Match('#'); 
            	// D:\\lesscss.g:93:8: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '0' && LA13_0 <= '9') || (LA13_0 >= 'A' && LA13_0 <= 'F') || (LA13_0 >= 'a' && LA13_0 <= 'f')) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
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
            			    break;

            			default:
            			    if ( cnt13 >= 1 ) goto loop13;
            		            EarlyExitException eee13 =
            		                new EarlyExitException(13, input);
            		            throw eee13;
            	    }
            	    cnt13++;
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whinging that label 'loop13' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COLOR"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\lesscss.g:98:2: ( ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )* | '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )* )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( ((LA16_0 >= 'A' && LA16_0 <= 'Z') || LA16_0 == '_' || (LA16_0 >= 'a' && LA16_0 <= 'z') || (LA16_0 >= '\u0100' && LA16_0 <= '\uFFFE')) )
            {
                alt16 = 1;
            }
            else if ( (LA16_0 == '-') )
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
                    // D:\\lesscss.g:98:4: ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
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

                    	// D:\\lesscss.g:99:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( (LA14_0 == '-' || (LA14_0 >= '0' && LA14_0 <= '9') || (LA14_0 >= 'A' && LA14_0 <= 'Z') || LA14_0 == '_' || (LA14_0 >= 'a' && LA14_0 <= 'z') || (LA14_0 >= '\u0100' && LA14_0 <= '\uFFFE')) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:
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
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements


                    }
                    break;
                case 2 :
                    // D:\\lesscss.g:100:4: '-' ( '_' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' ) ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
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

                    	// D:\\lesscss.g:101:3: ( '_' | '-' | 'a' .. 'z' | 'A' .. 'Z' | '\\u0100' .. '\\ufffe' | '0' .. '9' )*
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( (LA15_0 == '-' || (LA15_0 >= '0' && LA15_0 <= '9') || (LA15_0 >= 'A' && LA15_0 <= 'Z') || LA15_0 == '_' || (LA15_0 >= 'a' && LA15_0 <= 'z') || (LA15_0 >= '\u0100' && LA15_0 <= '\uFFFE')) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // D:\\lesscss.g:
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
                    			    goto loop15;
                    	    }
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements


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
            // D:\\lesscss.g:107:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? ) )
            // D:\\lesscss.g:107:4: '//' (~ ( '\\n' | '\\r' ) )* ( '\\n' | '\\r' ( '\\n' )? )
            {
            	Match("//"); 

            	// D:\\lesscss.g:108:3: (~ ( '\\n' | '\\r' ) )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= '\u0000' && LA17_0 <= '\t') || (LA17_0 >= '\u000B' && LA17_0 <= '\f') || (LA17_0 >= '\u000E' && LA17_0 <= '\uFFFF')) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:108:4: ~ ( '\\n' | '\\r' )
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
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	// D:\\lesscss.g:108:19: ( '\\n' | '\\r' ( '\\n' )? )
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == '\n') )
            	{
            	    alt19 = 1;
            	}
            	else if ( (LA19_0 == '\r') )
            	{
            	    alt19 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // D:\\lesscss.g:108:20: '\\n'
            	        {
            	        	Match('\n'); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\lesscss.g:108:25: '\\r' ( '\\n' )?
            	        {
            	        	Match('\r'); 
            	        	// D:\\lesscss.g:108:29: ( '\\n' )?
            	        	int alt18 = 2;
            	        	int LA18_0 = input.LA(1);

            	        	if ( (LA18_0 == '\n') )
            	        	{
            	        	    alt18 = 1;
            	        	}
            	        	switch (alt18) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\lesscss.g:108:30: '\\n'
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
            // D:\\lesscss.g:113:2: ( '/*' ( . )* '*/' )
            // D:\\lesscss.g:113:4: '/*' ( . )* '*/'
            {
            	Match("/*"); 

            	// D:\\lesscss.g:113:9: ( . )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == '*') )
            	    {
            	        int LA20_1 = input.LA(2);

            	        if ( (LA20_1 == '/') )
            	        {
            	            alt20 = 2;
            	        }
            	        else if ( ((LA20_1 >= '\u0000' && LA20_1 <= '.') || (LA20_1 >= '0' && LA20_1 <= '\uFFFF')) )
            	        {
            	            alt20 = 1;
            	        }


            	    }
            	    else if ( ((LA20_0 >= '\u0000' && LA20_0 <= ')') || (LA20_0 >= '+' && LA20_0 <= '\uFFFF')) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // D:\\lesscss.g:113:9: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements

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
            // D:\\lesscss.g:116:4: ( ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+ )
            // D:\\lesscss.g:116:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            {
            	// D:\\lesscss.g:116:6: ( ' ' | '\\t' | '\\r' | '\\n' | '\\f' )+
            	int cnt21 = 0;
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( ((LA21_0 >= '\t' && LA21_0 <= '\n') || (LA21_0 >= '\f' && LA21_0 <= '\r') || LA21_0 == ' ') )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
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
            			    if ( cnt21 >= 1 ) goto loop21;
            		            EarlyExitException eee21 =
            		                new EarlyExitException(21, input);
            		            throw eee21;
            	    }
            	    cnt21++;
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whinging that label 'loop21' has no statements

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
        // D:\\lesscss.g:1:8: ( T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | PSEUDO | SelectorClass | SelectorID | STRING | UNIT | NUM | COLOR | IDENT | SL_COMMENT | COMMENT | WS )
        int alt22 = 19;
        alt22 = dfa22.Predict(input);
        switch (alt22) 
        {
            case 1 :
                // D:\\lesscss.g:1:10: T__20
                {
                	mT__20(); 

                }
                break;
            case 2 :
                // D:\\lesscss.g:1:16: T__21
                {
                	mT__21(); 

                }
                break;
            case 3 :
                // D:\\lesscss.g:1:22: T__22
                {
                	mT__22(); 

                }
                break;
            case 4 :
                // D:\\lesscss.g:1:28: T__23
                {
                	mT__23(); 

                }
                break;
            case 5 :
                // D:\\lesscss.g:1:34: T__24
                {
                	mT__24(); 

                }
                break;
            case 6 :
                // D:\\lesscss.g:1:40: T__25
                {
                	mT__25(); 

                }
                break;
            case 7 :
                // D:\\lesscss.g:1:46: T__26
                {
                	mT__26(); 

                }
                break;
            case 8 :
                // D:\\lesscss.g:1:52: T__27
                {
                	mT__27(); 

                }
                break;
            case 9 :
                // D:\\lesscss.g:1:58: PSEUDO
                {
                	mPSEUDO(); 

                }
                break;
            case 10 :
                // D:\\lesscss.g:1:65: SelectorClass
                {
                	mSelectorClass(); 

                }
                break;
            case 11 :
                // D:\\lesscss.g:1:79: SelectorID
                {
                	mSelectorID(); 

                }
                break;
            case 12 :
                // D:\\lesscss.g:1:90: STRING
                {
                	mSTRING(); 

                }
                break;
            case 13 :
                // D:\\lesscss.g:1:97: UNIT
                {
                	mUNIT(); 

                }
                break;
            case 14 :
                // D:\\lesscss.g:1:102: NUM
                {
                	mNUM(); 

                }
                break;
            case 15 :
                // D:\\lesscss.g:1:106: COLOR
                {
                	mCOLOR(); 

                }
                break;
            case 16 :
                // D:\\lesscss.g:1:112: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 17 :
                // D:\\lesscss.g:1:118: SL_COMMENT
                {
                	mSL_COMMENT(); 

                }
                break;
            case 18 :
                // D:\\lesscss.g:1:129: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 19 :
                // D:\\lesscss.g:1:137: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
    protected DFA6 dfa6;
    protected DFA9 dfa9;
    protected DFA22 dfa22;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	    this.dfa6 = new DFA6(this);
	    this.dfa9 = new DFA9(this);
	    this.dfa22 = new DFA22(this);




	}

    const string DFA4_eotS =
        "\x14\uffff";
    const string DFA4_eofS =
        "\x14\uffff";
    const string DFA4_minS =
        "\x01\x25\x01\uffff\x01\x63\x01\uffff\x01\x6d\x01\uffff\x01\x6d"+
        "\x0d\uffff";
    const string DFA4_maxS =
        "\x01\x73\x01\uffff\x01\x78\x01\uffff\x01\x73\x01\uffff\x01\x78"+
        "\x0d\uffff";
    const string DFA4_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\uffff\x01\x05\x01\uffff"+
        "\x01\x0a\x01\x0b\x01\x0c\x01\x0e\x01\x0f\x01\x10\x01\x02\x01\x06"+
        "\x01\x07\x01\x04\x01\x0d\x01\x08\x01\x09";
    const string DFA4_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA4_transitionS = {
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

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "84:4: ( '%' | 'px' | 'cm' | 'mm' | 'in' | 'pt' | 'pc' | 'em' | 'ex' | 'deg' | 'rad' | 'grad' | 'ms' | 's' | 'hz' | 'khz' )"; }
        }

    }

    const string DFA6_eotS =
        "\x01\uffff\x01\x03\x02\uffff";
    const string DFA6_eofS =
        "\x04\uffff";
    const string DFA6_minS =
        "\x02\x2e\x02\uffff";
    const string DFA6_maxS =
        "\x02\x39\x02\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA6_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x02\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "88:9: ( ( '0' .. '9' )* '.' )?"; }
        }

    }

    const string DFA9_eotS =
        "\x01\uffff\x01\x03\x02\uffff";
    const string DFA9_eofS =
        "\x04\uffff";
    const string DFA9_minS =
        "\x02\x2e\x02\uffff";
    const string DFA9_maxS =
        "\x02\x39\x02\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA9_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x02\x01\uffff\x0a\x01",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "89:4: ( ( '0' .. '9' )* '.' )?"; }
        }

    }

    const string DFA22_eotS =
        "\x06\uffff\x01\x1d\x06\uffff\x08\x1a\x01\x0c\x02\x1a\x08\uffff"+
        "\x01\x22\x02\uffff\x09\x0c\x03\x1a\x01\x0c\x01\x1a\x02\uffff\x01"+
        "\x22\x02\x0c\x01\x1a\x02\x0c";
    const string DFA22_eofS =
        "\x39\uffff";
    const string DFA22_minS =
        "\x01\x09\x05\uffff\x01\x2d\x02\uffff\x02\x2d\x02\uffff\x01\x63"+
        "\x02\x6d\x01\x6e\x01\x6d\x01\x65\x01\x61\x01\x72\x01\x2d\x01\x7a"+
        "\x01\x68\x01\x2e\x02\uffff\x01\x2a\x04\uffff\x01\x30\x02\uffff\x09"+
        "\x2d\x01\x67\x01\x64\x01\x61\x01\x2d\x01\x7a\x02\uffff\x01\x30\x02"+
        "\x2d\x01\x64\x02\x2d";
    const string DFA22_maxS =
        "\x01\ufffe\x05\uffff\x01\ufffe\x02\uffff\x02\ufffe\x02\uffff\x01"+
        "\x78\x01\x6d\x01\x73\x01\x6e\x01\x78\x01\x65\x01\x61\x01\x72\x01"+
        "\ufffe\x01\x7a\x01\x68\x01\ufffe\x02\uffff\x01\x2f\x04\uffff\x01"+
        "\x66\x02\uffff\x09\ufffe\x01\x67\x01\x64\x01\x61\x01\ufffe\x01\x7a"+
        "\x02\uffff\x01\x66\x02\ufffe\x01\x64\x02\ufffe";
    const string DFA22_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01"+
        "\x07\x01\x08\x02\uffff\x01\x0c\x01\x0d\x0c\uffff\x01\x0e\x01\x10"+
        "\x01\uffff\x01\x13\x01\x06\x01\x09\x01\x0a\x01\uffff\x01\x0f\x01"+
        "\x0b\x0e\uffff\x01\x11\x01\x12\x06\uffff";
    const string DFA22_specialS =
        "\x39\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x02\x1c\x01\uffff\x02\x1c\x12\uffff\x01\x1c\x01\uffff\x01"+
            "\x0b\x01\x0a\x01\uffff\x01\x0c\x01\uffff\x01\x0b\x03\uffff\x01"+
            "\x05\x01\x03\x01\x18\x01\x09\x01\x1b\x0a\x19\x01\x06\x01\x07"+
            "\x02\uffff\x01\x04\x01\uffff\x01\x08\x1a\x1a\x04\uffff\x01\x1a"+
            "\x01\uffff\x02\x1a\x01\x0e\x01\x12\x01\x11\x01\x1a\x01\x14\x01"+
            "\x16\x01\x10\x01\x1a\x01\x17\x01\x1a\x01\x0f\x02\x1a\x01\x0d"+
            "\x01\x1a\x01\x13\x01\x15\x07\x1a\x01\x01\x01\uffff\x01\x02\u0082"+
            "\uffff\ufeff\x1a",
            "",
            "",
            "",
            "",
            "",
            "\x01\x1e\x13\uffff\x1a\x1e\x04\uffff\x01\x1e\x01\uffff\x1a"+
            "\x1e\u0085\uffff\ufeff\x1e",
            "",
            "",
            "\x01\x1f\x02\uffff\x0a\x19\x07\uffff\x1a\x1f\x04\uffff\x01"+
            "\x1f\x01\uffff\x1a\x1f\u0085\uffff\ufeff\x1f",
            "\x01\x22\x02\uffff\x0a\x21\x07\uffff\x06\x20\x14\x22\x04\uffff"+
            "\x01\x22\x01\uffff\x06\x20\x14\x22\u0085\uffff\ufeff\x22",
            "",
            "",
            "\x01\x25\x10\uffff\x01\x24\x03\uffff\x01\x23",
            "\x01\x26",
            "\x01\x27\x05\uffff\x01\x28",
            "\x01\x29",
            "\x01\x2a\x0a\uffff\x01\x2b",
            "\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x19\x01\uffff\x0a\x19\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "",
            "",
            "\x01\x32\x04\uffff\x01\x31",
            "",
            "",
            "",
            "",
            "\x0a\x33\x07\uffff\x06\x33\x1a\uffff\x06\x33",
            "",
            "",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x37",
            "",
            "",
            "\x0a\x33\x07\uffff\x06\x33\x1a\uffff\x06\x33",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x38",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a",
            "\x01\x1a\x02\uffff\x0a\x1a\x07\uffff\x1a\x1a\x04\uffff\x01"+
            "\x1a\x01\uffff\x1a\x1a\u0085\uffff\ufeff\x1a"
    };

    static readonly short[] DFA22_eot = DFA.UnpackEncodedString(DFA22_eotS);
    static readonly short[] DFA22_eof = DFA.UnpackEncodedString(DFA22_eofS);
    static readonly char[] DFA22_min = DFA.UnpackEncodedStringToUnsignedChars(DFA22_minS);
    static readonly char[] DFA22_max = DFA.UnpackEncodedStringToUnsignedChars(DFA22_maxS);
    static readonly short[] DFA22_accept = DFA.UnpackEncodedString(DFA22_acceptS);
    static readonly short[] DFA22_special = DFA.UnpackEncodedString(DFA22_specialS);
    static readonly short[][] DFA22_transition = DFA.UnpackEncodedStringArray(DFA22_transitionS);

    protected class DFA22 : DFA
    {
        public DFA22(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | PSEUDO | SelectorClass | SelectorID | STRING | UNIT | NUM | COLOR | IDENT | SL_COMMENT | COMMENT | WS );"; }
        }

    }

 
    
}
